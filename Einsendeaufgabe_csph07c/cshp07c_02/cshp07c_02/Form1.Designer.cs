namespace cshp07c_02
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1_ergebnis = new System.Windows.Forms.Label();
            this.label1_gleich = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1_ergebnis
            // 
            this.label1_ergebnis.AutoSize = true;
            this.label1_ergebnis.Location = new System.Drawing.Point(153, 47);
            this.label1_ergebnis.Name = "label1_ergebnis";
            this.label1_ergebnis.Size = new System.Drawing.Size(48, 13);
            this.label1_ergebnis.TabIndex = 3;
            this.label1_ergebnis.Text = "Ergebnis";
            // 
            // label1_gleich
            // 
            this.label1_gleich.AutoSize = true;
            this.label1_gleich.Location = new System.Drawing.Point(134, 47);
            this.label1_gleich.Name = "label1_gleich";
            this.label1_gleich.Size = new System.Drawing.Size(13, 13);
            this.label1_gleich.TabIndex = 2;
            this.label1_gleich.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 111);
            this.Controls.Add(this.label1_gleich);
            this.Controls.Add(this.label1_ergebnis);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Einsendeaufgabe 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1_ergebnis;
        private System.Windows.Forms.Label label1_gleich;
    }
}

