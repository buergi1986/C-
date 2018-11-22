namespace SMARegisTry_Backup
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.browseList = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.browseKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveSettings = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.ignoreRegWarnings = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // browseList
            // 
            this.browseList.Location = new System.Drawing.Point(205, 71);
            this.browseList.Name = "browseList";
            this.browseList.Size = new System.Drawing.Size(75, 23);
            this.browseList.TabIndex = 0;
            this.browseList.Text = "&Browse";
            this.browseList.UseVisualStyleBackColor = true;
            this.browseList.Click += new System.EventHandler(this.browseList_Click);
            // 
            // listBox
            // 
            this.listBox.Location = new System.Drawing.Point(14, 73);
            this.listBox.Name = "listBox";
            this.listBox.ReadOnly = true;
            this.listBox.Size = new System.Drawing.Size(171, 20);
            this.listBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Default Directory to Save Lists:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default Directory to Save Registry Keys:";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(14, 140);
            this.keyBox.Name = "keyBox";
            this.keyBox.ReadOnly = true;
            this.keyBox.Size = new System.Drawing.Size(171, 20);
            this.keyBox.TabIndex = 4;
            // 
            // browseKey
            // 
            this.browseKey.Location = new System.Drawing.Point(205, 140);
            this.browseKey.Name = "browseKey";
            this.browseKey.Size = new System.Drawing.Size(75, 23);
            this.browseKey.TabIndex = 5;
            this.browseKey.Text = "Br&owse";
            this.browseKey.UseVisualStyleBackColor = true;
            this.browseKey.Click += new System.EventHandler(this.browseKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(113, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Options";
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(185, 219);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(95, 25);
            this.saveSettings.TabIndex = 7;
            this.saveSettings.Text = "&Save Settings";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Delete Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ignoreRegWarnings
            // 
            this.ignoreRegWarnings.AutoSize = true;
            this.ignoreRegWarnings.Location = new System.Drawing.Point(13, 184);
            this.ignoreRegWarnings.Name = "ignoreRegWarnings";
            this.ignoreRegWarnings.Size = new System.Drawing.Size(293, 17);
            this.ignoreRegWarnings.TabIndex = 9;
            this.ignoreRegWarnings.Text = "Do &NOT Show Warnings when Keys Cannot Be Opened";
            this.ignoreRegWarnings.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 256);
            this.Controls.Add(this.ignoreRegWarnings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.browseKey);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.browseList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 290);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseList;
        private System.Windows.Forms.TextBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button browseKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ignoreRegWarnings;
    }
}