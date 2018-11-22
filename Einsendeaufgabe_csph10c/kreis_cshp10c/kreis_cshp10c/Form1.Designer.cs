namespace kreis_cshp10c
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
            this.buttonBeenden1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBeenden1
            // 
            this.buttonBeenden1.Location = new System.Drawing.Point(247, 13);
            this.buttonBeenden1.Name = "buttonBeenden1";
            this.buttonBeenden1.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden1.TabIndex = 0;
            this.buttonBeenden1.Text = "Beenden";
            this.buttonBeenden1.UseVisualStyleBackColor = true;
            this.buttonBeenden1.Click += new System.EventHandler(this.buttonBeenden1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.buttonBeenden1);
            this.Name = "Form1";
            this.Text = "Kreis";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBeenden1;
    }
}

