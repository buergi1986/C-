using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Memory
{
    class MemoryKarte : Button
    {
        //die Felder
        //eine eindeutige ID zur Identifizierung des Bildes
        int bildID;
        //für die Vorder- und Rückseite
        Image bildVorne, bildHinten;
        //wo liegt die Karte im Spielfeld?
        int bildPos;
        //ist die Karte umgedrehtt?
        bool umgedreht;
        //ist die Karte noch im Spiel?
        bool nochImSpiel;

        //für das Spielfeld für die Karte
        MemoryFeld spiel;
        //der Konstruktor
        //er setzt die Grösse, die Bilder und die Position
        public MemoryKarte(string vorne, int bildID, MemoryFeld spiel)
        {
            //die Vorderseite, der Dateiname des Bildes wird an
            //den Konstruktor übergeben
            bildVorne = new Image();
            //bitte in einer Zeile eingeben
            bildVorne.Source = new BitmapImage(new Uri(vorne, UriKind.Relative));
            //die Rückseite, sie wird fest gesetzt
            bildHinten = new Image();
            bildHinten.Source = new BitmapImage(new Uri("grafiken/verdeckt.bmp", UriKind.Relative));
            //die Eigenschaften zuweisen
            Content = bildHinten;
            //die Bild-ID
            this.bildID = bildID;
            //die Karte ist erst einmal umgedreht und noch im Feld
            umgedreht = false;
            nochImSpiel = true;
            //mit dem Spielfeld verbinden
            this.spiel = spiel;
         
            //die Methode mit dem Ereignis verbinden
            Click += new RoutedEventHandler(ButtonClick);
            
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            //ist die Karte überhaupt noch im Spiel?
            if ((nochImSpiel == false) || (spiel.ZugErlaubt() == false))
                return;
            //wenn die Rückseite zu sehen ist, die Vorderseite anzeigen
            if ((umgedreht == false))
            {
                VorderseiteZeigen();
                //die Methode KarteOeffnen() im Spielfeld aufrufen übergeben
                //wird dabei die Karte - also die this-Referenz
                spiel.KarteOeffnen(this);
            }
        }

        //die Methode zeigt die Rückseite der Karte an
        public void RueckseiteZeigen(bool rausnehmen)
        {
            //soll die Karte komplett aus dem Spiel genommen werden?
            if (rausnehmen == true)
            {
                //das Bild aufgedeckt zeigen und die Karte aus dem Spiel nehmen
                Image bildRausgenommen = new Image();
                //bitte in einer Zeile eingeben
                bildRausgenommen.Source = new BitmapImage(new
                Uri("grafiken/aufgedeckt.bmp", UriKind.Relative));
                Content = bildRausgenommen;
                nochImSpiel = false;
            }
            else
            {
                //sonst nur die Rückseite zeigen
                Content = bildHinten;
                umgedreht = false;
            }
        }

        //die Methode liefert die Bild-ID einer Karte
        public int GetBildID(){ return bildID; }

        //die Methode liefert die Position einer Karte
        public int GetBildPos(){ return bildPos; }

        //die Methode setzt die Position einer Karte
        public void SetBildPos(int bildPos){ this.bildPos = bildPos; }

        //die Methode liefert den Wert des Felds umgedreht
        public bool IsUmgedreht()
        {
            return umgedreht;
        }

        //die Methode liefert den Wert des Feld nochImSpiel
        public bool IsNochImSpiel()
        {
            return nochImSpiel;
        }

        //die Methode zeigt die Vorderseite der Karte an
        public void VorderseiteZeigen()
        {
            Content = bildVorne;
            umgedreht = true;
        }
    }
}
