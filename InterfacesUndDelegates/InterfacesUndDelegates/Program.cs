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

konten.Ausgeben("sortiert?");

Console.ReadLine();