using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace Editor
{
    public partial class Form1 : Form
    {
        int zaehler;
        string dateiname;
        string backupdatei = Application.StartupPath + "\\backup.bak";

        void NeuesDokument()
        {
            richTextBox1.Clear();
            this.Text = "ohnename" + zaehler;
            zaehler++;
            dateiname = string.Empty;
        }

        void Speichern(string name)
        {
            dateiname = name;

            this.Text = dateiname;

            richTextBox1.SaveFile(dateiname);
            richTextBox1.Modified = false;
        }
        public Form1()
        {
            InitializeComponent();
            zaehler = 1;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name;
            name = saveFileDialog1.FileName;
            Speichern(name);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            NeuesDokument();
        }

        private void neuToolStripButton_Click(object sender, EventArgs e)
        {
            NeuesDokument();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeuesDokument();
        }

        private void DateiSpeichern(object sender, EventArgs e)
        {
            if (dateiname == string.Empty)
                saveFileDialog1.ShowDialog();
            else
                Speichern(dateiname);
        }

        private void speichernunterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void DateiLaden(object sender, EventArgs e)
        {
            if (richTextBox1.Modified == true)
            {
                if (MessageBox.Show("Wollen Sie die Änderungen speichern?", "Abfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    DateiSpeichern(sender, e);
            }
                openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            dateiname = openFileDialog1.FileName;

            if (File.Exists(dateiname))
            {
                this.Text = dateiname;
                richTextBox1.LoadFile(dateiname);
                System.IO.File.Copy(dateiname, backupdatei, true);
                richTextBox1.Modified = false;
                if (File.Exists(backupdatei) == false)
                {
                    MessageBox.Show("Die Sicherungskopie ist nicht vorhanden", "Fehler");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Die Datei ist nicht vorhanden.", "Fehler");
                return;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (richTextBox1.Modified == true)
            {
                switch (MessageBox.Show("Wollen Sie die Änderungen speichern?", "Abfrage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DateiSpeichern(sender, e);
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void fettToolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void kursivToolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void unterstrichenToolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void zeichenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void zentriertToolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void linksToolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rechtsToolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ausschneidenToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopierenToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void einfügenToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ausschneidenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void einfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void rückgängigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
                richTextBox1.Redo();
        }

        private void wiederholenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
                richTextBox1.Undo();
        }

        private void alleauswählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dateiname != string.Empty)
            {
                using (RegistryKey regSchluessel = Registry.CurrentUser.CreateSubKey("Software\\Minitext"))
                {
                    regSchluessel.SetValue("Datei", dateiname);
                }
            }
        }

        private void letzteDatei_Click(object sender, EventArgs e)
        {
            string name;

            name = ((ToolStripMenuItem)(sender)).Text;

            name = name.Remove(0, 5);

            if (System.IO.File.Exists(name))
            {
                dateiname = name;

                this.Text = dateiname;

                richTextBox1.LoadFile(dateiname);

                richTextBox1.Modified = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripItem menuEintrag;

            string name;

            name = string.Empty;

            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey("Software\\Minitext"))
            {
                if (regSchluessel != null)
                {
                    name = Convert.ToString(regSchluessel.GetValue("Datei"));

                    menuEintrag = new ToolStripMenuItem("&1 - " + name, null, new EventHandler(this.letzteDatei_Click));

                    dateiToolStripMenuItem.DropDownItems.Insert(dateiToolStripMenuItem.DropDownItems.Count - 1, menuEintrag);

                    dateiToolStripMenuItem.DropDownItems.Insert(dateiToolStripMenuItem.DropDownItems.Count - 1, new ToolStripSeparator());
                }
            }
        }
    }
}
