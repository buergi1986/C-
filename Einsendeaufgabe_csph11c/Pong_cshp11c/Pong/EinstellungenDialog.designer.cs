namespace Pong
{
    partial class EinstellungenDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMaximal = new System.Windows.Forms.RadioButton();
            this.radioButton1024 = new System.Windows.Forms.RadioButton();
            this.radioButton640 = new System.Windows.Forms.RadioButton();
            this.radioButton320 = new System.Windows.Forms.RadioButton();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonUebernehmen = new System.Windows.Forms.Button();
            this.groupBoxFarben = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRahmen = new System.Windows.Forms.Button();
            this.buttonSpielfeld = new System.Windows.Forms.Button();
            this.panelVorschau = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.vorschauSchlaeger = new System.Windows.Forms.Panel();
            this.vorschauBall = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBoxFarben.SuspendLayout();
            this.panelVorschau.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMaximal);
            this.groupBox1.Controls.Add(this.radioButton1024);
            this.groupBox1.Controls.Add(this.radioButton640);
            this.groupBox1.Controls.Add(this.radioButton320);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Größe";
            // 
            // radioButtonMaximal
            // 
            this.radioButtonMaximal.AutoSize = true;
            this.radioButtonMaximal.Location = new System.Drawing.Point(252, 30);
            this.radioButtonMaximal.Name = "radioButtonMaximal";
            this.radioButtonMaximal.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMaximal.TabIndex = 3;
            this.radioButtonMaximal.Text = "Maximal";
            this.radioButtonMaximal.UseVisualStyleBackColor = true;
            // 
            // radioButton1024
            // 
            this.radioButton1024.AutoSize = true;
            this.radioButton1024.Location = new System.Drawing.Point(169, 30);
            this.radioButton1024.Name = "radioButton1024";
            this.radioButton1024.Size = new System.Drawing.Size(77, 17);
            this.radioButton1024.TabIndex = 2;
            this.radioButton1024.Text = "1024 * 768";
            this.radioButton1024.UseVisualStyleBackColor = true;
            // 
            // radioButton640
            // 
            this.radioButton640.AutoSize = true;
            this.radioButton640.Location = new System.Drawing.Point(92, 30);
            this.radioButton640.Name = "radioButton640";
            this.radioButton640.Size = new System.Drawing.Size(71, 17);
            this.radioButton640.TabIndex = 1;
            this.radioButton640.Text = "640 * 480";
            this.radioButton640.UseVisualStyleBackColor = true;
            // 
            // radioButton320
            // 
            this.radioButton320.AutoSize = true;
            this.radioButton320.Location = new System.Drawing.Point(15, 30);
            this.radioButton320.Name = "radioButton320";
            this.radioButton320.Size = new System.Drawing.Size(71, 17);
            this.radioButton320.TabIndex = 0;
            this.radioButton320.Text = "320 * 200";
            this.radioButton320.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(262, 312);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 5;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // buttonUebernehmen
            // 
            this.buttonUebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUebernehmen.Location = new System.Drawing.Point(15, 312);
            this.buttonUebernehmen.Name = "buttonUebernehmen";
            this.buttonUebernehmen.Size = new System.Drawing.Size(85, 23);
            this.buttonUebernehmen.TabIndex = 4;
            this.buttonUebernehmen.Text = "Übernehmen";
            this.buttonUebernehmen.UseVisualStyleBackColor = true;
            // 
            // groupBoxFarben
            // 
            this.groupBoxFarben.Controls.Add(this.buttonSpielfeld);
            this.groupBoxFarben.Controls.Add(this.buttonRahmen);
            this.groupBoxFarben.Controls.Add(this.label2);
            this.groupBoxFarben.Controls.Add(this.label1);
            this.groupBoxFarben.Location = new System.Drawing.Point(13, 96);
            this.groupBoxFarben.Name = "groupBoxFarben";
            this.groupBoxFarben.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxFarben.Size = new System.Drawing.Size(324, 91);
            this.groupBoxFarben.TabIndex = 6;
            this.groupBoxFarben.TabStop = false;
            this.groupBoxFarben.Text = "Farben";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rahmen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spielfeld";
            // 
            // buttonRahmen
            // 
            this.buttonRahmen.Location = new System.Drawing.Point(68, 28);
            this.buttonRahmen.Name = "buttonRahmen";
            this.buttonRahmen.Size = new System.Drawing.Size(31, 23);
            this.buttonRahmen.TabIndex = 2;
            this.buttonRahmen.Text = "...";
            this.buttonRahmen.UseVisualStyleBackColor = true;
            this.buttonRahmen.Click += new System.EventHandler(this.buttonRahmen_Click);
            // 
            // buttonSpielfeld
            // 
            this.buttonSpielfeld.Location = new System.Drawing.Point(67, 57);
            this.buttonSpielfeld.Name = "buttonSpielfeld";
            this.buttonSpielfeld.Size = new System.Drawing.Size(31, 23);
            this.buttonSpielfeld.TabIndex = 3;
            this.buttonSpielfeld.Text = "...";
            this.buttonSpielfeld.UseVisualStyleBackColor = true;
            this.buttonSpielfeld.Click += new System.EventHandler(this.buttonSpielfeld_Click);
            // 
            // panelVorschau
            // 
            this.panelVorschau.Controls.Add(this.vorschauBall);
            this.panelVorschau.Controls.Add(this.vorschauSchlaeger);
            this.panelVorschau.Location = new System.Drawing.Point(15, 206);
            this.panelVorschau.Name = "panelVorschau";
            this.panelVorschau.Size = new System.Drawing.Size(322, 100);
            this.panelVorschau.TabIndex = 7;
            this.panelVorschau.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVorschau_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vorschau:";
            // 
            // vorschauSchlaeger
            // 
            this.vorschauSchlaeger.Location = new System.Drawing.Point(38, 31);
            this.vorschauSchlaeger.Name = "vorschauSchlaeger";
            this.vorschauSchlaeger.Size = new System.Drawing.Size(58, 47);
            this.vorschauSchlaeger.TabIndex = 0;
            // 
            // vorschauBall
            // 
            this.vorschauBall.Location = new System.Drawing.Point(121, 17);
            this.vorschauBall.Name = "vorschauBall";
            this.vorschauBall.Size = new System.Drawing.Size(58, 47);
            this.vorschauBall.TabIndex = 1;
            // 
            // EinstellungenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 343);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelVorschau);
            this.Controls.Add(this.groupBoxFarben);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonUebernehmen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EinstellungenDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spielfeld";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFarben.ResumeLayout(false);
            this.groupBoxFarben.PerformLayout();
            this.panelVorschau.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMaximal;
        private System.Windows.Forms.RadioButton radioButton1024;
        private System.Windows.Forms.RadioButton radioButton640;
        private System.Windows.Forms.RadioButton radioButton320;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonUebernehmen;
        private System.Windows.Forms.GroupBox groupBoxFarben;
        private System.Windows.Forms.Button buttonSpielfeld;
        private System.Windows.Forms.Button buttonRahmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelVorschau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel vorschauBall;
        private System.Windows.Forms.Panel vorschauSchlaeger;
    }
}