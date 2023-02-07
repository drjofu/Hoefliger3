using SpieleLib;

Spielverwaltung spielverwaltung =
  new Spielverwaltung(@"E:\Projekte\Schulungen\Firmen\hoefliger3\wwm.csv");

while(!spielverwaltung.IstBeendet)
{
  Console.Clear();

  Aufgabe aufgabe = spielverwaltung.AktuelleAufgabe;
  Console.WriteLine(aufgabe.Frage + "?");
  Console.WriteLine();

  for (int i = 0;i < aufgabe.Antworten.Length; i++)
  {
    Console.WriteLine($"{"ABCD"[i]} {aufgabe.Antworten[i]}");
  }

  Console.WriteLine("Bitte A, B, C oder D antworten oder Q zum Aufgeben");

  string antwort = Console.ReadLine();
  spielverwaltung.AntwortPrüfen(antwort);
}

Console.WriteLine("Spiel beendet");
Console.WriteLine($"Ihr Gewinn beträgt {spielverwaltung.Gewinn} Gummipunkte");

Console.ReadLine();
