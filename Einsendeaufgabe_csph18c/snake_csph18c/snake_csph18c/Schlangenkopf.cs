using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace snake_csph18c
{
    class Schlangenkopf : Schlangenteil
    {
        //der Konstruktor
        public Schlangenkopf(Point position, Color farbe) : base(position, farbe)
        {

        }

        public override void Bewegen(int richtung)
        {
            //die alte Position speichern
            altePosition = position;
            //und verändern
            switch (richtung)
            {
                //nach oben
                case 0:
                    position.Y = position.Y - groesse;
                    break;
                //nach rechts
                case 1:
                    position.X = position.X + groesse;
                    break;
                //nach unten
                case 2:
                    position.Y = position.Y + groesse;
                    break;
                //nach links
                case 3:
                    position.X = position.X - groesse;
                    break;
            }
        }

        public override Point LieferePosition()
        {
            return (new Point(position.X + (groesse / 2), position.Y + (groesse / 2)));
        }
    }
}
