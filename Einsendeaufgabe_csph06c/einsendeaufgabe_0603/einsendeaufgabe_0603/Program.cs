/* ######################################################
Einsendeaufgabe 6.3
###################################################### */

using System;

namespace einsendeaufgabe_0603
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund hund = new Hund(5, 8);
            KleinerHund kleinerHund = new KleinerHund(1, 1, 50);
            Console.Title = "Einsendeaufgabe 6.3";

            Console.WriteLine("Der Hund ist {0} Jahre alt und {1} Kg.", hund.GetAlter, hund.GetGewicht);
            Console.WriteLine("Der kleinen Hund ist {0} Jahre alt, {1} Kg und {2} cm Grösser.", kleinerHund.GetAlter, kleinerHund.GetGewicht, kleinerHund.GetGroesse());
        }
    }
    //die Basisklasse Hund
    class Hund
    {
        int gewicht;
        int alter;

        public Hund(int gewicht, int alter)
        {
            this.gewicht = gewicht;
            this.alter = alter;
        }

        public int GetGewicht { get { return this.gewicht; } }

        public int GetAlter { get { return this.alter; } }
    }
    //die Klasse KleinerHund erbt von der Klasse Hund
    class KleinerHund : Hund
    {
        int groesse;

        //ein eigener Konstruktor
        public KleinerHund(int gewicht, int alter, int groesse) : base (gewicht, alter)
        {
            this.groesse = groesse;
        }

        public int GetGroesse()
        {
            return groesse;
        }
    }
}
