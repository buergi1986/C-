namespace aufgaben3_cshp12c
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUebernehmen = new System.Windows.Forms.Button();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 238);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonUebernehmen
            // 
            this.buttonUebernehmen.Location = new System.Drawing.Point(250, 62);
            this.buttonUebernehmen.Name = "buttonUebernehmen";
            this.buttonUebernehmen.Size = new System.Drawing.Size(172, 23);
            this.buttonUebernehmen.TabIndex = 2;
            this.buttonUebernehmen.Text = "Übernehmen";
            this.buttonUebernehmen.UseVisualStyleBackColor = true;
            this.buttonUebernehmen.Click += new System.EventHandler(this.buttonUebernehmen_Click);
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(250, 91);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(172, 23);
            this.buttonSpeichern.TabIndex = 3;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 260);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.buttonUebernehmen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Lösung Aufgabe 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUebernehmen;
        private System.Windows.Forms.Button buttonSpeichern;
    }
}

