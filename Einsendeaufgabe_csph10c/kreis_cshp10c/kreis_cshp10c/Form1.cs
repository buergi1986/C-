using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kreis_cshp10c
{
    public partial class Form1 : Form
    {
        Graphics zeichenkreis;
        Color black = Color.Black;
        Pen stift;
        int xPos;
        int yPos;
        //int xMax;
        //int yMax;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            zeichenkreis = this.CreateGraphics();
            stift = new Pen(black);

            xPos = ClientRectangle.Top + 100;
            yPos = ClientRectangle.Left + 100;
            //xMax = ClientRectangle.Right - 1;
            //yMax = ClientRectangle.Bottom - 1;

            zeichenkreis.DrawEllipse(stift, xPos, yPos, 100, 100);
            //zeichenkreis.DrawLine(stift, 0, 150, xMax, 150);
            //zeichenkreis.DrawLine(stift, 150, 0, 150, yMax);
            //zeichenkreis.DrawLine(stift, 0, 100, xMax, 100);
            //zeichenkreis.DrawLine(stift, 0, 200, xMax, 200);
            //zeichenkreis.DrawLine(stift, 100, yMax, 100, 0);
            //zeichenkreis.DrawLine(stift, 200, yMax, 200, 0);
        }

        private void buttonBeenden1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
