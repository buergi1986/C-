using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Threading;

namespace Memory
{
    class MemoryFeld
    {
        //das Array für die Karten
        MemoryKarte[] karten;

        //das Array für die Namen der Grafiken
        string[] bilder = { "grafiken/apfel.bmp", "grafiken/birne.bmp",
        "grafiken/blume.bmp", "grafiken/blume2.bmp",
        "grafiken/ente.bmp","grafiken/fisch.bmp",
        "grafiken/fuchs.bmp","grafiken/igel.bmp",
        "grafiken/kaenguruh.bmp","grafiken/katze.bmp",
        "grafiken/kuh.bmp","grafiken/maus1.bmp",
        "grafiken/maus2.bmp","grafiken/maus3.bmp",
        "grafiken/maus4.bmp","grafiken/melone.bmp",
        "grafiken/pilz.bmp","grafiken/ronny.bmp",
        "grafiken/schmetterling.bmp","grafiken/sonne.bmp",
        "grafiken/wolke.bmp" };

        //für die Punkte
        int menschPunkte, computerPunkte;
        Label menschPunkteLabel, computerPunkteLabel;

        //wie viele Karten sind aktuell umgedreht?
        int umgedrehteKarten;

        //für das aktuellen umdrehte Paar
        MemoryKarte[] paar;

        //für den aktuellen Spieler
        int spieler;

        //das "Gedächtnis" für den Computer
        //er speichert hier, wo das Gegenstück liegt
        int[,] gemerkteKarten;

        //für das eigentliche Spielfeld
        UniformGrid feld;

        //für den Timer
        DispatcherTimer timer;
        DispatcherTimer timer2;

        //für die Spielstärke
        int spielstaerke;

        Button schummel = new Button();

        bool schummelErlaubt = false;

        //der Konstruktor
        public MemoryFeld(UniformGrid feld)
        {
            //zum Zählen für die Bilder
            int count = 0;
            
            //das Array für die Karten erstellen, insgesamt 42 Stück
            karten = new MemoryKarte[42];

            //für das Paar
            paar = new MemoryKarte[2];

            Random zufallszahl = new Random();

            //für das Gedächtnis es speichert für jede Karte paarweise die Position im Spielfeld
            gemerkteKarten = new int[2, 21];

            //keiner hat zu Beginn einen Punkt
            menschPunkte = 0;
            computerPunkte = 0;

            //es ist keine Karte umgedreht
            umgedrehteKarten = 0;

            //der Mensch fängt an
            spieler = 0;

            //die Spielstärke setzen
            spielstaerke = 50;

            //das Spielfeld setzen
            this.feld = feld;

            //es gibt keine gemerkten Karten
            for (int aussen = 0; aussen < 2; aussen++)
                for (int innen = 0; innen < 21; innen++)
                    gemerkteKarten[aussen, innen] = -1;

            //das eigentliche Spielfeld erstellen
            for (int i = 0; i <= 41; i++)
            {
                //eine neue Karte erzeugen
                karten[i] = new MemoryKarte(bilder[count], count, this);
                //bei jeder zweiten Karte kommt auch ein neues Bild
                if ((i + 1) % 2 == 0)
                    count++;
            }

            for (int i = 0; i <= 41; i++)
            {
                int temp1;
                MemoryKarte temp2;
                //eine zufällige Zahl im Bereich 0 bis 41 erzeugen
                temp1 = zufallszahl.Next(42);
                //den alten Wert in Sicherheit bringen
                temp2 = karten[temp1];
                //die Werte tauschen
                karten[temp1] = karten[i];
                karten[i] = temp2;
            }

            //die Karten ins Spielfeld bringen
            for (int i = 0; i <= 41; i++)
            {
                //die Position der Karte setzen
                karten[i].SetBildPos(i);
                //die Karte hinzufügen
                feld.Children.Add(karten[i]);
            }

            //die Labels für die Punkte
            Label mensch = new Label();
            mensch.Content = "Mensch";
            feld.Children.Add(mensch);
            menschPunkteLabel = new Label();
            menschPunkteLabel.Content = 0;
            feld.Children.Add(menschPunkteLabel);

            Label computer = new Label();
            computer.Content = "Computer";
            feld.Children.Add(computer);
            computerPunkteLabel = new Label();
            computerPunkteLabel.Content = 0;
            feld.Children.Add(computerPunkteLabel);

            //die Schaltfläche der Schummel
            schummel.Content = "Schummel";
            feld.Children.Add(schummel);
            schummel.Click += Schummel_Click;
            
            //den Timer erzeugen
            //er wird alle zwei Sekunden ausgelöst
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(2000);
            timer.Tick += new EventHandler(Timer_Tick);

            //den Timer von den Schummel erzeugen
            //er wird alle 5 Sekunden aufgelöst
            timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromSeconds(5);
            timer2.Tick += new EventHandler(Timer2_Tick);
        }

