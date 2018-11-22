using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SMARegisTry_Backup
{
    public partial class Options : Form
    {
        string listPath = "", keyPath = "";
        public Options()
        {
            InitializeComponent();
        }

        private void browseList_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != "")
                {
                    listPath = folderBrowserDialog1.SelectedPath;
                }
                if (listPath != "")
                {
                    listBox.Text = listPath;
                }
            }
        }

        private void browseKey_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != "")
                {
                    keyPath = folderBrowserDialog1.SelectedPath;
                }
                if (keyPath != "")
                {
                    keyBox.Text = keyPath;
                }
            }
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory().ToString() + @"\\config.txt"))
            {
                File.Delete(Directory.GetCurrentDirectory().ToString() + @"\\config.txt");
            }
            // Check set options and get ready to write them out!

    
            using (StreamWriter outfile = new StreamWriter(Directory.GetCurrentDirectory().ToString() + @"\\config.txt"))
            {
                    if (listBox.Text != "")
                    {
                        outfile.Write(listBox.Text + ",");
                    }else{
                        outfile.Write(",");
                    }

                    if (keyBox.Text != "")
                    {
                        outfile.Write(keyBox.Text + ",");
                    }
                    else
                    {
                        outfile.Write(",");
                    }

                    if (ignoreRegWarnings.Checked)
                    {
                        outfile.Write("1");
                    }
                    else
                    {
                        outfile.Write("0");
                    }
                    outfile.Close();
            }
            this.Close();

        }

        private void Options_Load(object sender, EventArgs e)
        {
            getOptions();
        }

        private void getOptions()
        {
            string configString = "";
            // Reading Saved Options:
            if (File.Exists(Directory.GetCurrentDirectory().ToString() + @"\\config.txt"))
            {
                using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory().ToString() + @"\\config.txt"))
                {
                    configString = sr.ReadToEnd().ToString();
                    sr.Close();
                }
                if (configString != "" & configString.IndexOf(',') != -1)
                {
                    string[] settings;
                    settings = configString.Split(',');
                    if (settings.Length == 3)
                    {

                        if (settings[0] != "")
                        {
                            listBox.Text = settings[0];
                        }
                        if (settings[1] != "")
                        {
                            keyBox.Text = settings[1];
                        }
                        if (settings[2] != "")
                        {
                            if (settings[2] == "1")
                            {
                                ignoreRegWarnings.Checked = true;
                            }
                            else
                            {
                                ignoreRegWarnings.Checked = false;
                            }
                        }
                    }
                    else
                    {
                        File.Delete(Directory.GetCurrentDirectory().ToString() + @"\\config.txt");
                        MessageBox.Show("There's a problem with the configuration file.  It has been deleted.  Please recreate your settings!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Text = "";
            keyBox.Text = "";
        }
    }
}
