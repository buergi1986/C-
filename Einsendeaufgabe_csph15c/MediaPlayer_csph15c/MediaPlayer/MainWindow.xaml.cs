using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace MediaPlayer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //läuft gerade ein Video?
        bool wiedergabe;
        bool verzoegerung;
        //läuft zurück oder vor ein Video spulen
        TimeSpan time = new TimeSpan(0);
        TimeSpan seconds = TimeSpan.FromSeconds(10);
        //die lange Zeit anzeigen
        private TimeSpan zeitDuration;
        public TimeSpan ZeitDuration { get => zeitDuration; set => zeitDuration = value; }
        //die Stoppuhr
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            //es läuft kein Video
            wiedergabe = false;
            //Zeitverzögerung
            verzoegerung = false;
        }

        private void buttonOeffnen_Click(object sender, RoutedEventArgs e)
        {
            //den Dialog erzeugen
            Microsoft.Win32.OpenFileDialog oeffnenDialog = new Microsoft.Win32.OpenFileDialog();
            //das Feld für den Namen ist leer
            oeffnenDialog.FileName = String.Empty;
            //wurde der Dialog über OK geschlossen?
            //dann die Datei laden
            if (oeffnenDialog.ShowDialog() == true) { 
                mediaElement.Source = new Uri(oeffnenDialog.FileName);
                //die Schaltfläche für die Wiedergabe aktivieren
                buttonPlayPause.IsEnabled = true;                
                //das Symbol für die Wiedergabe anzeigen
                imagePlayPause.Source = new BitmapImage(new Uri("symbole/play.png", UriKind.Relative));
                //die Deckkraft wieder auf 100%
                buttonPlayPause.Opacity = 100;
                //den Namen im Label anzeigen
                label.Content = oeffnenDialog.FileName;
                //es läuft aktuell keine Wiedergabe mehr
                wiedergabe = false;
                //das Film öffnen durch der lange Zeit anzeigen
                mediaElement.MediaOpened += MediaElement_MediaOpened;
                //die Stoppuhr erzeugen
                timer.Interval = TimeSpan.FromSeconds(1);
                timer.Tick += Timer_Tick;
            }
        }

        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            //die lange Zeit erzeugen
            ZeitDuration = mediaElement.NaturalDuration.TimeSpan;            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //die Stoppuhr startet sich, wenn das Film läuft
            if((mediaElement.Source != null) && (mediaElement.NaturalDuration.HasTimeSpan) && !verzoegerung)
            {
                slider1.Minimum = 0;
                slider1.Maximum = ZeitDuration.TotalSeconds;
                slider1.Value = mediaElement.Position.TotalSeconds;
            }
        }
        private void buttonPlayPause_Click(object sender, RoutedEventArgs e)
        {
            //wenn aktuell keine Wiedergabe läuft
            if (wiedergabe == false)
            {
                //die Wiedergabe starten
                mediaElement.Play();
                //das Symbol wechseln
                imagePlayPause.Source = new BitmapImage(new Uri("symbole/pause.png", UriKind.Relative));
                //und auch den Tooltipp
                buttonPlayPause.ToolTip = "Unterbrechen";
                //jetzt läuft die Wiedergabe
                wiedergabe = true;
                //die Schaltfläche für das Zurückspulen und Vorspulen aktivieren
                buttonZurueck.IsEnabled = true;
                buttonVor.IsEnabled = true;
                //die Deckkraft wieder auf 100%
                buttonVor.Opacity = 100;
                buttonZurueck.Opacity = 100;
                //die Zeitdauer starten
                timer.Start();
            }
            //wenn aktuell eine Wiedergabe läuft
            else
            {
                //die Wiedergabe unterbrechen
                mediaElement.Pause();
                //das Symbol wechseln
                imagePlayPause.Source = new BitmapImage(new Uri("symbole/play.png", UriKind.Relative));
                //und auch den Tooltipp
                buttonPlayPause.ToolTip = "Wiedergeben";
                //jetzt läuft keine Wiedergabe
                wiedergabe = false;
                //die Schaltfläche für das Zurückspulen und Vorspulen deaktivieren
                buttonZurueck.IsEnabled = false;
                buttonVor.IsEnabled = false;
                //die Deckkraft wieder zurück auf 0.5%
                buttonVor.Opacity = 0.5;
                buttonZurueck.Opacity = 0.5;
                timer.Stop();
            }
            //die Schaltfläche für das Stoppen aktivieren
            buttonStopp.IsEnabled = true;
            //die Deckkraft wieder auf 100%
            buttonStopp.Opacity = 100;
        }

        private void buttonStopp_Click(object sender, RoutedEventArgs e)
        {
            //die Wiedergabe stoppen
            mediaElement.Stop();
            //das Symbol für die Wiedergabe anzeigen
            imagePlayPause.Source = new BitmapImage(new Uri("symbole/play.png", UriKind.Relative));
            //und auch den Tooltipp setzen
            buttonPlayPause.ToolTip = "Wiedergeben";
            //es läuft keine Wiedergabe
            wiedergabe = false;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //gibt es mediaElement bereits?
            if (mediaElement != null)
                //dann setzen wir die Lautstärke
                mediaElement.Volume = slider.Value / 100;
        }

        private void Window_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            //in welche Richtung wurde das Mausrad gedreht?
            if (e.Delta > 0)
                //nach vorne erhöhen wir die Lautstärke
                mediaElement.Volume = mediaElement.Volume + 0.1;
            else
                //nach hinten reduzieren wir sie
                mediaElement.Volume = mediaElement.Volume - 0.1;
            //die Anzeige des Schiebereglers aktualisieren
            slider.Value = mediaElement.Volume * 100;
        }

        private void buttonZurueck_Click(object sender, RoutedEventArgs e)
        {
            //Zurückspulen in 10 Sekunden
            mediaElement.Position += time.Subtract(seconds);
        }

        private void buttonVor_Click(object sender, RoutedEventArgs e)
        {
            //Vorspulen in 10 Sekunden
            mediaElement.Position += time.Add(seconds);
        }

        private void slider1_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            //der Schieber schleppen aktivieren
            verzoegerung = true;
        }

        private void slider1_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            //der Schieber bis zu Ende, dann deaktiviert
            verzoegerung = false;
            mediaElement.Position = TimeSpan.FromSeconds(slider1.Value);
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //die Zeitanzeige läuft
            label1.Content = String.Format(@"{0} / {1:hh\:mm\:ss}", TimeSpan.FromSeconds(slider1.Value).ToString(@"hh\:mm\:ss"), ZeitDuration);
        }
    }
}
