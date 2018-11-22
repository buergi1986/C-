using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bildbetrachter
{
    public partial class Form1 : Form
    {
        private FormMax fensterBilderschau;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOeffnen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            //wenn ein Eintrag im Eingabefeld steht, laden wir das 
            //entsprechende Bild
            if (textBox1.Text != String.Empty)
            {
                //existiert die Datei überhaupt?
                if (System.IO.File.Exists(textBox1.Text))
                    //soll die Datei in einem neuen Fenster 
                    //angezeigt werden?
                    if (checkBoxNeuesFenster.Checked == true)
                    {
                        //das neue Formular anzeigen
                        FormMax neuesFormular = new FormMax();
                        //die Datei laden
                        neuesFormular.BildLaden(textBox1.Text);
                        //das Formular modal anzeigen
                        neuesFormular.ShowDialog();
                    }
                    else
                        //wenn ja, dann laden und anzeigen
                        pictureBox1.Load(textBox1.Text);
                else
                    MessageBox.Show("Die Datei existiert nicht!", "Fehler");
            }
        }

        private void checkBoxOptGroesse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOptGroesse.Checked == true)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //den Namen der ausgewählten Datei in das Eingabefeld schreiben
            textBox1.Text = openFileDialog1.FileName;
            //die eigene Methode buttonAnzeigen_Click() aufrufen
            buttonAnzeigen_Click(sender, e);
        }

        private void buttonAuswaehlen_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            //ein neues Array vom Typ string anlegen und die 
            //markierten Namen kopieren
            string[] dateien = openFileDialog2.FileNames;
            //wenn sich noch Einträge in dem Listenfeld befinden, 
            //löschen wir sie
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();
            //die Namen in das Listenfeld kopieren
            foreach (string datei in dateien)
                listBox1.Items.Add(datei);
        }

        private void buttonStarten_Click(object sender, EventArgs e)
        {
            //befinden sich überhaupt Einträge in der Liste?
            //wenn nicht, erzeugen wir eine Meldung und verlassen 
            //die Methode wieder
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Sie müssen erst Dateien auswählen!", "Fehler");
                return;
            }
            //ist kein Eintrag im Listenfeld markiert?
            //dann den ersten Eintrag markieren
            if (listBox1.SelectedIndex == -1)
                listBox1.SelectedIndex = 0;
            //ein neues Fenster für die Bilderschau erzeugen
            fensterBilderschau = new FormMax();
            //das erste Bild laden
            fensterBilderschau.BildLaden(listBox1.SelectedItem.ToString());
            //den Titel des Formulars auf Bilderschau setzen 
            fensterBilderschau.Text = "Bilderschau";
            //das Systemmenü und das Schließensymbol ausblenden
            fensterBilderschau.ControlBox = false;
            //das Formular anzeigen 
            fensterBilderschau.Show();
            //den Timer starten
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ist der letzte Eintrag in der Liste noch nicht 
            //erreicht?
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
        	{
                //den nächsten Eintrag markieren
                listBox1.SelectedIndex++;
                //und das Bild laden
                fensterBilderschau.BildLaden(listBox1.SelectedItem.ToString());
                //einen Sound aus der Systemsteuerung abspielen
                //hier für den Stern
                System.Media.SystemSounds.Asterisk.Play();
            }
            //beim letzten Bild wieder aufräumen
            else
	        {
                //die Markierungen löschen
                listBox1.SelectedIndex = -1;
                //den Timer anhalten
                timer1.Stop();
                //das Fenster Bilderschau schließen
                fensterBilderschau.Close();
            }
        }

        private void tabPageSchau_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonStarten;
        }

        private void tabPageEinzel_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonAnzeigen;
        }
    }
}
