using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Minibrowser
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //für das Zwischenspeichern der Spaltenbreiten
        GridLength spalteLinksBreite, spalteSplitterBreite;
        double spalteLinksMindestbreite;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void browser_Navigated(object sender, NavigationEventArgs e)
        {
            //var eintrag = liste.SelectedItem;
            //string eingeben = string.Empty;

            //ItemContainerGenerator nutzt nicht wirklich. Contains funktioniert sich die existierende Liste oder nicht existierende Liste
            
            //ListBoxItem meinEintrag = (ListBoxItem)liste.ItemContainerGenerator.ContainerFromItem(eintrag);

            //if(meinEintrag != null)
            //{
            //    eingeben = meinEintrag.Content.ToString();
            //}

            //die Adresse in das Listenfeld schreiben, wenn das Listenfeld nicht existiert
            if (!liste.Items.Contains(browser.Source))
                liste.Items.Add(browser.Source);

            //den Text in der Titelleiste zusammenbauen
            Title = "MiniBrowser " + ((dynamic)browser.Document).Title;
            //den Text im Eingabefeld setzen
            eingabefeld.Text = browser.Source.ToString();
            //die Anzeigen in der Statusleiste setzen
            statusbarProgress.Visibility = Visibility.Collapsed;
            statusbarLabel.Content = "Seite geladen...";
        }

        private void dateiBeenden_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void dateiOeffnen_Click(object sender, RoutedEventArgs e)
        {
            string adresse;
            //den eigenen Öffnendialog modal öffnen
            UrlOeffnenDialog oeffnenDialog = new UrlOeffnenDialog();
            oeffnenDialog.ShowDialog();
            //den "Eigentümer" setzen
            oeffnenDialog.Owner = this;
            //wurde die Schaltfläche Öffnen in dem Dialog angeklickt?
            if (oeffnenDialog.DialogResult == true)
            {
                //die Adresse über die Methode im Öffnendialog beschaffen
                adresse = oeffnenDialog.LiefereAdresse();
                //lässt sich die Adresse umwandeln
                try
                {
                    if (!Uri.CheckSchemeName(adresse))
                        browser.Navigate(new Uri(adresse));
                    else
                        browser.Navigate(new Uri("http://" + adresse));
                }
                catch (UriFormatException)
                {
                    MessageBox.Show("Das Format der Adresse " + adresse + " ist nicht gültig.", "Fehler");
                }
            }
        }

        private void navigationNeuLaden_Click(object sender, RoutedEventArgs e)
        {
            browser.Refresh();
        }

        private void buttonLos_Click(object sender, RoutedEventArgs e)
        {
            string adresse;
            //den Text aus dem Eingabefeld beschaffen
            adresse = eingabefeld.Text;
            //wenn Text im Eingabefeld steht, übergeben wir ihn an die Methode Navigate()
            if (adresse != string.Empty)
            {
                //lässt sich die Adresse umwandeln
                try
                {
                    if (!Uri.CheckSchemeName(adresse))
                        browser.Navigate(new Uri(adresse));
                    else
                        browser.Navigate(new Uri("http://" + adresse));
                }
                catch (UriFormatException)
                {
                    MessageBox.Show("Das Format der Adresse " + adresse + " ist nicht gültig.", "Fehler");
                }
            }
        }

        private void eingabefeld_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                buttonLos_Click(sender, e);
        }

        private void ansichtNavigationsliste_Click(object sender, RoutedEventArgs e)
        {
            //ist der Eintrag markiert?
            if (ansichtNavigationsliste.IsChecked == true)
            {
                //die beiden Spalten auf die ursprüngliche Breite setzen
                spalteLinks.Width = spalteLinksBreite;
                spalteSplitter.Width = spalteSplitterBreite;
                spalteLinks.MinWidth = spalteLinksMindestbreite;
                //die Liste wieder einblenden
                liste.Visibility = Visibility.Visible;
            }
            else
            {
                //die Spalten ausblenden
                //die alten Breiten sichern
                spalteLinksBreite = spalteLinks.Width;
                spalteSplitterBreite = spalteSplitter.Width;
                spalteLinksMindestbreite = spalteLinks.MinWidth;
                //die Liste ausblenden
                liste.Visibility = Visibility.Collapsed;
                //und die Breite der Spalten auf 0 setzen
                spalteLinks.MinWidth = 0;
                spalteLinks.Width = new GridLength(0);
                spalteSplitter.Width = new GridLength(0);
            }
        }

        private void ansichtSymbolleistenAdresse_Click(object sender, RoutedEventArgs e)
        {
            if (ansichtSymbolleistenAdresse.IsChecked == true)
            {
                toolbarAdresse.Visibility = Visibility.Visible;
                if (ansichtVollbild.IsChecked == true)
                    ansichtVollbild.IsChecked = false;
                if (ansichtSymbolleistenNavigation.IsChecked == true)
                    statusleiste.Visibility = Visibility.Visible;
            }
            else
                toolbarAdresse.Visibility = Visibility.Collapsed;
        }

        private void ansichtSymbolleistenNavigation_Click(object sender, RoutedEventArgs e)
        {
            if (ansichtSymbolleistenNavigation.IsChecked == true)
            {
                toolbarNavigation.Visibility = Visibility.Visible;
                if (ansichtVollbild.IsChecked == true)
                    ansichtVollbild.IsChecked = false;
                if (ansichtSymbolleistenAdresse.IsChecked == true)
                    statusleiste.Visibility = Visibility.Visible;
            }
            else
                toolbarNavigation.Visibility = Visibility.Collapsed;
        }

        private void ansichtVollbild_Click(object sender, RoutedEventArgs e)
        {
            if (ansichtVollbild.IsChecked == true)
            {
                statusleiste.Visibility = Visibility.Collapsed;
                toolbarNavigation.Visibility = Visibility.Collapsed;
                ansichtSymbolleistenNavigation.IsChecked = false;
                toolbarAdresse.Visibility = Visibility.Collapsed;
                ansichtSymbolleistenAdresse.IsChecked = false;
            }
            else
            {
                statusleiste.Visibility = Visibility.Visible;
                toolbarAdresse.Visibility = Visibility.Visible;
                ansichtSymbolleistenAdresse.IsChecked = true;
                toolbarNavigation.Visibility = Visibility.Visible;
                ansichtSymbolleistenNavigation.IsChecked = true;
            }
        }

        private void liste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                if (liste.SelectedIndex == -1)
                    return;
                //die Seite aufrufen
                browser.Navigate(new Uri(liste.SelectedItem.ToString()));
            }
                
        }

        private void kontextMenuLoeschen_Click(object sender, RoutedEventArgs e)
        {
            if (Mouse.RightButton == MouseButtonState.Pressed)
                if (liste.SelectedIndex == -1)
                    return;
            //die Liste löschen
            liste.Items.RemoveAt(liste.SelectedIndex);
        }

        private void browser_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            //sind die Steuerelemente schon verfügbar?
            //dann die Anzeigen setzen
            if (statusbarProgress != null && statusbarLabel != null)
            {
                statusbarProgress.Visibility = Visibility.Visible;
                statusbarLabel.Content = "Seite wird geladen...";
            }
        }

        private void hilfeInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Programmiert von <Mein Name>", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BrowseBack_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //gibt es das Steuerelement und können wir zurück navigieren?
            if (browser != null && browser.CanGoBack == true)
            {
                e.CanExecute = true;
                //das Symbol normal darstellen
                buttonZurueck.Opacity = 1;
            }
            else
                //das Symbol abblenden
                buttonZurueck.Opacity = 0.5;
        }

        private void BrowseBack_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //zurück navigieren
            browser.GoBack();
        }

        private void BrowseForward_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //gibt es das Steuerelement und können wir vorwärts navigieren?
            if (browser != null && browser.CanGoForward == true)
            {
                e.CanExecute = true;
                //das Symbol normal darstellen
                buttonVorwaerts.Opacity = 1;
            }
            else
                //das Symbol abblenden
                buttonVorwaerts.Opacity = 0.5;
        }

        private void BrowseForward_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            browser.GoForward();
        }

        private void buttonLos_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonLos.ToolTip = "Los geht's zu " + eingabefeld.Text;
        }
    }
}
