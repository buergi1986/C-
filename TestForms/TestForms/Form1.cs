using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics zeichenflaeche;
        Color rot;
        Color blau;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            zeichenflaeche = this.CreateGraphics();
            rot = Color.Red;
            blau = Color.Blue;

            Pen stift = new Pen(rot);
            Brush pinsel = new SolidBrush(blau);

            int xPos = (ClientRectangle.Left + 150) - 50;
            int yPos = (ClientRectangle.Top + 150) - 50;

            int xMax = ClientRectangle.Right - 1;
            int yMax = ClientRectangle.Bottom - 1;
            int xMitte = (ClientSize.Width / 2) - 1;
            int yMitte = (ClientSize.Height / 2) - 1;

            zeichenflaeche.DrawEllipse(stift, xPos, yPos, 100, 100);

            //MessageBox.Show(xPos + " " + yPos);

            //zeichenflaeche.DrawLine(stift, xMax, yMitte, 0, yMitte);
            zeichenflaeche.DrawLine(stift, xMax, 150, 0, 150);
            //zeichenflaeche.DrawLine(stift, xMitte, yMax, xMitte, 0);
            zeichenflaeche.DrawLine(stift, 150, yMax, 150, 0);
            //zeichenflaeche.DrawLine(stift, 0, 0, xMax, yMax);
            //zeichenflaeche.DrawLine(stift, 0, yMax, xMax, 0);

        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
