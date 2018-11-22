namespace cshp07c_04
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
            this.buttonWanderung1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBeenden1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWanderung1
            // 
            this.buttonWanderung1.Location = new System.Drawing.Point(187, 13);
            this.buttonWanderung1.Name = "buttonWanderung1";
            this.buttonWanderung1.Size = new System.Drawing.Size(75, 23);
            this.buttonWanderung1.TabIndex = 0;
            this.buttonWanderung1.Text = "Wanderung";
            this.buttonWanderung1.UseVisualStyleBackColor = true;
            this.buttonWanderung1.Click += new System.EventHandler(this.buttonWanderung1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oben nach Unten";
            // 
            // buttonBeenden1
            // 
            this.buttonBeenden1.Location = new System.Drawing.Point(186, 43);
            this.buttonBeenden1.Name = "buttonBeenden1";
            this.buttonBeenden1.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden1.TabIndex = 2;
            this.buttonBeenden1.Text = "Beenden";
            this.buttonBeenden1.UseVisualStyleBackColor = true;
            this.buttonBeenden1.Click += new System.EventHandler(this.buttonBeenden1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.buttonBeenden1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWanderung1);
            this.Name = "Form1";
            this.Text = "Einsendeaufgabe 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWanderung1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBeenden1;
    }
}

