/* #################################################### 
Einsendeaufgabe 3.4 
##################################################### */

using System;

namespace einsendeaufgabe_0304
{
    class Program
    {
        //Method erstellen
        static void Rechner(double zahl1, double zahl2, char rechnenart)
        {
            Console.Title = "Einsendeaufgabe 3.4";

            double summe = 0;

            //Welche Grundrechnenart eingeben
            switch (rechnenart)
            {
                case '+' :
                    summe = zahl1 + zahl2;
                    Console.WriteLine("Das Ergebnis: {0}", summe);
                    break;
                case '-':
                    summe = zahl1 - zahl2;
                    Console.WriteLine("Das Ergebnis: {0}", summe);
                    break;
                case '/':
                    summe = zahl1 / zahl2;
                    Console.WriteLine("Das Ergebnis: {0}", summe);
                    break;
                case '*':
                    summe = zahl1 * zahl2;
                    Console.WriteLine("Das Ergebnis: {0}", summe);
                    break;
                default:
                    Console.WriteLine("Keine Wert");
                    break;
            }


        }

        static void Main(string[] args)
        {
            double zahl1, zahl2;
            char rechnenart;

            //Zeilen eingeben
            Console.WriteLine("Zahl 1: ");
            zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Grundrechnenart ( +, -, /, *) : ");
            rechnenart = Convert.ToChar(Console.ReadLine());
            Console.Write("Zahl 2: ");
            zahl2 = Convert.ToDouble(Console.ReadLine());

            //Method Ausgabe
            Rechner(zahl1, zahl2, rechnenart);

        }
    }
}
