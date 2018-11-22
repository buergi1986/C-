namespace Buch2020
{
    partial class Vertrageinzel
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
            System.Windows.Forms.Label vNummerLabel;
            System.Windows.Forms.Label ausleihDatumLabel;
            System.Windows.Forms.Label rueckgabeDatumLabel;
            System.Windows.Forms.Label kNummerLabel;
            System.Windows.Forms.Label mNummerLabel;
            this.buch2020DataSet = new Buch2020.buch2020DataSet();
            this.vertragBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vertragTableAdapter = new Buch2020.buch2020DataSetTableAdapters.VertragTableAdapter();
            this.tableAdapterManager = new Buch2020.buch2020DataSetTableAdapters.TableAdapterManager();
            this.kundeTableAdapter = new Buch2020.buch2020DataSetTableAdapters.KundeTableAdapter();
            this.mediumTableAdapter = new Buch2020.buch2020DataSetTableAdapters.MediumTableAdapter();
            this.vNummerTextBox = new System.Windows.Forms.TextBox();
            this.ausleihDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rueckgabeDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kNummerComboBox = new System.Windows.Forms.ComboBox();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mNummerComboBox = new System.Windows.Forms.ComboBox();
            this.mediumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonKundenDetail = new System.Windows.Forms.Button();
            this.buttonMediumDetail = new System.Windows.Forms.Button();
            vNummerLabel = new System.Windows.Forms.Label();
            ausleihDatumLabel = new System.Windows.Forms.Label();
            rueckgabeDatumLabel = new System.Windows.Forms.Label();
            kNummerLabel = new System.Windows.Forms.Label();
            mNummerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vNummerLabel
            // 
            vNummerLabel.AutoSize = true;
            vNummerLabel.Location = new System.Drawing.Point(10, 17);
            vNummerLabel.Name = "vNummerLabel";
            vNummerLabel.Size = new System.Drawing.Size(86, 13);
            vNummerLabel.TabIndex = 1;
            vNummerLabel.Text = "Vertragsnummer:";
            // 
            // ausleihDatumLabel
            // 
            ausleihDatumLabel.AutoSize = true;
            ausleihDatumLabel.Location = new System.Drawing.Point(10, 44);
            ausleihDatumLabel.Name = "ausleihDatumLabel";
            ausleihDatumLabel.Size = new System.Drawing.Size(73, 13);
            ausleihDatumLabel.TabIndex = 3;
            ausleihDatumLabel.Text = "Ausleihdatum:";
            // 
            // rueckgabeDatumLabel
            // 
            rueckgabeDatumLabel.AutoSize = true;
            rueckgabeDatumLabel.Location = new System.Drawing.Point(10, 70);
            rueckgabeDatumLabel.Name = "rueckgabeDatumLabel";
            rueckgabeDatumLabel.Size = new System.Drawing.Size(89, 13);
            rueckgabeDatumLabel.TabIndex = 5;
            rueckgabeDatumLabel.Text = "Rückgabedatum:";
            // 
            // kNummerLabel
            // 
            kNummerLabel.AutoSize = true;
            kNummerLabel.Location = new System.Drawing.Point(10, 95);
            kNummerLabel.Name = "kNummerLabel";
            kNummerLabel.Size = new System.Drawing.Size(41, 13);
            kNummerLabel.TabIndex = 7;
            kNummerLabel.Text = "Kunde:";
            // 
            // mNummerLabel
            // 
            mNummerLabel.AutoSize = true;
            mNummerLabel.Location = new System.Drawing.Point(10, 122);
            mNummerLabel.Name = "mNummerLabel";
            mNummerLabel.Size = new System.Drawing.Size(47, 13);
            mNummerLabel.TabIndex = 9;
            mNummerLabel.Text = "Medium:";
            // 
            // buch2020DataSet
            // 
            this.buch2020DataSet.DataSetName = "buch2020DataSet";
            this.buch2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vertragBindingSource
            // 
            this.vertragBindingSource.DataMember = "Vertrag";
            this.vertragBindingSource.DataSource = this.buch2020DataSet;
            // 
            // vertragTableAdapter
            // 
            this.vertragTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = this.kundeTableAdapter;
            this.tableAdapterManager.MediumTableAdapter = this.mediumTableAdapter;
            this.tableAdapterManager.ReservierungenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Buch2020.buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VertragTableAdapter = this.vertragTableAdapter;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // mediumTableAdapter
            // 
            this.mediumTableAdapter.ClearBeforeFill = true;
            // 
            // vNummerTextBox
            // 
            this.vNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vertragBindingSource, "vNummer", true));
            this.vNummerTextBox.Enabled = false;
            this.vNummerTextBox.Location = new System.Drawing.Point(111, 14);
            this.vNummerTextBox.Name = "vNummerTextBox";
            this.vNummerTextBox.Size = new System.Drawing.Size(200, 20);
            this.vNummerTextBox.TabIndex = 2;
            // 
            // ausleihDatumDateTimePicker
            // 
            this.ausleihDatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vertragBindingSource, "ausleihDatum", true));
            this.ausleihDatumDateTimePicker.Location = new System.Drawing.Point(111, 40);
            this.ausleihDatumDateTimePicker.Name = "ausleihDatumDateTimePicker";
            this.ausleihDatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ausleihDatumDateTimePicker.TabIndex = 4;
            // 
            // rueckgabeDatumDateTimePicker
            // 
            this.rueckgabeDatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vertragBindingSource, "rueckgabeDatum", true));
            this.rueckgabeDatumDateTimePicker.Location = new System.Drawing.Point(111, 66);
            this.rueckgabeDatumDateTimePicker.Name = "rueckgabeDatumDateTimePicker";
            this.rueckgabeDatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.rueckgabeDatumDateTimePicker.TabIndex = 6;
            // 
            // kNummerComboBox
            // 
            this.kNummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vertragBindingSource, "kNummer", true));
            this.kNummerComboBox.DataSource = this.kundeBindingSource;
            this.kNummerComboBox.DisplayMember = "kName";
            this.kNummerComboBox.FormattingEnabled = true;
            this.kNummerComboBox.Location = new System.Drawing.Point(111, 92);
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
            // mNummerComboBox
            // 
            this.mNummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vertragBindingSource, "mNummer", true));
            this.mNummerComboBox.DataSource = this.mediumBindingSource;
            this.mNummerComboBox.DisplayMember = "titel";
            this.mNummerComboBox.FormattingEnabled = true;
            this.mNummerComboBox.Location = new System.Drawing.Point(111, 119);
            this.mNummerComboBox.Name = "mNummerComboBox";
            this.mNummerComboBox.Size = new System.Drawing.Size(200, 21);
            this.mNummerComboBox.TabIndex = 10;
            this.mNummerComboBox.ValueMember = "mNummer";
            // 
            // mediumBindingSource
            // 
            this.mediumBindingSource.DataMember = "Medium";
            this.mediumBindingSource.DataSource = this.buch2020DataSet;
            this.mediumBindingSource.Filter = "ausgeliehen = 0 and bestand = 0";
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(13, 169);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichern.TabIndex = 11;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(235, 169);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 12;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // buttonKundenDetail
            // 
            this.buttonKundenDetail.Location = new System.Drawing.Point(318, 92);
            this.buttonKundenDetail.Name = "buttonKundenDetail";
            this.buttonKundenDetail.Size = new System.Drawing.Size(31, 23);
            this.buttonKundenDetail.TabIndex = 13;
            this.buttonKundenDetail.Text = "...";
            this.buttonKundenDetail.UseVisualStyleBackColor = true;
            this.buttonKundenDetail.Click += new System.EventHandler(this.buttonKundenDetail_Click);
            // 
            // buttonMediumDetail
            // 
            this.buttonMediumDetail.Location = new System.Drawing.Point(317, 121);
            this.buttonMediumDetail.Name = "buttonMediumDetail";
            this.buttonMediumDetail.Size = new System.Drawing.Size(31, 23);
            this.buttonMediumDetail.TabIndex = 14;
            this.buttonMediumDetail.Text = "...";
            this.buttonMediumDetail.UseVisualStyleBackColor = true;
            this.buttonMediumDetail.Click += new System.EventHandler(this.buttonMediumDetail_Click);
            // 
            // Vertrageinzel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 204);
            this.ControlBox = false;
            this.Controls.Add(this.buttonMediumDetail);
            this.Controls.Add(this.buttonKundenDetail);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(vNummerLabel);
            this.Controls.Add(this.vNummerTextBox);
            this.Controls.Add(ausleihDatumLabel);
            this.Controls.Add(this.ausleihDatumDateTimePicker);
            this.Controls.Add(rueckgabeDatumLabel);
            this.Controls.Add(this.rueckgabeDatumDateTimePicker);
            this.Controls.Add(kNummerLabel);
            this.Controls.Add(this.kNummerComboBox);
            this.Controls.Add(mNummerLabel);
            this.Controls.Add(this.mNummerComboBox);
            this.Name = "Vertrageinzel";
            this.Text = "Neue Ausleihe erfasssen";
            this.Load += new System.EventHandler(this.Vertrageinzel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource vertragBindingSource;
        private buch2020DataSetTableAdapters.VertragTableAdapter vertragTableAdapter;
        private buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox vNummerTextBox;
        private System.Windows.Forms.DateTimePicker ausleihDatumDateTimePicker;
        private System.Windows.Forms.DateTimePicker rueckgabeDatumDateTimePicker;
        private System.Windows.Forms.ComboBox kNummerComboBox;
        private System.Windows.Forms.ComboBox mNummerComboBox;
        private buch2020DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private buch2020DataSetTableAdapters.MediumTableAdapter mediumTableAdapter;
        private System.Windows.Forms.BindingSource mediumBindingSource;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonKundenDetail;
        private System.Windows.Forms.Button buttonMediumDetail;
    }
}