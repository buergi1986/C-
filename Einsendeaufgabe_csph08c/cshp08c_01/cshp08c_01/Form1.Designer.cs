namespace cshp08c_01
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOeffnen = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageEinzelbild = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageEinzelbild.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEinzelbild);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 236);
            this.tabControl1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Grafikformate|*.bmp;*.gif;*.jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // buttonOeffnen
            // 
            this.buttonOeffnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOeffnen.Location = new System.Drawing.Point(170, 6);
            this.buttonOeffnen.Name = "buttonOeffnen";
            this.buttonOeffnen.Size = new System.Drawing.Size(75, 23);
            this.buttonOeffnen.TabIndex = 2;
            this.buttonOeffnen.Text = "Öffnen";
            this.buttonOeffnen.UseVisualStyleBackColor = true;
            this.buttonOeffnen.Click += new System.EventHandler(this.buttonOeffnen_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.Location = new System.Drawing.Point(170, 35);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 3;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 172);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(3, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 5;
            // 
            // tabPageEinzelbild
            // 
            this.tabPageEinzelbild.Controls.Add(this.textBox1);
            this.tabPageEinzelbild.Controls.Add(this.pictureBox1);
            this.tabPageEinzelbild.Controls.Add(this.buttonBeenden);
            this.tabPageEinzelbild.Controls.Add(this.buttonOeffnen);
            this.tabPageEinzelbild.Location = new System.Drawing.Point(4, 22);
            this.tabPageEinzelbild.Name = "tabPageEinzelbild";
            this.tabPageEinzelbild.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEinzelbild.Size = new System.Drawing.Size(251, 210);
            this.tabPageEinzelbild.TabIndex = 0;
            this.tabPageEinzelbild.Text = "Einzelbild";
            this.tabPageEinzelbild.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bildbetrachter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageEinzelbild.ResumeLayout(false);
            this.tabPageEinzelbild.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPageEinzelbild;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonOeffnen;
    }
}

