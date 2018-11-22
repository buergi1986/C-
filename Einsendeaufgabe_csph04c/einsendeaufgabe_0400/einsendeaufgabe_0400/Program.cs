/* ######################################################
Einsendeaufgabe 4
###################################################### */

using System;

namespace einsendeaufgabe_0400
{
    class Program
    {
        //die Vereinbarung der Struktur
        //sie erfolgt außerhalb der Methoden
        struct Kiste
        {
            public int Hoehe;
            public int Breite;
            public int Laenge;
            public int Volumen;
            public int ID;
        }
        //die Methode zum Einlesen
        //sie liefert die "komplette" Kiste zurück
        static Kiste Einlesen(int KistenNummer)
        {
            //eine lokale Strukturvariable
            Kiste aKiste = new Kiste();

            //eindeutige Identifikation gespeichert
            aKiste.ID = KistenNummer;

            if (aKiste.ID < 75 && 0 < aKiste.ID)
            {
                Console.WriteLine("Der neuen Kiste anlegen");
                Console.Write("Geben Sie die Höhe der {0}. Kiste ein: ", aKiste.ID);
                aKiste.Hoehe = Convert.ToInt32(Console.ReadLine());
                Console.Write("Geben Sie die Breite der {0}. Kiste ein: ", aKiste.ID);
                aKiste.Breite = Convert.ToInt32(Console.ReadLine());
                Console.Write("Geben Sie die Länge der {0}. Kiste ein: ", aKiste.ID);
                aKiste.Laenge = Convert.ToInt32(Console.ReadLine());

                //leere Zeile ausgeben
                Console.WriteLine();
                //Automatisch Berechnen des Volumens
                aKiste.Volumen = aKiste.Breite * aKiste.Laenge * aKiste.Hoehe;
                Console.WriteLine("Das Volumen von Kiste {0} ist: {1}", aKiste.ID, aKiste.Volumen);
            }
            else
                Console.WriteLine("Gibt es keinen freien Kisten mehr.");

            //leere Zeile ausgeben
            Console.WriteLine();

            return aKiste;
        }

        static Kiste Löschen(int KistenNummer)
        {
            Kiste aKiste = new Kiste();
            aKiste.ID = KistenNummer + 1;
            //leere Zeile ausgeben
            Console.WriteLine();
            //Der Kiste wird den Wert auf 0 setzen
            aKiste.Hoehe = 0;
            aKiste.Breite = 0;
            aKiste.Laenge = 0;
            aKiste.Volumen = aKiste.Hoehe * aKiste.Breite * aKiste.Laenge;
            Console.WriteLine("Der {0}. Kiste wird gelöscht.", aKiste.ID);
            //leere Zeile ausgeben
            Console.WriteLine();

            return aKiste;
        }

        static Kiste Ändern(int KistenNummer)
        {
            Kiste aKiste = new Kiste();
            aKiste.ID = KistenNummer + 1;

            //leere Zeile ausgeben
            Console.WriteLine();
            Console.WriteLine("Der Kiste ändern");
            Console.Write("Geben Sie die Höhe der {0}. Kiste ein: ", aKiste.ID);
            aKiste.Hoehe = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie die Breite der {0}. Kiste ein: ", aKiste.ID);
            aKiste.Breite = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie die Länge der {0}. Kiste ein: ", aKiste.ID);
            aKiste.Laenge = Convert.ToInt32(Console.ReadLine());
            //leere Zeile ausgeben
            Console.WriteLine();
            aKiste.Volumen = aKiste.Breite * aKiste.Laenge * aKiste.Hoehe;
            Console.WriteLine("Das Volumen von Kiste {0} ist: {1}", aKiste.ID, aKiste.Volumen);

            return aKiste;
        }

        static int Anzeigen(Kiste aKiste)
        {
            int ID = aKiste.ID;
            int Volumen = aKiste.Volumen;
            if (aKiste.ID != 0 && 75 > aKiste.ID)
            {
                Console.WriteLine("Das Volumen von Kiste {0} ist: {1}", ID, Volumen);
                //leere Zeile ausgeben
                Console.WriteLine();
            }
            else
                Console.WriteLine("Gibt es keinen Kiste.");
                //leere Zeile ausgeben
                Console.WriteLine();

            return ID;
        }

        static int Auflisten(Kiste aKiste)
        {
            int ID = aKiste.ID;
            int Volumen = aKiste.Volumen;
            //Alle Auflisten ausgeben
            if( ID != 0 && ID < 75)
                Console.WriteLine("Das Volumen von Kiste {0} ist: {1}", ID, Volumen);

            return ID;
        }

