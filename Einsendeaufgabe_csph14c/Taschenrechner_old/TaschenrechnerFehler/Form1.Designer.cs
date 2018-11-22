namespace Taschenrechner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelAnzeige = new System.Windows.Forms.Label();
            this.labelBeschreibung = new System.Windows.Forms.Label();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMultiplikation = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtraktion = new System.Windows.Forms.RadioButton();
            this.radioButtonAddition = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAnzeige
            // 
            resources.ApplyResources(this.labelAnzeige, "labelAnzeige");
            this.labelAnzeige.Name = "labelAnzeige";
            // 
            // labelBeschreibung
            // 
            resources.ApplyResources(this.labelBeschreibung, "labelBeschreibung");
            this.labelBeschreibung.Name = "labelBeschreibung";
            // 
            // buttonBeenden
            // 
            resources.ApplyResources(this.buttonBeenden, "buttonBeenden");
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonBerechnen
            // 
            resources.ApplyResources(this.buttonBerechnen, "buttonBerechnen");
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // textBoxZahl2
            // 
            resources.ApplyResources(this.textBoxZahl2, "textBoxZahl2");
            this.textBoxZahl2.Name = "textBoxZahl2";
            // 
            // textBoxZahl1
            // 
            resources.ApplyResources(this.textBoxZahl1, "textBoxZahl1");
            this.textBoxZahl1.Name = "textBoxZahl1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMultiplikation);
            this.groupBox1.Controls.Add(this.radioButtonDivision);
            this.groupBox1.Controls.Add(this.radioButtonSubtraktion);
            this.groupBox1.Controls.Add(this.radioButtonAddition);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButtonMultiplikation
            // 
            resources.ApplyResources(this.radioButtonMultiplikation, "radioButtonMultiplikation");
            this.radioButtonMultiplikation.Name = "radioButtonMultiplikation";
            this.radioButtonMultiplikation.TabStop = true;
            this.radioButtonMultiplikation.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivision
            // 
            resources.ApplyResources(this.radioButtonDivision, "radioButtonDivision");
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.TabStop = true;
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtraktion
            // 
            resources.ApplyResources(this.radioButtonSubtraktion, "radioButtonSubtraktion");
            this.radioButtonSubtraktion.Name = "radioButtonSubtraktion";
            this.radioButtonSubtraktion.TabStop = true;
            this.radioButtonSubtraktion.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddition
            // 
            resources.ApplyResources(this.radioButtonAddition, "radioButtonAddition");
            this.radioButtonAddition.Checked = true;
            this.radioButtonAddition.Name = "radioButtonAddition";
            this.radioButtonAddition.TabStop = true;
            this.radioButtonAddition.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Controls.Add(this.labelAnzeige);
            this.Controls.Add(this.labelBeschreibung);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonBerechnen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnzeige;
        private System.Windows.Forms.Label labelBeschreibung;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMultiplikation;
        private System.Windows.Forms.RadioButton radioButtonDivision;
        private System.Windows.Forms.RadioButton radioButtonSubtraktion;
        private System.Windows.Forms.RadioButton radioButtonAddition;
    }
}

