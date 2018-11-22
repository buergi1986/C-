namespace bildbetrachter_ueben
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEinzel = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonOeffnen = new System.Windows.Forms.Button();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxNeuesFenster = new System.Windows.Forms.CheckBox();
            this.checkBoxoptGros = new System.Windows.Forms.CheckBox();
            this.tabPageSchau = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAuswaehlen = new System.Windows.Forms.Button();
            this.buttonStarten = new System.Windows.Forms.Button();
            this.buttonBeenden1 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPageEinzel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageSchau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEinzel);
            this.tabControl1.Controls.Add(this.tabPageSchau);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 236);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEinzel
            // 
            this.tabPageEinzel.Controls.Add(this.pictureBox1);
            this.tabPageEinzel.Controls.Add(this.buttonBeenden);
            this.tabPageEinzel.Controls.Add(this.buttonOeffnen);
            this.tabPageEinzel.Controls.Add(this.buttonAnzeigen);
            this.tabPageEinzel.Controls.Add(this.textBox1);
            this.tabPageEinzel.Controls.Add(this.checkBoxNeuesFenster);
            this.tabPageEinzel.Controls.Add(this.checkBoxoptGros);
            this.tabPageEinzel.Location = new System.Drawing.Point(4, 22);
            this.tabPageEinzel.Name = "tabPageEinzel";
            this.tabPageEinzel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEinzel.Size = new System.Drawing.Size(251, 210);
            this.tabPageEinzel.TabIndex = 0;
            this.tabPageEinzel.Text = "Einzelbild";
            this.tabPageEinzel.UseVisualStyleBackColor = true;
            this.tabPageEinzel.Click += new System.EventHandler(this.tabPageEinzel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 7);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(120, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.Location = new System.Drawing.Point(170, 65);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 5;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonOeffnen
            // 
            this.buttonOeffnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOeffnen.Location = new System.Drawing.Point(170, 36);
            this.buttonOeffnen.Name = "buttonOeffnen";
            this.buttonOeffnen.Size = new System.Drawing.Size(75, 23);
            this.buttonOeffnen.TabIndex = 0;
            this.buttonOeffnen.Text = "Öffnen";
            this.buttonOeffnen.UseVisualStyleBackColor = true;
            this.buttonOeffnen.Click += new System.EventHandler(this.buttonOeffnen_Click);
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnzeigen.Location = new System.Drawing.Point(170, 7);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.buttonAnzeigen.TabIndex = 1;
            this.buttonAnzeigen.Text = "Anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(7, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 4;
            // 
            // checkBoxNeuesFenster
            // 
            this.checkBoxNeuesFenster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNeuesFenster.AutoSize = true;
            this.checkBoxNeuesFenster.Location = new System.Drawing.Point(116, 187);
            this.checkBoxNeuesFenster.Name = "checkBoxNeuesFenster";
            this.checkBoxNeuesFenster.Size = new System.Drawing.Size(95, 17);
            this.checkBoxNeuesFenster.TabIndex = 3;
            this.checkBoxNeuesFenster.Text = "Neues Fenster";
            this.checkBoxNeuesFenster.UseVisualStyleBackColor = true;
            // 
            // checkBoxoptGros
            // 
            this.checkBoxoptGros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxoptGros.AutoSize = true;
            this.checkBoxoptGros.Location = new System.Drawing.Point(7, 187);
            this.checkBoxoptGros.Name = "checkBoxoptGros";
            this.checkBoxoptGros.Size = new System.Drawing.Size(103, 17);
            this.checkBoxoptGros.TabIndex = 2;
            this.checkBoxoptGros.Text = "Optimale Grösse";
            this.checkBoxoptGros.UseVisualStyleBackColor = true;
            this.checkBoxoptGros.CheckedChanged += new System.EventHandler(this.checkBoxoptGros_CheckedChanged);
            // 
            // tabPageSchau
            // 
            this.tabPageSchau.Controls.Add(this.buttonBeenden1);
            this.tabPageSchau.Controls.Add(this.buttonStarten);
            this.tabPageSchau.Controls.Add(this.buttonAuswaehlen);
            this.tabPageSchau.Controls.Add(this.listBox1);
            this.tabPageSchau.Location = new System.Drawing.Point(4, 22);
            this.tabPageSchau.Name = "tabPageSchau";
            this.tabPageSchau.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchau.Size = new System.Drawing.Size(251, 210);
            this.tabPageSchau.TabIndex = 1;
            this.tabPageSchau.Text = "Bilderschau";
            this.tabPageSchau.UseVisualStyleBackColor = true;
            this.tabPageSchau.Click += new System.EventHandler(this.tabPageSchau_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Grafikdateien|*.bmp;*.gif;*.jpg;*.png;*.tif;*.wmf";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 121);
            this.listBox1.TabIndex = 0;
            // 
            // buttonAuswaehlen
            // 
            this.buttonAuswaehlen.Location = new System.Drawing.Point(170, 7);
            this.buttonAuswaehlen.Name = "buttonAuswaehlen";
            this.buttonAuswaehlen.Size = new System.Drawing.Size(75, 23);
            this.buttonAuswaehlen.TabIndex = 1;
            this.buttonAuswaehlen.Text = "Auswählen";
            this.buttonAuswaehlen.UseVisualStyleBackColor = true;
            this.buttonAuswaehlen.Click += new System.EventHandler(this.buttonAuswaehlen_Click);
            // 
            // buttonStarten
            // 
            this.buttonStarten.Location = new System.Drawing.Point(170, 36);
            this.buttonStarten.Name = "buttonStarten";
            this.buttonStarten.Size = new System.Drawing.Size(75, 23);
            this.buttonStarten.TabIndex = 2;
            this.buttonStarten.Text = "Starten";
            this.buttonStarten.UseVisualStyleBackColor = true;
            this.buttonStarten.Click += new System.EventHandler(this.buttonStarten_Click);
            // 
            // buttonBeenden1
            // 
            this.buttonBeenden1.Location = new System.Drawing.Point(170, 65);
            this.buttonBeenden1.Name = "buttonBeenden1";
            this.buttonBeenden1.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden1.TabIndex = 3;
            this.buttonBeenden1.Text = "Beenden";
            this.buttonBeenden1.UseVisualStyleBackColor = true;
            this.buttonBeenden1.Click += new System.EventHandler(this.buttonBeenden1_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Multiselect = true;
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bildbetrachter";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEinzel.ResumeLayout(false);
            this.tabPageEinzel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageSchau.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEinzel;
        private System.Windows.Forms.TabPage tabPageSchau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonOeffnen;
        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.CheckBox checkBoxNeuesFenster;
        private System.Windows.Forms.CheckBox checkBoxoptGros;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBeenden1;
        private System.Windows.Forms.Button buttonStarten;
        private System.Windows.Forms.Button buttonAuswaehlen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Timer timer1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

