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
using System.Security.Principal;

namespace SMARegisTry_Backup
{
    public partial class smartRegistryMain : Form
    {
        // Global variables
        string listPath = "", keyPath = "", actionTakenString = "", successMessages = "", prefix = "", catchErrText = "", argErrText="";
        int promptIfExists = 1, argumentsMode = 0, errArgs = 0;
        public int showWarnings = 1;
        public string logFile = AppDomain.CurrentDomain.BaseDirectory + "\\log.txt";

        public smartRegistryMain()
        {
            InitializeComponent();
        }

        private void ProcessArguments()
        {
            // Create the log file if it doesn't exist for when arguments are passed to the program
            if (!File.Exists(logFile))
            {
                File.Create(logFile);
            }
            else
            {
                // If the log file is over 20MB, rename it to the name + date
                FileInfo fSize = new FileInfo(logFile);
                long s1 = fSize.Length;
                if (s1 >= 20971520)
                {
                    string dForFName = DateTime.Now.ToShortDateString();
                    dForFName = dForFName.Replace(@"/", @"_");
                    string newFileName = Directory.GetCurrentDirectory() + "\\log_" + dForFName + ".txt";
                    File.Move(logFile, newFileName);
                }
            }

            // Get arguments for backup of a list or importing dir with registry files
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length != 0)
            {
                int foundSaveFlag = -1;
                int foundRestoreFlag = -1;
                int k = 0;
                foreach (string a in args)
                {
                    if (a == "-s")
                    {
                        foundSaveFlag = k;
                    }

                    if (a == "-r")
                    {
                        foundRestoreFlag = k;
                    }

                    k++;
                }
                // Add 1 to each position for length
                if (args.Length >= ((foundSaveFlag + 1) + 2) && foundSaveFlag != -1)
                {
                    if (args[foundSaveFlag].ToString() == "-s")
                    {
                        if (!args[foundSaveFlag + 1].ToString().Equals("") && !args[foundSaveFlag + 2].ToString().Equals(""))
                        {
                            string regListFileToBackupNow = args[foundSaveFlag + 1].ToString();
                            string regDirectoryToBackupNow = args[foundSaveFlag + 2].ToString();

                            if (File.Exists(regListFileToBackupNow))
                            {
                                int dirCanBeUsed = 1;
                                if (!Directory.Exists(regDirectoryToBackupNow))
                                {
                                    // The directory doesn't exist, so attempt to create it.
                                    Directory.CreateDirectory(regDirectoryToBackupNow);

                                    // If it still doesn't exist, there was a problem creating this directory.
                                    if (!Directory.Exists(regDirectoryToBackupNow))
                                    {
                                        dirCanBeUsed = 0;
                                    }
                                }

                                if (dirCanBeUsed == 1)
                                {
                                    // List of keys

                                    List<String> regListOfKeys = new List<String>();

                                    // Set arguments mode so we can be silent and close the program without any messages after backup is successful or fails
                                    argumentsMode = 1;

                                    // Read list line by line
                                    string line;
                                    System.IO.StreamReader file = new System.IO.StreamReader(regListFileToBackupNow);
                                    while ((line = file.ReadLine()) != null)
                                    {
                                        if (line != "")
                                        {
                                            if (!regListOfKeys.Contains(line))
                                            {
                                                regListOfKeys.Add(line);
                                            }
                                        }
                                    }
                                    file.Close();

                                    // Set keypath
                                    keyPath = regDirectoryToBackupNow;

                                    // Perform key operations
                                    keyOperations(regListOfKeys);

                                    if (successMessages != "")
                                    {
                                        // Add to log file...
                                        if (File.Exists(logFile))
                                        {
                                            using (StreamWriter w = File.AppendText(logFile))
                                            {
                                                w.WriteLine("-------------------------------------------------------------------------------");
                                                w.WriteLine("The following operations ran at: " + DateTime.Now);
                                                w.WriteLine("-------------------------------------------------------------------------------");
                                                w.Write(successMessages);
                                                w.Write("\n\n");
                                            }
                                        }
                                        successMessages = "";
                                    }

                                }
                                else
                                {
                                    errArgs++;
                                    argErrText += "Registry backup directory " + regDirectoryToBackupNow + " is invalid!\n";
                                }

                            }
                            else
                            {
                                errArgs++;
                                argErrText += "Registry list file " + regListFileToBackupNow + " does not exist!\n";
                            }

                            // Expecting an input file
                            // Run validation (make sure file exists, line starts with an HKEY of some sort)
                            // Call keyOperations to backup list of keys to dir specified

                            // Output errors in commandline arguments to log file
                            if (argErrText != "")
                            {
                                // Add to log file...
                                if (File.Exists(logFile))
                                {
                                    using (StreamWriter w = File.AppendText(logFile))
                                    {
                                        w.WriteLine("-------------------------------------------------------------------------------");
                                        w.WriteLine("Errors were detected in the arguments passed to SMARegisTry Backup at: " + DateTime.Now);
                                        w.WriteLine("-------------------------------------------------------------------------------");
                                        w.Write(argErrText);
                                        w.Write("\n\n");
                                    }
                                }
                                argErrText = "";
                                errArgs = 0;
                            }
                        }
                    }
                }
                // Add one to position for length
                else if (args.Length >= ((foundRestoreFlag + 1) + 1) && foundRestoreFlag != -1)
                {
                    if (args[foundRestoreFlag].ToString() == "-r")
                    {
                        // Restore all registry files from directory specified
                        string regFilesToRestoreDir = args[foundRestoreFlag + 1].ToString();
                        if (regFilesToRestoreDir != "" && Directory.Exists(regFilesToRestoreDir))
                        {
                            // Set arguments mode
                            argumentsMode = 1;

                            // Send the directory with registry files to the scanner method which then also restores each key that was found:
                            getRegFilesInDir(regFilesToRestoreDir);

                            // Add to log file...
                            if (File.Exists(logFile))
                            {
                                using (StreamWriter w = File.AppendText(logFile))
                                {
                                    w.WriteLine("-------------------------------------------------------------------------------");
                                    w.WriteLine("The following operations ran at: " + DateTime.Now);
                                    w.WriteLine("-------------------------------------------------------------------------------");
                                    w.Write(successMessages);
                                    w.Write("\n\n");
                                }
                            }
                            successMessages = "";

                        }
                        else
                        {
                            errArgs++;
                            argErrText += "Registry restore directory of " + regFilesToRestoreDir + " does not exist or is invalid!\n";
                        }

                        // Output errors in commandline arguments to log file
                        if (argErrText != "")
                        {
                            // Add to log file...
                            if (File.Exists(logFile))
                            {
                                using (StreamWriter w = File.AppendText(logFile))
                                {
                                    w.WriteLine("-------------------------------------------------------------------------------");
                                    w.WriteLine("Errors were detected in the arguments passed to SMARegisTry Backup at: " + DateTime.Now);
                                    w.WriteLine("-------------------------------------------------------------------------------");
                                    w.Write(argErrText);
                                    w.Write("\n\n");
                                }
                            }
                            argErrText = "";
                            errArgs = 0;
                        }
                    }
                }

            }

        }

