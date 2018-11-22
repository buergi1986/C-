namespace Buch2020
{
    partial class Kundenliste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kundenliste));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buch2020DataSet = new Buch2020.buch2020DataSet();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new Buch2020.buch2020DataSetTableAdapters.KundeTableAdapter();
            this.tableAdapterManager = new Buch2020.buch2020DataSetTableAdapters.TableAdapterManager();
            this.kundeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kundeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kundeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vertragBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vertragTableAdapter = new Buch2020.buch2020DataSetTableAdapters.VertragTableAdapter();
            this.reservierungenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservierungenTableAdapter = new Buch2020.buch2020DataSetTableAdapters.ReservierungenTableAdapter();
            this.mediumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediumTableAdapter = new Buch2020.buch2020DataSetTableAdapters.MediumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingNavigator)).BeginInit();
            this.kundeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kundeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservierungenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).BeginInit();
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
            this.tableAdapterManager.MediumTableAdapter = this.mediumTableAdapter;
            this.tableAdapterManager.ReservierungenTableAdapter = this.reservierungenTableAdapter;
            this.tableAdapterManager.UpdateOrder = Buch2020.buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VertragTableAdapter = this.vertragTableAdapter;
            // 
            // kundeBindingNavigator
            // 
            this.kundeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kundeBindingNavigator.BindingSource = this.kundeBindingSource;
            this.kundeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kundeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kundeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kundeBindingNavigatorSaveItem});
            this.kundeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kundeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kundeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kundeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kundeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kundeBindingNavigator.Name = "kundeBindingNavigator";
            this.kundeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kundeBindingNavigator.Size = new System.Drawing.Size(881, 25);
            this.kundeBindingNavigator.TabIndex = 0;
            this.kundeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // kundeBindingNavigatorSaveItem
            // 
            this.kundeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kundeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kundeBindingNavigatorSaveItem.Image")));
            this.kundeBindingNavigatorSaveItem.Name = "kundeBindingNavigatorSaveItem";
            this.kundeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kundeBindingNavigatorSaveItem.Text = "Daten speichern";
            this.kundeBindingNavigatorSaveItem.Click += new System.EventHandler(this.kundeBindingNavigatorSaveItem_Click);
            // 
            // kundeDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.kundeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kundeDataGridView.AutoGenerateColumns = false;
            this.kundeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kundeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.kundeDataGridView.DataSource = this.kundeBindingSource;
            this.kundeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kundeDataGridView.Location = new System.Drawing.Point(0, 25);
            this.kundeDataGridView.Name = "kundeDataGridView";
            this.kundeDataGridView.Size = new System.Drawing.Size(881, 292);
            this.kundeDataGridView.TabIndex = 1;
            this.kundeDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.kundeDataGridView_CellEndEdit);
            this.kundeDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.kundeDataGridView_CellMouseEnter);
            this.kundeDataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.kundeDataGridView_CellMouseLeave);
            this.kundeDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.kundeDataGridView_CellValidating);
            this.kundeDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.kundeDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kNummer";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Kundennummer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Klicken Sie hier, um die Anzeige nach der Kundennummer zu sortieren.";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "Klicken Sie hier, um die Anzeige nach dem Namen zu sortieren.";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "vorname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vorname";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "strasse";
            this.dataGridViewTextBoxColumn4.HeaderText = "Straße";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Klicken Sie hier, um die Anzeige nach der Straße zu sortieren.";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "postleitzahl";
            this.dataGridViewTextBoxColumn5.HeaderText = "PLZ";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 5;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Klicken Sie hier, um die Anzeige nach der Postleitzahl zu sortieren.";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ort";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ort";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "Klicken Sie hier, um die Anzeige nach dem Ort zu sortieren.";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "telefon1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefon 1";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 20;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ToolTipText = "Klicken Sie hier, um die Anzeige nach der Telefonnummer zu sortieren.";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "telefon2";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefon 2";
            this.dataGridViewTextBoxColumn8.MaxInputLength = 20;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ToolTipText = "Klicken Sie hier, um die Anzeige nach der Telefonnummer zu sortieren.";
            // 
            // vertragBindingSource
            // 
            this.vertragBindingSource.DataMember = "FK_Kunde_Vertrag";
            this.vertragBindingSource.DataSource = this.kundeBindingSource;
            // 
            // vertragTableAdapter
            // 
            this.vertragTableAdapter.ClearBeforeFill = true;
            // 
            // reservierungenBindingSource
            // 
            this.reservierungenBindingSource.DataMember = "FK_Kunde_Reservierungen";
            this.reservierungenBindingSource.DataSource = this.kundeBindingSource;
            // 
            // reservierungenTableAdapter
            // 
            this.reservierungenTableAdapter.ClearBeforeFill = true;
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
            // Kundenliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(881, 317);
            this.Controls.Add(this.kundeDataGridView);
            this.Controls.Add(this.kundeBindingNavigator);
            this.Name = "Kundenliste";
            this.Text = "Kunden - Listenansicht";
            this.Load += new System.EventHandler(this.Kundenliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingNavigator)).EndInit();
            this.kundeBindingNavigator.ResumeLayout(false);
            this.kundeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kundeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservierungenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private buch2020DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kundeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kundeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kundeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource vertragBindingSource;
        private buch2020DataSetTableAdapters.VertragTableAdapter vertragTableAdapter;
        private System.Windows.Forms.BindingSource reservierungenBindingSource;
        private buch2020DataSetTableAdapters.ReservierungenTableAdapter reservierungenTableAdapter;
        private System.Windows.Forms.BindingSource mediumBindingSource;
        private buch2020DataSetTableAdapters.MediumTableAdapter mediumTableAdapter;
    }
}