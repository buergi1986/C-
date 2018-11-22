using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshp07c_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Oben Rand Abstand für 10
            label1.Top = 10;
        }

        private void buttonWanderung1_Click(object sender, EventArgs e)
        {
            int j = 0;
            //min. 10 mal Wiederholung
            while(j < 15)
            {
                //Koordinaten 0 bis 300 mit pro Schritt wandert
                for (int i = 0; i < 300; i++)
                    label1.Location = new Point(10, i);
                j++;
            }
        }

        private void buttonBeenden1_Click(object sender, EventArgs e)
        {
            //Fenster schliessen
            Close();
        }
    }
}
