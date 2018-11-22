using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace aufgaben3_cshp12c
{
    public partial class Form1 : Form
    {
        string xmlName;
        string pfand = "E:\\Desktop\\liste.xml";

        public Form1()
        {
            InitializeComponent();
            //xmlName = System.IO.Path.ChangeExtension(Application.ExecutablePath, ".xml");
            xmlName = pfand;
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void buttonUebernehmen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar == Convert.ToChar(Keys.Return))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {

            XmlWriterSettings einstellungen = new XmlWriterSettings();
            einstellungen.Indent = true;
            var list = listBox1.SelectedItems.Cast<string>().ToList();

            if (listBox1.SelectedItem != null)
            {
                XmlWriter xmlSchreiben = XmlWriter.Create(xmlName, einstellungen);

                xmlSchreiben.WriteStartDocument();
                xmlSchreiben.WriteStartElement("eintraege");
                xmlSchreiben.WriteStartElement("eintraeg");
                foreach (string eintraeg in list)
                    xmlSchreiben.WriteElementString("liste", eintraeg);
                xmlSchreiben.WriteEndElement();
                xmlSchreiben.WriteEndElement();
                xmlSchreiben.WriteEndDocument();
                xmlSchreiben.Close();

                MessageBox.Show("Die Liste wird gespeichert");
            }
            else
                MessageBox.Show("Die Liste wird nicht gespeichert, dadurch ist es die leere Liste!");
        }
    }
}
