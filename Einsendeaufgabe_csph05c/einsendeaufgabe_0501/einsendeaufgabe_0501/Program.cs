/* ######################################################
Einsendeaufgabe 5.1
###################################################### */

using System;

namespace einsendeaufgabe_0501
{
    class Program
    {
        static void Main(string[] args)
        {
            Fernsehensklasse fernseher = new Fernsehensklasse
            {
                //Lautstärke Leise oder Laut einstellen
                Lautstaerke = 0,
                //Fernseher eingeschaltet oder ausgeschaltet einstellen
                Schalten = true,
                //Programm Auswahl
                Programm = "",
        };
            int LautstaekeStufe;
            int ProgrammNummer;
            int auswahl;
            bool aktiv = true;
            //Erste Infomation über die Fernbedienung zur Steuerung
            Console.WriteLine(" _______________________________________ ");
            Console.WriteLine("#\t\t\t\t\t#");
            Console.WriteLine("# Die Fernbedienung zur Steuerung\t#");
            Console.WriteLine("#\t\t\t\t\t#");
            Console.WriteLine(" _______________________________________ ");
            Console.WriteLine("#\t\t\t\t\t#");
            Console.WriteLine("# 1. Fernseher ein- und ausschalten\t#");
            Console.WriteLine("# 2. Lautstärke zur Steuerung\t\t#");
            Console.WriteLine("# 3. TV-Programm zur Auswahl\t\t#");
            Console.WriteLine("# 0. Beenden\t\t\t\t#");
            Console.WriteLine("#_______________________________________#");
            //leere Zeile ausgeben
            Console.WriteLine();
            Console.WriteLine("#########################################################");
            Console.WriteLine("# Bemerkung: Zuerst schalten Sie dem Fernseher ein.\t#");
            Console.WriteLine("# Dann wird Lautstärke und Programm einstellen können.\t#");
            Console.WriteLine("#########################################################");
            //leere Zeile ausgeben
            Console.WriteLine();

            while (aktiv == true)
            {
                Console.Write("Sie geben bitte welchen Auswahl (0-3) ein: ");
                auswahl = Convert.ToInt32(Console.ReadLine());
                //leere Zeile ausgeben
                Console.WriteLine();

                switch (auswahl)
                {
                    case 1:
                        fernseher.EinAusschalten(fernseher.Schalten);
                        fernseher.FernseherAusgeben();
                        //leere Zeile ausgeben
                        Console.WriteLine();
                        break;
                    case 2:
                        //Verzweigung dem Fernseher eingeschaltet, denn wird das Lautstärke einstellen können
                        if (fernseher.Schalten != true)
                        {
                            Console.Write("Wie erwünschen Sie Laut (+ Zahl \"+50\") oder Leise (- Zahl \"-50\") Lautstärke einstellen: ");
                            LautstaekeStufe = Convert.ToInt32(Console.ReadLine());
                            fernseher.LautstaerkeStufe(LautstaekeStufe);
                            //leere Zeile ausgeben
                            Console.WriteLine();
                            fernseher.LautstaerkeStufeAusgeben();
                        }
                        else
                            Console.WriteLine("Das Fernseher ist noch ausgeschaltet");
                        //leere Zeile ausgeben
                        Console.WriteLine();
                        break;
                    case 3:
                        //Verzweigung dem Fernseher eingeschaltet, denn wird das Programm auswählen können
                        if (fernseher.Schalten != true)
                        {
                            //Programm mit Nummer auflisten
                            Console.WriteLine(" _______________________________________ ");
                            Console.WriteLine("#\t\t\t\t\t#");
                            Console.WriteLine("# 1.\tARD\t\t\t\t#");
                            Console.WriteLine("# 2.\tZDF\t\t\t\t#");
                            Console.WriteLine("# 3.\tRTL II\t\t\t\t#");
                            Console.WriteLine("# 4.\tRTL\t\t\t\t#");
                            Console.WriteLine("# 5.\tProSieben\t\t\t#");
                            Console.WriteLine("# 6.\tArte\t\t\t\t#");
                            Console.WriteLine("# 7.\tPhonix\t\t\t\t#");
                            Console.WriteLine("# 8.\tBR\t\t\t\t#");
                            Console.WriteLine("# 9.\tEuroSport\t\t\t#");
                            Console.WriteLine("# 10.\tSkySport\t\t\t#");
                            Console.WriteLine("#_______________________________________#");
                            //leere Zeile ausgeben
                            Console.WriteLine();
                            Console.Write("Wie erwünschen Sie das Programm auswahlen: ");
                            ProgrammNummer = Convert.ToInt32(Console.ReadLine());
                            fernseher.Auswahlen(ProgrammNummer);
                            //leere Zeile ausgeben
                            Console.WriteLine();
                            fernseher.ProgrammAusgeben();
                        }
                        else
                            Console.WriteLine("Das Fernseher ist noch ausgeschaltet");
                        //leere Zeile ausgeben
                        Console.WriteLine();
                        break;
                    default:
                        //Das Fernseher wird beenden
                        Environment.Exit(0);
                        aktiv = false;
                        break;
                }
            }
            
        }
    }
    //Klasse Fernsehensklasse
    class Fernsehensklasse
    {
        //ein Feld
        private int lautstaerke;
        private string volumen;
        private string programm;
        private bool schalten;
        
