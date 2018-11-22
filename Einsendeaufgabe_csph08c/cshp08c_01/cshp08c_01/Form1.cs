using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshp08c_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOeffnen_Click(object sender, EventArgs e)
        {
            //Datei öffnen
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //die Grafikformate mit Filter nur BMP, GIF und JPG
            textBox1.Text = openFileDialog1.FileName;
            pictureBox1.Load(textBox1.Text);
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            //Fenster schliessen
            Close();
        }
    }
}
