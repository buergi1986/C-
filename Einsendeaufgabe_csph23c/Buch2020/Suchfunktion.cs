using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class Suchfunktion : Form
    {
        public Suchfunktion()
        {
            InitializeComponent();
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            if (textBoxNachname.Text != string.Empty)
            {
                this.kundeTableAdapter.FillBynachnameSuchen(this.buch2020DataSet.Kunde, textBoxNachname.Text);
            }
            else
            {
                MessageBox.Show("Die Eingabe darf nicht leer sein.", "Fehler");
            }
        }

        private void buttonSchliessen_Click(object sender, EventArgs e)
        {       
            Close();
        }
    }
}
