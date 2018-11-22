using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace snake_csph18c
{
    class Apfel
    {
        //die Felder
        //die Farbe
        Color farbe;
        //die Form
        Ellipse kreis;
        //die Grösse
        int groesse;
        //die Kollision initialisieren
        Rectangle rechteckKollision = new Rectangle();
        //die Methoden
        //der Konstruktor zum Setzen der Farbe und der Grösse und des Spielfelds
        public Apfel(Color farbe, int groesse)
        {
            //Farbe setzen
            this.farbe = farbe;
            //die Grösse setzen
            this.groesse = groesse;
            //einen neuen Kreis erzeugen
            kreis = new Ellipse();
        }

        //den Apfel anzeigen
        public void Anzeigen(Canvas meinCanvas, int balkenbreite)
        {
            //den Zufallsgenerator initialisieren
            Random zufall = new Random(GetHashCode());
            kreis.Name = "Apfel";
            //das Minium ist die Balkenbreite
            int min = balkenbreite;
            //das Maximum ermitteln
            //die Balken und die Grösse für die maximalen Positionen abziehen
            int maxX = (int)meinCanvas.ActualWidth - balkenbreite - groesse;
            int maxY = (int)meinCanvas.ActualHeight - balkenbreite - groesse;
            //positionieren
            Canvas.SetLeft(kreis, zufall.Next(min, maxX));
            Canvas.SetTop(kreis, zufall.Next(min, maxY));

            //die Grösse setzen
            kreis.Width = groesse;
            kreis.Height = groesse;
            //Farben setzen
            SolidColorBrush colorBrush = new SolidColorBrush(Colors.Green);
            kreis.Fill = colorBrush;

            rechteckKollision.Name = "Kollision";
            //den Dummy für die Kollision erstellen
            rechteckKollision.Width = kreis.Width + (groesse - 1);
            rechteckKollision.Height = kreis.Height + (groesse - 1);
            //Farben setzen
            SolidColorBrush farbe = new SolidColorBrush(Colors.Aqua);
            farbe.Opacity = 0;
            rechteckKollision.Fill = farbe;
            Canvas.SetLeft(rechteckKollision, Canvas.GetLeft(kreis) - ((groesse - 1) / 2));
            Canvas.SetTop(rechteckKollision, Canvas.GetTop(kreis) - ((groesse - 1) / 2));
            //hinzufügen
            //erst das Rechteck für die Kollision
            meinCanvas.Children.Add(rechteckKollision);
            //dann den Kreis
            meinCanvas.Children.Add(kreis);
        }

        //den Apfel entfernen
        public void Entfernen(Canvas meinCanvas)
        {
            meinCanvas.Children.Remove(rechteckKollision);
            meinCanvas.Children.Remove(kreis);
        }
    }
}
