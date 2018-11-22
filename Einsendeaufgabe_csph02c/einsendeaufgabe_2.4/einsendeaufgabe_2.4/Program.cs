/* ################################################
Einsendeaufgabe 2.4
################################################# */

using System;

namespace einsendeaufgabe_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Einsendeaufgabe 2.4";

            const int minutes = 60;
            const int hours = 24;
            int days = 7;

            int variable = minutes;

            Console.WriteLine("Eine Stunde hat {0} Minuten.", variable);
            variable *= hours;
            //bitte in einer Zeile eingeben
            Console.WriteLine("Ein Tag hat {0} Minuten.", variable);
            variable *= days;
            //bitte in einer Zeile eingeben
            Console.WriteLine("Eine Woche hat {0} Minuten.", variable);

        }
    }
}
