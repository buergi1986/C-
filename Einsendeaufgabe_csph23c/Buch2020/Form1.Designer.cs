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
            this.buttonEinzelansicht = new System.Windows.Forms.Button();
            this.buttonListenansicht = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonMedienliste = new System.Windows.Forms.Button();
            this.buttonMEinzelansicht = new System.Windows.Forms.Button();
            this.buttonMListenansicht = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonReservierungAnlegen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAusleihe = new System.Windows.Forms.Button();
            this.buttonRueckgabe = new System.Windows.Forms.Button();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSuchen);
            this.groupBox1.Controls.Add(this.buttonEinzelansicht);
            this.groupBox1.Controls.Add(this.buttonListenansicht);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunden";
            // 
            // buttonEinzelansicht
            // 
            this.buttonEinzelansicht.Location = new System.Drawing.Point(55, 48);
            this.buttonEinzelansicht.Name = "buttonEinzelansicht";
            this.buttonEinzelansicht.Size = new System.Drawing.Size(89, 23);
            this.buttonEinzelansicht.TabIndex = 1;
            this.buttonEinzelansicht.Text = "Einzelansicht";
            this.buttonEinzelansicht.UseVisualStyleBackColor = true;
            this.buttonEinzelansicht.Click += new System.EventHandler(this.buttonEinzelansicht_Click);
            // 
            // buttonListenansicht
            // 
            this.buttonListenansicht.Location = new System.Drawing.Point(55, 19);
            this.buttonListenansicht.Name = "buttonListenansicht";
            this.buttonListenansicht.Size = new System.Drawing.Size(89, 23);
            this.buttonListenansicht.TabIndex = 0;
            this.buttonListenansicht.Text = "Listenansicht";
            this.buttonListenansicht.UseVisualStyleBackColor = true;
            this.buttonListenansicht.Click += new System.EventHandler(this.buttonListenansicht_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMedienliste);
            this.groupBox2.Controls.Add(this.buttonMEinzelansicht);
            this.groupBox2.Controls.Add(this.buttonMListenansicht);
            this.groupBox2.Location = new System.Drawing.Point(230, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medien";
            // 
            // buttonMedienliste
            // 
            this.buttonMedienliste.Location = new System.Drawing.Point(58, 99);
            this.buttonMedienliste.Name = "buttonMedienliste";
            this.buttonMedienliste.Size = new System.Drawing.Size(89, 23);
            this.buttonMedienliste.TabIndex = 4;
            this.buttonMedienliste.Text = "Medienliste";
            this.buttonMedienliste.UseVisualStyleBackColor = true;
            this.buttonMedienliste.Click += new System.EventHandler(this.buttonMedienliste_Click);
            // 
            // buttonMEinzelansicht
            // 
            this.buttonMEinzelansicht.Location = new System.Drawing.Point(58, 48);
            this.buttonMEinzelansicht.Name = "buttonMEinzelansicht";
            this.buttonMEinzelansicht.Size = new System.Drawing.Size(89, 23);
            this.buttonMEinzelansicht.TabIndex = 3;
            this.buttonMEinzelansicht.Text = "Einzelansicht";
            this.buttonMEinzelansicht.UseVisualStyleBackColor = true;
            this.buttonMEinzelansicht.Click += new System.EventHandler(this.buttonMEinzelansicht_Click);
            // 
            // buttonMListenansicht
            // 
            this.buttonMListenansicht.Location = new System.Drawing.Point(58, 19);
            this.buttonMListenansicht.Name = "buttonMListenansicht";
            this.buttonMListenansicht.Size = new System.Drawing.Size(89, 23);
            this.buttonMListenansicht.TabIndex = 2;
            this.buttonMListenansicht.Text = "Listenansicht";
            this.buttonMListenansicht.UseVisualStyleBackColor = true;
            this.buttonMListenansicht.Click += new System.EventHandler(this.buttonMListenansicht_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonReservierungAnlegen);
            this.groupBox4.Location = new System.Drawing.Point(227, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 136);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reservierungen";
            // 
            // buttonReservierungAnlegen
            // 
            this.buttonReservierungAnlegen.Location = new System.Drawing.Point(55, 19);
            this.buttonReservierungAnlegen.Name = "buttonReservierungAnlegen";
            this.buttonReservierungAnlegen.Size = new System.Drawing.Size(89, 23);
            this.buttonReservierungAnlegen.TabIndex = 0;
            this.buttonReservierungAnlegen.Text = "Anlegen";
            this.buttonReservierungAnlegen.UseVisualStyleBackColor = true;
            this.buttonReservierungAnlegen.Click += new System.EventHandler(this.buttonReservierungAnlegen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAusleihe);
            this.groupBox3.Controls.Add(this.buttonRueckgabe);
            this.groupBox3.Location = new System.Drawing.Point(6, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 136);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Verträge";
            // 
            // buttonAusleihe
            // 
            this.buttonAusleihe.Location = new System.Drawing.Point(55, 19);
            this.buttonAusleihe.Name = "buttonAusleihe";
            this.buttonAusleihe.Size = new System.Drawing.Size(89, 23);
            this.buttonAusleihe.TabIndex = 0;
            this.buttonAusleihe.Text = "Ausleihe";
            this.buttonAusleihe.UseVisualStyleBackColor = true;
            this.buttonAusleihe.Click += new System.EventHandler(this.buttonAusleihe_Click);
            // 
            // buttonRueckgabe
            // 
            this.buttonRueckgabe.Location = new System.Drawing.Point(55, 48);
            this.buttonRueckgabe.Name = "buttonRueckgabe";
            this.buttonRueckgabe.Size = new System.Drawing.Size(89, 23);
            this.buttonRueckgabe.TabIndex = 0;
            this.buttonRueckgabe.Text = "Rückgabe";
            this.buttonRueckgabe.UseVisualStyleBackColor = true;
            this.buttonRueckgabe.Click += new System.EventHandler(this.buttonRueckgabe_Click);
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Location = new System.Drawing.Point(55, 90);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(89, 23);
            this.buttonSuchen.TabIndex = 2;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 321);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Buch2020";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonListenansicht;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEinzelansicht;
        private System.Windows.Forms.Button buttonMEinzelansicht;
        private System.Windows.Forms.Button buttonMListenansicht;
        private System.Windows.Forms.Button buttonMedienliste;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonReservierungAnlegen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAusleihe;
        private System.Windows.Forms.Button buttonRueckgabe;
        private System.Windows.Forms.Button buttonSuchen;
    }
}

