using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace snake_csph18c
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region
        //eine Liste mit Schlangenteilen
        List<Schlangenteil> schlange;
        //für den Apfel
        Apfel meinApfel;
        //für die Bestenliste
        Score spielpunkte;
        //die Felder
        //für die Punkte
        int punkte;
        //Speichern für die Punkte
        int punkteSpeichern;
        //für mehr die Punkte
        int punkteMehr;
        //für die Zeit
        int zeit;
        //Speichern für die Zeit
        int zeitSpeichern;
        //für die Richtung der Schlange
        int richtung;
        //für die Breite der Spielfeldbegrenzung
        int balkenBreite;
        int breiteAendern;
        int hoeheAendern;
        int punkteAendern;
        //für die Geschwindigkeit
        double geschwindigkeit;       
        int neuesSchlange;

        //für die alte Timer speichern
        int timerSpeichern;
        //für Spiel unterbrochen
        bool spielUnterbrochen;
        //ist ein Spiel gestartet?
        bool spielGestartet;
        //Tempo erhöhen?
        bool tempo;
        //Schalten aktivieren?
        bool ergebnis = false;
        //Geschwindigkeit für den Schlange
        private DispatcherTimer timerSchlange;
        //für die Spielzeit
        private DispatcherTimer timerSpielzeit;
        //für die Schritttempo mit Zeit abnehmen
        private DispatcherTimer timerSchritttempo;
        //für das Fortschrittbalken
        DoubleAnimation doubleAnimation;
        Duration duration;
        //für das eigene Command
        static RoutedCommand pause = new RoutedCommand();
        static RoutedCommand neuesStart = new RoutedCommand();
        bool neuenWert = true;
        bool level = false;

        //die Eigenschaft für den Zugriff
        public static RoutedCommand Pause
        {
            get
            {
                return pause;
            }
        }

        public static RoutedCommand NeuesStart
        {
            get
            {
                return neuesStart;
            }
        }

        public int NeuesSchlange { get => neuesSchlange; set => neuesSchlange = value; }
        public bool NeuenWert { get => neuenWert; set => neuenWert = value; }
        public int ZeitAbnehmen { get; set; }
        #endregion
        #region
        void Start()
        {            
            richtung = 0;
            balkenBreite = 25;     
            tempo = true;
            //den Wert behalten oder löschen
            if (punkteSpeichern != 0 && !NeuenWert)
            {
                timerSpeichern = ZeitAbnehmen;
                punkte = punkteSpeichern;
                zeit = zeitSpeichern;
                punkteAnzeige.Content = punkteSpeichern;
                zeitAnzeige.Content = zeitSpeichern;
            }
            else
            {
                spielpunkte.LoeschePunkte();
                punkte = 0;
                zeit = 0;
                ZeitAbnehmen = 0;
                geschwindigkeit = 1000;
                zeitAnzeige.Content = zeit;
                punkteAnzeige.Content = punkte;
                tempoOnOff.Content = "AUS";
                tempoOnOff.Opacity = 0;
            }
            //für die Timer ausblenden
            timerAnzeige.Opacity = 0;
            timerStatus.Opacity = 0;            
            //es läuft ein Spiel
            timerSchlange.Interval = TimeSpan.FromMilliseconds(geschwindigkeit);
            spielGestartet = true;
            schlange = new List<Schlangenteil>();
            schlange.Clear();
            //den Schlangenkopf erzeugen und positionieren
            Schlangenkopf meineSchlangekopf = new Schlangenkopf(new Point(spielfeld.ActualWidth / 2, spielfeld.ActualHeight / 2), Colors.Red);
            //in die Liste setzen
            schlange.Add(meineSchlangekopf);
            spielfeld.Children.Clear();
            ZeichneSpielfeld();      
            //und einen neuen erzeugen
            meinApfel = new Apfel(Colors.Green, 20);
            meinApfel.Anzeigen(spielfeld, balkenBreite);
        }

        //für den Level durch ändern Rahmen und Apfel positionieren
        void levelAendern()
        {
            timerSpeichern = ZeitAbnehmen;
            spielfeld.Children.Clear();
            ZeichneSpielfeld();
            //und einen neuen erzeugen
            meinApfel = new Apfel(Colors.Green, 20);
            meinApfel.Anzeigen(spielfeld, balkenBreite);
        }

        void Timer_Bewegen()
        {
            //die Instanz erzeugen
            timerSchlange = new DispatcherTimer();
            //das Intervall setzen
            timerSchlange.Interval = TimeSpan.FromMilliseconds(geschwindigkeit);
            //die Methode für das Ereignis zuweisen
            timerSchlange.Tick += new EventHandler(Timer_SchlangeBewegen);
            //den Timer starten
            timerSchlange.Start();
        }

        void Timer_Spielzeit()
        {
            timerSpielzeit = new DispatcherTimer();
            timerSpielzeit.Interval = TimeSpan.FromMilliseconds(1000);
            timerSpielzeit.Tick += new EventHandler(Timer_Spielzeit);
            timerSpielzeit.Start();
        }
        //für den Schlangensbewegung verlangsam
        void Timer_Schritttempo()
        {
            timerSchritttempo = new DispatcherTimer();
            timerSchritttempo.Interval = TimeSpan.FromSeconds(1);
            timerSchritttempo.Tick += new EventHandler(Timer_Schritttempo);
        }

        void ZeichneRechteck(Point position, double laenge, double breite)
        {
            //einen neuen Balken erzeugen
            Rectangle balken = new Rectangle();
            balken.Name = "Grenze";
            Canvas.SetLeft(balken, position.X);
            Canvas.SetTop(balken, position.Y);
            balken.Width = laenge;
            balken.Height = breite;
            SolidColorBrush colorBrush = new SolidColorBrush(Colors.Red);
            balken.Fill = colorBrush;
            //und hinzufügen
            spielfeld.Children.Add(balken);
        }

        void ZeichneSpielfeld()
        {
            //der Balken oben
            ZeichneRechteck(new Point(0, 0), spielfeld.ActualWidth, balkenBreite);
            //der Balken rechts
            ZeichneRechteck(new Point(spielfeld.ActualWidth - balkenBreite, 0), balkenBreite, spielfeld.ActualHeight);
            //der Balken unten
            ZeichneRechteck(new Point(0, spielfeld.ActualHeight - balkenBreite), spielfeld.ActualWidth, balkenBreite);
            //der Balken links
            ZeichneRechteck(new Point(0, 0), balkenBreite, spielfeld.ActualHeight - balkenBreite);

            //Auflösung mit Häkchen setzen
            if (this.Width == 1000)
                schwierigkeitEinfach.IsChecked = true;
            if (this.Width == 800)
                schwierigkeitMittel.IsChecked = true;
            if (this.Width == 400)
                schwierigkeitSchwer.IsChecked = true;
        }

        void KollisionPruefen()
        {
            //die Trefferabfrage
            HitTestResult treffer = VisualTreeHelper.HitTest(spielfeld, schlange[0].LieferePosition());
            if (treffer != null)
            {
                //den Namen beschaffen
                string name = ((Shape)(treffer.VisualHit)).Name;
                //was haben wir getroffen?
                //war es der Rand oder die Schlange?
                if (name == "Grenze" || name == "Schlange")
                    //dann halten wir erst einmal einfach den Timer an
                    SpielEnde();
                //war es ein Apfel oder das Rechteck eines Apfels?
                if (name == "Apfel" || name == "Kollision")
                {
                    //die Punkte erhöhen und neu anzeigen
                    punkte = spielpunkte.VeraenderePunkte(punkteMehr);
                    punkteAnzeige.Content = punkte;
                    //die Punkte erhöhen und neu anzeigen
                    if (punkte % 50 == 0 && geschwindigkeit > 100)
                    {
                        geschwindigkeit = geschwindigkeit - 100;
                        timerSchlange.Interval = TimeSpan.FromMilliseconds(geschwindigkeit);
                        tempo = true;
                    }
                    //für die Timer erhöhen, um dem Schlangensbewegung verlangsamt
                    if (punkte % 100 == 0 && ZeitAbnehmen < 10)
                    {
                        ZeitAbnehmen = ZeitAbnehmen + 1;
                        if (punkte == 100)
                        {
                            tempoOnOff.Opacity = 100;
                        }
                    }
                    //für die Rahmen verkleinern, jeweils 100 Punkte erreichen
                    if (punkte % 100 == 0 && this.Height >= 400 && level == true)
                    {
                        breiteAendern = breiteAendern - 25;
                        hoeheAendern = hoeheAendern - 25;
                        SetzeEinstellungenAendern(breiteAendern, hoeheAendern, punkteAendern);
                        //für das Status verkleinern, mit dem kleinen Rahmen positionieren
                        if (this.Height == 400)
                        {
                            timerAnzeige.HorizontalAlignment = HorizontalAlignment.Center;
                            timerAnzeige.VerticalAlignment = VerticalAlignment.Top;
                            timerAnzeige.FontSize = 50;
                            timerStatus.Width = 150;
                            timerStatus.Margin = new Thickness(115);
                        }

                    }
                    //ein Teil hinten an die Schlange anhängen
                      Schlangenteil steil = new Schlangenteil(new Point(schlange[schlange.Count - 1].LiefereAltePosition().X,
                        schlange[schlange.Count - 1].LiefereAltePosition().Y + schlange[schlange.Count - 1].LiefereGroesse()),
                        Colors.Black);
                    schlange.Add(steil);
                    neuesSchlange = schlange.Count;
                    //den alten Apfel löschen
                    meinApfel.Entfernen(spielfeld);
                    //und einen neuen erzeugen
                    meinApfel = new Apfel(Colors.Green, 20);
                    meinApfel.Anzeigen(spielfeld, balkenBreite);
                }
            }
        }
        //die Methode unterbricht das Spiel oder setzt es fort
        void SpielPause()
        {
            //erst einmal prüfen wir den Status
            //läuft das Spiel?
            if (spielUnterbrochen == false)
            {
                //alle Timer anhalten
                timerSchlange.Stop();
                timerSpielzeit.Stop();
                if (timerSchritttempo != null)
                {
                    timerSchritttempo.Stop();
                }
                timerStatus.IsIndeterminate = true;
                //die Markierung im Menü einschalten
                spielPause.IsChecked = true;
                //den Text in der Titelleiste ändern
                Title = "Snake - Das Spiel ist angehalten!";
                spielUnterbrochen = true;
            }
            else
            {
                //alle Timer wieder starten
                timerSchlange.Start();
                timerSpielzeit.Start();
                if (timerSchritttempo != null)
                {
                    timerSchritttempo.Start();
                }
                timerStatus.IsIndeterminate = false;
                //die Markierung im Menü abschalten
                spielPause.IsChecked = false;
                //den Text in der Titelleiste ändern
                Title = "Snake";
                spielUnterbrochen = false;
            }
        }
        //erzeugt einen Dialog zu Neustart und liefert das Ergebnis zurück
        bool NeuesSpiel()
        {
            //das Spiel stoppen
            if (spielUnterbrochen == false)
            {
                SpielPause();
            }
            if (ergebnis == false)
            {
                //einen Dialog mit Ja/Nein erzeugen
                MessageBoxResult abfrage = MessageBox.Show("Wollen Sie ein neues Spiel starten?", "Neues Spiel", MessageBoxButton.YesNo, MessageBoxImage.Question);

                //wurde auf Ja geklickt?
                if (abfrage == MessageBoxResult.Yes)
                {
                    NeuenWert = true;
                    //dann rufen wir die Methode Start() auf
                    Start();
                    ergebnis = true;
                    level = false;
                }
            }
            else
            {
                ergebnis = false;
            }
            //das Spiel "fortsetzen"
            if (spielUnterbrochen == true)
            {
                SpielPause();
            }
            return ergebnis;
        }

        //erzeugt einen Dialog zu Neustart und liefert das Ergebnis zurück
        bool wertAendern()
        {
            //das Spiel stoppen
            if (spielUnterbrochen == false)
            {
                SpielPause();
            }
                        
            //einen Dialog mit Ja/Nein erzeugen
            MessageBoxResult abfrage = MessageBox.Show("Wollen Sie den Wert behalten?", "Wert verlieren?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //wurde auf Ja geklickt?
            if (abfrage == MessageBoxResult.Yes)
            {
                //den Wert nicht ändern
                NeuenWert = false;
                //dann rufen wir die Methode Start() ohne Wert verlieren auf
                Start();
            }
            else
            {
                //den Wert sämtlich löschen
                NeuenWert = true;
                //dann rufen wir die Methode Start() auf
                Start();
            }

            //das Spiel "fortsetzen"
            if (spielUnterbrochen == true)
            {
                SpielPause();
            }
            return ergebnis;
        }

        void SpielEnde()
        {
            //das Spiel anhalten
            SpielPause();
            //eine Meldung anzeigen
            MessageBox.Show("Schade.", "Spielende", MessageBoxButton.OK, MessageBoxImage.Information);
            if (spielpunkte.NeuerEintrag(this) == true)
                spielpunkte.ListeAusgeben(this);
            //Anfrage, ob ein neues Spiel gestartet werden soll
            if (NeuesSpiel() == true)
            {
                Start();
                //das Spiel "fortsetzen"
                if (spielUnterbrochen == true)
                {
                    SpielPause();
                }
            }
            else
                //sonst beenden
                Close();
        }

        void SetzeEinstellungen(int breite, int hoehe, int punkteNeu)
        {
            //die Grösse des Fensters setzen
            Width = breite;
            Height = hoehe;
            //die Punkte setzen
            punkteMehr = punkteNeu;
            //Fenster neu positionieren
            Left = (SystemParameters.PrimaryScreenWidth - Width) / 2;
            Top = (SystemParameters.PrimaryScreenHeight - Height) / 2;
            //die Elemente im Spielfeld löschen
            spielfeld.Children.Clear();
            level = false;
            if (punkte != 0)
            {
                punkteSpeichern = punkte;
                zeitSpeichern = zeit;
                //das Spielfeld neu erstellen oder den Wert nicht ändern
                wertAendern();
            }
            else
                //das Spielfeld neu erstellen
                Start();
        }

        void SetzeEinstellungenAendern(int breite, int hoehe, int punkteNeu)
        {
            //die Grösse des Fensters setzen
            Width = breite;
            Height = hoehe;
            //die Punkte setzen
            punkteMehr = punkteNeu;
            //Fenster neu positionieren
            Left = (SystemParameters.PrimaryScreenWidth - Width) / 2;
            Top = (SystemParameters.PrimaryScreenHeight - Height) / 2;
            //die Elemente im Spielfeld löschen
            spielfeld.Children.Clear();
            punkteSpeichern = punkte;
            zeitSpeichern = zeit;
            levelAendern();
            //das Spielfeld neu erstellen oder den Wert nicht ändern
            //wertAendern();
        }
        #endregion
        public MainWindow()
        {
            System.Threading.Thread.Sleep(2000);
            InitializeComponent();
            geschwindigkeit = 1000;
            punkteMehr = 10;
            //das Spiel ist erst einmal angehalten
            spielUnterbrochen = false;
            spielGestartet = true;
            tempo = true;
            spielpunkte = new Score();
            
            //für Schlange bewegen
            Timer_Bewegen();
            //für Spielzeit
            Timer_Spielzeit();
            //Timer_Schritttempo();
        }

        private void spielBeenden_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Start();
            ZeichneSpielfeld();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //je nach Taste die Richtung setzten
            //oben
            if (e.Key == Key.Up)
                richtung = 0;
            //rechts
            if (e.Key == Key.Right)
                richtung = 1;
            //unten
            if (e.Key == Key.Down)
                richtung = 2;
            //links
            if (e.Key == Key.Left)
                richtung = 3;
            //Geschwindigkeit zu Schleichtempo ändern und alte Geschwindigkeit zurücksetzen
            if (e.Key == Key.Space)
            {
                if (spielUnterbrochen == true)
                {
                    return;
                }

                if (tempo && ZeitAbnehmen != 0)
                {
                    timerSpeichern = ZeitAbnehmen;
                    tempo = false;
                    progressbar();
                    timerSchlange.Interval = TimeSpan.FromMilliseconds(2000);
                    timerAnzeige.Opacity = 0.3;
                    timerStatus.Opacity = 0.3;
                    timerAnzeige.Content = ZeitAbnehmen;
                    tempoOnOff.Content = "AN";
                    Timer_Schritttempo();
                    timerSchritttempo.Start();
                }
                else
                {
                    if (!tempo)
                    {
                        timerSchritttempo.Stop();
                        timerAnzeige.Opacity = 0;
                        timerStatus.Opacity = 0;
                        ZeitAbnehmen = timerSpeichern;
                        tempoOnOff.Content = "AUS";
                        tempo = true;
                          if (geschwindigkeit >= 100)
                        {
                            timerSchlange.Interval = TimeSpan.FromMilliseconds(geschwindigkeit);
                        }
                    }
                    return;
                }
            }                       
        }

        void progressbar()
        {
            duration = new Duration(TimeSpan.FromSeconds(ZeitAbnehmen));
            doubleAnimation = new DoubleAnimation(0, 10, duration);
            timerStatus.BeginAnimation(ProgressBar.ValueProperty, doubleAnimation);
        }

        private void Timer_SchlangeBewegen(object sender, EventArgs e)
        {
            //den Kopf in die angegebene Richtung bewegen
            schlange[0].Bewegen(richtung);
            //und zeichnen
            schlange[0].Zeichnen(spielfeld);
            //die Teile in einer Schleife bewegen
            for (int i = 1; i < schlange.Count; i++)
            {
                schlange[i].SetzePosition(schlange[i - 1].LiefereAltePosition());
                schlange[i].Zeichnen(spielfeld);
            }
            KollisionPruefen();
        }

        private void Timer_Spielzeit(object sender, EventArgs e)
        {
            zeit = zeit + 1;
            zeitAnzeige.Content = zeit;
        }

        private void Timer_Schritttempo(object sender, EventArgs e)
        {
            ZeitAbnehmen--;
            if (ZeitAbnehmen == 0)
            {
                timerSchritttempo.Stop();
                timerAnzeige.Opacity = 0;
                timerStatus.Opacity = 0;
                ZeitAbnehmen = timerSpeichern;
                tempoOnOff.Content = "AUS";
                tempo = true;
                if (geschwindigkeit >= 100)
                {
                    timerSchlange.Interval = TimeSpan.FromMilliseconds(geschwindigkeit);
                }
            }
            timerAnzeige.Content = ZeitAbnehmen;
        }

        private void spielNeuesSpiel_Click(object sender, RoutedEventArgs e)
        {
            //läuft gerade ein Spiel?
            //dann halten wir es an
            if (spielUnterbrochen == false)
            {
                SpielPause();
                //den Dialog anzeigen
                NeuesSpiel();
                //und weiter spielen
                SpielPause();
            }
            //wenn kein Spiel läuft, starten wir ein neues, wenn im Dialog auf Ja geklickt wurde
            else
                if(NeuesSpiel() == true)
                {
                    SpielPause();
                }
        }

        private void spielPause_Click(object sender, RoutedEventArgs e)
        {
            Pause_Executed(sender, null);
            ergebnis = true;
        }
                
        private void schwierigkeitEinfach_Click(object sender, RoutedEventArgs e)
        {
            //die Markierung bei den anderen Einträgen abschalten
            schwierigkeitMittel.IsChecked = false;
            schwierigkeitSchwer.IsChecked = false;
            SetzeEinstellungen(1000, 800, 1);
        }

        private void schwierigkeitMittel_Click(object sender, RoutedEventArgs e)
        {
            //die Markierung bei den anderen Einträgen abschalten
            schwierigkeitEinfach.IsChecked = false;
            schwierigkeitSchwer.IsChecked = false;
            SetzeEinstellungen(800, 600, 10);
        }

        private void schwierigkeitSchwer_Click(object sender, RoutedEventArgs e)
        {
            //die Markierung bei den anderen Einträgen abschalten
            schwierigkeitMittel.IsChecked = false;
            schwierigkeitEinfach.IsChecked = false;
            SetzeEinstellungen(400, 300, 25);
            timerAnzeige.HorizontalAlignment = HorizontalAlignment.Center;
            timerAnzeige.VerticalAlignment = VerticalAlignment.Top;
            timerAnzeige.FontSize = 50;
            timerStatus.Width = 150;
            timerStatus.Margin = new Thickness(115);
        }

        //die Methoden für das Command
        private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //gibt es das Spielfeld und läuft ein Spiel?
            if (spielfeld != null && spielGestartet == true && ergebnis == false)
                e.CanExecute = true;
            else
                ergebnis = false;
        }

        private void Pause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //pausieren?            
            SpielPause();
        }

        private void NeuesStart_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (spielfeld != null)
                e.CanExecute = true;
        }

        private void NeuesStart_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //neues Start?
            //NeuesSpiel();
            if (NeuesSpiel() == true)
            {
                Start();
                ergebnis = false;
            }                         
        }

        private void levelStapeln_Click(object sender, RoutedEventArgs e)
        {
            breiteAendern = 1000;
            hoeheAendern = 800;
            punkteAendern = 20;
            //die Markierung bei den anderen Einträgen abschalten
            schwierigkeitEinfach.IsChecked = false;
            schwierigkeitMittel.IsChecked = false;
            schwierigkeitSchwer.IsChecked = false;
            
            SetzeEinstellungen(breiteAendern, hoeheAendern, punkteAendern);
            level = true;
            timerSchlange.Interval = TimeSpan.FromMilliseconds(100);
        }
    }
}
