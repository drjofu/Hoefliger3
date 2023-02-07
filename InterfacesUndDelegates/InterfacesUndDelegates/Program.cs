using InterfacesUndDelegates;

List<Konto> konten = new List<Konto>()
{
  new Konto{ Kontonummer=1, Inhaber="Dagobert", Saldo=99999999},
  new Konto{ Kontonummer=2, Inhaber="Donald", Saldo=-23454},
  new Konto{ Kontonummer=3, Inhaber="Micky", Saldo=3636},
  new Konto{ Kontonummer=105, Inhaber="Tick", Saldo=100.6},
  new Konto{ Kontonummer=103, Inhaber="Trick", Saldo=100.8},
  new Konto{ Kontonummer=107, Inhaber="Track", Saldo=100.4},
  new Konto{ Kontonummer=55, Inhaber="Panzerknacker", Saldo=-666}
};

//foreach (Konto konto in konten)
//  Console.WriteLine(konto);

//Erweiterungsmethoden.Ausgeben<Konto>(konten, "Ausgangsliste");


//int[] zahlen = new int[] { 1, 325, 7, 21, 7, 59 };
//zahlen.Ausgeben("Zahlen");

//"Hallo".Ausgeben("Text");

konten.Ausgeben("Als Erweiterungsmethode");
konten.Sort();
konten.Ausgeben("sortiert via IComparable");

Comparison<Konto> vergleichsmethode = new Comparison<Konto>(VergleicheNachSaldo);
konten.Sort(vergleichsmethode);
konten.Ausgeben("sortiert via Comparison");

konten.Sort(VergleicheNachSaldo); // vereinfachte Syntax
konten.Ausgeben();

//Console.WriteLine(vergleichsmethode.Invoke(konten[0], konten[1]));

// anonyme Methode (C# 2.0)
konten.Sort(delegate (Konto k1, Konto k2)
{
  return k1.Inhaber.CompareTo(k2.Inhaber);
});

konten.Ausgeben("Sortiert via anonymous method");

// Lambda-Ausdruck
konten.Sort((k1, k2) =>   // goes to
{
  return k1.Inhaber.CompareTo(k2.Inhaber);
});

konten.Ausgeben("Sortiert via Lambda expression");

konten.Sort((k1, k2) => k1.Inhaber.CompareTo(k2.Inhaber));
konten.Ausgeben("nochmal via Lambda");

Konto dagobert = konten.Find(k => k.Inhaber == "Dagobert");
Console.WriteLine($"Gefunden: {dagobert}");

konten.FindAll(k => k.Saldo > 0).Ausgeben("Alle mit Saldo im Plus");


// using System.Linq
var erg1 = konten
  .Where(k => k.Inhaber.StartsWith("T"))
  .OrderBy(k => k.Kontonummer)
  .Select(k => new { Name = k.Inhaber, k.Saldo })
  .ToList();

erg1.Ausgeben("Verarbeitung via Linq-Extension-Methods");
erg1.Ausgeben("Verarbeitung via Linq-Extension-Methods");

var micky = konten.Where(k => k.Inhaber=="Micky").SingleOrDefault();
if (micky == null)
  Console.WriteLine("nix gefunden...");
else
  Console.WriteLine(micky);

// LINQ - Language integrated query
var erg2 = from k in konten
           where k.Saldo > 0
           orderby k.Inhaber
           select new { k.Inhaber, k.Saldo };

erg2.Ausgeben("via Linq-Syntax");


//var x = new { Zahl = 17, Text = "Hallo" };
//Console.WriteLine(x.Zahl);
//x.Zahl = 123;

//var x = 123;
//var t = "Hallo";

Console.ReadLine();



static int VergleicheNachSaldo(Konto k1, Konto k2)
{
  return k1.Saldo.CompareTo(k2.Saldo);
}