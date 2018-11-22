/* #################################################### 
Einsendeaufgabe 3.3 
##################################################### */

using System;

namespace einsedeaufgabe0303
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Einsendeaufgabe 3.3";

            int i = 1;
            int zahl = 25;

            while (i < zahl)
            {
                i += 1;
                Console.WriteLine(i++);
            }
        }
    }
}
