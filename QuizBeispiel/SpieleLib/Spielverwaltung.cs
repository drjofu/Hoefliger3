namespace SpieleLib
{
  public class Spielverwaltung
  {
    private List<Aufgabe>[] aufgaben; // Array von Listen
    private int aktuellerSchwierigkeitsgrad = 1;
    private Random rnd = new Random();
    private int[] gewinnstufen =
    {
      0, 50, 100, 200,300,500,
      1000,2000,4000,8000,16000,
      32000, 64000, 125000,500000,1000000
    };

    public Aufgabe AktuelleAufgabe { get; set; }
    public bool IstBeendet { get; set; }
    public int Gewinn { get; set; }

    public Spielverwaltung(string pfad)
    {
      // Array instanzieren
      aufgaben = new List<Aufgabe>[15];

      // 15 leere Listen anlegen
      for (int i = 0; i < aufgaben.Length; i++)
        aufgaben[i] = new List<Aufgabe>();

      //Console.WriteLine($"Datei lesen von {pfad}");
      string[] zeilen = File.ReadAllLines(pfad);

      foreach (string zeile in zeilen)
      {
        //Console.WriteLine(zeile);
        Aufgabe aufgabe = new Aufgabe(zeile);
        aufgaben[aufgabe.Schwierigkeitsgrad - 1].Add(aufgabe);
      }

      AufgabeAuslosen();
    }

    private void AufgabeAuslosen()
    {
      int n = aufgaben[aktuellerSchwierigkeitsgrad - 1].Count;
      int index = rnd.Next(n);
      AktuelleAufgabe = aufgaben[aktuellerSchwierigkeitsgrad - 1][index];
    }

    public void AntwortPrüfen(string antwort)
    {
      if (IstBeendet) return;

      if (antwort.ToUpper() == "Q")
      {
        IstBeendet= true;
        Gewinn = gewinnstufen[aktuellerSchwierigkeitsgrad-1];
        return;
      }

      if (AktuelleAufgabe.Lösung == antwort.ToUpper()[0])
      {
        // Antwort war richtig
        if (aktuellerSchwierigkeitsgrad == 15)
        {
          Gewinn = gewinnstufen[15];
          IstBeendet = true;
        }
        else
        {
          aktuellerSchwierigkeitsgrad++;
          AufgabeAuslosen();
        }
      }
      else
      {
        // die Antwort war falsch
        IstBeendet = true;
      }
    }
  }
}
