namespace Spielerei
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonLinienFarbe = new System.Windows.Forms.Button();
            this.panelLinienFarbeVorschau = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownLinieStaerke = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxLinieStil = new System.Windows.Forms.ListBox();
            this.buttonHintergrundFarbe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelHintergrundFarbeVorschau = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxHintergrundMuster = new System.Windows.Forms.ListBox();
            this.radioButtonHintergrundMuster = new System.Windows.Forms.RadioButton();
            this.radioButtonHintergrundFarbe = new System.Windows.Forms.RadioButton();
            this.radioButtonHintergrundOhne = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonLinie = new System.Windows.Forms.RadioButton();
            this.radioButtonRechteck = new System.Windows.Forms.RadioButton();
            this.radioButtonKreis = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownGesch = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAnzahl = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLinieStaerke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGesch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnzahl)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLinienFarbe
            // 
            this.buttonLinienFarbe.Location = new System.Drawing.Point(83, 17);
            this.buttonLinienFarbe.Name = "buttonLinienFarbe";
            this.buttonLinienFarbe.Size = new System.Drawing.Size(24, 23);
            this.buttonLinienFarbe.TabIndex = 7;
            this.buttonLinienFarbe.Text = "...";
            this.buttonLinienFarbe.UseVisualStyleBackColor = true;
            this.buttonLinienFarbe.Click += new System.EventHandler(this.buttonLinienFarbe_Click);
            // 
            // panelLinienFarbeVorschau
            // 
            this.panelLinienFarbeVorschau.BackColor = System.Drawing.Color.Black;
            this.panelLinienFarbeVorschau.Location = new System.Drawing.Point(59, 19);
            this.panelLinienFarbeVorschau.Name = "panelLinienFarbeVorschau";
            this.panelLinienFarbeVorschau.Size = new System.Drawing.Size(18, 18);
            this.panelLinienFarbeVorschau.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Farbe";
            // 
            // numericUpDownLinieStaerke
            // 
            this.numericUpDownLinieStaerke.Location = new System.Drawing.Point(59, 82);
            this.numericUpDownLinieStaerke.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownLinieStaerke.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLinieStaerke.Name = "numericUpDownLinieStaerke";
            this.numericUpDownLinieStaerke.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLinieStaerke.TabIndex = 2;
            this.numericUpDownLinieStaerke.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLinienFarbe);
            this.groupBox1.Controls.Add(this.panelLinienFarbeVorschau);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownLinieStaerke);
            this.groupBox1.Controls.Add(this.listBoxLinieStil);
            this.groupBox1.Location = new System.Drawing.Point(369, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 108);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stärke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stil";
            // 
            // listBoxLinieStil
            // 
            this.listBoxLinieStil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxLinieStil.FormattingEnabled = true;
            this.listBoxLinieStil.Location = new System.Drawing.Point(58, 46);
            this.listBoxLinieStil.Name = "listBoxLinieStil";
            this.listBoxLinieStil.Size = new System.Drawing.Size(120, 30);
            this.listBoxLinieStil.TabIndex = 1;
            this.listBoxLinieStil.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxLinieStil_DrawItem);
            // 
            // buttonHintergrundFarbe
            // 
            this.buttonHintergrundFarbe.Location = new System.Drawing.Point(83, 44);
            this.buttonHintergrundFarbe.Name = "buttonHintergrundFarbe";
            this.buttonHintergrundFarbe.Size = new System.Drawing.Size(24, 23);
            this.buttonHintergrundFarbe.TabIndex = 9;
            this.buttonHintergrundFarbe.Text = "...";
            this.buttonHintergrundFarbe.UseVisualStyleBackColor = true;
            this.buttonHintergrundFarbe.Click += new System.EventHandler(this.buttonHintergrundFarbe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonHintergrundFarbe);
            this.groupBox2.Controls.Add(this.panelHintergrundFarbeVorschau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listBoxHintergrundMuster);
            this.groupBox2.Controls.Add(this.radioButtonHintergrundMuster);
            this.groupBox2.Controls.Add(this.radioButtonHintergrundFarbe);
            this.groupBox2.Controls.Add(this.radioButtonHintergrundOhne);
            this.groupBox2.Location = new System.Drawing.Point(369, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 110);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hintergrund";
            // 
            // panelHintergrundFarbeVorschau
            // 
            this.panelHintergrundFarbeVorschau.Location = new System.Drawing.Point(59, 46);
            this.panelHintergrundFarbeVorschau.Name = "panelHintergrundFarbeVorschau";
            this.panelHintergrundFarbeVorschau.Size = new System.Drawing.Size(18, 18);
            this.panelHintergrundFarbeVorschau.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Farbe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stil";
            // 
            // listBoxHintergrundMuster
            // 
            this.listBoxHintergrundMuster.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxHintergrundMuster.FormattingEnabled = true;
            this.listBoxHintergrundMuster.Location = new System.Drawing.Point(59, 73);
            this.listBoxHintergrundMuster.Name = "listBoxHintergrundMuster";
            this.listBoxHintergrundMuster.Size = new System.Drawing.Size(120, 30);
            this.listBoxHintergrundMuster.TabIndex = 6;
            this.listBoxHintergrundMuster.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxHintergrundMuster_DrawItem);
            // 
            // radioButtonHintergrundMuster
            // 
            this.radioButtonHintergrundMuster.AutoSize = true;
            this.radioButtonHintergrundMuster.Location = new System.Drawing.Point(137, 23);
            this.radioButtonHintergrundMuster.Name = "radioButtonHintergrundMuster";
            this.radioButtonHintergrundMuster.Size = new System.Drawing.Size(57, 17);
            this.radioButtonHintergrundMuster.TabIndex = 2;
            this.radioButtonHintergrundMuster.Text = "Muster";
            this.radioButtonHintergrundMuster.UseVisualStyleBackColor = true;
            // 
            // radioButtonHintergrundFarbe
            // 
            this.radioButtonHintergrundFarbe.AutoSize = true;
            this.radioButtonHintergrundFarbe.Location = new System.Drawing.Point(70, 23);
            this.radioButtonHintergrundFarbe.Name = "radioButtonHintergrundFarbe";
            this.radioButtonHintergrundFarbe.Size = new System.Drawing.Size(52, 17);
            this.radioButtonHintergrundFarbe.TabIndex = 1;
            this.radioButtonHintergrundFarbe.Text = "Farbe";
            this.radioButtonHintergrundFarbe.UseVisualStyleBackColor = true;
            // 
            // radioButtonHintergrundOhne
            // 
            this.radioButtonHintergrundOhne.AutoSize = true;
            this.radioButtonHintergrundOhne.Checked = true;
            this.radioButtonHintergrundOhne.Location = new System.Drawing.Point(15, 23);
            this.radioButtonHintergrundOhne.Name = "radioButtonHintergrundOhne";
            this.radioButtonHintergrundOhne.Size = new System.Drawing.Size(49, 17);
            this.radioButtonHintergrundOhne.TabIndex = 0;
            this.radioButtonHintergrundOhne.TabStop = true;
            this.radioButtonHintergrundOhne.Text = "ohne";
            this.radioButtonHintergrundOhne.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(332, 345);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 21;
            this.buttonStart.Text = "Los geht\'s";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(369, 292);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(206, 45);
            this.trackBar1.TabIndex = 20;
            this.trackBar1.Value = 2;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(494, 345);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 23;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(413, 345);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(75, 23);
            this.buttonLoeschen.TabIndex = 22;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(9, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 16;
            // 
            // radioButtonLinie
            // 
            this.radioButtonLinie.AutoSize = true;
            this.radioButtonLinie.Location = new System.Drawing.Point(147, 19);
            this.radioButtonLinie.Name = "radioButtonLinie";
            this.radioButtonLinie.Size = new System.Drawing.Size(47, 17);
            this.radioButtonLinie.TabIndex = 2;
            this.radioButtonLinie.Text = "Linie";
            this.radioButtonLinie.UseVisualStyleBackColor = true;
            // 
            // radioButtonRechteck
            // 
            this.radioButtonRechteck.AutoSize = true;
            this.radioButtonRechteck.Location = new System.Drawing.Point(70, 19);
            this.radioButtonRechteck.Name = "radioButtonRechteck";
            this.radioButtonRechteck.Size = new System.Drawing.Size(72, 17);
            this.radioButtonRechteck.TabIndex = 1;
            this.radioButtonRechteck.Text = "Rechteck";
            this.radioButtonRechteck.UseVisualStyleBackColor = true;
            // 
            // radioButtonKreis
            // 
            this.radioButtonKreis.AutoSize = true;
            this.radioButtonKreis.Checked = true;
            this.radioButtonKreis.Location = new System.Drawing.Point(15, 19);
            this.radioButtonKreis.Name = "radioButtonKreis";
            this.radioButtonKreis.Size = new System.Drawing.Size(48, 17);
            this.radioButtonKreis.TabIndex = 0;
            this.radioButtonKreis.TabStop = true;
            this.radioButtonKreis.Text = "Kreis";
            this.radioButtonKreis.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonLinie);
            this.groupBox3.Controls.Add(this.radioButtonRechteck);
            this.groupBox3.Controls.Add(this.radioButtonKreis);
            this.groupBox3.Location = new System.Drawing.Point(369, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 42);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Figur";
            // 
            // numericUpDownGesch
            // 
            this.numericUpDownGesch.Location = new System.Drawing.Point(12, 345);
            this.numericUpDownGesch.Name = "numericUpDownGesch";
            this.numericUpDownGesch.Size = new System.Drawing.Size(126, 20);
            this.numericUpDownGesch.TabIndex = 8;
            this.numericUpDownGesch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownAnzahl
            // 
            this.numericUpDownAnzahl.Location = new System.Drawing.Point(148, 345);
            this.numericUpDownAnzahl.Name = "numericUpDownAnzahl";
            this.numericUpDownAnzahl.Size = new System.Drawing.Size(105, 20);
            this.numericUpDownAnzahl.TabIndex = 24;
            this.numericUpDownAnzahl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(259, 345);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(67, 23);
            this.buttonOK.TabIndex = 25;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Geschwindigkeit pro Sek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Anzahl Wiederholung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownAnzahl);
            this.Controls.Add(this.numericUpDownGesch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Eine Spielerei";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLinieStaerke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGesch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnzahl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonLinienFarbe;
        private System.Windows.Forms.Panel panelLinienFarbeVorschau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownLinieStaerke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLinieStil;
        private System.Windows.Forms.Button buttonHintergrundFarbe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelHintergrundFarbeVorschau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxHintergrundMuster;
        private System.Windows.Forms.RadioButton radioButtonHintergrundMuster;
        private System.Windows.Forms.RadioButton radioButtonHintergrundFarbe;
        private System.Windows.Forms.RadioButton radioButtonHintergrundOhne;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonLinie;
        private System.Windows.Forms.RadioButton radioButtonRechteck;
        private System.Windows.Forms.RadioButton radioButtonKreis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownGesch;
        private System.Windows.Forms.NumericUpDown numericUpDownAnzahl;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

