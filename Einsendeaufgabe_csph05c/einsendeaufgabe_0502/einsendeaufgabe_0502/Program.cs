/* ######################################################
Einsendeaufgabe 5.2
###################################################### */

using System;

namespace einsendeaufgabe_0502
{
    //die Klasse für die Listenelemente
    //jetzt auch mit Methoden
    class Listenelement
    {
        string daten;
        Listenelement naechster;
        Listenelement ListenEnde;
        private Listenelement hilfsKonstruktion;

        //die Methode zum Setzen der Daten
        public void SetDaten(string datenNeu)
        {
            //die Zeichenkette setzen
            daten = datenNeu;
            //das Ende markieren
            naechster = null;
        }

        //die Methode zum Anhängen eines neuen Elements
        //sie ruft sich rekursiv auf, bis das Ende erreicht
        //ist
        public void Anhaengen(string datenNeu)
        {
            //wenn das Ende erreicht ist, ein neues
            //Element erzeugen
            if (naechster == null)
            {
                //voriger
                naechster = new Listenelement
                {
                    hilfsKonstruktion = this
                };
                //Neue ListenEnde setzen
                ListenEnde = naechster;
                naechster.SetDaten(datenNeu);
            }
            //sonst ruft sich die Methode selbst wieder auf
            else
                naechster.Anhaengen(datenNeu);
            //zur Veranschaulichung der Rekursion
            //bitte in einer Zeile eingeben
            Console.WriteLine("Daten {0} wurden eingefügt.", datenNeu);
        }
        //die Methode zur Ausgabe der Liste
        //sie ruft sich ebenfalls rekursiv auf, bis das
        //Ende erreicht ist
        public void Ausgeben()
        {
            Console.WriteLine(daten);
            if (naechster != null)
                naechster.Ausgeben();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ein neues Listenelement erzeugen
            //bitte in einer Zeile eingeben
            Listenelement listenAnfang = new Listenelement();
            //die Daten im ersten Listenelement setzen
            listenAnfang.SetDaten("Element 1");
            //weitere Elemente in einer Schleife anfügen
            for (int element = 2; element < 4; element++)
                //bitte in einer Zeile eingeben
                listenAnfang.Anhaengen("Element " +
                element);
            //die Liste ausgeben
            listenAnfang.Ausgeben();
        }
    }
}