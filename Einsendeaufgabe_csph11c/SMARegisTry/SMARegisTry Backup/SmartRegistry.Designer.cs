namespace SMARegisTry_Backup
{
    partial class smartRegistryMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(smartRegistryMain));
            this.registryTreeView = new System.Windows.Forms.TreeView();
            this.AddKeyToList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.keysToBackup = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.removeFromList = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.SaveListButton = new System.Windows.Forms.Button();
            this.LoadListButton = new System.Windows.Forms.Button();
            this.restoreKeysButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ViewContentsButton = new System.Windows.Forms.Button();
            this.restoreIndividualButton = new System.Windows.Forms.Button();
            this.manual = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registryTreeView
            // 
            this.registryTreeView.Location = new System.Drawing.Point(21, 192);
            this.registryTreeView.Name = "registryTreeView";
            this.registryTreeView.Size = new System.Drawing.Size(282, 238);
            this.registryTreeView.TabIndex = 0;
            // 
            // AddKeyToList
            // 
            this.AddKeyToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddKeyToList.ForeColor = System.Drawing.Color.Green;
            this.AddKeyToList.Location = new System.Drawing.Point(21, 446);
            this.AddKeyToList.Name = "AddKeyToList";
            this.AddKeyToList.Size = new System.Drawing.Size(282, 51);
            this.AddKeyToList.TabIndex = 1;
            this.AddKeyToList.Text = "&Add Key to List";
            this.AddKeyToList.UseVisualStyleBackColor = true;
            this.AddKeyToList.Click += new System.EventHandler(this.AddKeyToList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(21, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Keys to Backup:";
            // 
            // keysToBackup
            // 
            this.keysToBackup.FormattingEnabled = true;
            this.keysToBackup.HorizontalScrollbar = true;
            this.keysToBackup.Location = new System.Drawing.Point(389, 192);
            this.keysToBackup.Name = "keysToBackup";
            this.keysToBackup.ScrollAlwaysVisible = true;
            this.keysToBackup.Size = new System.Drawing.Size(282, 238);
            this.keysToBackup.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(385, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Backup These Keys:";
            // 
            // removeFromList
            // 
            this.removeFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromList.ForeColor = System.Drawing.Color.Green;
            this.removeFromList.Location = new System.Drawing.Point(389, 446);
            this.removeFromList.Name = "removeFromList";
            this.removeFromList.Size = new System.Drawing.Size(125, 51);
            this.removeFromList.TabIndex = 6;
            this.removeFromList.Text = "&Remove";
            this.removeFromList.UseVisualStyleBackColor = true;
            this.removeFromList.Click += new System.EventHandler(this.removeFromList_Click);
            // 
            // BackupButton
            // 
            this.BackupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupButton.ForeColor = System.Drawing.Color.Green;
            this.BackupButton.Location = new System.Drawing.Point(389, 564);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(282, 51);
            this.BackupButton.TabIndex = 7;
            this.BackupButton.Text = "&Backup Keys Now";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // SaveListButton
            // 
            this.SaveListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveListButton.ForeColor = System.Drawing.Color.Green;
            this.SaveListButton.Location = new System.Drawing.Point(389, 503);
            this.SaveListButton.Name = "SaveListButton";
            this.SaveListButton.Size = new System.Drawing.Size(125, 51);
            this.SaveListButton.TabIndex = 8;
            this.SaveListButton.Text = "&Save List";
            this.SaveListButton.UseVisualStyleBackColor = true;
            this.SaveListButton.Click += new System.EventHandler(this.SaveListButton_Click);
            // 
            // LoadListButton
            // 
            this.LoadListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadListButton.ForeColor = System.Drawing.Color.Green;
            this.LoadListButton.Location = new System.Drawing.Point(541, 503);
            this.LoadListButton.Name = "LoadListButton";
            this.LoadListButton.Size = new System.Drawing.Size(130, 51);
            this.LoadListButton.TabIndex = 9;
            this.LoadListButton.Text = "&Load List";
            this.LoadListButton.UseVisualStyleBackColor = true;
            this.LoadListButton.Click += new System.EventHandler(this.LoadListButton_Click);
            // 
            // restoreKeysButton
            // 
            this.restoreKeysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreKeysButton.ForeColor = System.Drawing.Color.Green;
            this.restoreKeysButton.Location = new System.Drawing.Point(389, 621);
            this.restoreKeysButton.Name = "restoreKeysButton";
            this.restoreKeysButton.Size = new System.Drawing.Size(282, 51);
            this.restoreKeysButton.TabIndex = 11;
            this.restoreKeysButton.Text = "R&estore All Keys From Directory to Registry";
            this.restoreKeysButton.UseVisualStyleBackColor = true;
            this.restoreKeysButton.Click += new System.EventHandler(this.restoreKeysButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveListToolStripMenuItem,
            this.openListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveListToolStripMenuItem
            // 
            this.saveListToolStripMenuItem.Name = "saveListToolStripMenuItem";
            this.saveListToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveListToolStripMenuItem.Text = "&Save List";
            this.saveListToolStripMenuItem.Click += new System.EventHandler(this.saveListToolStripMenuItem_Click);
            // 
            // openListToolStripMenuItem
            // 
            this.openListToolStripMenuItem.Name = "openListToolStripMenuItem";
            this.openListToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openListToolStripMenuItem.Text = "&Open List";
            this.openListToolStripMenuItem.Click += new System.EventHandler(this.openListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AutoUpgradeEnabled = false;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AutoUpgradeEnabled = false;
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // ViewContentsButton
            // 
            this.ViewContentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewContentsButton.ForeColor = System.Drawing.Color.Green;
            this.ViewContentsButton.Location = new System.Drawing.Point(21, 503);
            this.ViewContentsButton.Name = "ViewContentsButton";
            this.ViewContentsButton.Size = new System.Drawing.Size(282, 51);
            this.ViewContentsButton.TabIndex = 13;
            this.ViewContentsButton.Text = "&View Key Contents";
            this.ViewContentsButton.UseVisualStyleBackColor = true;
            this.ViewContentsButton.Click += new System.EventHandler(this.ViewContentsButton_Click);
            // 
            // restoreIndividualButton
            // 
            this.restoreIndividualButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreIndividualButton.ForeColor = System.Drawing.Color.Green;
            this.restoreIndividualButton.Location = new System.Drawing.Point(21, 621);
            this.restoreIndividualButton.Name = "restoreIndividualButton";
            this.restoreIndividualButton.Size = new System.Drawing.Size(282, 51);
            this.restoreIndividualButton.TabIndex = 14;
            this.restoreIndividualButton.Text = "Restore &Individual Key to Registry";
            this.restoreIndividualButton.UseVisualStyleBackColor = true;
            this.restoreIndividualButton.Click += new System.EventHandler(this.restoreIndividualButton_Click);
            // 
            // manual
            // 
            this.manual.Location = new System.Drawing.Point(25, 566);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(278, 20);
            this.manual.TabIndex = 15;
            this.manual.Text = "Example:  HKEY_CURRENT_USER\\SOFTWARE";
            this.manual.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manual_MouseClick);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(171, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add &Manual Key Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::SMARegisTry_Backup.Properties.Resources.smart_registry_backup_icon;
            this.pictureBox1.Location = new System.Drawing.Point(21, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(103, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "SMARegisTry Backup";
            // 
            // removeAllButton
            // 
            this.removeAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAllButton.ForeColor = System.Drawing.Color.Green;
            this.removeAllButton.Location = new System.Drawing.Point(541, 446);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(130, 51);
            this.removeAllButton.TabIndex = 19;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = true;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 678);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 173);
            this.listBox1.TabIndex = 20;
            // 
            // smartRegistryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 861);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.restoreIndividualButton);
            this.Controls.Add(this.ViewContentsButton);
            this.Controls.Add(this.restoreKeysButton);
            this.Controls.Add(this.LoadListButton);
            this.Controls.Add(this.SaveListButton);
            this.Controls.Add(this.BackupButton);
            this.Controls.Add(this.removeFromList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keysToBackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddKeyToList);
            this.Controls.Add(this.registryTreeView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(704, 900);
            this.Name = "smartRegistryMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMARegisTry Backup";
            this.Load += new System.EventHandler(this.smartRegistryMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView registryTreeView;
        private System.Windows.Forms.Button AddKeyToList;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox keysToBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeFromList;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Button SaveListButton;
        private System.Windows.Forms.Button LoadListButton;
        private System.Windows.Forms.Button restoreKeysButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ViewContentsButton;
        private System.Windows.Forms.Button restoreIndividualButton;
        private System.Windows.Forms.TextBox manual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