        static void Main(string[] args)
        {
            Console.Title = "Lagerverwaltung";
            int waehlen = 0;
            int nummer;
            const int maxNummer = 75;
            bool aktiv = true;
            //ein lokales Array kleineKiste für die Struktur Kiste
            Kiste[] kleineKiste = new Kiste[maxNummer];
            //Titel anzeigen
            Console.WriteLine("Die Daten für der Kisten in der Lagerverwaltung speichern");
            //leere Zeile ausgeben
            Console.WriteLine();
            do
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("1: Der neuen Kiste anlegen");
                Console.WriteLine("2: Der Kiste ändern");
                Console.WriteLine("3: Der Kiste löschen");
                Console.WriteLine("4: Der Kiste anzeigen");
                Console.WriteLine("5: Der Kiste auflisten");
                Console.WriteLine("0: Abbrechen");
                Console.WriteLine();
                Console.Write("Sie geben bitte welchen Nummer für dem Programm ein: ");
                waehlen = Convert.ToInt32(Console.ReadLine());
                //leere Zeile ausgeben
                Console.WriteLine();
                //Auswahlmenü für Eingeben, Löschen, Ändern, Anzeigen, Auflisten und Beenden
                switch (waehlen)
                {
                    case 1:
                        //Bis 75 fleissige eingeben
                        //for (int index = 0; index < kleineKiste.Length; index++)
                        //Neue Anlegen bis 3 Zeilen eingeben
                        for (int index = 0; index < 3; index++)
                        {
                            kleineKiste[index] = Einlesen(index + 1);
                            //break;
                        }
                        break;
                    case 2:
                        //Daten ändern
                        Console.Write("Welche Kisten möchten Sie ändern, dann geben Sie welchen Nummer eingeben [1 - 75]: ");
                        nummer = Convert.ToInt32(Console.ReadLine()) - 1;
                        //leere Zeile ausgeben
                        Console.WriteLine();
                        if (nummer < 75 && nummer > -1)
                        {
                            kleineKiste[nummer] = Ändern(nummer);
                        }
                        //Der Nummer existiert nicht
                        else
                        {
                            Console.WriteLine("Gibt es keinen Kiste.");
                        }
                        //leere Zeile ausgeben
                        Console.WriteLine();
                        break;
                    case 3:
                        //Daten löschen
                        Console.Write("Welche Kisten möchten Sie löschen, dann geben Sie welchen Nummer eingeben [1 - 75]: ");
                        nummer = Convert.ToInt32(Console.ReadLine()) - 1;
                        //leere Zeile ausgeben
                        Console.WriteLine();
                        if (nummer < 75 && nummer > -1)
                        {
                            kleineKiste[nummer] = Löschen(nummer);
                        }
                        //Der Nummer existiert nicht
                        else
                        {
                            Console.WriteLine("Der Kiste ist bereits gelöscht.");
                            //leere Zeile ausgeben
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        //Anzeigen welchen Nummer ausgeben                        
                        Console.Write("Welche Kisten möchten Sie anzeigen, dann geben Sie welchen Nummer eingeben [1 - 75]: ");
                        nummer = Convert.ToInt32(Console.ReadLine()) - 1;
                        //leere Zeile ausgeben
                        Console.WriteLine();
                        if (nummer < 75 && nummer > -1)
                        {
                            Console.WriteLine("Hier wird welchen Anzeigen ausgeben");
                            Console.WriteLine("------------------------------------");
                            //leere Zeile ausgeben
                            Console.WriteLine();
                            Anzeigen(kleineKiste[nummer]);
                        }
                        //Der Nummer existiert nicht
                        else
                        {
                            Console.WriteLine("Gibt es keinen Kiste.");
                            //leere Zeile ausgeben
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        //Auflisten mit Foreach ausgeben
                        Console.WriteLine("Hier wird welchen Auflisten ausgeben");
                        Console.WriteLine("------------------------------------");
                        //leere Zeile ausgeben
                        Console.WriteLine();
                        foreach (Kiste element in kleineKiste)
                        {
                            Auflisten(element);
                        }
                        //leere Zeile
                        Console.WriteLine();
                        break;
                    default:
                        //Programm beenden
                        Environment.Exit(0);
                        aktiv = false;
                        break;
                }
            } while (aktiv == true); //Auswahlmenü wiederholen       
        }
    }
}
