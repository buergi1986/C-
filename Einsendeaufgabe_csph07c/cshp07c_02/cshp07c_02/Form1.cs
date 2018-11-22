using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshp07c_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            float zahl1;
            float zahl2;

            InitializeComponent();
            textBox1.Text = Convert.ToString(20);
            textBox2.Text = Convert.ToString(30);

            zahl1 = Convert.ToSingle(textBox1.Text);
            zahl2 = Convert.ToSingle(textBox2.Text);

            label1_ergebnis.Text = Convert.ToString(zahl1 + zahl2);
        }
    }
}
