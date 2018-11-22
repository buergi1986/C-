namespace cshp07c_03
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
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.labelErgebnis = new System.Windows.Forms.Label();
            this.labelAnzeige = new System.Windows.Forms.Label();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(13, 13);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl1.TabIndex = 0;
            this.textBoxZahl1.Text = "0";
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(13, 39);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl2.TabIndex = 1;
            this.textBoxZahl2.Text = "0";
            // 
            // labelErgebnis
            // 
            this.labelErgebnis.AutoSize = true;
            this.labelErgebnis.Location = new System.Drawing.Point(10, 84);
            this.labelErgebnis.Name = "labelErgebnis";
            this.labelErgebnis.Size = new System.Drawing.Size(51, 13);
            this.labelErgebnis.TabIndex = 0;
            this.labelErgebnis.Text = "Ergebnis:";
            // 
            // labelAnzeige
            // 
            this.labelAnzeige.AutoSize = true;
            this.labelAnzeige.Location = new System.Drawing.Point(58, 85);
            this.labelAnzeige.Name = "labelAnzeige";
            this.labelAnzeige.Size = new System.Drawing.Size(13, 13);
            this.labelAnzeige.TabIndex = 0;
            this.labelAnzeige.Text = "0";
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(12, 102);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(75, 23);
            this.buttonBerechnen.TabIndex = 4;
            this.buttonBerechnen.Text = "Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Addition",
            "Subtraktion",
            "Division",
            "Multiplikation"});
            this.comboBox1.Location = new System.Drawing.Point(178, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(224, 101);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 5;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 137);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonBerechnen);
            this.Controls.Add(this.labelAnzeige);
            this.Controls.Add(this.labelErgebnis);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Einsendeaufgabe 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.Label labelErgebnis;
        private System.Windows.Forms.Label labelAnzeige;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonBeenden;
    }
}