        private void smartRegistryMain_Load(object sender, EventArgs e)
        {
            ProcessArguments();
            if (argumentsMode == 0)
            {
                getSavedSettings();
                ReadRegistry();
            }
            else
            {
                // Close the program after ops have been processed in command arguments mode.
                this.Close();
            }
        }

        private void ReadRegistry()
        {
            //HKEY_CLASSES_ROOT  
            TreeNode rootNode = new TreeNode(Registry.ClassesRoot.Name, 0, 1);
            string[] rootSubKeys = Registry.ClassesRoot.GetSubKeyNames();
            foreach (string key in rootSubKeys)
            {
                try
                {
                    TreeNode node = new TreeNode(key, 0, 1);
                    string[] subKeys = Registry.ClassesRoot.OpenSubKey(key).GetSubKeyNames();

                    foreach (string subKeysKey in subKeys)
                    {
                        node.Nodes.Add(subKeysKey, subKeysKey, 0, 1);

                    }
                    rootNode.Nodes.Add(node);
                }
                catch
                {
                    catchErrText += "Unable to open the HKEY_CLASSES_ROOT key of: " + key + "\n";
                }
            }
            registryTreeView.Nodes.Add(rootNode);

            //HKEY_CURRENT_CONFIG  
            TreeNode configNode = new TreeNode(Registry.CurrentConfig.Name, 0, 1);
            string[] configSubKeys = Registry.CurrentConfig.GetSubKeyNames();
            foreach (string key in configSubKeys)
            {
                try
                {
                    TreeNode node = new TreeNode(key, 0, 1);
                    string[] subKeys =
                        Registry.CurrentConfig.OpenSubKey(key).GetSubKeyNames();
                    foreach (string subKeysKey in subKeys)
                        node.Nodes.Add(subKeysKey, subKeysKey, 0, 1);

                    configNode.Nodes.Add(node);
                }
                catch
                {
                    catchErrText += "Unable to open the HKEY_CURRENT_CONFIG key of: " + key + "\n";
                }
            }
            registryTreeView.Nodes.Add(configNode);

            //HKEY_CURRENT_USER  
            TreeNode currentUserNode = new TreeNode(Registry.CurrentUser.Name, 0, 1);
            string[] currentUserSubKeys = Registry.CurrentUser.GetSubKeyNames();
            foreach (string key in currentUserSubKeys)
            {
                try
                {
                    TreeNode node = new TreeNode(key, 0, 1);
                    string[] subKeys = Registry.CurrentUser.OpenSubKey(key).GetSubKeyNames();
                    foreach (string subKeysKey in subKeys)
                        node.Nodes.Add(subKeysKey, subKeysKey, 0, 1);

                    currentUserNode.Nodes.Add(node);
                }
                catch
                {
                    catchErrText += "Unable to open the HKEY_CURRENT_USER key of: " + key + "\n";
                }
            }
            registryTreeView.Nodes.Add(currentUserNode);
            listBox1.Items.Add(currentUserNode);

            //HKEY_LOCAL_MACHINE  
            TreeNode localMachineNode = new TreeNode(Registry.LocalMachine.Name);
            string[] localMachineSubKeys = Registry.LocalMachine.GetSubKeyNames();
            foreach (string key in localMachineSubKeys)
            {
                TreeNode node = new TreeNode(key, 0, 1);
                TreeNode nodeTwo = new TreeNode();
                try
                {
                    string[] subKeys =
                        Registry.LocalMachine.OpenSubKey(key, false).GetSubKeyNames();
                    foreach (string subKeysKey in subKeys)
                    {

                        if (subKeysKey == "Wow6432Node")
                        {
                            nodeTwo = new TreeNode(subKeysKey, 0, 1);
                            //MessageBox.Show(subKeysKey);
                            // MessageBox.Show(key + "\\" + subKeysKey);
                            string[] subKeys64 = Registry.LocalMachine.OpenSubKey(key + "\\" + subKeysKey, false).GetSubKeyNames();
                            foreach (string subKeysKeyKey in subKeys64)
                            {
                                //MessageBox.Show(subKeysKeyKey);
                                nodeTwo.Nodes.Add(subKeysKeyKey, subKeysKeyKey, 0, 1);
                            }
                            node.Nodes.Add(nodeTwo);

                        }
                        else
                        {
                            node.Nodes.Add(subKeysKey, subKeysKey, 0, 1);
                        }
                    }
                }
                catch (Exception)
                {
                    //an exception is thrown if the user has no access to this subkey  
                    //if this is the case, change the icon to show a dimmed folder  
                    node.ImageIndex = 4;
                    node.SelectedImageIndex = 5;

                    // The security key is always locked down
                    if (key != "SECURITY")
                    {
                        catchErrText += "Unable to open the HKEY_LOCAL_MACHINE key of: " + key + "\n";
                    }
                }

                localMachineNode.Nodes.Add(node);

            }
            registryTreeView.Nodes.Add(localMachineNode);

            //HKEY_USERS  
            TreeNode usersNode = new TreeNode(Registry.Users.Name);
            string[] usersSubKeys = Registry.Users.GetSubKeyNames();
            foreach (string key in usersSubKeys)
            {
                TreeNode node = new TreeNode(key, 0, 1);

                try
                {
                    string[] subKeys = Registry.Users.OpenSubKey(key).GetSubKeyNames();
                    foreach (string subKeysKey in subKeys)
                        node.Nodes.Add(subKeysKey, subKeysKey, 0, 1);
                }
                catch (Exception)
                {
                    //an exception is thrown if the user has no access to this subkey  
                    //if this is the case, change the icon to show a dimmed folder  
                    node.ImageIndex = 4;
                    node.SelectedImageIndex = 5;

                    catchErrText += "Unable to open the HKEY_USERS key of: " + key + "\n";

                }

                usersNode.Nodes.Add(node);
            }
            registryTreeView.Nodes.Add(usersNode);

            if (catchErrText != "")
            {
                if (showWarnings == 1)
                {
                    MessageBox.Show(catchErrText + "\nDoes your local security policy allow access to these registry keys?\nTo ensure access to as many keys as possible, run SMARegisTry Backup as an administrator!\nClick on \"OK\" to proceed.", "Unable to Read The Following Registry Keys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Add to log file...
                if (File.Exists(logFile))
                {
                    using (StreamWriter w = File.AppendText(logFile))
                    {
                        w.WriteLine("-------------------------------------------------------------------------------");
                        w.WriteLine("The following Registry keys could NOT be accessed during the registry scan at: " + DateTime.Now);
                        w.WriteLine("-------------------------------------------------------------------------------");
                        w.Write(catchErrText);
                        w.Write("\n\n");
                    }
                }
            }
        }



        private static void GetValuesAndData(RegistryKey registryKey, TreeNode node)
        {
            string[] values = registryKey.GetValueNames();
            foreach (string value in values)
            {
                object data = registryKey.GetValue(value);

                if (data != null)
                {
                    string stringData = data.ToString();

                    //if the data is too long, display the begining only  
                    if (stringData.Length > 50)
                        stringData = stringData.Substring(0, 46) + " ...";

                    //Display the data of the value. The conditional operatore is  
                    //needed because the default value has no name  
                    node.Nodes.Add(value, (value == "" ? "Default" : value) +
                        ": " + stringData, 2, 2);
                }
                else
                {
                    //Display <empty> if the value is empty  
                    node.Nodes.Add(value, (value == "" ? "Default" : value) +
                        ": <empty>", 2, 2);
                }
            }
        }

        private void AddKeyToList_Click(object sender, EventArgs e)
        {
            if (registryTreeView.SelectedNode != null)
            {
                string keyToSave = registryTreeView.SelectedNode.FullPath;
                if (keyToSave != "" & keyToSave != null)
                {
                    //MessageBox.Show(keyToSave);
                    if (keysToBackup.Items.IndexOf(keyToSave) == -1)
                    {
                        keysToBackup.Items.Add(keyToSave);
                    }
                    else
                    {
                        MessageBox.Show("The key " + keyToSave + " has already been added to the list of keys to backup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No registry key has been selected for addition to the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            registryTreeView.Focus();

        }

        private void removeFromList_Click(object sender, EventArgs e)
        {
            int index = keysToBackup.SelectedIndex;
            if (index != -1)
            {
                keysToBackup.Items.RemoveAt(index);
            }
        }

        public void ExportKey(string RegKey, string SavePath)
        {
            string path = "\"" + SavePath + "\"";
            string key = "\"" + RegKey + "\"";

            var proc = new Process();
            try
            {
                proc.StartInfo.FileName = "regedit.exe";
                proc.StartInfo.UseShellExecute = false;
                //MessageBox.Show(path);
                //MessageBox.Show(key);
                proc = Process.Start("regedit.exe", "/e " + path + " " + key + "");

                if (proc != null) proc.WaitForExit();

                successMessages += "Successfully exported " + key + " to " + path + "\n";
            }
            finally
            {
                if (proc != null) proc.Dispose();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void writeToRegistry(string key)
        {
            // Bug Fix for Not Importing Keys Successfully
            // Needs quote incase directory has spaces or other special chars in it.  Stupid Windows.
            string parametersForRun = "/s " + "\"" + key + "\"";
            // Old way of doing it... which doesn't work
            // Process regeditProcess = Process.Start("regedit.exe", parametersForRun);
            Process regeditProcess = new Process();
            regeditProcess.StartInfo.FileName = "regedit.exe";
            regeditProcess.StartInfo.Arguments = parametersForRun;
            regeditProcess.StartInfo.UseShellExecute = true;

            // Debugging
            /*
            regeditProcess.StartInfo.UseShellExecute = false;
            regeditProcess.StartInfo.RedirectStandardError = true;
            regeditProcess.StartInfo.RedirectStandardOutput = true;
            */

            regeditProcess.Start();

            // Debugging
            // string stdout = regeditProcess.StandardOutput.ReadToEnd();
            // string stderr = regeditProcess.StandardError.ReadToEnd();

            regeditProcess.WaitForExit();

            // Debug code
            // MessageBox.Show(regeditProcess.ExitCode.ToString());

            successMessages += "Successfully imported " + key + " into the registry!" + "\n";

        }

        private void SaveListButton_Click(object sender, EventArgs e)
        {
            saveList();
        }

        private void saveList()
        {
            if (keysToBackup.Items.Count != 0)
            {
                //string dateNow = DateTime.Now.ToString("M-d-yyyy");
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text File|*.txt";
                saveFileDialog1.Title = "List";
                if (listPath == "")
                {
                    saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                }
                else
                {
                    saveFileDialog1.InitialDirectory = listPath;
                }
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if (saveFileDialog1.FileName != "")
                    {
                        using (StreamWriter sw = File.CreateText(Path.GetFullPath(saveFileDialog1.FileName)))
                        {
                            foreach (string item in keysToBackup.Items)
                            {
                                sw.WriteLine(item);
                            }
                        }
                        Success savedSuccess = new Success("Your list was successfully saved to " + saveFileDialog1.FileName);
                        savedSuccess.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no items in the list to be saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveList();
        }

        private void LoadListButton_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            int proceed = 1;
            if (keysToBackup.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("There are already items in your list.  Are you sure you want to proceed?  If your current list has not been saved, you will lose all items in the list!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    proceed = 0;
                }
            }
            if (proceed == 1)
            {
                clearRegList();
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                if (listPath == "")
                {
                    openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                }
                else
                {
                    openFileDialog1.InitialDirectory = listPath;
                }
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (openFileDialog1.FileName != "")
                        {
                            if (File.Exists(openFileDialog1.FileName))
                            {
                                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                                {
                                    string line;
                                    // Read and display lines from the file until the end of
                                    // the file is reached.
                                    while ((line = sr.ReadLine()) != null)
                                    {
                                        keysToBackup.Items.Add(line);
                                    }
                                }
                            }
                        }
                        Success openSuccess = new Success("Your list was successfully opened from " + openFileDialog1.FileName);
                        openSuccess.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }
        private void clearRegList()
        {
            keysToBackup.Items.Clear();
        }

        private void getSavedSettings()
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
                            listPath = settings[0];
                        }
                        else
                        {
                            listPath = "";
                        }
                        if (settings[1] != "")
                        {
                            keyPath = settings[1];
                        }
                        else
                        {
                            keyPath = "";
                        }
                        if (settings[2] != "")
                        {
                            if (settings[2] == "1")
                            {
                                // Don't show access warnings
                                showWarnings = 0;
                            }
                            else
                            {
                                // Do show access warnings
                                showWarnings = 1;
                            }
                        }
                    }
                }
            }
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            List<String> keysFromList = new List<String>();
            if (keysToBackup.Items.Count != 0)
            {
                // Build list to send to keyOperations method

                foreach (string itemFromList in keysToBackup.Items)
                {
                    keysFromList.Add(itemFromList);
                }

                if (keyPath != "")
                {
                    keyOperations(keysFromList);
                }
                else
                {
                    MessageBox.Show("Please select the directory where you'd like to save your registry key files.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult result = folderBrowserDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        if (folderBrowserDialog1.SelectedPath != "")
                        {
                            keyPath = folderBrowserDialog1.SelectedPath;
                        }

                        keyOperations(keysFromList);
                    }
                }

                // Show results
                if (successMessages != "")
                {
                    Success backedUp = new Success(successMessages);
                    backedUp.Show();
                    successMessages = "";
                }

            }
            else
            {
                MessageBox.Show("There are no registry keys selected for backup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void restoreKeysButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a directory containing registry keys to import into the registry.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (keyPath == "")
            {
                openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            }
            else
            {
                openFileDialog1.InitialDirectory = keyPath;
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != "")
                {
                    getRegFilesInDir(folderBrowserDialog1.SelectedPath);
                }
            }
            if (successMessages != "")
            {
                Success backedUp = new Success(successMessages);
                backedUp.Show();
                successMessages = "";
            }
        }

        private void getRegFilesInDir(string dirToScan)
        {
            string[] filePaths = Directory.GetFiles(dirToScan, "*.reg");
            foreach (string regFile in filePaths)
            {
                writeToRegistry(regFile);
            }
        }

        private void ViewContentsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (registryTreeView.SelectedNode != null)
                {

                    string keyToView = registryTreeView.SelectedNode.FullPath;
                    if (keyToView.IndexOf("\\") != -1)
                    {
                        string toSwitch = keyToView.Substring(0, keyToView.IndexOf("\\"));
                        string subkey = keyToView.Substring(keyToView.IndexOf("\\") + 1);
                        //MessageBox.Show("I got the following " + toSwitch);
                        // MessageBox.Show(subkey);
                        Microsoft.Win32.RegistryKey key;
                        switch (toSwitch)
                        {
                            case "HKEY_LOCAL_MACHINE":
                                key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(subkey, false);
                                break;
                            case "HKEY_CLASSES_ROOT":
                                key = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(subkey, false);
                                break;
                            case "HKEY_CURRENT_USER":
                                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subkey, false);
                                break;
                            case "HKEY_USERS":
                                key = Microsoft.Win32.Registry.Users.OpenSubKey(subkey, false);
                                break;
                            case "HKEY_CURRENT_CONFIG":
                                key = Microsoft.Win32.Registry.CurrentConfig.OpenSubKey(subkey, false);
                                break;
                            default:
                                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", false);
                                break;
                        }

                        if (key.SubKeyCount == 0)
                        {
                            MessageBox.Show("There are no additional subkeys or values within the selected key!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ShowValues showIt = new ShowValues(key, this);
                            showIt.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please select a subkey first for " + keyToView + " before trying to view more information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No registry key has been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Unable to pull information from this registry key, as permission is denied.\nThis happens with some registry keys.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options setOptions = new Options();
            setOptions.ShowDialog();
            getSavedSettings();
        }

        private void openListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void restoreIndividualButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a registry key to import.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (keyPath == "")
            {
                openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            }
            else
            {
                openFileDialog1.InitialDirectory = keyPath;
            }

            openFileDialog1.Filter = "reg files (*.reg)|*.reg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    if (openFileDialog1.FileName.IndexOf(".") != -1)
                    {
                        if (openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf(".")) == ".reg")
                        {
                            writeToRegistry(openFileDialog1.FileName);
                            if (successMessages != "")
                            {
                                Success backedUp = new Success(successMessages);
                                backedUp.Show();
                                successMessages = "";
                            }
                        }
                    }
                }
            }
        }

        private void manual_MouseClick(object sender, MouseEventArgs e)
        {
            if (manual.Text == @"Example:  HKEY_CURRENT_USER\SOFTWARE")
            {
                manual.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int formatOK = 0;
            string valueT = manual.Text;
            if (valueT != @"Example:  HKEY_CURRENT_USER\SOFTWARE" & valueT != "")
            {
                if (valueT.IndexOf(@"\\") != -1)
                {
                    valueT = valueT.Substring(2);

                }

                //MessageBox.Show(valueT[valueT.Length - 1].ToString());
                if (valueT[valueT.Length - 1] == '\\')
                {
                    valueT = valueT.Substring(0, valueT.LastIndexOf(@"\"));
                }
                string check = "";
                if (valueT.IndexOf(@"\") != -1)
                {
                    check = valueT.Substring(0, valueT.IndexOf(@"\"));
                }
                else
                {
                    check = valueT;
                }
                Microsoft.Win32.RegistryKey key;
                switch (check)
                {
                    case "HKEY_LOCAL_MACHINE":
                        if (valueT.IndexOf(@"\") != -1)
                        {
                            string sCheck = valueT.Substring(valueT.IndexOf(@"\") + 1);
                            //MessageBox.Show(sCheck);
                            key = Registry.LocalMachine.OpenSubKey(sCheck, false);
                            if (key != null)
                            {
                                formatOK = 1;
                            }
                            else
                            {
                                MessageBox.Show("The key you entered does not exist and is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                manual.Text = "";
                            }
                        }
                        else
                        {
                            formatOK = 1;
                        }
                        break;
                    case "HKEY_CLASSES_ROOT":
                        if (valueT.IndexOf(@"\") != -1)
                        {
                            string sCheck = valueT.Substring(valueT.IndexOf(@"\") + 1);
                            key = Registry.ClassesRoot.OpenSubKey(sCheck, false);
                            if (key != null)
                            {
                                formatOK = 1;
                            }
                            else
                            {
                                MessageBox.Show("The key you entered does not exist and is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                manual.Text = "";
                            }
                        }
                        else
                        {
                            formatOK = 1;
                        }
                        break;
                    case "HKEY_CURRENT_USER":
                        if (valueT.IndexOf(@"\") != -1)
                        {
                            string sCheck = valueT.Substring(valueT.IndexOf(@"\") + 1);
                            key = Registry.CurrentUser.OpenSubKey(sCheck, false);
                            if (key != null)
                            {
                                formatOK = 1;
                            }
                            else
                            {
                                MessageBox.Show("The key you entered does not exist and is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                manual.Text = "";
                            }
                        }
                        else
                        {
                            formatOK = 1;
                        }
                        break;
                    case "HKEY_USERS":
                        if (valueT.IndexOf(@"\") != -1)
                        {
                            string sCheck = valueT.Substring(valueT.IndexOf(@"\") + 1);
                            key = Registry.Users.OpenSubKey(sCheck, false);
                            if (key != null)
                            {
                                formatOK = 1;
                            }
                            else
                            {
                                MessageBox.Show("The key you entered does not exist and is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                manual.Text = "";
                            }
                        }
                        else
                        {
                            formatOK = 1;
                        }
                        break;
                    case "HKEY_CURRENT_CONFIG":
                        if (valueT.IndexOf(@"\") != -1)
                        {
                            string sCheck = valueT.Substring(valueT.IndexOf(@"\") + 1);
                            key = Registry.CurrentConfig.OpenSubKey(sCheck, false);
                            if (key != null)
                            {
                                formatOK = 1;
                            }
                            else
                            {
                                MessageBox.Show("The key you entered does not exist and is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                manual.Text = "";
                            }
                        }
                        else
                        {
                            formatOK = 1;
                        }
                        break;

                }
                if (formatOK == 1)
                {
                    if (!keysToBackup.Items.Contains(valueT))
                    {
                        keysToBackup.Items.Add(valueT);
                    }
                    else
                    {
                        MessageBox.Show("The registry key of " + valueT + " already exists within your list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Your custom registry key is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    manual.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Your custom registry key is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                manual.Text = "";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About showAbout = new About();
            showAbout.Show();
        }

        private void keyOperations(List<String> items)
        {
            foreach (string key in items)
            {
                if (!key.Equals(""))
                {
                    int proceedWithKey = 0;
                    if (key.IndexOf("\\") != -1)
                    {
                        // Validate key first
                        string mainHive = key.Substring(0, key.IndexOf("\\"));
                        proceedWithKey = validateKey(mainHive);

                        if (proceedWithKey == 1)
                        {
                            // First six characters should return part of the HKEY
                            // USE THIS ONE AFTER TESTING PREFIX
                            // USE the BELOW string to prevent keys with the same name from conflicting and to better identify where the keys come from
                            string[] separators = key.Split('_');
                            string realPath = keyPath + "\\" + key.Substring(0, 2).ToUpper() + key.Substring(key.IndexOf("_") + 1, 1) + separators[2].Substring(0, 1) + "_" + key.Substring(key.LastIndexOf('\\') + 1) + ".reg";
                            //  MessageBox.Show(key + "\n" + keyPath + "\\" + "\n" + key.Substring(0, 2).ToUpper() + key.Substring(key.IndexOf("_") + 1, 1) + separators[2].Substring(0,1) + "\n" + key.Substring(key.LastIndexOf('\\') + 1) + ".reg", "Info");
                            // OLD
                            // string realPath = keyPath + key.Substring(key.LastIndexOf('\\')) + ".reg";
                            // MessageBox.Show(realPath);
                            backupOps(realPath, key);
                        }

                    }
                    else
                    {
                        // Validate key first
                        proceedWithKey = validateKey(key);

                        if (proceedWithKey == 1)
                        {
                            string realPath = keyPath + "\\" + key + ".reg";

                            // MessageBox.Show(realPath);
                            backupOps(realPath, key);
                        }
                    }
                }
            }
            // Reset vars if used
            prefix = "";
            promptIfExists = 1;


        }

        private int validateKey(string mainHive)
        {
            string[] validHives = { "HKEY_CLASSES_ROOT", "HKEY_CURRENT_CONFIG", "HKEY_CURRENT_USER", "HKEY_LOCAL_MACHINE", "HKEY_USERS" };
            int valid = 0;
            foreach (string hiveName in validHives)
            {
                if (hiveName == mainHive)
                {
                    valid = 1;
                }
            }
            return valid;
        }

        private void backupOps(string realPath, string key)
        {
            // MessageBox.Show(realPath);
            if (File.Exists(realPath))
            {
                if (promptIfExists == 1 && argumentsMode == 0)
                {
                    FileExists prompt = new FileExists(realPath, key);
                    prompt.ShowDialog();
                    actionTakenString = prompt.returnAction();
                    if (actionTakenString != "")
                    {
                        switch (actionTakenString)
                        {
                            // Prefix single and one time renames uses the default method which is just to accept the changed name.  
                            case "overwrite_all":
                                promptIfExists = 0;
                                actionTakenString = "";
                                ExportKey(key, realPath);
                                break;
                            case "overwrite_one":
                                actionTakenString = "";
                                ExportKey(key, realPath);
                                break;
                            case "prefixAll":
                                actionTakenString = "";
                                prefix = prompt.returnPrefix();
                                // MessageBox.Show(prefix);
                                promptIfExists = 0;
                                // MessageBox.Show(realPath);
                                if (prefix != "")
                                {
                                    string tempFileName = realPath.Substring(0, realPath.LastIndexOf("\\") + 1);
                                    string actualRegFName = realPath.Substring(realPath.LastIndexOf("\\") + 1);
                                    realPath = tempFileName + prefix + actualRegFName;
                                    // MessageBox.Show(realPath);
                                    ExportKey(key, realPath);
                                }
                                break;
                            default:
                                realPath = actionTakenString;
                                actionTakenString = "";
                                ExportKey(key, realPath);
                                break;
                        }

                    }
                }
                else
                {
                    if (prefix != "")
                    {
                        string tempFileName = realPath.Substring(0, realPath.LastIndexOf("\\") + 1);
                        string actualRegFName = realPath.Substring(realPath.LastIndexOf("\\") + 1);
                        realPath = tempFileName + prefix + actualRegFName;
                        if (File.Exists(realPath))
                        {
                            File.Delete(realPath);
                        }
                        ExportKey(key, realPath);
                    }
                    else
                    {
                        File.Delete(realPath);
                        ExportKey(key, realPath);
                    }

                }

            }
            else
            {
                ExportKey(key, realPath);
            }
            // MessageBox.Show(realPath);
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            if (keysToBackup.Items.Count > 0)
            {
                DialogResult r = MessageBox.Show("Are you sure you want to delete all added keys from your backup list?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    keysToBackup.Items.Clear();
                }
            }
        }

    }
}
