using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegDemo03
{
    public partial class Form1 : Form
    {
        //ein Array mit Zeichenketten für die Schlüssel
        string[] regSchluesselListe;
        //ein Array mit Zeichenketten für die Einträge
        string[] regEintragListe;

        string key;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //die Schlüssel aus HKEY_CURRENT_USER holen
            regSchluesselListe = Registry.CurrentUser.GetSubKeyNames();
            //und in das erste Listenfeld eintragen
            foreach (string eintrag in regSchluesselListe)
                listBox1.Items.Add(eintrag);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            key = listBox1.Text;


            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey(key))
            {
                regSchluesselListe = regSchluessel.GetSubKeyNames();
            }

            //in das zweite Listenfeld eintragen
            foreach (string eintrag in regSchluesselListe)
            {
                listBox2.Items.Add(eintrag);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            key = listBox1.Text + "\\" + listBox2.Text;

            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey(key))
            {
                regSchluesselListe = regSchluessel.GetSubKeyNames();
            }
            //in das dritte Listenfeld eintragen
            foreach (string eintrag in regSchluesselListe)
                listBox3.Items.Add(eintrag);
        }

        private void buttonEinlesen_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();

            key = listBox1.Text + "\\" + listBox2.Text + "\\" + listBox3.Text;

            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey(key))
            {
                //die Einträge lesen
                regEintragListe = regSchluessel.GetValueNames();
                //die Namen und die Werte in das dritte Listenfeld schreiben
                foreach (string eintrag in regEintragListe)
                    listBox4.Items.Add(eintrag + " = " + Convert.ToString(regSchluessel.GetValue(eintrag)));
            }
        }
    }
}
