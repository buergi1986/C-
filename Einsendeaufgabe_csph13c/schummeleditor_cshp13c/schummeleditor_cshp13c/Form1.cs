using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace schummeleditor_cshp13c
{
    public partial class Form1 : Form
    {
        //den Dateinamen aus dem Pfad zusammenbauen
        string dateiname = System.Windows.Forms.Application.StartupPath + "\\score.txt";
        StreamReader textDatei = null;

        public Form1()
        {
            InitializeComponent();
            _Form1 = this;
        }

        //auf andere Klasse rufen
        public static Form1 _Form1;

        //Das Fenster schliessen
        private void beendenButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //Die Datei auslesen
        public void lesenButton_Click(object sender, EventArgs e)
        {
            //die Einträge in den Textfeld setzen
            Score lesenEintraege = new Score();
            lesenEintraege.LesePunkte();
        }
        //Die Datei speichern
        private void speichernButton_Click(object sender, EventArgs e)
        {
            //die Einträge in die Texte aufschreiben
            Score schreibenEintraege = new Score();
            schreibenEintraege.SchreibePunkte();

            //wenn es die Datei schon gibt, die Daten lesen
            if (System.IO.File.Exists(dateiname) != true)
                MessageBox.Show("Die Datei ist nicht vorhanden", "Fehler");

            //Aufruf: Drucker Vorschau
            try
            {
                textDatei = new StreamReader(dateiname);
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Es hat ein Problem gegeben.", ex.Message);
            }
            finally
            {
                if (textDatei != null)
                    textDatei.Dispose();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //ein Pinsel für die Farbe
            SolidBrush pinsel = new SolidBrush(Color.Black);
            //für die Schriftart
            Font schrift = new Font("Arial", 12, FontStyle.Bold);
            //für die Zeilen pro Seite
            int zeilenProSeite = 0;
            //für die Y-Position der Ausgabe
            int yPos = e.MarginBounds.Top;
            //zum Mitzählen der Zeilen
            int zeilenGedruckt = 0;
            //für die Textzeile
            string zeile;
            zeile = String.Empty;
            //die Höhe des Ausgabebereichs wird durch die Höhe der Schrift geteilt
            zeilenProSeite = e.MarginBounds.Height / schrift.Height;
            //so lange noch mehr Zeilen da sind und der untere Rand nicht erreicht ist
            //wird gedruckt
            while ((zeilenGedruckt < zeilenProSeite) && (textDatei.EndOfStream == false))
            {
                //die nächste Zeile lesen
                zeile = textDatei.ReadLine();
                //die Zeile ausgeben
                e.Graphics.DrawString(zeile, schrift, pinsel, e.MarginBounds.Left, yPos);
                //die Anzahl der gedruckten Zeilen erhöhen
                zeilenGedruckt++;
                //yPos auf die nächste Ausgabeposition setzen
                yPos = yPos + schrift.Height;
            }
            //kommt noch mehr Text
            //dann die nächste Seite anfangen
            if (textDatei.EndOfStream == false)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }
    }
}