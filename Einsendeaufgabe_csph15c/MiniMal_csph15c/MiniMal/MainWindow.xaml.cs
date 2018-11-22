using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls.Ribbon;

namespace MiniMal
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        //für die Farbe
        SolidColorBrush farbe;
        //für die Position
        Point start;
        //für das Werkzeug
        int werkzeug;

        //die eigenen Methoden
        //Sie erstellen die Objekte und fügen sie ein
        //Breite und Höhe bzw. Endpunkt werden übergeben
        
        //für das Rechteck
        void Rechteck(int breite, int hoehe)
        {
            try
            {
                //das Rechteck erzeugen
                Rectangle rechteck = new Rectangle();
                //die Eigenschaften setzen
                //die linke obere Ecke
                Canvas.SetLeft(rechteck, start.X);
                Canvas.SetTop(rechteck, start.Y);
                //Breite und Höhe
                rechteck.Width = breite;
                rechteck.Height = hoehe;
                rechteck.Stroke = farbe;
                //und hinzufügen
                meinCanvas.Children.Add(rechteck);
            }
            catch
            {
                MessageBox.Show("Es hat ein Problem gegeben");
            }
        }

        //die Methode zeichnet einen Kreis
        //die Breite und Höhe des umgebenden 
        //Rechtecks werden als Parameter übergeben
        void Kreis(int breite, int hoehe)
        {
            try
            {
                //den Kreis erzeugen
                Ellipse kreis = new Ellipse();
                //die Eigenschaften setzen
                //die linke obere Ecke
                Canvas.SetLeft(kreis, start.X);
                Canvas.SetTop(kreis, start.Y);
                //Breite und Höhe
                kreis.Width = breite;
                kreis.Height = hoehe;
                kreis.Stroke = farbe;
                //und hinzufügen
                meinCanvas.Children.Add(kreis);
            }
            catch
            {
                MessageBox.Show("Es hat ein Problem gegeben");
            }
        }

        //Markus bearbeitet hier als Kreis Füllen
        void Kreisgefüllt(int breite, int hoehe)
        {
            try
            {
                //den gefüllten Kreis erzeugen
                Ellipse kreisgefuellt = new Ellipse();

                Canvas.SetLeft(kreisgefuellt, start.X);
                Canvas.SetTop(kreisgefuellt, start.Y);

                kreisgefuellt.Width = breite;
                kreisgefuellt.Height = hoehe;
                kreisgefuellt.Fill = farbe;

                meinCanvas.Children.Add(kreisgefuellt);
            }
            catch
            {
                MessageBox.Show("Es hat ein Problem gegeben");
            }
        }

        //die Methode zeichnet eine Linie
        //Der Endpunkt wird als Parameter übergeben
        void Linie(int x2, int y2)
        {
            //eine neue Linie erzeugen
            Line linie = new Line();
            //die Eigenschaften setzen
            linie.X1 = start.X;
            linie.Y1 = start.Y;
            linie.X2 = x2;
            linie.Y2 = y2;
            linie.Stroke = farbe;
            //und hinzufügen
            meinCanvas.Children.Add(linie);
        }

        void Speichern()
        {
            //einen Speicherndialog erzeugen
            Microsoft.Win32.SaveFileDialog speichernDialog = new Microsoft.Win32.SaveFileDialog();
            //die Eigenschaften für den Dialog setzen
            speichernDialog.Filter = "MiniMal-Dateien|*.mml";
            speichernDialog.FileName = string.Empty;
            //wurde der Dialog über Speichern geschlossen?
            //dann die Datei unter dem angegebenen Namen speichern
            if (speichernDialog.ShowDialog() == true)
            {
                using (System.IO.FileStream dateiStream = new System.IO.FileStream(speichernDialog.FileName, System.IO.FileMode.Create))
                {
                    System.Windows.Markup.XamlWriter.Save(meinCanvas, dateiStream);
                }
            }
        }

        void Laden()
        {
            //einen Öffnendialog erzeugen
            Microsoft.Win32.OpenFileDialog oeffnenDialog = new Microsoft.Win32.OpenFileDialog();
            //die Eigenschaften für den Dialog setzen
            oeffnenDialog.Filter = "MiniMal-Dateien|*.mml";
            oeffnenDialog.FileName = string.Empty;
            //wurde der Dialog über Öffnen geschlossen?
            //dann die Datei öffnen
            if (oeffnenDialog.ShowDialog() == true)
            {
                using (System.IO.FileStream dateiStream = new System.IO.FileStream(oeffnenDialog.FileName, System.IO.FileMode.Open))
                {
                    //die alte Zeichenfläche entfernen
                    meinGrid.Children.Remove(meinCanvas);
                    //und laden und wieder einfügen
                    meinCanvas = System.Windows.Markup.XamlReader.Load(dateiStream) as Canvas;
                    meinGrid.Children.Add(meinCanvas);
                    //die Eventhandler müssen wieder zugewiesen werden
                    meinCanvas.MouseLeftButtonDown += new MouseButtonEventHandler(meinCanvas_MouseLeftButtonDown);
                    meinCanvas.MouseLeftButtonUp += new MouseButtonEventHandler(meinCanvas_MouseLeftButtonUp);
                }
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            //die Standardfarbe ist Schwarz
            farbe = Brushes.Black;
            //das Standardwerkzeug ist die Linie
            werkzeug = 1;
        }

        //die Methoden setzen jeweils den Wert für das entsprechende Werkzeug
        private void buttonLinie_Click(object sender, RoutedEventArgs e)
        {
            werkzeug = 1;
        }

        private void buttonKreis_Click(object sender, RoutedEventArgs e)
        {
            werkzeug = 2;
        }

        private void buttonRechteck_Click(object sender, RoutedEventArgs e)
        {
            werkzeug = 3;
        }

        private void buttonFuellKreis_Click(object sender, RoutedEventArgs e)
        {
            werkzeug = 4;
        }

        private void meinCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //die Koordinate als Startpunkt speichern
            start = e.GetPosition(meinCanvas);
            //den Cursor in einen Stift verändern
            meinCanvas.Cursor = Cursors.Pen;
        }

        private void meinCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //wenn die Taste losgelassen wird, zeichnen wir von der alten 
            //zur aktuellen Position
            //je nach Werkzeug wird ein anderes Objekt gezeichnet
            //die Linie
            if (werkzeug == 1)
                Linie((int)e.GetPosition(meinCanvas).X, (int)e.GetPosition(meinCanvas).Y);
            //ein Kreis
            if (werkzeug == 2)
                Kreis((int)(e.GetPosition(meinCanvas).X - start.X), (int)(e.GetPosition(meinCanvas).Y - start.Y));
            //das Rechteck
            if (werkzeug == 3)
                Rechteck((int)(e.GetPosition(meinCanvas).X - start.X), (int)(e.GetPosition(meinCanvas).Y - start.Y));
            //ein Kreis gefüllt
            if (werkzeug == 4)
                Kreisgefüllt((int)(e.GetPosition(meinCanvas).X - start.X), (int)(e.GetPosition(meinCanvas).Y - start.Y));
            //wieder den Startcursor verwenden
            meinCanvas.Cursor = Cursors.Arrow;
        }

        private void buttonFarbAuswahl_Click(object sender, RoutedEventArgs e)
        {
            //einen neuen Standarddialog von Windows zur Farbauswahl erzeugen
            System.Windows.Forms.ColorDialog farbAuswahl = new System.Windows.Forms.ColorDialog();
            //wurde der Dialog über OK geschlossen
            if (farbAuswahl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //dann die Farbe zuweisen
                //das geht nur über einen Umweg
                Color farbeWPF = Color.FromArgb(farbAuswahl.Color.A, farbAuswahl.Color.R, farbAuswahl.Color.G, farbAuswahl.Color.B);
                farbe = new SolidColorBrush(farbeWPF);
            }
        }

        private void menuNeu_Click(object sender, RoutedEventArgs e)
        {
            //die Zeichenfläche löschen
            meinCanvas.Children.Clear();
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            Speichern();
        }

        private void menuOeffnen_Click(object sender, RoutedEventArgs e)
        {
            Laden();
        }

    }
}
