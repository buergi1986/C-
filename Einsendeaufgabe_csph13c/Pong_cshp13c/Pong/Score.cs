using System;
using System.IO;
using System.Windows.Forms;

namespace schummeleditor_cshp13c
{
    //die Klasse für die Liste
    //Sie muss die Schnittstelle IComparable implementieren
    class Liste : IComparable
    {
        //die Felder
        int listePunkte;
        string listeName;

        //die Methoden
        //der Konstruktor
        public Liste()
        {
            //er setzt die Punkte und den Namen auf Standard-Werte
            listePunkte = 0;
            listeName = "Nobody";
        }

        //die Vergleichsmethode
        public int CompareTo(object objekt)
        {
            Liste tempListe = (Liste)(objekt);
            if (this.listePunkte < tempListe.listePunkte)
                return 1;
            if (this.listePunkte > tempListe.listePunkte)
                return -1;
            else
                return 0;
        }

        //die Methode zum Setzen von Einträgen
        public void SetzeEintrag(int punkte, string name)
        {
            listePunkte = punkte;
            listeName = name;
        }

        //die Methode zum Liefern der Punkte
        public int GetPunkte()
        {
            return listePunkte;
        }

        //die Methode zum Liefern des Namens
        public string GetName()
        {
            return listeName;
        }
    }

    class Score
    {
        //die Felder
        int punkte;
        //die Anzahl der Einträge in der Liste
        int anzahl = 10;
        //für die Liste
        Liste[] bestenliste;
        //für den Dateinamen
        string dateiname;

        //die Methoden
        //der Konstruktor
        public Score()
        {
            punkte = 0;
            //eine neue Instanz der Liste erstellen
            bestenliste = new Liste[anzahl];
            //die Elemente initialisieren
            for (int i = 0; i < anzahl; i++)
                bestenliste[i] = new Liste();
            //den Dateinamen aus dem Pfad zusammenbauen
            dateiname = System.Windows.Forms.Application.StartupPath + "\\score.dat";
            //wenn es die Datei schon gibt, die Daten lesen
            if (System.IO.File.Exists(dateiname))
                LesePunkte();
            else
                MessageBox.Show("Die Datei ist nicht vorhanden", "Fehler");
        }

        //zum Verändern der Punkte
        public int VeraenderePunkte(int anzahl)
        {
            punkte = punkte + anzahl;
            return punkte;
        }

        //zum Zurücksetzen der Punkte
        public void LoeschePunkte()
        {
            punkte = 0;
        }

        //die Liste ausgeben
        public void ListeAusgeben(System.Drawing.Graphics zeichenflaeche, System.Drawing.RectangleF flaeche)
        {
            //ein temporärer Pinsel
            System.Drawing.SolidBrush tempPinsel = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            //die Schriftart setzen
            System.Drawing.Font tempSchrift = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            //für die zentrierte Ausgabe
            System.Drawing.StringFormat ausrichtung = new System.Drawing.StringFormat();
            //Koordinaten für die Ausgabe
            float punkteX, nameX, y;
            punkteX = flaeche.Left + 50;
            nameX = flaeche.Left + 250;
            y = flaeche.Top + 50;
            //die Ausrichtung ist zentriert
            ausrichtung.Alignment = System.Drawing.StringAlignment.Center;
            //die Zeichenfläche löschen
            zeichenflaeche.Clear(System.Drawing.Color.Black);
            //den Titel ausgeben
            zeichenflaeche.DrawString("Bestenliste", tempSchrift, tempPinsel, flaeche.Width / 2, y, ausrichtung);
            //und nun die Liste selbst
            for (int i = 0; i < anzahl; i++)
            {
                y = y + 20;
                zeichenflaeche.DrawString(Convert.ToString(bestenliste[i].GetPunkte()), tempSchrift, tempPinsel, punkteX, y);
                zeichenflaeche.DrawString(bestenliste[i].GetName(), tempSchrift, tempPinsel, nameX, y);
            }
        }

        //zum Lesen aus der Datei
        public void LesePunkte()
        {
            //zum Zwischenspeichern der gelesenen Daten
            int tempPunkte;
            string tempName;
            //eine neue Instanz von FileStream erzeugen
            //die Datei soll geöffnet werden
            using (FileStream fStream = new FileStream(dateiname, FileMode.Open))
            {
                //eine neue Instanz von BinaryReader erzeugen
                using (BinaryReader binaerDatei = new BinaryReader(fStream))
                {
                    //die Einträge lesen und zuweisen
                    for (int i = 0; i < anzahl; i++)
                    {
                        //die Punkte
                        tempPunkte = binaerDatei.ReadInt32();
                        //den Namen
                        tempName = binaerDatei.ReadString();
                        //und jetzt zuweisen
                        bestenliste[i].SetzeEintrag(tempPunkte, tempName);
                        //die Listen sortieren
                        switch (i)
                        {
                            case 0:
                                Form1._Form1.punkteTextBox1.Text = tempPunkte.ToString();
                                Form1._Form1.nameTextBox1.Text = tempName;
                                break;
                            case 1:
                                Form1._Form1.punkteTextBox2.Text = tempPunkte.ToString();
                                Form1._Form1.nameTextBox2.Text = tempName;
                                break;
                            case 2:
                                Form1._Form1.punkteTextBox3.Text = tempPunkte.ToString();
                                Form1._Form1.nameTextBox3.Text = tempName;
                                break;
                            case 3:
                                Form1._Form1.punkteTextBox4.Text = tempPunkte.ToString();
                                Form1._Form1.nameTextBox4.Text = tempName;
                                break;
                            case 4:
                                Form1._Form1.punkteTextBox5.Text = tempPunkte.ToString();
                                Form1._Form1.nameTextBox5.Text = tempName;
                                break;
                            case 5:
                                Form1._Form1.punkteTextBox6.Text = tempPunkte.ToString();
                                Form1._Form1.nameTextBox6.Text = tempName;
                                break;
                            case 6:
                                Form1._Form1.punkteTextBox7.Text = tempPunkte.ToString();
                                Form1._Form1.nameTextBox7.Text = tempName;
                                break;
                            case 7:
                                Form1._Form1.punkteTextBox8.Text = tempPunkte.ToString();
                                Form1._Form1.nameTextBox8.Text = tempName;
                                break;
                            case 8:
                                Form1._Form1.punkteTextBox9.Text = tempPunkte.ToString();
                                Form1._Form1.nameTextBox9.Text = tempName;
                                break;
                            case 9:
                                Form1._Form1.punkteTextBox10.Text = tempPunkte.ToString();
                                Form1._Form1.nameTextBox10.Text = tempName;
                                break;
                        }
                    }
                }
            }
        }
   

        //zum Schreiben in die Datei
        public void SchreibePunkte()
        {
            //eine neue Instanz von FileStream erzeugen
            //die Datei soll entweder geöffnet oder neu erzeugt werden
            using (FileStream fStream =  new FileStream(dateiname, FileMode.Create))
            {
                //eine neue Instanz von BinaryWriter erzeugen
                using (BinaryWriter binaerDatei = new BinaryWriter(fStream))
                {
                    //die Einträge in die Datei schreiben
                    for (int i = 0; i < anzahl; i++)
                    {
                        //die Punkte
                        binaerDatei.Write(bestenliste[i].GetPunkte());
                        //und dann den Namen
                        binaerDatei.Write(bestenliste[i].GetName());
                    }
                }
            }
        }
    }
}
