namespace Buch2020
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonListenansicht = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEinzel = new System.Windows.Forms.Button();
            this.buttonListenMedien = new System.Windows.Forms.Button();
            this.buttonEinzelMedien = new System.Windows.Forms.Button();
            this.buttonMedien = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEinzel);
            this.groupBox1.Controls.Add(this.buttonListenansicht);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunden";
            // 
            // buttonListenansicht
            // 
            this.buttonListenansicht.Location = new System.Drawing.Point(52, 41);
            this.buttonListenansicht.Name = "buttonListenansicht";
            this.buttonListenansicht.Size = new System.Drawing.Size(83, 23);
            this.buttonListenansicht.TabIndex = 0;
            this.buttonListenansicht.Text = "Listenansicht";
            this.buttonListenansicht.UseVisualStyleBackColor = true;
            this.buttonListenansicht.Click += new System.EventHandler(this.buttonListenansicht_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMedien);
            this.groupBox2.Controls.Add(this.buttonEinzelMedien);
            this.groupBox2.Controls.Add(this.buttonListenMedien);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medien";
            // 
            // buttonEinzel
            // 
            this.buttonEinzel.Location = new System.Drawing.Point(52, 70);
            this.buttonEinzel.Name = "buttonEinzel";
            this.buttonEinzel.Size = new System.Drawing.Size(83, 23);
            this.buttonEinzel.TabIndex = 1;
            this.buttonEinzel.Text = "Einzelansicht";
            this.buttonEinzel.UseVisualStyleBackColor = true;
            this.buttonEinzel.Click += new System.EventHandler(this.buttonEinzel_Click);
            // 
            // buttonListenMedien
            // 
            this.buttonListenMedien.Location = new System.Drawing.Point(70, 41);
            this.buttonListenMedien.Name = "buttonListenMedien";
            this.buttonListenMedien.Size = new System.Drawing.Size(83, 23);
            this.buttonListenMedien.TabIndex = 2;
            this.buttonListenMedien.Text = "Listenansicht";
            this.buttonListenMedien.UseVisualStyleBackColor = true;
            this.buttonListenMedien.Click += new System.EventHandler(this.buttonListenMedien_Click);
            // 
            // buttonEinzelMedien
            // 
            this.buttonEinzelMedien.Location = new System.Drawing.Point(70, 70);
            this.buttonEinzelMedien.Name = "buttonEinzelMedien";
            this.buttonEinzelMedien.Size = new System.Drawing.Size(83, 23);
            this.buttonEinzelMedien.TabIndex = 2;
            this.buttonEinzelMedien.Text = "Einzelansicht";
            this.buttonEinzelMedien.UseVisualStyleBackColor = true;
            this.buttonEinzelMedien.Click += new System.EventHandler(this.buttonEinzelMedien_Click);
            // 
            // buttonMedien
            // 
            this.buttonMedien.Location = new System.Drawing.Point(70, 121);
            this.buttonMedien.Name = "buttonMedien";
            this.buttonMedien.Size = new System.Drawing.Size(83, 23);
            this.buttonMedien.TabIndex = 3;
            this.buttonMedien.Text = "Medienliste";
            this.buttonMedien.UseVisualStyleBackColor = true;
            this.buttonMedien.Click += new System.EventHandler(this.buttonMedien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 279);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Buch2020";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonListenansicht;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEinzel;
        private System.Windows.Forms.Button buttonMedien;
        private System.Windows.Forms.Button buttonEinzelMedien;
        private System.Windows.Forms.Button buttonListenMedien;
    }
}