        //die Eigenschaften
        public int Lautstaerke { get => lautstaerke; set => lautstaerke = value; }
        public string Volumen { get => volumen; set => volumen = value; }
        public string Programm { get => programm; set => programm = value; }
        public bool Schalten { get => schalten; set => schalten = value; }
     
        //Lautstärke zur Steuerung
        public void LautstaerkeStufe(int aenderung)
        {
            lautstaerke = lautstaerke + aenderung;
            volumen = "";
            //Lautstäre einstellt Min. 1 Volumen bis Max. 100 Volumen
            if (lautstaerke >= 0 && 100 >= lautstaerke)
            {
                for (int index = 0; index < lautstaerke; index++)
                    volumen += "|";
            }
            else
            {
                if (lautstaerke > 100)
                {
                    lautstaerke = 100;
                    for (int index = 0; index < lautstaerke; index++)
                        volumen += "|";
                }                    
                else if (lautstaerke < 0)
                {
                    lautstaerke = 0;
                }
                    

            }   
        }

        //zum Programm auswahlen
        public void Auswahlen(int aenderung)
        {
            switch (aenderung)
            {
                case 1:
                    programm = "ARD";
                    break;
                case 2:
                    programm = "ZDF";
                    break;
                case 3:
                    programm = "RTL II";
                    break;
                case 4:
                    programm = "RTL";
                    break;
                case 5:
                    programm = "ProSieben";
                    break;
                case 6:
                    programm = "Arte";
                    break;
                case 7:
                    programm = "Phonix";
                    break;
                case 8:
                    programm = "BR";
                    break;
                case 9:
                    programm = "EuroSport";
                    break;
                case 10:
                    programm = "SkySport";
                    break;
                default:
                    //Kein Programm
                    programm = "";
                    break;
            }
        }

        //zum Fernseher schalten
        public void EinAusschalten(bool PowerOnOffofTV)
        {
            //Fernseher eingeschaltet werden
            if (PowerOnOffofTV == true)
            {
                schalten = false;
            }
                
            //Fernseher ausgeschaltet werden
            else if (PowerOnOffofTV == false)
            {
                schalten = true;
            }
                
        }

        public void FernseherAusgeben()
        {
            //Welche ausgeschaltete oder eingeschaltete Fernseher ausgeben
            if (schalten == false)
            {
                Console.WriteLine("Das Fernseher wird eingeschaltet");
            }
            else
            {
                Console.WriteLine("Das Fernseher wird ausgeschaltet.");
                lautstaerke = 0;
                programm = "";
            }
        }

        public void LautstaerkeStufeAusgeben()
        {
            //Welche Lautstärke Laut(+) oder Leise(-) ausgeben
            Console.Write(volumen);
            if (lautstaerke > 0)
                Console.WriteLine(" Lautstärke: {0}", lautstaerke);
            else
                Console.WriteLine("Lautlos");
        }

        public void ProgrammAusgeben()
        {
            if(programm == String.Empty)
                //Kein Programm dabei
                Console.WriteLine("Das Programm existieret nicht.");
            else
                //Welche Programm ausgeben
                Console.WriteLine("Sie haben {0} ausgewählt", programm);
        }
    }
}
