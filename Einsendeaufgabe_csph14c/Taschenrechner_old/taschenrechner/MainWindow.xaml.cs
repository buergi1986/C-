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

namespace taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float zahl1 = 0F, zahl2 = 0F, ergebnis = 0F;
        string rechenoperation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Berechnen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                zahl1 = Convert.ToSingle(zahlTextbox1.Text);
                zahl2 = Convert.ToSingle(zahlTextbox2.Text);
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                if (additionRadiobutton.IsChecked.Value)
                    rechenoperation = "addition";
                else if (subtraktionRadiobutton.IsChecked.Value)
                    rechenoperation = "subtraktion";
                else if (multipliaktionRadiobutton.IsChecked.Value)
                    rechenoperation = "multipliaktion";
                else if (divisionRadiobutton.IsChecked.Value)
                    rechenoperation = "division";

                switch (rechenoperation)
                {
                    case "addition":
                        ergebnis = zahl1 + zahl2;
                        break;
                    case "subtraktion":
                        ergebnis = zahl1 - zahl2;
                        break;
                    case "multipliaktion":
                        ergebnis = zahl1 * zahl2;
                        break;
                    case "division":
                        if (zahl2 == 0 && zahl1 > 0)
                            MessageBox.Show("Da die Division durch Null nicht definiert ist");
                        else
                            ergebnis = zahl1 / zahl2;
                        break;
                    default:
                        MessageBox.Show("Bitte Rechenoperation auswählen");
                        break;
                }
            }
            rechenLabel.Content = ergebnis.ToString();
        }

        private void Beenden_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
