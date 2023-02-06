namespace SpieleLib
{
  public class Spielverwaltung
  {
    public Spielverwaltung(string pfad)
    {
      Console.WriteLine($"Datei lesen von {pfad}");
      string[] zeilen = File.ReadAllLines(pfad);

      foreach (string zeile in zeilen)
      {
        Console.WriteLine(zeile);
      }
    }
  }
}
