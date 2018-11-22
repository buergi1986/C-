using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace snake_csph18c
{
    class Schlangenteil
    {
        //die Felder
        //die Position
        protected Point position;
        //die alte Position
        protected Point altePosition;
        //die Farbe
        protected Color farbe;
        //die Form
        protected Rectangle quadrat;
        //die Grösse
        protected int groesse;

        //die Methoden
        //der Konstruktor zum Setzen der Position und der Farbe
        public Schlangenteil(Point position, Color farbe)
        {
            this.position.X = position.X;
            this.position.Y = position.Y;
            //alte und neue Position sind erst einmal identisch
            altePosition.X = this.position.X;
            altePosition.Y = this.position.Y;
            //Farbe setzen
            this.farbe = farbe;
            //die Grösse wird fest gesetzt
            groesse = 20;
            //ein neues Rechteck erzeugen
            quadrat = new Rectangle();
        }
        //eine leere Methode zum Bewegen
        //Sie wird in der abgeleiteten Klasse überschrieben
        public virtual void Bewegen(int richtung)
        {

        }
        //die neue Position setzen
        public void SetzePosition(Point neuePosition)
        {
            //die alte Position speichern
            altePosition = position;
            position = neuePosition;
        }
        //das Teil anzeigen
        public void Zeichnen(Canvas meinCanvas)
        {
            //das Quadrat löschen
            meinCanvas.Children.Remove(quadrat);
            //positionieren
            Canvas.SetLeft(quadrat, position.X);
            Canvas.SetTop(quadrat, position.Y);
            //die Grösse setzen
            quadrat.Width = groesse;
            quadrat.Height = groesse;
            //Farbe und Rahmen setzen
            SolidColorBrush brush = new SolidColorBrush(farbe);
            quadrat.Fill = brush;
            SolidColorBrush rahmen = new SolidColorBrush(Colors.White);
            quadrat.Stroke = rahmen;
            quadrat.Name = "Schlange";
            //wieder hinzufügen
            meinCanvas.Children.Add(quadrat);
        }
        //die alte Position liefern
        public Point LiefereAltePosition()
        {
            return altePosition;
        }
        //die Grösse liefern
        public int LiefereGroesse()
        {
            return groesse;
        }
        //die Position liefern
        //die Methode wird in der abgeleiteten Klasse überschrieben
        public virtual Point LieferePosition()
        {
            return position;
        }
    }
}
