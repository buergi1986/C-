namespace Buch2020
{
    partial class Rueckgabe
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
            this.buch2020DataSet = new Buch2020.buch2020DataSet();
            this.mediumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediumTableAdapter = new Buch2020.buch2020DataSetTableAdapters.MediumTableAdapter();
            this.tableAdapterManager = new Buch2020.buch2020DataSetTableAdapters.TableAdapterManager();
            this.mNummerComboBox = new System.Windows.Forms.ComboBox();
            this.buttonUebernehmen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonDetailMedium = new System.Windows.Forms.Button();
            mNummerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mNummerLabel
            // 
            mNummerLabel.AutoSize = true;
            mNummerLabel.Location = new System.Drawing.Point(12, 9);
            mNummerLabel.Name = "mNummerLabel";
            mNummerLabel.Size = new System.Drawing.Size(82, 13);
            mNummerLabel.TabIndex = 1;
            mNummerLabel.Text = "Mediennummer:";
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
            this.mediumBindingSource.Filter = "ausgeliehen = 1";
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
            // mNummerComboBox
            // 
            this.mNummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "mNummer", true));
            this.mNummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mediumBindingSource, "mNummer", true));
            this.mNummerComboBox.DataSource = this.mediumBindingSource;
            this.mNummerComboBox.DisplayMember = "mNummer";
            this.mNummerComboBox.FormattingEnabled = true;
            this.mNummerComboBox.Location = new System.Drawing.Point(110, 6);
            this.mNummerComboBox.Name = "mNummerComboBox";
            this.mNummerComboBox.Size = new System.Drawing.Size(121, 21);
            this.mNummerComboBox.TabIndex = 2;
            this.mNummerComboBox.ValueMember = "mNummer";
            // 
            // buttonUebernehmen
            // 
            this.buttonUebernehmen.Location = new System.Drawing.Point(15, 50);
            this.buttonUebernehmen.Name = "buttonUebernehmen";
            this.buttonUebernehmen.Size = new System.Drawing.Size(81, 23);
            this.buttonUebernehmen.TabIndex = 3;
            this.buttonUebernehmen.Text = "Übernehmen";
            this.buttonUebernehmen.UseVisualStyleBackColor = true;
            this.buttonUebernehmen.Click += new System.EventHandler(this.buttonUebernehmen_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(196, 50);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 3;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // buttonDetailMedium
            // 
            this.buttonDetailMedium.Location = new System.Drawing.Point(237, 6);
            this.buttonDetailMedium.Name = "buttonDetailMedium";
            this.buttonDetailMedium.Size = new System.Drawing.Size(34, 23);
            this.buttonDetailMedium.TabIndex = 14;
            this.buttonDetailMedium.Text = "...";
            this.buttonDetailMedium.UseVisualStyleBackColor = true;
            this.buttonDetailMedium.Click += new System.EventHandler(this.buttonDetailMedium_Click);
            // 
            // Rueckgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 89);
            this.ControlBox = false;
            this.Controls.Add(this.buttonDetailMedium);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonUebernehmen);
            this.Controls.Add(mNummerLabel);
            this.Controls.Add(this.mNummerComboBox);
            this.Name = "Rueckgabe";
            this.Text = "Rückgabe";
            this.Load += new System.EventHandler(this.Rueckgabe_Load);
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
        private System.Windows.Forms.ComboBox mNummerComboBox;
        private System.Windows.Forms.Button buttonUebernehmen;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonDetailMedium;
    }
}