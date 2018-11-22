using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class Medienliste : Form
    {
        public Medienliste()
        {
            InitializeComponent();
        }

        private void mediumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mediumBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.buch2020DataSet);
            }
            catch
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\nBitte überprüfen Sie Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Medienliste_Load(object sender, EventArgs e)
        {
            
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);

        }

        private void mediumDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if ((e.ColumnIndex > 0) && (e.ColumnIndex < 4))
            {
                if (e.FormattedValue.ToString() == string.Empty)
                {
                    //eine Meldung anzeigen
                    //bitte jeweils in einer Zeile eingeben
                    MessageBox.Show("Sie müssen einen Wert für " + mediumDataGridView.Columns[e.ColumnIndex].HeaderText + " eingeben.");
                    //den Fehlertext setzen
                    mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Die Zelle darf nicht leer sein!";
                    //die Aktion abbrechen
                    e.Cancel = true;
                }
            }
        }

        private void mediumDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText != string.Empty)
            {
                mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
            }
        }
    }
}
