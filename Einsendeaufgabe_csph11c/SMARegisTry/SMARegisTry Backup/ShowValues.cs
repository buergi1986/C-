using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace SMARegisTry_Backup
{
    public partial class ShowValues : Form
    {
        string regKeyToSubScan = "", contents = "";
        // The main registry key we'll be scanning
        TreeNode registryNode;

        // Reference to the main window so we can add selected keys to the parent
        smartRegistryMain mainWindow = null;

        public ShowValues()
        {
            InitializeComponent();
            richTextBox1.Padding = new System.Windows.Forms.Padding(5);
        }

        public ShowValues(string text, string key, smartRegistryMain f)
        {
            InitializeComponent();
            richTextBox1.Text = text;
            regKeyToSubScan = key;
            mainWindow = f;
        }

        public ShowValues(RegistryKey key, smartRegistryMain f)
        {
            InitializeComponent();
            registryNode = new TreeNode(key.Name, 0, 1);
            GetSubKeys(key, registryNode);
            registryTreeSubView.Nodes.Add(registryNode);
            registryTreeSubView.SelectedNode = registryNode;
            mainWindow = f;
        }


        private void ShowValues_Load(object sender, EventArgs e)
        {
            //ReadSubRegistry();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetSubKeys(RegistryKey SubKey, TreeNode parent)
        {
            try
            {
                if (SubKey.GetSubKeyNames() != null && SubKey.SubKeyCount > 0)
                {
                    foreach (string sub in SubKey.GetSubKeyNames())
                    {
                        TreeNode node = new TreeNode(sub, 0, 1);
                        if (SubKey.OpenSubKey(sub) != null)
                        {
                            GetSubKeys(SubKey.OpenSubKey(sub), node); // By recalling itself it makes sure it get all the subkey names
                        }
                        parent.Nodes.Add(node);
                    }
                }
            }
            catch(Exception e)
            {
                string errMess = "Unable to open the following subkey: " + SubKey.ToString() + " exception: " + e.ToString();
                if (mainWindow.showWarnings == 1)
                {
                    // Debug why you're getting an error
                    MessageBox.Show(errMess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Add to log file...
                if (File.Exists(mainWindow.logFile))
                {
                    using (StreamWriter w = File.AppendText(mainWindow.logFile))
                    {
                        w.WriteLine("-------------------------------------------------------------------------------");
                        w.WriteLine("The following Registry key could NOT be accessed during the sub-registry scan invoked by \"View Key Contents\" at: " + DateTime.Now);
                        w.WriteLine("-------------------------------------------------------------------------------");
                        w.Write(errMess);
                        w.Write("\n\n");
                    }
                }
            }
        }

        private void getKeyContents(RegistryKey key)
        {
            contents = "";

            // Key values
            string[] keyValues = key.GetValueNames();
            if (keyValues.Length > 0)
            {
                int count = 0;
                foreach (string valName in keyValues)
                {
                    if (valName != "")
                    {
                        count++;
                        if (count == 1)
                        {
                            contents += "Key Values: \n";
                        }
                        try
                        {
                            string valueInKey = key.GetValue(valName).ToString();
                            contents += "\t\u2022 " + valName;
                            if (valueInKey != "")
                            {
                                contents += " with a value of:  " + valueInKey;
                            }
                            contents += "\n";
                        }
                        catch
                        {
                            string errMess = "Unable to open the following registry key for scanning: " + key;
                            if (mainWindow.showWarnings == 1)
                            {
                                MessageBox.Show(errMess, "Unable To Access Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            // Add to log file...
                            if (File.Exists(mainWindow.logFile))
                            {
                                using (StreamWriter w = File.AppendText(mainWindow.logFile))
                                {
                                    w.WriteLine("-------------------------------------------------------------------------------");
                                    w.WriteLine("The following Registry key could NOT be accessed during the sub-registry scan invoked by \"View Key Contents\" at: " + DateTime.Now);
                                    w.WriteLine("-------------------------------------------------------------------------------");
                                    w.Write(errMess);
                                    w.Write("\n\n");
                                }
                            }
                            
                        }
                    }
                }
            }

            // Additional keys
            string[] keyContents = key.GetSubKeyNames();
            if (keyContents.Length > 0)
            {
                if (contents == "")
                {
                    contents += "Additional Keys:\n";
                }
                else
                {
                    contents += "\nAdditional Keys:\n";
                }
                foreach (string subkey_name in keyContents)
                {
                    try
                    {
                        contents += "\t\u2022 " + subkey_name + "\n";
                    }
                    catch
                    {
                        // Add to log file...
                        if (File.Exists(mainWindow.logFile))
                        {
                            string errMess = "Unable to open the following registry key for scanning: " + key;
                            using (StreamWriter w = File.AppendText(mainWindow.logFile))
                            {
                                w.WriteLine("-------------------------------------------------------------------------------");
                                w.WriteLine("The following Registry key could NOT be accessed during the sub-registry scan invoked by \"View Key Contents\" at: " + DateTime.Now);
                                w.WriteLine("-------------------------------------------------------------------------------");
                                w.Write(errMess);
                                w.Write("\n\n");
                            }
                        }
                    }
                }
            }

            // Set contents
            richTextBox1.Text = contents;
        }

        private void registryTreeSubView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            scanKey();
        }

        public void scanKey()
        {
            if (registryTreeSubView.SelectedNode != null)
            {
                contents = "";
                string keyToView = registryTreeSubView.SelectedNode.FullPath;
                string toSwitch = keyToView.Substring(0, keyToView.IndexOf("\\"));
                string subkey = keyToView.Substring(keyToView.IndexOf("\\") + 1);
                //MessageBox.Show("I got the following " + toSwitch);
                // MessageBox.Show(subkey);
                Microsoft.Win32.RegistryKey key;
                switch (toSwitch)
                {
                    case "HKEY_LOCAL_MACHINE":
                        key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(subkey);
                        getKeyContents(key);
                        break;
                    case "HKEY_CLASSES_ROOT":
                        key = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(subkey);
                        getKeyContents(key);
                        break;
                    case "HKEY_CURRENT_USER":
                        key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subkey);
                        getKeyContents(key);
                        break;
                    case "HKEY_USERS":
                        key = Microsoft.Win32.Registry.Users.OpenSubKey(subkey);
                        getKeyContents(key);
                        break;
                    case "HKEY_CURRENT_CONFIG":
                        key = Microsoft.Win32.Registry.CurrentConfig.OpenSubKey(subkey);
                        getKeyContents(key);
                        break;
                }
            }
        }

        public void addSubKey_Click(object sender, EventArgs e)
        {
            if (registryTreeSubView.SelectedNode != null)
            {
                string keyToSave = registryTreeSubView.SelectedNode.FullPath;
                if (keyToSave != "" & keyToSave != null){
                    if (mainWindow.keysToBackup.Items.IndexOf(keyToSave) == -1)
                    {
                        mainWindow.keysToBackup.Items.Add(keyToSave);
                    }
                }
            }
        }
    }
}
