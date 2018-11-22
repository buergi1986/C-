namespace Buch2020
{
    partial class Suchfunktion
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
            this.buch2020DataSet = new Buch2020.buch2020DataSet();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new Buch2020.buch2020DataSetTableAdapters.KundeTableAdapter();
            this.tableAdapterManager = new Buch2020.buch2020DataSetTableAdapters.TableAdapterManager();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSchliessen = new System.Windows.Forms.Button();
            this.buch2020DataSet1 = new Buch2020.buch2020DataSet();
            this.dataGridViewKunde = new System.Windows.Forms.DataGridView();
            this.kNummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postleitzahlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKunde)).BeginInit();
            this.SuspendLayout();
            // 
            // buch2020DataSet
            // 
            this.buch2020DataSet.DataSetName = "buch2020DataSet";
            this.buch2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = this.kundeTableAdapter;
            this.tableAdapterManager.MediumTableAdapter = null;
            this.tableAdapterManager.ReservierungenTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Buch2020.buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VertragTableAdapter = null;
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Location = new System.Drawing.Point(183, 12);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(75, 23);
            this.buttonSuchen.TabIndex = 2;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.UseVisualStyleBackColor = true;
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(77, 14);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(100, 20);
            this.textBoxNachname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nachname:";
            // 
            // buttonSchliessen
            // 
            this.buttonSchliessen.Location = new System.Drawing.Point(264, 12);
            this.buttonSchliessen.Name = "buttonSchliessen";
            this.buttonSchliessen.Size = new System.Drawing.Size(75, 23);
            this.buttonSchliessen.TabIndex = 5;
            this.buttonSchliessen.Text = "Schliessen";
            this.buttonSchliessen.UseVisualStyleBackColor = true;
            this.buttonSchliessen.Click += new System.EventHandler(this.buttonSchliessen_Click);
            // 
            // buch2020DataSet1
            // 
            this.buch2020DataSet1.DataSetName = "buch2020DataSet";
            this.buch2020DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewKunde
            // 
            this.dataGridViewKunde.AllowUserToAddRows = false;
            this.dataGridViewKunde.AllowUserToDeleteRows = false;
            this.dataGridViewKunde.AutoGenerateColumns = false;
            this.dataGridViewKunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKunde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kNummerDataGridViewTextBoxColumn,
            this.kNameDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.strasseDataGridViewTextBoxColumn,
            this.postleitzahlDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.telefon1DataGridViewTextBoxColumn,
            this.telefon2DataGridViewTextBoxColumn});
            this.dataGridViewKunde.DataSource = this.kundeBindingSource;
            this.dataGridViewKunde.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewKunde.Location = new System.Drawing.Point(0, 41);
            this.dataGridViewKunde.Name = "dataGridViewKunde";
            this.dataGridViewKunde.ReadOnly = true;
            this.dataGridViewKunde.Size = new System.Drawing.Size(844, 296);
            this.dataGridViewKunde.TabIndex = 6;
            // 
            // kNummerDataGridViewTextBoxColumn
            // 
            this.kNummerDataGridViewTextBoxColumn.DataPropertyName = "kNummer";
            this.kNummerDataGridViewTextBoxColumn.HeaderText = "Kundennummer";
            this.kNummerDataGridViewTextBoxColumn.Name = "kNummerDataGridViewTextBoxColumn";
            this.kNummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kNameDataGridViewTextBoxColumn
            // 
            this.kNameDataGridViewTextBoxColumn.DataPropertyName = "kName";
            this.kNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.kNameDataGridViewTextBoxColumn.Name = "kNameDataGridViewTextBoxColumn";
            this.kNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            this.vornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strasseDataGridViewTextBoxColumn
            // 
            this.strasseDataGridViewTextBoxColumn.DataPropertyName = "strasse";
            this.strasseDataGridViewTextBoxColumn.HeaderText = "Strasse";
            this.strasseDataGridViewTextBoxColumn.Name = "strasseDataGridViewTextBoxColumn";
            this.strasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postleitzahlDataGridViewTextBoxColumn
            // 
            this.postleitzahlDataGridViewTextBoxColumn.DataPropertyName = "postleitzahl";
            this.postleitzahlDataGridViewTextBoxColumn.HeaderText = "Postleitzahl";
            this.postleitzahlDataGridViewTextBoxColumn.Name = "postleitzahlDataGridViewTextBoxColumn";
            this.postleitzahlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            this.ortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefon1DataGridViewTextBoxColumn
            // 
            this.telefon1DataGridViewTextBoxColumn.DataPropertyName = "telefon1";
            this.telefon1DataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefon1DataGridViewTextBoxColumn.Name = "telefon1DataGridViewTextBoxColumn";
            this.telefon1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefon2DataGridViewTextBoxColumn
            // 
            this.telefon2DataGridViewTextBoxColumn.DataPropertyName = "telefon2";
            this.telefon2DataGridViewTextBoxColumn.HeaderText = "Weitere Telefon...";
            this.telefon2DataGridViewTextBoxColumn.Name = "telefon2DataGridViewTextBoxColumn";
            this.telefon2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Suchfunktion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 337);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewKunde);
            this.Controls.Add(this.buttonSchliessen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.buttonSuchen);
            this.Name = "Suchfunktion";
            this.Text = "Kunden suchen";
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKunde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private buch2020DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSchliessen;
        private buch2020DataSet buch2020DataSet1;
        private System.Windows.Forms.DataGridView dataGridViewKunde;
        private System.Windows.Forms.DataGridViewTextBoxColumn kNummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postleitzahlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon2DataGridViewTextBoxColumn;
    }
}