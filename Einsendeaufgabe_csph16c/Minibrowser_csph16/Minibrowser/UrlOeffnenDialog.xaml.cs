using System.Windows;
using System.Windows.Controls;

namespace Minibrowser
{
    /// <summary>
    /// Interaktionslogik für UrlOeffnenDialog.xaml
    /// </summary>
    public partial class UrlOeffnenDialog : Window
    {
        public UrlOeffnenDialog()
        {
            InitializeComponent();
        }

        private void buttonOeffnen_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void buttonAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        //die Methode liefert die eingegebene Adresse zurück
        public string LiefereAdresse()
        {
            return textBox.Text;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //den Fokus setzen
            textBox.Focus();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //die Schaltfläche Öffnen aktivieren, wenn das Feld nicht leer ist
            if (textBox.Text != string.Empty)
                buttonOeffnen.IsEnabled = true;
            else
                buttonOeffnen.IsEnabled = false;
        }
    }
}
