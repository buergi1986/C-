using System;
using System.Drawing;
using System.Windows.Forms;

namespace Spielerei
{
    public partial class Form1 : Form
    {
        //für die Zeichenfläche
        Graphics zeichenflaeche;
        //für die Linienfarbe
        Color linienfarbe;
        //für die Hintergrundfarbe
        Color hintergrundfarbe;

        Pen stift;

        //eine lokale Variable für die Größe
        int groesse = 0;
        int i = 0;
        int y = 0;
        int uPos;
        int oPos;

        //für den Linienstil
        System.Drawing.Drawing2D.DashStyle[] linienstil = 
		{
		    System.Drawing.Drawing2D.DashStyle.Dash,
		    System.Drawing.Drawing2D.DashStyle.DashDot,
		    System.Drawing.Drawing2D.DashStyle.DashDotDot,
		    System.Drawing.Drawing2D.DashStyle.Dot,
		    System.Drawing.Drawing2D.DashStyle.Solid 
		};

        //für den Hintergrund
        System.Drawing.Drawing2D.HatchStyle[] fuellstil =
		{
    		System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal,
		    System.Drawing.Drawing2D.HatchStyle.Cross,
		    System.Drawing.Drawing2D.HatchStyle.DottedGrid,
		    System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal,
		    System.Drawing.Drawing2D.HatchStyle.Sphere,
		    System.Drawing.Drawing2D.HatchStyle.Vertical,
    		System.Drawing.Drawing2D.HatchStyle.Wave,
		    System.Drawing.Drawing2D.HatchStyle.ZigZag
	    };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //die Linienfarbe ist zunächst schwarz
            linienfarbe = Color.Black;
            //und auch die Hintergrundfarbe
            hintergrundfarbe = Color.Black;
            //für die Lininenstile 
            foreach (System.Drawing.Drawing2D.DashStyle element in linienstil)
                listBoxLinieStil.Items.Add("");
            //für den Hintergrund
            foreach (System.Drawing.Drawing2D.HatchStyle element in fuellstil)
                listBoxHintergrundMuster.Items.Add("");
            //eine Referenz auf die Zeichenfläche des Panels beschaffen
            //zeichenflaeche ist als Feld der Klasse Form1 vereinbart
            zeichenflaeche = panel1.CreateGraphics();
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            zeichenflaeche.Clear(panel1.BackColor);
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            //einen Stift mit der ausgewählten Farbe erzeugen
            stift = new Pen(linienfarbe);
            //einen Pinsel in der ausgewählten Farbe erzeugen
            SolidBrush pinsel = new SolidBrush(hintergrundfarbe);          
            //die Dicke des Stiftes setzen
            stift.Width = Convert.ToInt32(numericUpDownLinieStaerke.Value);
            //die Größe der Figur ermitteln
            switch (trackBar1.Value)
            {
                case 1: groesse = 125;
                    break;
                case 2: groesse = 100;
                    break;
                case 3: groesse = 75;
                    break;
            }

            y = groesse;

