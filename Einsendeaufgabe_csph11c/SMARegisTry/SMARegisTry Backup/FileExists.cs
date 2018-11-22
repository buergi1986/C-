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
    public partial class FileExists : Form
    {
        string action = "", filename = "", finalFileName = "", prefix="";
        public FileExists(string fileName, string key)
        {
            InitializeComponent();
            filename = fileName;
            richTextBox1.Text = "The key you are trying to export " + key + " cannot be saved to " + fileName + " as another key with the same name has already been saved to this reg file!  Please rename this key's filename, overwrite the existing key, or append a prefix to the registry key's filename!";
        }

        private void overWriteButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            action = "overwrite_one";
            this.Close();
        }

        private void overWriteAllButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            action = "overwrite_all";
            this.Close();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            int successInt = 0;
            if (filename.LastIndexOf("\\") != -1)
            {
                string tempFileName = filename.Substring(0, filename.LastIndexOf("\\") + 1);
                // MessageBox.Show(tempFileName + "\n" + filename);
                string newFile = renameFile.Text;
                if (newFile != "")
                {
                    if (newFile.IndexOf("\\") == -1 & newFile.IndexOf("/") == -1 & newFile.IndexOf(".") == -1)
                    {

                        tempFileName += newFile + ".reg";
                        if (File.Exists(tempFileName))
                        {
                            MessageBox.Show("The file exists, please try another name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            successInt = 1;
                            action = tempFileName;

                        }
                        //MessageBox.Show(tempFileName);
                    }
                    else
                    {
                        MessageBox.Show("Please insert only the new file name without any extensions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You cannot leave the new file name blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (successInt == 1)
                {
                    this.Close();
                }
            }
        }
        public string returnAction()
        {
            return action;
        }

        public string returnFileName()
        {
            return finalFileName;
        }

        public string returnPrefix()
        {
            return prefix;
        }

        private void addPrefixSingle_Click(object sender, EventArgs e)
        {
            int successInt = 0;
            if (filename.LastIndexOf("\\") != -1)
            {
                string tempFileName = filename.Substring(0, filename.LastIndexOf("\\") + 1);
                string actualRegFName = filename.Substring(filename.LastIndexOf("\\") + 1);
                if (prefixTextBox.Text != "")
                {
                    prefix = prefixTextBox.Text;
                    if (prefix.IndexOf("\\") == -1 & prefix.IndexOf("/") == -1 & prefix.IndexOf(".") == -1)
                    {
                        tempFileName += prefix;
                        tempFileName += actualRegFName;
                        if (File.Exists(tempFileName))
                        {
                            MessageBox.Show("The file exists with the prefix you entered!\nPlease try another prefix!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            successInt = 1;
                            finalFileName = tempFileName;
                            action = finalFileName;

                        }
                        if (successInt == 1)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your prefix cannot contain any invalid characters!\n Periods and slashes are not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You cannot leave the prefix field blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addPrefixAll_Click(object sender, EventArgs e)
        {
            int successInt = 0;
            if (filename.LastIndexOf("\\") != -1)
            {
                string tempFileName = filename.Substring(0, filename.LastIndexOf("\\") + 1);
                string actualRegFName = filename.Substring(filename.LastIndexOf("\\") + 1);
                //  MessageBox.Show(actualRegFName + "\n" + tempFileName);
                if (prefixTextBox.Text != "")
                {
                    prefix = prefixTextBox.Text;
                    // MessageBox.Show(prefix);
                    if (prefix.IndexOf("\\") == -1 & prefix.IndexOf("/") == -1 & prefix.IndexOf(".") == -1)
                    {
                        tempFileName += prefix;
                        tempFileName += actualRegFName;
                        if (File.Exists(tempFileName))
                        {
                            MessageBox.Show("The file exists with the prefix you entered!\nPlease try another prefix!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            successInt = 1;
                            action = "prefixAll";
                        }
                        if (successInt == 1)
                        {
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Your prefix cannot contain any invalid characters!\n Periods and slashes are not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You cannot leave the prefix field blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
