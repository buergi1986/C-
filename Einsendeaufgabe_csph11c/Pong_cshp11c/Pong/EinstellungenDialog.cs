using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    public partial class EinstellungenDialog : Form
    {
        Rectangle spielfeldGroesse;
        Graphics FarbenZeichenflaeche;
        SolidBrush pinsel;
        Color rahmenFarben, spielfeldFarben;
        int spielfeldBreite, spielfeldHoehe;
        int spielfeldLinienbreite;
        int schlaegerGroesse;
        string rclr = null;
        string sfclr = null;

        //die Methode liefert den ausgewählten Wert
        public Point LiefereWert()
        {
            Point rueckgabe = new Point(0, 0);
            if (radioButton320.Checked == true)
                rueckgabe = new Point(320, 200);              
            if (radioButton640.Checked == true)
                rueckgabe = new Point(640, 480);
            if (radioButton1024.Checked == true)
                rueckgabe = new Point(1024, 768);
            if (radioButtonMaximal.Checked == true)
                rueckgabe = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            return rueckgabe;
        }

        //Radiobutton setzen durch aktuelle Grösse
        public void aktuelleGroesse(int Breite)
        {
            if (Breite == 320)
                radioButton320.Checked = true;
            if (Breite == 640)
                radioButton640.Checked = true;
            if (Breite == 1024)
                radioButton1024.Checked = true;
            if (Breite > 1024)
                radioButtonMaximal.Checked = true;
        }

        public EinstellungenDialog(Color rahmen, Color spielfeld)
        {
            InitializeComponent();            
            spielfeldLinienbreite = 10;
            schlaegerGroesse = 25;
            //den Pinsel erzeugen
            pinsel = new SolidBrush(Color.White);
            //den Grafik erzeugen
            FarbenZeichenflaeche = panelVorschau.CreateGraphics();
            //Panel Vorschau das Farbe erzeugen
            panelVorschau.BackColor = Color.Black;
            NeuerBall();
            SetzenSpielfeldFarben();
            ZeichneSpielfeld();
            rahmenFarben = rahmen;
            spielfeldFarben = spielfeld;
            FarbenRahmenaendern();
            FarbenSpielfeldaendern();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRahmen_Click(object sender, EventArgs e)
        {

            ColorDialog rhm = new ColorDialog();
            //Das Farbensauswahl für Rahmen
            if (rhm.ShowDialog() == DialogResult.OK)
            {
                rclr = rhm.Color.Name;
                rahmenFarben = Color.FromName(rclr);

                vorschauBall.BackColor = rahmenFarben;
                vorschauSchlaeger.BackColor = rahmenFarben;
                pinsel = new SolidBrush(rahmenFarben);
            }
            Refresh();
        }

        private void buttonSpielfeld_Click(object sender, EventArgs e)
        {

            ColorDialog sf = new ColorDialog();
            //Das Farbensauswahl für Spielfeld
            if (sf.ShowDialog() == DialogResult.OK)
            {
                sfclr = sf.Color.Name;
                spielfeldFarben = Color.FromName(sfclr);

                panelVorschau.BackColor = spielfeldFarben;
            }
            Refresh();
        }

        public void FarbenRahmenaendern()
        {
            //Rahmen des Farbens 
            if (rahmenFarben != Color.Empty)
            {
                vorschauBall.BackColor = rahmenFarben;
                vorschauSchlaeger.BackColor = rahmenFarben;
                pinsel = new SolidBrush(rahmenFarben);
                Refresh();
            }
            else
                Refresh();
        }

        public void FarbenSpielfeldaendern()
        {
            //Spielfeld des Farbens
            if (spielfeldFarben != Color.Empty)
            {
                panelVorschau.BackColor = spielfeldFarben;
                Refresh();
            }
            else
                Refresh();
        }

        public Color FarbenRahmen()
        {
            return rahmenFarben;
        }

        public Color FarbenSpielfeld()
        {
            return spielfeldFarben;
        }

        void SetzenSpielfeldFarben()
        {
            spielfeldGroesse = panelVorschau.ClientRectangle;
            //Spielfeld mit Breite und Höhe messen
            spielfeldBreite = spielfeldGroesse.Width;
            spielfeldHoehe = spielfeldGroesse.Height;
        }

        void ZeichneSpielfeld()
        {
            //ein Rechteck oben
            FarbenZeichenflaeche.FillRectangle(pinsel, 0, 0, spielfeldBreite, spielfeldLinienbreite);
            //ein Rechteck rechts
            FarbenZeichenflaeche.FillRectangle(pinsel, spielfeldBreite - spielfeldLinienbreite, 0, spielfeldLinienbreite, spielfeldBreite + spielfeldLinienbreite);
            //und noch eins unten
            FarbenZeichenflaeche.FillRectangle(pinsel, 0, spielfeldHoehe - spielfeldLinienbreite, spielfeldBreite, spielfeldLinienbreite);
            //und Rechteck links
            FarbenZeichenflaeche.FillRectangle(pinsel, 0, 0, spielfeldLinienbreite, spielfeldHoehe + spielfeldLinienbreite);
        }

        void ZeichneSchlaeger(int y)
        {
            //befindet sich der Schläger im Spielfeld?
            if (((y + schlaegerGroesse) < spielfeldHoehe) && (y > spielfeldHoehe))
                vorschauSchlaeger.Top = y;
        }

        void NeuerBall()
        {
            vorschauBall.Width = 10;
            vorschauBall.Height = 10;

            vorschauSchlaeger.Width = spielfeldLinienbreite;
            vorschauSchlaeger.Height = 25;

            vorschauBall.BackColor = Color.White;
            vorschauSchlaeger.BackColor = Color.White;

            vorschauSchlaeger.Left = 12;

            ZeichneSchlaeger((spielfeldHoehe / 2) - (25 / 2));
        }

        private void panelVorschau_Paint(object sender, PaintEventArgs e)
        {
            //Rechteck erzeugen
            ZeichneSpielfeld();
        }
    }
}
