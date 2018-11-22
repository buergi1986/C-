/* ######################################################
Einsendeaufgabe 5.3
###################################################### */

using System;

namespace einsendeaufgabe_0503
{
    //die Klasse für die Listenelemente
    //jetzt auch mit Methoden
    class Knotenklasse
    {
        public string daten;
        public Knotenklasse naechster;
        public Knotenklasse ListenEnde;
        public Knotenklasse voriger;
        //die Methode zum Setzen der Daten
        public Knotenklasse(string datenNeu)
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
                naechster = new Knotenklasse(datenNeu)
                {
                    voriger = this
                };
                ListenEnde = naechster;
            }
            //sonst ruft sich die Methode selbst wieder auf
            else
            {
                Knotenklasse temp = new Knotenklasse(datenNeu);
                temp.naechster = naechster;
                naechster = temp;
            }
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
    class Listenelement
    {
        public Knotenklasse knoten;
        public Knotenklasse listenEnde;

        public Listenelement()
        {
            knoten = null;
        }

        public void Anhaengen(string datenNeu)
        {
            //wenn das Ende erreicht ist, ein neues
            //Element erzeugen
            if (knoten == null)
            {
                knoten = new Knotenklasse(datenNeu);
                listenEnde = knoten;
            }
            //sonst ruft sich die Methode selbst wieder auf
            else
            {
                Knotenklasse temp = new Knotenklasse(datenNeu)
                {
                    naechster = knoten
                };
                knoten = temp;
            }
            //zur Veranschaulichung der Rekursion
            //vorwärts Ausgeben
            Console.WriteLine("Daten {0} wurden eingefügt.", datenNeu);
        }
        //die Methode zur Ausgabe der Liste
        public void Ausgeben()
        {
            knoten.Ausgeben();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ein neues Listenelement erzeugen
            //bitte in einer Zeile eingeben
            //die Daten im ersten leeren Listenelement setzen
            Listenelement listenAnfang = new Listenelement();
            //leere Zeile
            Console.WriteLine();
            Console.WriteLine("Vorwärts:");
            //leere Zeile
            Console.WriteLine();

            //weitere Elemente in einer Schleife anfügen
            for (int element = 1; element < 10; element++)
            {
                //rückwärts Ausgeben
                listenAnfang.Anhaengen("Element " + element);
            }
            //leere Zeile
            Console.WriteLine();
            Console.WriteLine("Rückwärts:");
            //leere Zeile
            Console.WriteLine();
            //die Liste ausgeben
            listenAnfang.Ausgeben();
            //leere Zeile
            Console.WriteLine();
        }
    }
}