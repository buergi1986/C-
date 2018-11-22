namespace Bildbetrachter
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
            this.checkBoxNeuesFenster = new System.Windows.Forms.CheckBox();
            this.checkBoxOptGroesse = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonOeffnen = new System.Windows.Forms.Button();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.tabPageSchau = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonBeenden1 = new System.Windows.Forms.Button();
            this.buttonStarten = new System.Windows.Forms.Button();
            this.buttonAuswaehlen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPageEinzel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageSchau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEinzel);
            this.tabControl1.Controls.Add(this.tabPageSchau);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 237);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEinzel
            // 
            this.tabPageEinzel.Controls.Add(this.pictureBox1);
            this.tabPageEinzel.Controls.Add(this.checkBoxNeuesFenster);
            this.tabPageEinzel.Controls.Add(this.checkBoxOptGroesse);
            this.tabPageEinzel.Controls.Add(this.textBox1);
            this.tabPageEinzel.Controls.Add(this.buttonBeenden);
            this.tabPageEinzel.Controls.Add(this.buttonOeffnen);
            this.tabPageEinzel.Controls.Add(this.buttonAnzeigen);
            this.tabPageEinzel.Location = new System.Drawing.Point(4, 22);
            this.tabPageEinzel.Name = "tabPageEinzel";
            this.tabPageEinzel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEinzel.Size = new System.Drawing.Size(252, 211);
            this.tabPageEinzel.TabIndex = 0;
            this.tabPageEinzel.Text = "Einzelbild";
            this.tabPageEinzel.UseVisualStyleBackColor = true;
            this.tabPageEinzel.Enter += new System.EventHandler(this.tabPageEinzel_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 148);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxNeuesFenster
            // 
            this.checkBoxNeuesFenster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxNeuesFenster.AutoSize = true;
            this.checkBoxNeuesFenster.Location = new System.Drawing.Point(111, 189);
            this.checkBoxNeuesFenster.Name = "checkBoxNeuesFenster";
            this.checkBoxNeuesFenster.Size = new System.Drawing.Size(95, 17);
            this.checkBoxNeuesFenster.TabIndex = 5;
            this.checkBoxNeuesFenster.Text = "Neues Fenster";
            this.checkBoxNeuesFenster.UseVisualStyleBackColor = true;
            // 
            // checkBoxOptGroesse
            // 
            this.checkBoxOptGroesse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxOptGroesse.AutoSize = true;
            this.checkBoxOptGroesse.Location = new System.Drawing.Point(6, 189);
            this.checkBoxOptGroesse.Name = "checkBoxOptGroesse";
            this.checkBoxOptGroesse.Size = new System.Drawing.Size(99, 17);
            this.checkBoxOptGroesse.TabIndex = 4;
            this.checkBoxOptGroesse.Text = "Optimale Größe";
            this.checkBoxOptGroesse.UseVisualStyleBackColor = true;
            this.checkBoxOptGroesse.CheckedChanged += new System.EventHandler(this.checkBoxOptGroesse_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(6, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.Location = new System.Drawing.Point(171, 64);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 2;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonOeffnen
            // 
            this.buttonOeffnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOeffnen.Location = new System.Drawing.Point(171, 35);
            this.buttonOeffnen.Name = "buttonOeffnen";
            this.buttonOeffnen.Size = new System.Drawing.Size(75, 23);
            this.buttonOeffnen.TabIndex = 1;
            this.buttonOeffnen.Text = "Öffnen";
            this.buttonOeffnen.UseVisualStyleBackColor = true;
            this.buttonOeffnen.Click += new System.EventHandler(this.buttonOeffnen_Click);
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnzeigen.Location = new System.Drawing.Point(171, 6);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.buttonAnzeigen.TabIndex = 0;
            this.buttonAnzeigen.Text = "Anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // tabPageSchau
            // 
            this.tabPageSchau.Controls.Add(this.numericUpDown1);
            this.tabPageSchau.Controls.Add(this.label1);
            this.tabPageSchau.Controls.Add(this.listBox1);
            this.tabPageSchau.Controls.Add(this.buttonBeenden1);
            this.tabPageSchau.Controls.Add(this.buttonStarten);
            this.tabPageSchau.Controls.Add(this.buttonAuswaehlen);
            this.tabPageSchau.Location = new System.Drawing.Point(4, 22);
            this.tabPageSchau.Name = "tabPageSchau";
            this.tabPageSchau.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchau.Size = new System.Drawing.Size(252, 211);
            this.tabPageSchau.TabIndex = 1;
            this.tabPageSchau.Text = "Bilderschau";
            this.tabPageSchau.UseVisualStyleBackColor = true;
            this.tabPageSchau.Enter += new System.EventHandler(this.tabPageSchau_Enter);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 121);
            this.listBox1.TabIndex = 0;
            // 
            // buttonBeenden1
            // 
            this.buttonBeenden1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBeenden1.Location = new System.Drawing.Point(170, 148);
            this.buttonBeenden1.Name = "buttonBeenden1";
            this.buttonBeenden1.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden1.TabIndex = 3;
            this.buttonBeenden1.Text = "Beenden";
            this.buttonBeenden1.UseVisualStyleBackColor = true;
            this.buttonBeenden1.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonStarten
            // 
            this.buttonStarten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStarten.Location = new System.Drawing.Point(90, 148);
            this.buttonStarten.Name = "buttonStarten";
            this.buttonStarten.Size = new System.Drawing.Size(75, 23);
            this.buttonStarten.TabIndex = 2;
            this.buttonStarten.Text = "Starten";
            this.buttonStarten.UseVisualStyleBackColor = true;
            this.buttonStarten.Click += new System.EventHandler(this.buttonStarten_Click);
            // 
            // buttonAuswaehlen
            // 
            this.buttonAuswaehlen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAuswaehlen.Location = new System.Drawing.Point(170, 6);
            this.buttonAuswaehlen.Name = "buttonAuswaehlen";
            this.buttonAuswaehlen.Size = new System.Drawing.Size(75, 23);
            this.buttonAuswaehlen.TabIndex = 1;
            this.buttonAuswaehlen.Text = "Auswählen";
            this.buttonAuswaehlen.UseVisualStyleBackColor = true;
            this.buttonAuswaehlen.Click += new System.EventHandler(this.buttonAuswaehlen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Grafikformate|*.bmp;*.gif;*jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Grafikformate|*.bmp;*.gif;*.jpg";
            this.openFileDialog2.Multiselect = true;
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bildwechsel pro Sekunde";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown1.Location = new System.Drawing.Point(9, 148);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 5;
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
            this.tabPageSchau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEinzel;
        private System.Windows.Forms.TabPage tabPageSchau;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonOeffnen;
        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxOptGroesse;
        private System.Windows.Forms.CheckBox checkBoxNeuesFenster;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonBeenden1;
        private System.Windows.Forms.Button buttonStarten;
        private System.Windows.Forms.Button buttonAuswaehlen;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