        //die Schaltfläche aktivieren, alle Karten umgedreht
        private void Schummel_Click(object sender, RoutedEventArgs e)
        {
            if ((spieler == 0) && ZugErlaubt() == true && umgedrehteKarten == 0)
            {
                for (int i = 0; i < 42; i++)
                {
                    karten[i].VorderseiteZeigen();
                }
                //Schummel erlaubt, dass noch alle Karten wieder zurück umgedreht wird
                schummelErlaubt = true;
                //die Zeit vom 2 Sekunden starten
                timer2.Start();
            }
            else
                return;
        }

        //die Methode für den Timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            //den Timer anhalten 
            timer.Stop();
            //die Karten zurückdrehen
            KarteSchliessen();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();

            //Schummel erlaubt, durchführen
            if (schummelErlaubt)
            {
                //alle Karten wieder zurück umgedreht
                for (int i = 0; i < 42; i++)
                {
                    karten[i].RueckseiteZeigen(false);
                }
                //Schummel erlaubt nicht mehr
                schummelErlaubt = false;
            }
        }

        public void KarteOeffnen(MemoryKarte karte)
        {
            //zum Zwischenspeichern der ID und der Position
            int kartenID = 0, kartenPos = 0;
                        
            try
            {
                //die Karten zwischenspeichern
                paar[umgedrehteKarten] = karte;
                //die ID und die Position beschaffen
                kartenID = karte.GetBildID();
                kartenPos = karte.GetBildPos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            
                //die Karte in das Gedächtnis des Computers eintragen,
                //aber nur dann, wenn es noch keinen Eintrag an der entsprechenden Stelle gibt
                if (gemerkteKarten[0, kartenID] == -1)
                    gemerkteKarten[0, kartenID] = kartenPos;
                else
                {
                    //wenn es schon einen Eintrag gibt und der nicht mit der aktuellen Position übereinstimmt,
                    //dann haben wir die zweite Karte gefunden
                    //Sie wird in die zweite Dimension eingetragen
                    if (gemerkteKarten[0, kartenID] != kartenPos)
                    {
                        gemerkteKarten[1, kartenID] = kartenPos;
                    }               
                }
                //umgedrehte Karten erhöhen
                umgedrehteKarten++;
            }
            //sind zwei Karten umgedreht worden?
            if (umgedrehteKarten == 2)
            {
                //dann prüfen wir, ob es ein Paar ist
                PaarPruefen(kartenID);
                //den Timer zum Umdrehen der Karten starten
                timer.Start();
            }
            //haben wir zusammen 21 Paare, dann ist das Spiel vorbei
            if (computerPunkte + menschPunkte == 21)
            {
                int paar;
                string name = string.Empty;

                if (computerPunkte > menschPunkte)
                {
                    paar = computerPunkte;
                    name = "Computer";
                }
                else
                {
                    paar = menschPunkte;
                    name = "Mensch";
                }
                //den Timer anhalten
                timer.Stop();
                MessageBox.Show("Das Spiel ist vorbei.\n" +
                    name + " ist Gewinner und Paare:\t" + paar);
                Application.Current.Shutdown();
            }
        }

        //die Methode prüft, ob ein Paar gefunden wurde
        private void PaarPruefen(int kartenID)
        {
            if (paar[0].GetBildID() == paar[1].GetBildID())
            {
                //die Punkte setzen
                PaarGefunden();
                //die Karten aus dem Gedächtnis löschen
                gemerkteKarten[0, kartenID] = -2;
                gemerkteKarten[1, kartenID] = -2;
            }
        }

        //die Methode setzt die PUnkte, wenn ein Paar gefunden wurde
        private void PaarGefunden()
        {
            //spielt gerade der Mensch?
            if (spieler == 0)
            {
                menschPunkte++;
                menschPunkteLabel.Content = menschPunkte.ToString();
            }
            else
            {
                computerPunkte++;
                computerPunkteLabel.Content = computerPunkte.ToString();
            }

            if (schummelErlaubt == false)
            {
                //die Schaltfläche deaktivieren
                schummel.IsEnabled = false;
            }
        }

