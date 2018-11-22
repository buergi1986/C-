using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace Pong
{
    public partial class Form1 : Form
    {
        //die Felder
        //eine Struktur für die Richtung des Balls
        struct Spielball
        {
            //wenn die Richtung true ist, geht es nach oben 
            //bzw. nach rechts, 
            //sonst nach unten bzw. nach links
            public bool richtungX;
            public bool richtungY;
            //für die Veränderung des Bewegungswinkels
            public int winkel;
        }

        //für die Zeichenfläche
        Graphics zeichenflaeche;
        //für das Spielfeld
        Rectangle spielfeldGroesse;
        int spielfeldMaxX, spielfeldMaxY, spielfeldMinX, spielfeldMinY;
        int spielfeldLinienbreite;
        //für den Schläger
        int schlaegerGroesse;
        //für den Ball
        Spielball ballPosition;
        //zum Zeichnen
        SolidBrush pinsel;
        //ist das Spiel angehalten?
        bool spielPause;
        //die restliche Spielzeit
        int aktuelleSpielzeit;
        //für die Schrift
        Font schrift;
        //für die Punkte
        Score spielpunkte;
        int punkteMehr, punkteWeniger;
        //für die Veränderung des Winkels
        int winkelZufall;
        //für die Speicherung der Daten
        string xmlDateiname;
        int xmlBreite, xmlHoehe;
        int xmlSchwierigkeit;

        //die Methoden
        //zum Setzen des Spielfeldes
        void SetzeSpielfeld()
        {
            spielfeldGroesse = spielfeld.ClientRectangle;
            //die minimalen und die maximalen Ränder festlegen
            //dabei werden die Linien berücksichtigt
            spielfeldMaxX = spielfeldGroesse.Right - spielfeldLinienbreite;
            //den linken Rand verschieben wir ein Pixel nach rechts
            spielfeldMinX = spielfeldGroesse.Left + spielfeldLinienbreite + 1;
            spielfeldMaxY = spielfeldGroesse.Bottom - spielfeldLinienbreite;
            spielfeldMinY = spielfeldGroesse.Top + spielfeldLinienbreite;
        }

        //zum Zeichnen des Spielfeldes
        void ZeichneSpielfeld()
        {
            //die weißen Begrenzungen
            pinsel.Color = Color.White;
            //ein Rechteck oben
            zeichenflaeche.FillRectangle(pinsel, 0, 0, spielfeldMaxX, spielfeldLinienbreite);
            //ein Rechteck rechts
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX, 0, spielfeldLinienbreite, spielfeldMaxY + spielfeldLinienbreite);
            //und noch eins unten
            zeichenflaeche.FillRectangle(pinsel, 0, spielfeldMaxY, spielfeldMaxX, spielfeldLinienbreite);
            //damit es nicht langweilig wird, noch eine graue Linie in die Mitte
            pinsel.Color = Color.Gray;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX / 2, spielfeldMinY, spielfeldLinienbreite, spielfeldMaxY - spielfeldLinienbreite);
        }

        //setzt die Position des Balls
        void ZeichneBall(Point position)
        {
            //für die Zufallszahl
            Random zufall = new Random();
            ball.Location = position;

            //wenn der Ball rechts anstößt, ändern wir die Richtung
            if ((position.X + 10) >= spielfeldMaxX)
                ballPosition.richtungX = false;
            //stößt er unten bzw. oben an, ebenfalls
            if ((position.Y + 10) >= spielfeldMaxY)
                ballPosition.richtungY = true;
            else
                if (position.Y <= spielfeldMinY)
                    ballPosition.richtungY = false;
            //ist er wieder links, prüfen wir, ob der Schläger in der Nähe ist
            if ((position.X == spielfeldMinX) && ((schlaeger.Top <= position.Y) && (schlaeger.Bottom >= position.Y)))
            {
                if (ballPosition.richtungX == false)
                    //einen Punkt dazu und die Punkte ausgeben
                    ZeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteMehr)));
                //die Richtung ändern
                ballPosition.richtungX = true;
                //und den Winkel
                ballPosition.winkel = zufall.Next(winkelZufall);
            }
            //ist der Ball hinter dem Schläger?
            if (position.X < spielfeldMinX)
            {
                //fünf Punkte abziehen und die Punkte ausgeben
                ZeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteWeniger)));
                //eine kurze Pause einlegen
                System.Threading.Thread.Sleep(1000);
                //und alles von vorne
                ZeichneBall(new Point(spielfeldMinX, position.Y));
                ballPosition.richtungX = true;
            }
        }

        //setzt die Y-Position des Schlägers
        void ZeichneSchlaeger(int Y)
        {
            //befindet sich der Schläger im Spielfeld?
            if (((Y + schlaegerGroesse) < spielfeldMaxY) && (Y > spielfeldMinY))
                schlaeger.Top = Y;
        }

        //setzt die Einstellungen für einen neuen Ball und einen neuen Schläger
        void NeuerBall()
        {
            //die Größe des Balles setzen
            ball.Width = 10;
            ball.Height = 10;
            //die Größe des Schlägers setzen
            schlaeger.Width = spielfeldLinienbreite;
            schlaeger.Height = schlaegerGroesse;
            //beide Panels werden weiß
            ball.BackColor = Color.White;
            schlaeger.BackColor = Color.White;
            //den Schläger positionieren
            //links an den Rand
            schlaeger.Left = 2;
            //ungefähr in die Mitte
            ZeichneSchlaeger((spielfeldMaxY / 2) - (schlaegerGroesse / 2));
            //der Ball kommt vor den Schläger ungefähr in die Mitte
            ZeichneBall(new Point(spielfeldMinX, spielfeldMaxY / 2));
        }

        //die Zeit ausgeben
        void ZeichneZeit(string restzeit)
        {
            //zuerst die alte Anzeige "überschreiben"
            pinsel.Color = spielfeld.BackColor;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 20, 30, 20);
            //in weißer Schrift
            pinsel.Color = Color.White;
            //die Auszeichnungen für die Schrift werden beim Erstellen des Spielfeldes gesetzt
            zeichenflaeche.DrawString(restzeit, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 20));
        }

        void ZeichnePunkte(string punkte)
        {
            //zuerst die alte Anzeige "überschreiben"
            pinsel.Color = spielfeld.BackColor;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 40, 30, 20);
            //in weißer Schrift
            pinsel.Color = Color.White;
            //die Einstelungen für die Schrift werden beim Erstellen des Spielfeldes gesetzt
            zeichenflaeche.DrawString(punkte, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 40));
        }

        //erzeugt einen Dialog zum Neustart und liefert das Ergebnis zurück
        bool NeuesSpiel()
        {
            bool ergebnis = false;
            if (MessageBox.Show("Neues Spiel starten?", "Neues Spiel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //die Spielzeit neu setzen
                aktuelleSpielzeit = 120;
                //alles neu zeichnen
                ZeichneSpielfeld();
                NeuerBall();
                ZeichneZeit(Convert.ToString(aktuelleSpielzeit));
                //die Punkte zurücksetzen und anzeigen
                spielpunkte.LoeschePunkte();
                ZeichnePunkte("0");
                //den Menüeintrag Pause wieder aktivieren
                pauseToolStripMenuItem.Enabled = true;
                //die Menüeinträge für die Einstellungen deaktivieren
                schwierigkeitsgradToolStripMenuItem.Enabled = false;
                spielfeldToolStripMenuItem.Enabled = false;
                ergebnis = true;
            }
            return ergebnis;
        }

        //setzt die Einstellungen für den Schwierigkeitsgrad
        void SetzeEinstellungen(int schlaeger, int mehr, int weniger, int winkel)
        {
            schlaegerGroesse = schlaeger;
            punkteMehr = mehr;
            punkteWeniger = weniger;
            winkelZufall = winkel;
        }

        //speichert die Einstellungen
        void SchreibeEinstellungen()
        {
            //die Einstellungen setzen
            XmlWriterSettings einstellungen = new XmlWriterSettings();
            einstellungen.Indent = true;
            //eine Instanz für XmlWriter erzeugen
            XmlWriter xmlSchreiben = XmlWriter.Create(xmlDateiname, einstellungen);
            //die Deklaration schreiben
            xmlSchreiben.WriteStartDocument();
            //den Wurzelknoten pong erzeugen
            xmlSchreiben.WriteStartElement("pong");
            //den Knoten groesse erzeugen
            xmlSchreiben.WriteStartElement("groesse");
            //die Einträge schreiben
            xmlSchreiben.WriteElementString("breite", Convert.ToString(this.Width));
            xmlSchreiben.WriteElementString("hoehe", Convert.ToString(this.Height));
            //den Knoten abschließen
            xmlSchreiben.WriteEndElement();
            //den Knoten schwierigkeitsgrad erzeugen
            xmlSchreiben.WriteStartElement("schwierigkeitsgrad");
            //den Eintrag schreiben
            xmlSchreiben.WriteElementString("wert", Convert.ToString(xmlSchwierigkeit));
            //alle abschließen
            xmlSchreiben.WriteEndDocument();
            //Datei schließen
            xmlSchreiben.Close();
        }

        //liest die Einstellungen
        void LeseEinstellungen()
        {
            //gibt es die Datei?
            if (System.IO.File.Exists(xmlDateiname) == false)
                return;
            //eine Instanz von XmlReader erzeugen
            XmlReader xmlLesen = XmlReader.Create(xmlDateiname);
            //die Daten lesen und zuweisen
            xmlLesen.ReadToFollowing("breite");
            xmlBreite = Convert.ToInt32(xmlLesen.ReadElementString());
            xmlLesen.ReadToFollowing("hoehe");
            xmlHoehe = Convert.ToInt32(xmlLesen.ReadElementString());
            xmlLesen.ReadToFollowing("wert");
            xmlSchwierigkeit = Convert.ToInt32(xmlLesen.ReadElementString());
            //die Datei wieder schließen
            xmlLesen.Close();
            //nach Schwierigkeitsgrad die Einstellungen setzen
            //als Sender wird das Formular übergeben, das zweite Argument ist EventArgs.Empty
            switch (xmlSchwierigkeit)
            {
                case 1:
                    sehrEinfachToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;
                case 2:
                    einfachToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;
                case 3:
                    mittelToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;
                case 4:
                    schwerToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;
                case 5:
                    sehrSchwerToolStripMenuItem_Click(this, EventArgs.Empty);
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
            //die Breite der Linien
            spielfeldLinienbreite = 10;
            //die Größe des Schlägers
            schlaegerGroesse = 50;
            //die Standardeinstellungen für den Schwierigkeitsgrad Einfach
            punkteMehr = 1;
            punkteWeniger = -5;
            winkelZufall = 5;
            //die Standard-Schwierigkeit
            xmlSchwierigkeit = 2;
            //den Dateinamen setzen
            xmlDateiname = System.IO.Path.ChangeExtension(Application.ExecutablePath, ".xml");
            //Standardwert für die Größe
            xmlBreite = 640;
            xmlHoehe = 480;
            //die Daten lesen
            LeseEinstellungen();
            //die Größe des Formulars setzen
            this.Height = xmlHoehe;
            this.Width = xmlBreite;
            //erst einmal geht der Ball nach vorne und oben mit dem Winkel 0
            ballPosition.richtungX = true;
            ballPosition.richtungY = true;
            ballPosition.winkel = 0;
            //den Pinsel erzeugen
            pinsel = new SolidBrush(Color.Black);
            //die Zeichenfläche beschaffen
            zeichenflaeche = spielfeld.CreateGraphics();
            //das Spielfeld bekommt einen schwarzen Hintergrund
            spielfeld.BackColor = Color.Black;
            //die Grenzen für das Spielfeld setzen
            SetzeSpielfeld();
            //einen "neuen" Ball erstellen
            NeuerBall();
            //erst einmal ist das Spiel angehalten
            spielPause = true;
            //alle drei Timer sind zunächst angehalten
            timerBall.Enabled = false;
            timerSpiel.Enabled = false;
            timerSekunde.Enabled = false;
            //die Schriftauszeichnung setzen
            schrift = new Font("Arial", 12, FontStyle.Bold);
            //die Pausenfunktion ist erst einmal deaktiviert
            pauseToolStripMenuItem.Enabled = false;
            //eine neue Instanz der Klasse Score für die Punkte
            spielpunkte = new Score();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void schlaeger_MouseMove(object sender, MouseEventArgs e)
        {
            //wenn das Spiel angehalten ist, verlassen wir die Methode direkt wieder
            if (spielPause == true)
                return;
            if (e.Button == MouseButtons.Left)
                ZeichneSchlaeger(e.Y + schlaeger.Top);
        }

        private void timerBall_Tick(object sender, EventArgs e)
        {
            int neuX = 0, neuY = 0;
            //abhängig von der Bewegungsrichtung die Koordinaten neu setzen
            if (ballPosition.richtungX == true)
                neuX = ball.Left + 10;
            else
                neuX = ball.Left - 10;
            if (ballPosition.richtungY == true)
                neuY = ball.Top - ballPosition.winkel;
            else
                neuY = ball.Top + ballPosition.winkel;
            //den Ball neu zeichnen
            ZeichneBall(new Point(neuX, neuY));
        }

        private void spielfeld_Paint(object sender, PaintEventArgs e)
        {
            ZeichneSpielfeld();
            ZeichneZeit(Convert.ToString(aktuelleSpielzeit));
        }

        private void timerSekunde_Tick(object sender, EventArgs e)
        {
            //eine Sekunde abziehen
            aktuelleSpielzeit = aktuelleSpielzeit - 1;
            //die Restzeit ausgeben
            ZeichneZeit(Convert.ToString(aktuelleSpielzeit));
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //erst einmal prüfen wir den Status
            //läuft das Spiel?
            if (spielPause == false)
            {
                //alle Timer anhalten
                timerBall.Enabled = false;
                timerSekunde.Enabled = false;
                timerSpiel.Enabled = false;
                //die Markierung im Menü einschalten
                pauseToolStripMenuItem.Checked = true;
                //den Text in der Titelleiste ändern
                this.Text = "Pong - Das Spiel ist angehalten!";
                spielPause = true;
            }
            else
            {
                //das Intervall für die verbleibende Spielzeit setzen
                timerSpiel.Interval = aktuelleSpielzeit * 1000;
                //alle Timer wieder an
                timerBall.Enabled = true;
                timerSekunde.Enabled = true;
                timerSpiel.Enabled = true;
                //die Markierung im Menü abschalten
                pauseToolStripMenuItem.Checked = false;
                //den Text in der Titelleiste ändern
                this.Text = "Pong";
                spielPause = false;
            }
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //"läuft" ein Spiel?
            //dann erst einmal pausieren
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                //den Dialog anzeigen
                NeuesSpiel();
                //und weiter spielen
                pauseToolStripMenuItem_Click(sender, e);
            }
            //wenn kein Spiel läuft, starten wir ein neues, wenn im Dialog auf Ja geklickt wurde
            else
                if (NeuesSpiel() == true)
                    pauseToolStripMenuItem_Click(sender, e);
        }

        private void timerSpiel_Tick(object sender, EventArgs e)
        {
            //das Spiel anhalten
            pauseToolStripMenuItem_Click(sender, e);
            //eine Meldung anzeigen
            MessageBox.Show("Die Zeit ist um", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //nachsehen, ob ein neuer Eintrag in der Bestenliste erfolgen kann
            if (spielpunkte.NeuerEintrag() == true)
            {
                //Ball und Schläger "verstecken"
                ball.Hide();
                schlaeger.Hide();
                //die Liste ausgeben
                spielpunkte.ListeAusgeben(zeichenflaeche, spielfeldGroesse);
                //fünf Sekunden warten
                System.Threading.Thread.Sleep(5000);
                //die Zeichenfläche löschen
                zeichenflaeche.Clear(spielfeld.BackColor);
                //Ball und Schläger wieder anzeigen
                ball.Show();
                schlaeger.Show();
            }
            //Abfrage, ob ein neues Spiel gestartet werden soll
            if (NeuesSpiel() == true)
                //das Spiel "fortsetzen"
                pauseToolStripMenuItem_Click(sender, e);
            else
                //sonst beenden
                beendenToolStripMenuItem_Click(sender, e);
        }

        private void bestenlisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zur Unterscheidung zwischen einem laufenden und einem nicht gestarteten Spiel
            bool weiter = false;
            //"läuft" ein Spiel? dann erst einmal pausieren
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                weiter = true;
            }
            //Ball und Schläger "verstecken"
            ball.Hide();
            schlaeger.Hide();
            //die Liste ausgeben
            spielpunkte.ListeAusgeben(zeichenflaeche, spielfeldGroesse);
            //fünf Sekunden warten
            System.Threading.Thread.Sleep(5000);
            //die Zeichenfläche löschen
            zeichenflaeche.Clear(spielfeld.BackColor);
            //Ball und Schläger wieder anzeigen
            ball.Show();
            schlaeger.Show();
            //das Spiel wieder fortsetzen, wenn wir es angehalten haben
            if (weiter == true)
                pauseToolStripMenuItem_Click(sender, e);
        }

        private void sehrEinfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 200;
            //die Einstellungen setzen
            SetzeEinstellungen(100, 1, -20, 2);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = true;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
            //für das Speichern des Schwierigkeitsgrades
            xmlSchwierigkeit = 1;
        }

        private void einfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 100;
            //die Einstellungen setzen
            SetzeEinstellungen(50, 1, -5, 5);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = true;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
            //für das Speichern des Schwierigkeitsgrades
            xmlSchwierigkeit = 2;
        }

        private void mittelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 50;
            //die Einstellungen setzen
            SetzeEinstellungen(50, 3, -5, 15);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = true;
            sehrSchwerToolStripMenuItem.Checked = false;
            //für das Speichern des Schwierigkeitsgrades
            xmlSchwierigkeit = 3;
        }

        private void schwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 25;
            //die Einstellungen setzen
            SetzeEinstellungen(50, 10, -5, 25);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = true;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
            //für das Speichern des Schwierigkeitsgrades
            xmlSchwierigkeit = 4;
        }

        private void sehrSchwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 10;
            //die Einstellungen setzen
            SetzeEinstellungen(20, 20, -5, 40);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = true;
            //für das Speichern des Schwierigkeitsgrades
            xmlSchwierigkeit = 5;
        }

        private void spielfeldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point neueGroesse = new Point(0, 0);
            EinstellungenDialog neueWerte = new EinstellungenDialog();
            //wenn der Dialog über die "OK"-Schaltlfäche beendet wird
            if (neueWerte.ShowDialog() == DialogResult.OK)
            {
                //die neue Größe holen
                neueGroesse = neueWerte.LiefereWert();
                //den Dialog wieder schließen
                neueWerte.Close();
                //das Formular ändern
                this.Width = neueGroesse.X;
                this.Height = neueGroesse.Y;
                //neu ausrichten
                this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
                this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                //die Zeichenfläche neu beschaffen
                zeichenflaeche = spielfeld.CreateGraphics();
                //das Spielfeld neu setzen
                SetzeSpielfeld();
                //Spielfeld löschen
                zeichenflaeche.Clear(spielfeld.BackColor);
                //und einen neuen Ball und einen neuen Schläger zeichnen
                NeuerBall();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SchreibeEinstellungen();
        }
    }
}
