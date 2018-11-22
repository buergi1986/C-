using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Controls.Ribbon;

namespace WPFMinitext
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        //für die Anzahl der neuen Dokumente
        int zaehler;
        //für den Dateinamen
        string dateiname;
        //für Änderungen
        bool geaendert;

        //die eigenen Methoden
        //legt ein "neues" Dokument an
        void NeuesDokument()
        {
            //den Text "löschen"
            richTextBox.Document = new FlowDocument();
            //die Anzeige in der Titelleiste setzen
            this.Title = "ohnename" + zaehler;
            //den Zähler um 1 erhöhen
            zaehler++;
            //es liegen keine Änderungen vor
            geaendert = false;
            //der Dateiname ist leer
            dateiname = string.Empty;
            //die Rechtschreibprüfung aktivieren
            richTextBox.SpellCheck.IsEnabled = true;
        }

        //zum Speichern unter einem festen Namen
        void Speichern(string name)
        {
            dateiname = name;
            //den Text in der Titelleiste setzen
            this.Title = dateiname;
            //einen Stream erzeugen
            //die Datei wird dabei erzeugt bzw. überschrieben
            using (System.IO.FileStream dateiStream = new System.IO.FileStream(name, System.IO.FileMode.Create))
            {
                //den Bereich für das Speichern festlegen
                //wir nehmen den gesamten Inhalte der RichTextBox
                TextRange textBereich = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                //nun über den Stream im RTF-Format speichern
                textBereich.Save(dateiStream, DataFormats.Rtf);
            }
            //geaendert auf false setzen, da die Änderungen gespeichert sind
            geaendert = false;
        }

        //zeigt den Dialog Speichern unter an und speichert die Datei
        void DateiSpeichern()
        {
            //wenn der Dateiname leer ist, einen Speichern-Dialog anzeigen
            if (dateiname == string.Empty)
            {
                Microsoft.Win32.SaveFileDialog speichernDialog = new Microsoft.Win32.SaveFileDialog();
                //die Eigenschaften für den Dialog setzen
                speichernDialog.Filter = "RTF-Dateien|*.rtf";
                speichernDialog.FileName = string.Empty;
                //wurde der Dialog über Speichern geschlossen?
                //dann die Datei unter dem angegebenen Namen speichern
                if (speichernDialog.ShowDialog() == true)
                    Speichern(speichernDialog.FileName);
            }
            //wenn der Dateiname nicht leer ist, direkt speichern
            else
                Speichern(dateiname);
        }

        public MainWindow()
        {
            InitializeComponent();
            zaehler = 1;
        }

        private void RibbonWindow_Loaded(object sender, RoutedEventArgs e)
        {
            NeuesDokument();
        }

        private void menuNeu_Click(object sender, RoutedEventArgs e)
        {
            NeuesDokument();
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            DateiSpeichern();
        }

        private void menuSpeichern_Click(object sender, RoutedEventArgs e)
        {
            DateiSpeichern();
        }

        private void menuSpeichernUnter_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog speichernDialog = new Microsoft.Win32.SaveFileDialog();
            //die Eigenschaften für den Dialog setzen
            speichernDialog.Filter = "RTF-Dateien|*.rtf";
            speichernDialog.FileName = string.Empty;
            //wurde der Dialog über OK geschlossen?
            //dann die Datei unter dem angegebenen Namen speichern
            if (speichernDialog.ShowDialog() == true)
                Speichern(speichernDialog.FileName);
        }

        private void menuOeffnen_Click(object sender, RoutedEventArgs e)
        {
            //wenn nicht gespeicherte Änderungen vorliegen
            if (geaendert == true)
            {
                //Meldung mit Ja und Nein erzeugen und überprüfen, ob Ja angeklickt wurde
                if (MessageBox.Show("Wollen Sie die Änderungen speichern?", "Abfrage", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    DateiSpeichern();
            }
            //den Öffnen-Dialog erzeugen
            Microsoft.Win32.OpenFileDialog oeffnenDialog = new Microsoft.Win32.OpenFileDialog();
            //den Filter setzen
            oeffnenDialog.Filter = "RTF-Dateien|*.rtf";
            oeffnenDialog.FileName = string.Empty;
            //wurde der Dialog über OK geschlossen?
            //dann die Datei laden
            if (oeffnenDialog.ShowDialog() == true)
            {
                //einen Stream erzeugen
                //die Datei wird dabei geöffnet
                using (System.IO.FileStream dateiStream = new System.IO.FileStream(oeffnenDialog.FileName, System.IO.FileMode.Open))
                {
                    //den Bereich für das Speichern festlegen
                    //wir nehmen den gesamten Inhalt der RichTextBox
                    TextRange textBereich = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                    //nun über den Stream im RTF-Format laden
                    textBereich.Load(dateiStream, DataFormats.Rtf);
                }
                //geaendert auf false setzen, da es erst einmal keine Änderungen gibt
                geaendert = false;
                //den Namen setzen
                dateiname = oeffnenDialog.FileName;
                this.Title = dateiname;
            }
        }

        private void richTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //es gibt Änderungen
            geaendert = true;
        }

        private void RibbonWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //wenn nicht gespeicherte Änderungen vorliegen
            if (geaendert == true)
            {
                //Meldung mit Ja, Nein und Abbrechen erzeugen und auswerten
                switch (MessageBox.Show("Wollen Sie die Änderungen speichern?", "Abfrage", MessageBoxButton.YesNoCancel, MessageBoxImage.Question))
                {
                    case MessageBoxResult.Yes:
                        //das Dokument speichern
                        DateiSpeichern();
                        break;
                    case MessageBoxResult.Cancel:
                        //Abbrechen
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
