using System;
using System.Collections.Generic;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace Texteditor
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //die Liste den Schriftgrad von 10 bis 40
        List<double> fontSizeList = new List<double>() { 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 };
        //der Schriftgrad nimmt Grösser auf
        string newSize;

        public MainPage()
        {
            this.InitializeComponent();
            //Start einrichtet den Schriftgrad
            //die Auswahl aus der Liste erstellen
            fontSize.ItemsSource = fontSizeList;
            //SelectedIndex auf 0, und nicht auf -1
            fontSize.SelectedIndex = 0;
            //den Schriftgrad auf "newSize" übertragen
            newSize = fontSize.SelectedItem.ToString();
            //auf RichEditor markieren
            Windows.UI.Text.ITextSelection textSelection = editor.Document.Selection;

            //den Schriftgrad ändern
            if (textSelection != null)
            {
                //die Textformat wechlen Schriftgrad befehlen
                Windows.UI.Text.ITextCharacterFormat textCharacter = textSelection.CharacterFormat;
                textCharacter.Size = Convert.ToInt32(newSize);
                textSelection.CharacterFormat = textCharacter;
            }
        }

        private void vergroessertText_Click(object sender, RoutedEventArgs e)
        {
            //den Schrift vergrössern
            try
            {
                //die Liste mit SelectedIndex bis 40 Grösser herauf
                fontSize.SelectedIndex += 1;
                //den Schriftgrad auf "newSize" übertragen
                newSize = fontSize.SelectedItem.ToString();
                //auf RichEditor markieren
                Windows.UI.Text.ITextSelection selection = editor.Document.Selection;

                if (selection != null)
                {
                    //die Textformat wechlen Schriftgrad befehlen
                    Windows.UI.Text.ITextCharacterFormat format = selection.CharacterFormat;
                    format.Size = Convert.ToInt32(newSize);
                    selection.CharacterFormat = format;
                }
            }
            catch
            {
                //unötige Zeilen
            }
        }

        private void verkleinertText_Click(object sender, RoutedEventArgs e)
        {
            //den Schrift verkleinern herunter
            try
            {
                //Min. 0 Grösser, und nicht mehr weiter heruntera
                if (fontSize.SelectedIndex != 0)
                {
                    //die List mit SelectedIndex 
                    fontSize.SelectedIndex -= 1;
                    //den Schriftgrad auf "newSize" übertragen
                    newSize = fontSize.SelectedItem.ToString();
                    //auf RichEditor markieren
                    Windows.UI.Text.ITextSelection selection = editor.Document.Selection;

                    if (selection != null)
                    {
                        //die Textformat wechlen Schriftgrad befehlen
                        Windows.UI.Text.ITextCharacterFormat format = selection.CharacterFormat;
                        format.Size = Convert.ToInt32(newSize);
                        selection.CharacterFormat = format;
                    }
                }
                else
                {
                    return;
                }
                
            }
            catch
            {
                //unötige Zeilen
            }
        }

        private void fontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //den Schriftgrad auswählen
            try
            {
                if (fontSize.SelectedIndex != -1)
                {
                    //den Schriftgrad auf "newSize" übertragen
                    newSize = fontSize.SelectedItem.ToString();
                    //auf RichEditor markieren
                    Windows.UI.Text.ITextSelection selection = editor.Document.Selection;

                    if (selection != null)
                    {
                        //die Textformat wechlen Schriftgrad befehlen
                        Windows.UI.Text.ITextCharacterFormat format = selection.CharacterFormat;
                        format.Size = Convert.ToInt32(newSize);
                        selection.CharacterFormat = format;
                    }
                }                
            }
            catch
            {
                //unötige Zeilen
            }
        }

        public void Speichern()
        {
            ApplicationDataContainer dataContainer = ApplicationData.Current.LocalSettings;
            dataContainer.Values["selectedindex"] = fontSize.SelectedIndex.ToString();
            dataContainer.Values["selecteditem"] = fontSize.SelectedItem.ToString();
        }

        public void Laden()
        {
            ApplicationDataContainer dataContainer = ApplicationData.Current.LocalSettings;
            if (dataContainer.Values["selectedindex"] != null)
            {
                fontSize.SelectedIndex = Convert.ToInt32(dataContainer.Values["selectedindex"]);
            }
            if (dataContainer.Values["selecteditem"] != null)
            {
                fontSize.SelectedItem = dataContainer.Values["selecteditem"].ToString();
            }
        }
    }
}
