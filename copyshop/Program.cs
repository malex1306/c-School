using System;
using System.Windows.Forms;

namespace BruttoVerkaufspreisGUI
{
    public class MainForm : Form
    {
        private TextBox txtZaehlerstandAlt;
        private TextBox txtZaehlerstandNeu;
        private Button btnBerechnen;
        private Label lblErgebnis;

        public MainForm()
        {
            // Form-Einstellungen
            Text = "Brutto Verkaufspreis Rechner";
            Width = 400;
            Height = 300;

            // Zählerstand Alt
            var lblZaehlerstandAlt = new Label { Text = "Alter Zählerstand:", Top = 20, Left = 20, Width = 150 };
            txtZaehlerstandAlt = new TextBox { Top = 20, Left = 180, Width = 150 };

            // Zählerstand Neu
            var lblZaehlerstandNeu = new Label { Text = "Neuer Zählerstand:", Top = 60, Left = 20, Width = 150 };
            txtZaehlerstandNeu = new TextBox { Top = 60, Left = 180, Width = 150 };

            // Berechnen-Button
            btnBerechnen = new Button { Text = "Berechnen", Top = 100, Left = 20, Width = 150 };
            btnBerechnen.Click += BtnBerechnen_Click;

            // Ergebnis-Label
            lblErgebnis = new Label { Text = "Ergebnis:", Top = 140, Left = 20, Width = 350, Height = 100 };

            // Steuerelemente zum Formular hinzufügen
            Controls.Add(lblZaehlerstandAlt);
            Controls.Add(txtZaehlerstandAlt);
            Controls.Add(lblZaehlerstandNeu);
            Controls.Add(txtZaehlerstandNeu);
            Controls.Add(btnBerechnen);
            Controls.Add(lblErgebnis);
        }

        private void BtnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                double zaehlerstandAlt = double.Parse(txtZaehlerstandAlt.Text);
                double zaehlerstandNeu = double.Parse(txtZaehlerstandNeu.Text);

                double verbrauch = zaehlerstandNeu - zaehlerstandAlt;

                if (verbrauch <= 0)
                {
                    lblErgebnis.Text = "Fehler: Neuer Zählerstand muss größer sein.";
                    return;
                }

                double preisProEinheit = verbrauch switch
                {
                    <= 10 => 0.12,
                    <= 50 => 0.07,
                    <= 100 => 0.06,
                    _ => 0.05
                };

                double nettoVerkaufspreis = verbrauch * preisProEinheit;
                double mehrwertsteuer = nettoVerkaufspreis * 0.16;
                double bruttoVerkaufspreis = nettoVerkaufspreis + mehrwertsteuer;

                lblErgebnis.Text = $"Verbrauch: {verbrauch} Einheiten\n" +
                                   $"Preis pro Einheit: {preisProEinheit:F2} €\n" +
                                   $"Nettopreis: {nettoVerkaufspreis:F2} €\n" +
                                   $"Mehrwertsteuer: {mehrwertsteuer:F2} €\n" +
                                   $"Bruttoverkaufspreis: {bruttoVerkaufspreis:F2} €";
            }
            catch (FormatException)
            {
                lblErgebnis.Text = "Fehler: Bitte geben Sie gültige Zahlen ein.";
            }
            catch (Exception ex)
            {
                lblErgebnis.Text = $"Ein Fehler ist aufgetreten: {ex.Message}";
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
