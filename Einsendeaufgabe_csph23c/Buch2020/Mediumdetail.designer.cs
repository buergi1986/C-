namespace Buch2020
{
    partial class Mediumdetail
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mNummerLabel;
            System.Windows.Forms.Label titelLabel;
            System.Windows.Forms.Label typLabel;
            System.Windows.Forms.Label standortLabel;
            System.Windows.Forms.Label ausgeliehenLabel;
            System.Windows.Forms.Label bestandLabel;
            this.buch2020DataSet = new Buch2020.buch2020DataSet();
            this.mediumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediumTableAdapter = new Buch2020.buch2020DataSetTableAdapters.MediumTableAdapter();
            this.tableAdapterManager = new Buch2020.buch2020DataSetTableAdapters.TableAdapterManager();
            this.mNummerTextBox = new System.Windows.Forms.TextBox();
            this.titelTextBox = new System.Windows.Forms.TextBox();
            this.typTextBox = new System.Windows.Forms.TextBox();
            this.standortTextBox = new System.Windows.Forms.TextBox();
            this.ausgeliehenCheckBox = new System.Windows.Forms.CheckBox();
            this.bestandCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonSchliessen = new System.Windows.Forms.Button();
            mNummerLabel = new System.Windows.Forms.Label();
            titelLabel = new System.Windows.Forms.Label();
            typLabel = new System.Windows.Forms.Label();
            standortLabel = new System.Windows.Forms.Label();
            ausgeliehenLabel = new System.Windows.Forms.Label();
            bestandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mNummerLabel
            // 
            mNummerLabel.AutoSize = true;
            mNummerLabel.Location = new System.Drawing.Point(11, 9);
            mNummerLabel.Name = "mNummerLabel";
            mNummerLabel.Size = new System.Drawing.Size(82, 13);
            mNummerLabel.TabIndex = 1;
            mNummerLabel.Text = "Mediennummer:";
            // 
            // titelLabel
            // 
            titelLabel.AutoSize = true;
            titelLabel.Location = new System.Drawing.Point(11, 35);
            titelLabel.Name = "titelLabel";
            titelLabel.Size = new System.Drawing.Size(30, 13);
            titelLabel.TabIndex = 3;
            titelLabel.Text = "Titel:";
            // 
            // typLabel
            // 
            typLabel.AutoSize = true;
            typLabel.Location = new System.Drawing.Point(11, 61);
            typLabel.Name = "typLabel";
            typLabel.Size = new System.Drawing.Size(28, 13);
            typLabel.TabIndex = 5;
            typLabel.Text = "Typ:";
            // 
            // standortLabel
            // 
            standortLabel.AutoSize = true;
            standortLabel.Location = new System.Drawing.Point(11, 87);
            standortLabel.Name = "standortLabel";
            standortLabel.Size = new System.Drawing.Size(50, 13);
            standortLabel.TabIndex = 7;
            standortLabel.Text = "Standort:";
            // 
            // ausgeliehenLabel
            // 
            ausgeliehenLabel.AutoSize = true;
            ausgeliehenLabel.Location = new System.Drawing.Point(11, 115);
            ausgeliehenLabel.Name = "ausgeliehenLabel";
            ausgeliehenLabel.Size = new System.Drawing.Size(68, 13);
            ausgeliehenLabel.TabIndex = 9;
            ausgeliehenLabel.Text = "Ausgeliehen:";
            // 
            // bestandLabel
            // 
            bestandLabel.AutoSize = true;
            bestandLabel.Location = new System.Drawing.Point(11, 145);
            bestandLabel.Name = "bestandLabel";
            bestandLabel.Size = new System.Drawing.Size(49, 13);
            bestandLabel.TabIndex = 11;
            bestandLabel.Text = "Bestand:";
            // 
            // buch2020DataSet
            // 
            this.buch2020DataSet.DataSetName = "buch2020DataSet";
            this.buch2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediumBindingSource
            // 
            this.mediumBindingSource.DataMember = "Medium";
            this.mediumBindingSource.DataSource = this.buch2020DataSet;
            // 
            // mediumTableAdapter
            // 
            this.mediumTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = null;
            this.tableAdapterManager.MediumTableAdapter = this.mediumTableAdapter;
            this.tableAdapterManager.ReservierungenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Buch2020.buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VertragTableAdapter = null;
            // 
            // mNummerTextBox
            // 
            this.mNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "mNummer", true));
            this.mNummerTextBox.Location = new System.Drawing.Point(99, 6);
            this.mNummerTextBox.Name = "mNummerTextBox";
            this.mNummerTextBox.ReadOnly = true;
            this.mNummerTextBox.Size = new System.Drawing.Size(104, 20);
            this.mNummerTextBox.TabIndex = 2;
            // 
            // titelTextBox
            // 
            this.titelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "titel", true));
            this.titelTextBox.Location = new System.Drawing.Point(99, 32);
            this.titelTextBox.Name = "titelTextBox";
            this.titelTextBox.ReadOnly = true;
            this.titelTextBox.Size = new System.Drawing.Size(104, 20);
            this.titelTextBox.TabIndex = 4;
            // 
            // typTextBox
            // 
            this.typTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "typ", true));
            this.typTextBox.Location = new System.Drawing.Point(99, 58);
            this.typTextBox.Name = "typTextBox";
            this.typTextBox.ReadOnly = true;
            this.typTextBox.Size = new System.Drawing.Size(104, 20);
            this.typTextBox.TabIndex = 6;
            // 
            // standortTextBox
            // 
            this.standortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "standort", true));
            this.standortTextBox.Location = new System.Drawing.Point(99, 84);
            this.standortTextBox.Name = "standortTextBox";
            this.standortTextBox.ReadOnly = true;
            this.standortTextBox.Size = new System.Drawing.Size(104, 20);
            this.standortTextBox.TabIndex = 8;
            // 
            // ausgeliehenCheckBox
            // 
            this.ausgeliehenCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mediumBindingSource, "ausgeliehen", true));
            this.ausgeliehenCheckBox.Enabled = false;
            this.ausgeliehenCheckBox.Location = new System.Drawing.Point(99, 110);
            this.ausgeliehenCheckBox.Name = "ausgeliehenCheckBox";
            this.ausgeliehenCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ausgeliehenCheckBox.TabIndex = 10;
            this.ausgeliehenCheckBox.UseVisualStyleBackColor = true;
            // 
            // bestandCheckBox
            // 
            this.bestandCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mediumBindingSource, "bestand", true));
            this.bestandCheckBox.Enabled = false;
            this.bestandCheckBox.Location = new System.Drawing.Point(99, 140);
            this.bestandCheckBox.Name = "bestandCheckBox";
            this.bestandCheckBox.Size = new System.Drawing.Size(104, 24);
            this.bestandCheckBox.TabIndex = 12;
            this.bestandCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonSchliessen
            // 
            this.buttonSchliessen.Location = new System.Drawing.Point(80, 173);
            this.buttonSchliessen.Name = "buttonSchliessen";
            this.buttonSchliessen.Size = new System.Drawing.Size(75, 23);
            this.buttonSchliessen.TabIndex = 13;
            this.buttonSchliessen.Text = "Schließen";
            this.buttonSchliessen.UseVisualStyleBackColor = true;
            this.buttonSchliessen.Click += new System.EventHandler(this.buttonSchliessen_Click);
            // 
            // Mediumdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 208);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSchliessen);
            this.Controls.Add(mNummerLabel);
            this.Controls.Add(this.mNummerTextBox);
            this.Controls.Add(titelLabel);
            this.Controls.Add(this.titelTextBox);
            this.Controls.Add(typLabel);
            this.Controls.Add(this.typTextBox);
            this.Controls.Add(standortLabel);
            this.Controls.Add(this.standortTextBox);
            this.Controls.Add(ausgeliehenLabel);
            this.Controls.Add(this.ausgeliehenCheckBox);
            this.Controls.Add(bestandLabel);
            this.Controls.Add(this.bestandCheckBox);
            this.Name = "Mediumdetail";
            this.Text = "Detailanzeige Medium";
            this.Load += new System.EventHandler(this.MediumEinzel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource mediumBindingSource;
        private buch2020DataSetTableAdapters.MediumTableAdapter mediumTableAdapter;
        private buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox mNummerTextBox;
        private System.Windows.Forms.TextBox titelTextBox;
        private System.Windows.Forms.TextBox typTextBox;
        private System.Windows.Forms.TextBox standortTextBox;
        private System.Windows.Forms.CheckBox ausgeliehenCheckBox;
        private System.Windows.Forms.CheckBox bestandCheckBox;
        private System.Windows.Forms.Button buttonSchliessen;
    }
}