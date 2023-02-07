using SpieleLib;

namespace WinFormsQuiz
{
  public partial class Form1 : Form
  {
    private Spielverwaltung spielverwaltung;
    private RadioButton[] radioButtons;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      spielverwaltung = new Spielverwaltung(@"E:\Projekte\Schulungen\Firmen\hoefliger3\wwm.csv");
      radioButtons = new RadioButton[] { RBAntwortA, RBAntwortB, RBAntwortC, RBAntwortD };
    }

    private void AufgabeAnzeigen()
    {
      Aufgabe aufgabe = spielverwaltung.AktuelleAufgabe;
      LBLFrage.Text = aufgabe.Frage + "?";
      for (int i = 0; i < radioButtons.Length; i++)
      {
        radioButtons[i].Text = aufgabe.Antworten[i];
        radioButtons[i].Checked = false;
      }
    }

    private void BTNAntworten_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < radioButtons.Length; i++)
      {
        if (radioButtons[i].Checked)
        {
          spielverwaltung.AntwortPrüfen("ABCD"[i].ToString());
          break;
        }
      }

      if (spielverwaltung.IstBeendet)
      {
        SpielendeAnzeigen();
      }
      else
      {
        AufgabeAnzeigen();
      }
    }

    private void SpielendeAnzeigen()
    {
      BTNAntworten.Enabled = false;
      BTNAufgeben.Enabled = false;
      foreach (RadioButton rb in radioButtons)
        rb.Enabled= false;

      MessageBox.Show($"Ihr Gewinn beträgt {spielverwaltung.Gewinn} Gummipunkte", "Spiel ist beendet");
    }

    private void BTNAufgeben_Click(object sender, EventArgs e)
    {
      spielverwaltung.AntwortPrüfen("Q");
      SpielendeAnzeigen();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      AufgabeAnzeigen();
    }
  }
}