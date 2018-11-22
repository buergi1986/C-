using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bildbetrachter_ueben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FormMax fensterBilderschau;

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                if (System.IO.File.Exists(textBox1.Text))
                {
                    if (checkBoxNeuesFenster.Checked == true)
                    {
                        FormMax neuesFormular = new FormMax();                        
                        neuesFormular.BildLaden(textBox1.Text);
                        neuesFormular.ShowDialog();
                    }
                    else
                        pictureBox1.Load(textBox1.Text);
                } 
                else
                    MessageBox.Show("Die Datei existiert nicht!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxoptGros_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxoptGros.Checked == true)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOeffnen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
            //button1_Click(sender, e);
            //pictureBox1.Load(openFileDialog1.FileName);
            pictureBox1.Load(textBox1.Text);
        }

        private void buttonAuswaehlen_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            String[] dateien = openFileDialog2.FileNames;
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();
            foreach (string datei in dateien)
                listBox1.Items.Add(datei);
        }

        private void buttonBeenden1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonStarten_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Sie müssen erst Dateien auswählen!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBox1.SelectedIndex == -1)
                listBox1.SelectedIndex = 0;

            fensterBilderschau = new FormMax();            
            fensterBilderschau.Text = "Bilderschau";
            fensterBilderschau.Show();
            fensterBilderschau.ControlBox = false;
            timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex++;
                fensterBilderschau.BildLaden(listBox1.SelectedItem.ToString());
                System.Media.SystemSounds.Asterisk.Play();
            }
            else
            {
                listBox1.SelectedIndex = -1;
                timer1.Stop();
                fensterBilderschau.Close();
            }
        }

        private void tabPageEinzel_Click(object sender, EventArgs e)
        {
            AcceptButton = buttonAnzeigen;
        }

        private void tabPageSchau_Click(object sender, EventArgs e)
        {
            AcceptButton = buttonStarten;
        }
    }
}
