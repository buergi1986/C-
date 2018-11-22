using System;
using System.Collections.Generic;
using System.IO;

namespace snake_csph18c
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
            dateiname = System.AppDomain.CurrentDomain.BaseDirectory + "\\score.dat";
            //wenn es die Datei schon gibt, die Daten lesen
            if (System.IO.File.Exists(dateiname))
                LesePunkte();
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

        //ist ein neuer Eintrag erreicht?
        public bool NeuerEintrag(System.Windows.Window fenster)
        {
            string tempName = string.Empty;
            //wenn die aktuelle Punktzahl größer ist als der letzte Eintrag der Liste, 
            //wird der letzte Eintrag der Liste überschrieben und die Liste neu sortiert
            if (punkte > bestenliste[anzahl - 1].GetPunkte())
            {
                //den Namen beschaffen
                NameDialog neuerName = new NameDialog();
                //den "Eigentümer" setzen
                neuerName.Owner = fenster;
                //den Dialog modal anzeigen
                neuerName.ShowDialog();
                if (neuerName.DialogResult == true)
                    tempName = neuerName.LiefereName();
                bestenliste[anzahl - 1].SetzeEintrag(punkte, tempName);
                //neu sortieren
                Array.Sort(bestenliste);
                //und speichern
                SchreibePunkte();
                return true;
            }
            else
                return false;
        }

        //die Liste ausgeben
        public void ListeAusgeben(System.Windows.Window fenster)
        {
            //wir erstellen uns der Einfachheit halber eine Liste vom Typ string
            List<string> eintraege = new List<string>();
            for (int i = 0; i < anzahl; i++)
            {
                eintraege.Add(Convert.ToString(bestenliste[i].GetPunkte()));
                eintraege.Add(bestenliste[i].GetName());
            }
            //die Liste anzeigen
            Bestenliste listenAnzeige = new Bestenliste(eintraege);
            //den "Eigentümer" setzen
            listenAnzeige.Owner = fenster;
            //den Dialog modal anzeigen
            listenAnzeige.ShowDialog();
        }

        //zum Lesen aus der Datei
        void LesePunkte()
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
                    }
                }
            }
        }

        //zum Schreiben in die Datei
        void SchreibePunkte()
        {
            //eine neue Instanz von FileStream erzeugen
            //die Datei soll entweder geöffnet oder neu erzeugt werden
            using (FileStream fStream = new FileStream(dateiname, FileMode.Create))
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
