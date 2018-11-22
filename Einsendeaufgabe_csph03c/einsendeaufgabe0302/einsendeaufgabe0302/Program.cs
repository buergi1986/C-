/* #################################################### 
Einsendeaufgabe 3.2 
##################################################### */

using System;

namespace einsendeaufgabe0302
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Einsendeaufgabe 3.2";

            for (int i = 1; i <= 5; i++) {
                Console.Write(i);
            if (i < 5)
                Console.Write(",");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        
    }
}
