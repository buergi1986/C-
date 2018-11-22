/* #################################################### 
Einsendeaufgabe 3.1 
##################################################### */

using System;

namespace einsendeaufgabe_0301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Einsendeaufgabe 3.1";

            int schaltjahr = 0;

            Console.WriteLine("Um zu prüfen ob es sich um ein Schaltjahr handelt.");
            Console.Write("Sie geben bitte ein Jahr ein: ");
            schaltjahr = Convert.ToInt32(Console.ReadLine());

            if (schaltjahr % 4 == 0)
            {
                Console.WriteLine("Das {0} war ein Schaltjahr.", schaltjahr);
            }

            else if (schaltjahr % 100 == 0)
            {
                Console.WriteLine("Das {0} war kein Schaltjahr.", schaltjahr);
            }

            else if (schaltjahr % 400 == 0)
            { 
                Console.WriteLine("Das {0} war ein Schaltjahr.", schaltjahr);
            }

            else
                Console.WriteLine("Das {0} war kein Schaltjahr.", schaltjahr);
        }
    }
}
