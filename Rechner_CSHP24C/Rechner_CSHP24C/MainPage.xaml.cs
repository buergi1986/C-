using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;
using Windows.Storage;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace Rechner_CSHP24C
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int aktiveEingabe;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void eingabe1_GotFocus(object sender, RoutedEventArgs e)
        {
            aktiveEingabe = 1;
        }

        private void eingabe2_GotFocus(object sender, RoutedEventArgs e)
        {
            aktiveEingabe = 2;
        }

        private void Button_Click_Ziffer(object sender, RoutedEventArgs e)
        {
            Anzeige((sender as Button).Content.ToString());
        }

        private void Anzeige(string eingabe)
        {
            string tempText;
            if (aktiveEingabe == 1)
                tempText = eingabe1.Text;
            else
                tempText = eingabe2.Text;

            if (eingabe == "," && tempText.Contains(","))
                return;
            else
                tempText = tempText + eingabe;

            if (aktiveEingabe == 1)
                eingabe1.Text = tempText;
            else
                eingabe2.Text = tempText;
        }

        private void Button_Click_Rechnung(object sender, RoutedEventArgs e)
        {
            Rechnen((sender as Button).Content.ToString());
        }

        private void Rechnen(string eingabe)
        {
            float zahl1, zahl2, ergebnis = 0;

            try
            {            
                zahl1 = Convert.ToSingle(eingabe1.Text);
                zahl2 = Convert.ToSingle(eingabe2.Text);

                switch (eingabe)
                {
                    case "+":
                        ergebnis = zahl1 + zahl2;
                        break;
                    case "-":
                        ergebnis = zahl1 - zahl2;
                        break;
                    case "*":
                        ergebnis = zahl1 * zahl2;
                        break;
                    case "/":
                        if (zahl2 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        else
                        {
                            ergebnis = zahl1 / zahl2;
                        }                                                   
                        break;
                }

                ausgabe.Text = ergebnis.ToString();
            }
            catch(Exception ex)
            {
                if (ex is DivideByZeroException)
                {
                    ausgabe.Text = "Teilen durch 0 nicht möglich!";
                }
                if (ex is FormatException)
                {
                    FehlerMeldung();
                }
            }
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            eingabe1.Text = String.Empty;
            eingabe2.Text = String.Empty;
            ausgabe.Text = String.Empty;
        }

        private async void FehlerMeldung()
        {
            MessageDialog message = new MessageDialog("Es ist ein Problem aufgetreten");
            await message.ShowAsync();
        }

        public void Speichern()
        {
            ApplicationDataContainer lokaleDaten = ApplicationData.Current.LocalSettings;

            lokaleDaten.Values["eingabe1"] = eingabe1.Text;
            lokaleDaten.Values["eingabe2"] = eingabe2.Text;
            lokaleDaten.Values["ausgabe"] = ausgabe.Text;
        }

        public void Laden()
        {
            ApplicationDataContainer lokaleDaten = ApplicationData.Current.LocalSettings;

            if (lokaleDaten.Values["eingabe1"] != null)
            {
                eingabe1.Text = lokaleDaten.Values["eingabe1"].ToString();
                eingabe2.Text = lokaleDaten.Values["eingabe2"].ToString();
                ausgabe.Text = lokaleDaten.Values["ausgabe"].ToString();
            }
        }
    }
}
