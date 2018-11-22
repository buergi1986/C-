namespace RegDemo03
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
            this.buttonEinlesen = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonEinlesen
            // 
            this.buttonEinlesen.Location = new System.Drawing.Point(312, 227);
            this.buttonEinlesen.Name = "buttonEinlesen";
            this.buttonEinlesen.Size = new System.Drawing.Size(75, 23);
            this.buttonEinlesen.TabIndex = 11;
            this.buttonEinlesen.Text = "Einlesen";
            this.buttonEinlesen.UseVisualStyleBackColor = true;
            this.buttonEinlesen.Click += new System.EventHandler(this.buttonEinlesen_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(511, 12);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(179, 199);
            this.listBox4.Sorted = true;
            this.listBox4.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(141, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(179, 199);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(326, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(179, 199);
            this.listBox3.Sorted = true;
            this.listBox3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 262);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.buttonEinlesen);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Registrierungsdemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEinlesen;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox3;
    }
}