            //den Linienstil ermitteln
            if (listBoxLinieStil.SelectedIndex >= 0)
                stift.DashStyle = linienstil[listBoxLinieStil.SelectedIndex];
            //Figur ermitteln
            //beim Kreis und beim Rechteck auch die Füllung überprüfen
            if (radioButtonKreis.Checked == true)
            {
                if (radioButtonHintergrundOhne.Checked == true)
                    zeichenflaeche.DrawEllipse(stift, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));
                if (radioButtonHintergrundFarbe.Checked == true)
                    zeichenflaeche.FillEllipse(pinsel, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));
                //soll mit Muster gezeichnet werden und ist ein Muster ausgewählt?
                if (radioButtonHintergrundMuster.Checked == true && listBoxHintergrundMuster.SelectedIndex >= 0)
                {
                    //einen neuen Pinsel für das Muster erzeugen
                    //die Vordergrundfarbe kommt vom Stift, der Hintergrund ist immer weiß
                    System.Drawing.Drawing2D.HatchBrush musterPinsel = new System.Drawing.Drawing2D.HatchBrush(fuellstil[listBoxHintergrundMuster.SelectedIndex], stift.Color, Color.White);
                    zeichenflaeche.FillEllipse(musterPinsel, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));
                }
            }
            if (radioButtonRechteck.Checked == true)
            {
                if (radioButtonHintergrundOhne.Checked == true)
                    zeichenflaeche.DrawRectangle(stift, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));
                if (radioButtonHintergrundFarbe.Checked == true)
                    zeichenflaeche.FillRectangle(pinsel, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));
                //soll mit Muster gezeichnet werden und ist ein Muster ausgewählt?
                if (radioButtonHintergrundMuster.Checked == true && listBoxHintergrundMuster.SelectedIndex >= 0)
                {
                    //einen neuen Pinsel für das Muster erzeugen
                    //die Vordergrundfarbe kommt vom Stift, der Hintergrund ist immer weiß
                    System.Drawing.Drawing2D.HatchBrush musterPinsel = new System.Drawing.Drawing2D.HatchBrush(fuellstil[listBoxHintergrundMuster.SelectedIndex], stift.Color, Color.White);
                    zeichenflaeche.FillRectangle(musterPinsel, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));
                }
            }
            if (radioButtonLinie.Checked == true)
                zeichenflaeche.DrawLine(stift, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Height / 2, panel1.ClientRectangle.Width - groesse, panel1.ClientRectangle.Height / 2);
        }

        private void buttonLinienFarbe_Click(object sender, EventArgs e)
        {
            //den Dialog zur Farbauswahl anzeigen
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //die Hintergrundfarbe für das Panel auf die ausgewählte Farbe setzen
                panelLinienFarbeVorschau.BackColor = colorDialog1.Color;
                //und die Linienfarbe
                //linienfarbe ist ein Feld der Klasse Form1
                linienfarbe = colorDialog1.Color;
            }
        }

        private void buttonHintergrundFarbe_Click(object sender, EventArgs e)
        {
            //den Dialog zur Farbauswahl anzeigen
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //die Hintergrundfarbe für das Panel auf die ausgewählte Farbe setzen
                panelHintergrundFarbeVorschau.BackColor = colorDialog1.Color;
                //und die eigentliche Hintergrundfarbe
                //hintergrundfarbe ist ein Feld der Klasse Form1
                hintergrundfarbe = colorDialog1.Color;
                //die Auswahl Farbe aktivieren
                radioButtonHintergrundFarbe.Checked = true;
            }
        }

        private void listBoxLinieStil_DrawItem(object sender, DrawItemEventArgs e)
        {
            //eine lokale Variable für die Berechnung der Mitte
            int y;
            //ein neuer lokaler Stift
            Pen boxStift = new Pen(Color.Black);
            //die Mitte berechnen
            y = (e.Bounds.Top + e.Bounds.Bottom) / 2;
            //den Hintergrund zeichnen
            e.DrawBackground();
            //und die Linie
            boxStift.DashStyle = linienstil[e.Index];
            e.Graphics.DrawLine(boxStift, e.Bounds.Left + 1, y, e.Bounds.Right - 1, y);
        }

        private void listBoxHintergrundMuster_DrawItem(object sender, DrawItemEventArgs e)
        {
            //ein neuer lokaler Pinsel für das Muster
            System.Drawing.Drawing2D.HatchBrush boxPinsel = new System.Drawing.Drawing2D.HatchBrush(fuellstil[e.Index], Color.Black, Color.White);
            //den Hintergrund zeichnen
            e.DrawBackground();
            //und das Rechteck
            e.Graphics.FillRectangle(boxPinsel, e.Bounds.Left + 1, e.Bounds.Top + 1, e.Bounds.Width - 1, e.Bounds.Height - 1);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //Anzahl der Wiederholung und Geschwindigkeit im Steuerelemente
            int anzahl = Convert.ToInt32(numericUpDownAnzahl.Value);
            int geschwindigkeit = Convert.ToInt32(numericUpDownGesch.Value)*100;

            //Anzahl der Wiederholung
            for(int zahl = 0; zahl < anzahl; zahl++)
            {
                //Variable erstellen
                groesse = 75;
                int groesse1 = 125;
                y = groesse;
                //Schwarz und Weiss Farben
                Pen stiftSchwarz = new Pen(linienfarbe);
                Pen stiftWeiss = new Pen(Color.White);
                //Position bei den Linien
                uPos = panel1.ClientRectangle.Height / 2;
                oPos = panel1.ClientRectangle.Height / 2;

                //Kreise beziehungsweise Rechtecke schrittweise vergrössert
                while (i < y)
                {
                    zeichenflaeche.DrawRectangle(stiftSchwarz, panel1.ClientRectangle.Left + groesse1, panel1.ClientRectangle.Top + groesse1, panel1.ClientRectangle.Width - (groesse1 * 2), panel1.ClientRectangle.Height - (groesse1 * 2));
                    zeichenflaeche.DrawEllipse(stiftSchwarz, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));
                    System.Threading.Thread.Sleep(geschwindigkeit);
                    groesse--;
                    groesse1--;
                    i++;
                }
                
                i = 0;
                //Grösse wieder 75 setzen
                y = 75;

                //Kreise beziehungsweise Rechtecke schrittweise verkleinert
                while (i < y)
                {
                    zeichenflaeche.DrawRectangle(stiftWeiss, panel1.ClientRectangle.Left + groesse1, panel1.ClientRectangle.Top + groesse1, panel1.ClientRectangle.Width - (groesse1 * 2), panel1.ClientRectangle.Height - (groesse1 * 2));
                    zeichenflaeche.DrawEllipse(stiftWeiss, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));
                    System.Threading.Thread.Sleep(geschwindigkeit);
                    groesse++;
                    groesse1++;
                    i++;
                }

                //Hintergrund löschen
                zeichenflaeche.Clear(panel1.BackColor);
                i = 0;
                //Grösse wieder 75 setzen
                groesse = 75;
                y = groesse;
                
                //Linie läuft nach oben und unten
                while (i < y)
                {
                    zeichenflaeche.DrawLine(stiftSchwarz, panel1.ClientRectangle.Left + groesse, uPos, panel1.ClientRectangle.Width - groesse, uPos);
                    zeichenflaeche.DrawLine(stiftSchwarz, panel1.ClientRectangle.Left + groesse, oPos, panel1.ClientRectangle.Width - groesse, oPos);
                    System.Threading.Thread.Sleep(geschwindigkeit);
                    oPos--;
                    uPos++;
                    i++;
                }

                i = 0;
                //Grösse wieder 75 setzen
                y = 75;

                //Linie läuft nach oben und unten wieder zurück
                while (i < y)
                {
                    zeichenflaeche.DrawLine(stiftWeiss, panel1.ClientRectangle.Left + groesse, uPos, panel1.ClientRectangle.Width - groesse, uPos);
                    zeichenflaeche.DrawLine(stiftWeiss, panel1.ClientRectangle.Left + groesse, oPos, panel1.ClientRectangle.Width - groesse, oPos);
                    System.Threading.Thread.Sleep(geschwindigkeit);
                    oPos++;
                    uPos--;
                    i++;
                }

                //Ganz löschen und aktualisieren
                zeichenflaeche.Clear(panel1.BackColor);
                i = 0;
                //Grösse wieder 75 setzen
                groesse = 75;
                y = groesse;
                Refresh();
            }
        }
    }
}
