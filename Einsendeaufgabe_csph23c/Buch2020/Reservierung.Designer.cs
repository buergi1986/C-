namespace Buch2020
{
    partial class Reservierung
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
            System.Windows.Forms.Label rNummerLabel;
            System.Windows.Forms.Label gueltigBisLabel;
            System.Windows.Forms.Label mNummerLabel;
            System.Windows.Forms.Label kNummerLabel;
            this.buch2020DataSet = new Buch2020.buch2020DataSet();
            this.reservierungenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservierungenTableAdapter = new Buch2020.buch2020DataSetTableAdapters.ReservierungenTableAdapter();
            this.tableAdapterManager = new Buch2020.buch2020DataSetTableAdapters.TableAdapterManager();
            this.rNummerTextBox = new System.Windows.Forms.TextBox();
            this.gueltigBisDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mNummerComboBox = new System.Windows.Forms.ComboBox();
            this.kNummerComboBox = new System.Windows.Forms.ComboBox();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new Buch2020.buch2020DataSetTableAdapters.KundeTableAdapter();
            this.mediumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediumTableAdapter = new Buch2020.buch2020DataSetTableAdapters.MediumTableAdapter();
            this.buttonDetailKunde = new System.Windows.Forms.Button();
            this.buttonDetailMedium = new System.Windows.Forms.Button();
            this.buttonUebernehmen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            rNummerLabel = new System.Windows.Forms.Label();
            gueltigBisLabel = new System.Windows.Forms.Label();
            mNummerLabel = new System.Windows.Forms.Label();
            kNummerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservierungenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buch2020DataSet
            // 
            this.buch2020DataSet.DataSetName = "buch2020DataSet";
            this.buch2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservierungenBindingSource
            // 
            this.reservierungenBindingSource.DataMember = "Reservierungen";
            this.reservierungenBindingSource.DataSource = this.buch2020DataSet;
            // 
            // reservierungenTableAdapter
            // 
            this.reservierungenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = this.kundeTableAdapter;
            this.tableAdapterManager.MediumTableAdapter = this.mediumTableAdapter;
            this.tableAdapterManager.ReservierungenTableAdapter = this.reservierungenTableAdapter;
            this.tableAdapterManager.UpdateOrder = Buch2020.buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VertragTableAdapter = null;
            // 
            // rNummerLabel
            // 
            rNummerLabel.AutoSize = true;
            rNummerLabel.Location = new System.Drawing.Point(8, 13);
            rNummerLabel.Name = "rNummerLabel";
            rNummerLabel.Size = new System.Drawing.Size(115, 13);
            rNummerLabel.TabIndex = 1;
            rNummerLabel.Text = "Reservierungsnummer:";
            // 
            // rNummerTextBox
            // 
            this.rNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservierungenBindingSource, "rNummer", true));
            this.rNummerTextBox.Location = new System.Drawing.Point(141, 6);
            this.rNummerTextBox.Name = "rNummerTextBox";
            this.rNummerTextBox.ReadOnly = true;
            this.rNummerTextBox.Size = new System.Drawing.Size(200, 20);
            this.rNummerTextBox.TabIndex = 2;
            // 
            // gueltigBisLabel
            // 
            gueltigBisLabel.AutoSize = true;
            gueltigBisLabel.Location = new System.Drawing.Point(8, 40);
            gueltigBisLabel.Name = "gueltigBisLabel";
            gueltigBisLabel.Size = new System.Drawing.Size(53, 13);
            gueltigBisLabel.TabIndex = 3;
            gueltigBisLabel.Text = "Gültig bis:";
            // 
            // gueltigBisDateTimePicker
            // 
            this.gueltigBisDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservierungenBindingSource, "gueltigBis", true));
            this.gueltigBisDateTimePicker.Location = new System.Drawing.Point(141, 36);
            this.gueltigBisDateTimePicker.Name = "gueltigBisDateTimePicker";
            this.gueltigBisDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.gueltigBisDateTimePicker.TabIndex = 4;
            // 
            // mNummerLabel
            // 
            mNummerLabel.AutoSize = true;
            mNummerLabel.Location = new System.Drawing.Point(8, 65);
            mNummerLabel.Name = "mNummerLabel";
            mNummerLabel.Size = new System.Drawing.Size(82, 13);
            mNummerLabel.TabIndex = 5;
            mNummerLabel.Text = "Mediennummer:";
            // 
            // mNummerComboBox
            // 
            this.mNummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reservierungenBindingSource, "mNummer", true));
            this.mNummerComboBox.DataSource = this.mediumBindingSource;
            this.mNummerComboBox.DisplayMember = "titel";
            this.mNummerComboBox.FormattingEnabled = true;
            this.mNummerComboBox.Location = new System.Drawing.Point(141, 62);
            this.mNummerComboBox.Name = "mNummerComboBox";
            this.mNummerComboBox.Size = new System.Drawing.Size(200, 21);
            this.mNummerComboBox.TabIndex = 6;
            this.mNummerComboBox.ValueMember = "mNummer";
            // 
            // kNummerLabel
            // 
            kNummerLabel.AutoSize = true;
            kNummerLabel.Location = new System.Drawing.Point(8, 92);
            kNummerLabel.Name = "kNummerLabel";
            kNummerLabel.Size = new System.Drawing.Size(84, 13);
            kNummerLabel.TabIndex = 7;
            kNummerLabel.Text = "Kundennummer:";
            // 
            // kNummerComboBox
            // 
            this.kNummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reservierungenBindingSource, "kNummer", true));
            this.kNummerComboBox.DataSource = this.kundeBindingSource;
            this.kNummerComboBox.DisplayMember = "kName";
            this.kNummerComboBox.FormattingEnabled = true;
            this.kNummerComboBox.Location = new System.Drawing.Point(141, 92);
            this.kNummerComboBox.Name = "kNummerComboBox";
            this.kNummerComboBox.Size = new System.Drawing.Size(200, 21);
            this.kNummerComboBox.TabIndex = 8;
            this.kNummerComboBox.ValueMember = "kNummer";
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            this.kundeBindingSource.DataSource = this.buch2020DataSet;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // mediumBindingSource
            // 
            this.mediumBindingSource.DataMember = "Medium";
            this.mediumBindingSource.DataSource = this.buch2020DataSet;
            this.mediumBindingSource.Filter = "ausgeliehen = 1";
            // 
            // mediumTableAdapter
            // 
            this.mediumTableAdapter.ClearBeforeFill = true;
            // 
            // buttonDetailKunde
            // 
            this.buttonDetailKunde.Location = new System.Drawing.Point(347, 92);
            this.buttonDetailKunde.Name = "buttonDetailKunde";
            this.buttonDetailKunde.Size = new System.Drawing.Size(34, 23);
            this.buttonDetailKunde.TabIndex = 13;
            this.buttonDetailKunde.Text = "...";
            this.buttonDetailKunde.UseVisualStyleBackColor = true;
            this.buttonDetailKunde.Click += new System.EventHandler(this.buttonDetailKunde_Click);
            // 
            // buttonDetailMedium
            // 
            this.buttonDetailMedium.Location = new System.Drawing.Point(347, 62);
            this.buttonDetailMedium.Name = "buttonDetailMedium";
            this.buttonDetailMedium.Size = new System.Drawing.Size(34, 23);
            this.buttonDetailMedium.TabIndex = 13;
            this.buttonDetailMedium.Text = "...";
            this.buttonDetailMedium.UseVisualStyleBackColor = true;
            this.buttonDetailMedium.Click += new System.EventHandler(this.buttonDetailMedium_Click);
            // 
            // buttonUebernehmen
            // 
            this.buttonUebernehmen.Location = new System.Drawing.Point(11, 148);
            this.buttonUebernehmen.Name = "buttonUebernehmen";
            this.buttonUebernehmen.Size = new System.Drawing.Size(79, 23);
            this.buttonUebernehmen.TabIndex = 14;
            this.buttonUebernehmen.Text = "Übernehmen";
            this.buttonUebernehmen.UseVisualStyleBackColor = true;
            this.buttonUebernehmen.Click += new System.EventHandler(this.buttonUebernehmen_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(306, 148);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 14;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // Reservierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 185);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonUebernehmen);
            this.Controls.Add(this.buttonDetailMedium);
            this.Controls.Add(this.buttonDetailKunde);
            this.Controls.Add(rNummerLabel);
            this.Controls.Add(this.rNummerTextBox);
            this.Controls.Add(gueltigBisLabel);
            this.Controls.Add(this.gueltigBisDateTimePicker);
            this.Controls.Add(mNummerLabel);
            this.Controls.Add(this.mNummerComboBox);
            this.Controls.Add(kNummerLabel);
            this.Controls.Add(this.kNummerComboBox);
            this.Name = "Reservierung";
            this.Text = "Reservierung anlegen";
            this.Load += new System.EventHandler(this.Reservierung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservierungenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource reservierungenBindingSource;
        private buch2020DataSetTableAdapters.ReservierungenTableAdapter reservierungenTableAdapter;
        private buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox rNummerTextBox;
        private System.Windows.Forms.DateTimePicker gueltigBisDateTimePicker;
        private System.Windows.Forms.ComboBox mNummerComboBox;
        private System.Windows.Forms.ComboBox kNummerComboBox;
        private buch2020DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private buch2020DataSetTableAdapters.MediumTableAdapter mediumTableAdapter;
        private System.Windows.Forms.BindingSource mediumBindingSource;
        private System.Windows.Forms.Button buttonDetailKunde;
        private System.Windows.Forms.Button buttonDetailMedium;
        private System.Windows.Forms.Button buttonUebernehmen;
        private System.Windows.Forms.Button buttonAbbrechen;
    }
}