/* ################################################
Einsendeaufgabe 2.2
################################################# */

using System;

namespace einsendaufgabe_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Einsendeaufgabe 2.2";

            //Variablen
            int zahl1, zahl2;
            double variablDouble1, summeDouble;

            //Wertzuweisung
            zahl1 = 10;
            zahl2 = 3; 

            Console.WriteLine("Ein int zum double getestet.");
           
            //int zum double
            summeDouble = (double)zahl1 / zahl2;
            Console.WriteLine("Das Ergebnis: {0}", summeDouble);
            Console.WriteLine();
            
            //int zum double dirket in den Ausgaben
            Console.WriteLine("Andere möglich...");
            Console.WriteLine("Das Ergebnis von (double) int/int: {0}", (double)zahl1 / zahl2);
            Console.WriteLine();
            
            //int1 zu double konventieren / int2
            summeDouble = Convert.ToDouble(zahl1)/zahl2;
            Console.WriteLine("Noch andere möglich...");
            Console.WriteLine("Das Ergebnis von das int1 zum Convert.ToDouble / int2: {0}", summeDouble);
            Console.WriteLine();
            
            //int1 zu double1 übertragen / int2
            variablDouble1 = zahl1;
            summeDouble = variablDouble1 / zahl2;
            Console.WriteLine("Noch andere möglich...");
            Console.WriteLine("Das Ergebnis von das int1 zu double übertragen / int2: {0}", summeDouble);
        }
    }
}
