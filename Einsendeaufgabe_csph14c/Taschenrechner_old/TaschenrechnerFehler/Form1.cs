using System;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float Berechnen(float zahl1, float zahl2)
        {
            float ergebnis = 0;

            //die beiden Zahlen einlesen und konvertieren
            zahl1 = Convert.ToSingle(textBoxZahl1.Text);
            zahl2 = Convert.ToSingle(textBoxZahl2.Text);
            //die Rechenoperation ermitteln und ausführen
            if (radioButtonAddition.Checked == true)
                ergebnis = zahl1 + zahl2;
            if (radioButtonSubtraktion.Checked == true)
                ergebnis = zahl1 - zahl2;
            if (radioButtonMultiplikation.Checked == true)
                ergebnis = zahl1 * zahl2;
            if (radioButtonDivision.Checked == true)
                ergebnis = zahl1 / zahl2;
                
            return ergebnis;
        }

        private void Test(TextBox textBoxZahl1, TextBox textBoxZahl2)
        {
            float zahl1 = 0, zahl2 = 0;
            bool ausnahme = true;

            try
            {
                zahl1 = Convert.ToSingle(textBoxZahl1.Text);

                try
                {
                    zahl2 = Convert.ToSingle(textBoxZahl2.Text);

                    if (radioButtonDivision.Checked == true)
                    {
                        if (zahl2 == 0)
                            throw new DivideByZeroException();
                    }
                }
                catch (Exception ex)
                {
                    if (ex is FormatException || ex is DivideByZeroException)
                    {
                        MessageBox.Show(ex.Message, "Oh nein!");
                        textBoxZahl2.Select();
                        ausnahme = false;
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Oh nein!");
                textBoxZahl1.Select();
                ausnahme = false;
            }

            if (ausnahme == true)
                labelAnzeige.Text = Convert.ToString(Berechnen(zahl1,zahl2));
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            Test(textBoxZahl1, textBoxZahl2);
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