        //die Methode dreht die Karten wieder auf die Rückseite
        //beziehungsweise nimmt sie aus dem Spiel
        private void KarteSchliessen()
        {
            bool raus = false;
            //ist es ein Paar?
            if (paar[0].GetBildID() == paar[1].GetBildID())            
                raus = true;
            //wenn es ein Paar war, nehmen wir die Karten aus
            //dem Spiel, sonst drehen wir sie nur wieder um
            paar[0].RueckseiteZeigen(raus);
            paar[1].RueckseiteZeigen(raus);
            //es ist keine Karte mehr geöffnet
            umgedrehteKarten = 0;
            //hat der Spieler kein Paar gefunden?
            if (raus == false)
            {
                //dass wird der Spieler gewchselt
                SpielerWechseln();
            }
            else
            {
                //hat der computer ein Paar gefunden?
                //dann ist er noch einmal an der Reihe
                if (spieler == 1)
                {
                    ComputerZug();
                }
            }
        }

        private void SpielerWechseln()
        {
            //wenn der Mensch an der Reihe war, kommt jetzt der Computer
            if (spieler == 0)
            {
                spieler = 1;
                ComputerZug();
            }
            else
                spieler = 0;
        }

        //die Methode setzt die Computerzüge um
        //Sie ist erst einmal leer, damit der Compiler nicht mault
        private void ComputerZug()
        {
            int kartenZaehler = 0;
            int zufall = 0;
            bool treffer = false;
            Random zufallszahl = new Random();

            //zur Steuerung über die Spielstärke
            if (zufallszahl.Next(spielstaerke) == 0)
            {
                //erst einmal nach einem Paar suchen
                //dazu durchsuchen wir das Array gemerkteKarten, bis wir
                //in beiden Dimensionen einen Wert für eine Karte finden
                while ((kartenZaehler < 21) && (treffer == false))
                {
                    //gibt es in beiden Dimensionen einen Wert größer oder gleich 0?
                    if ((gemerkteKarten[0, kartenZaehler] >= 0) && (gemerkteKarten[1, kartenZaehler] >= 0))
                    {
                        //dann haben wir ein Paar
                        treffer = true;
                        //der simulierte Klick wird nicht mehr ausgeführt
                        //karten[gemerkteKarten[0, kartenZaehler]].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                        //die Vorderseite zeigen
                        karten[gemerkteKarten[0, kartenZaehler]].VorderseiteZeigen();
                        //und die Karte öffnen
                        KarteOeffnen(karten[gemerkteKarten[0, kartenZaehler]]);
                        //die zweite Karte auch
                        //karten[gemerkteKarten[1, kartenZaehler]].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                        //die Vorderseite zeigen
                        karten[gemerkteKarten[1, kartenZaehler]].VorderseiteZeigen();
                        //und die Karte öffnen
                        KarteOeffnen(karten[gemerkteKarten[1, kartenZaehler]]);
                    }
                    kartenZaehler++;
                }
            }
            //wenn wir kein Paar gefunden haben, drehen wir zufällig zwei Karten um
            if (treffer == false)
            {
                //solange eine Zufallszahl suchen, bis eine Karte
                //gefunden wird, die noch im Spiel ist
                do
                {
                    zufall = zufallszahl.Next(42);
                } while (karten[zufall].IsNochImSpiel() == false);
                //die erste Karte umdrehen
                karten[zufall].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
                //die Vorderseite zeigen
                karten[zufall].VorderseiteZeigen();
                //und die Karte öffnen
                KarteOeffnen(karten[zufall]);
                //für die zweite Karte müssen wir außerdem prüfen, ob
                //sie nicht gerade angezeigt wird
                do
                {
                    zufall = zufallszahl.Next(42);
                } while ((karten[zufall].IsNochImSpiel() == false) || (karten[zufall].IsUmgedreht() == true));
                //und die zweite Karte umdrehen
                //karten[zufall].RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent)); ;
                karten[zufall].VorderseiteZeigen();
                //und die Karte öffnen
                KarteOeffnen(karten[zufall]);
            }
        }

        //die Methode liefert, ob Züge des Menschen erlaubt sind
        //die Rückgabe ist false, wenn gerade der Computer zieht 
        //oder wenn schon zwei Karten umgedreht sind
        //sonst ist die Rückgabe true
        public bool ZugErlaubt()
        {
            bool erlaubt = true;
            //zieht der Computer?
            if (spieler == 1)
                erlaubt = false;
            //sind schon zwei Karten umdreht?
            if (umgedrehteKarten == 2)
                erlaubt = false;
            return erlaubt;
        }
    }
}
