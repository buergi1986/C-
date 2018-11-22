using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float zahl1 = 0F, zahl2 = 0F, ergebnis = 0F;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void berechnen(TextBox zahl1, TextBox zahl2)
        {
            try
            {
                this.zahl1 = Convert.ToSingle(zahlTextbox1.Text);
                this.zahl2 = Convert.ToSingle(zahlTextbox2.Text);

                try
                {
                    if (divisionRadiobutton.IsChecked.Value)
                    {
                        if (this.zahl2 == 0 && this.zahl1 > 0)
                            throw new DivideByZeroException();
                    }                        
                }
                catch (Exception)
                {
                    MessageBox.Show("Da die Division durch Null nicht definiert ist");
                    zahlTextbox2.Focus();
                    zahlTextbox2.Clear();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            finally
            {
                if (additionRadiobutton.IsChecked.Value)
                    ergebnis = this.zahl1 + this.zahl2;
                else if (subtraktionRadiobutton.IsChecked.Value)
                    ergebnis = this.zahl1 - this.zahl2;
                else if (multipliaktionRadiobutton.IsChecked.Value)
                    ergebnis = this.zahl1 * this.zahl2;
                else if (divisionRadiobutton.IsChecked.Value)
                    ergebnis = this.zahl1 / this.zahl2;
                else
                    MessageBox.Show("Bitte Rechenoperation auswählen");
            }
            rechenLabel.Content = ergebnis.ToString();
        }

        private void Berechnen_Click(object sender, RoutedEventArgs e)
        {
            berechnen(zahlTextbox1, zahlTextbox2);
        }

        private void Beenden_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
