namespace SpieleLib
{
  public class Aufgabe
  {
    // snippet prop
    public int Schwierigkeitsgrad { get; set; }
    public string Frage { get; set; }
    public string[] Antworten { get; set; } = new string[4];
    public char Lösung { get; set; }

    public Aufgabe(string zeile)
    {
      // Zeile:  Schwierigkeitsgrad;Frage;Antwort1;Antwort2;Antwort3;Antwort4;Lösung
      //                 0             1      2        3        4        5       6

      string[] teile = zeile.Split(";");

      Frage = teile[1];
      Schwierigkeitsgrad = int.Parse(teile[0]);
      for (int i = 0; i < Antworten.Length; i++)
      {
        Antworten[i] = teile[i + 2];
      }

      Lösung = teile[6][0];

    }
  }
}
