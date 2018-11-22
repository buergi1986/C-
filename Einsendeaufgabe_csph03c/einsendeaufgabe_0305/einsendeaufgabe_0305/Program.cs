/* #################################################### 
Einsendeaufgabe 3.5 
##################################################### */

using System;

namespace einsendeaufgabe_0304
{
    class Program
    {
        //Method erstellen
        static void Potenzberechnen(double zahl1, int zahl2)
        {
            double summe = zahl1;

            //Potenz mit Schleife errechnet

            for(int i = 1; i < zahl2; i++)
            {
                summe *= zahl1;
            }
            Console.WriteLine("Das Potenzwert des Ergebnisses: {0}", summe);
        }

        static int ExponentNull()
        {
            return 1;
        }

        static double NegativPotenzberechnen(double zahl1, int zahl2)
        {
            double summe = 1;

            for (int i = 0; i < -zahl2; i++)
                summe /= zahl1;

            return summe;
        }

        static void Main(string[] args)
        {
            Console.Title = "Einsendeaufgabe 3.5";

            double zahl1 = 0;
            int zahl2 = 0;
            bool flag = false;

            Console.WriteLine("Sie geben bitte ein Potenz mit der Basis und dem Exponent.");
            //Zeilen eingeben
            while(flag == false)
            {
                try
                {
                    Console.Write("Wert die Basis: ");
                    zahl1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Wert den Exponent: ");
                    zahl2 = Convert.ToInt32(Console.ReadLine());
                    flag = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ungültige Zahl. Sie können sie bitte wiederholen.");
                }
            }
                       

            //Method des Ergebnisses wird Ausgaben
            if (zahl2 > 0)
            {
                //Basis ergibt den Wert mit 0 bis n.
                Potenzberechnen(zahl1, zahl2);
            }
            else if (zahl2 == 0)
            {
                //Exponent ergibt den Wert mit 0
                Console.WriteLine("Das Potenzwert des Ergebnisses: {0}", ExponentNull());
            }
            else
            {
                if(zahl1 != 0)
                {
                  Console.WriteLine("Das Potenzwert des Ergebnisses: {0}", NegativPotenzberechnen(zahl1, zahl2));
                }
                else
                {
                    Console.WriteLine("Ungültige Zahl");
                }
            }
        }
    }
}
