using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshp07c_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            float zahl1, zahl2, ergebnis = 0;
            bool divDurchNull = false;

            //die beiden Zahlen einlesen und konvertieren
            zahl1 = Convert.ToSingle(textBoxZahl1.Text);
            zahl2 = Convert.ToSingle(textBoxZahl2.Text);
            //die Rechenoperation ermitteln und ausführen
            if (comboBox1.SelectedItem.ToString() == "Addition")
                ergebnis = zahl1 + zahl2;
            if (comboBox1.SelectedItem.ToString() == "Subtraktion")
                ergebnis = zahl1 - zahl2;
            if (comboBox1.SelectedItem.ToString() == "Multiplikation")
                ergebnis = zahl1 * zahl2;
            if (comboBox1.SelectedItem.ToString() == "Division")
            {
                //wird eine Division durch Null versucht?
                if (zahl2 == 0)
                    divDurchNull = true;
                else
                    ergebnis = zahl1 / zahl2;
            }
            //wurde durch Null dividiert?
            if (divDurchNull == true)
                labelAnzeige.Text = "Nicht definiert!";
            else
                labelAnzeige.Text = Convert.ToString(ergebnis);
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
