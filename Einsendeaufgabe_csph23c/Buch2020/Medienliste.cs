using System;
using System.Drawing;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class Medienliste : Form
    {
        Color alteFarbe;

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
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Reservierungen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.reservierungenTableAdapter.Fill(this.buch2020DataSet.Reservierungen);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Vertrag". Sie können sie bei Bedarf verschieben oder entfernen.
            this.vertragTableAdapter.Fill(this.buch2020DataSet.Vertrag);
        }

        private void mediumDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //befindet sich die Maus über einer Zelle?
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                //für den leichteren Zugriff
                DataGridViewCell zelle = mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //die alte Farbe sichern
                alteFarbe = zelle.Style.BackColor;
                //die neue Farbe setzen
                zelle.Style.BackColor = Color.LightBlue;
            }
        }

        private void mediumDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                //für den leichteren Zugriff
                DataGridViewCell zelle = mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //die alte Farbe wiederherstellen
                zelle.Style.BackColor = alteFarbe;
            }
        }

        private void mediumDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\nBitte überprüfen Sie Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mediumDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText != string.Empty)
                mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
        }

        private void mediumDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //überprüft werden nur die Spalten 2 bis 4
            //der Index beginnt bei 0!
            if ((e.ColumnIndex > 0) && (e.ColumnIndex < 3))
            {
                //ist der Eintrag leer?
                if (e.FormattedValue.ToString() == string.Empty)
                {
                    //eine Meldung anzeigen
                    MessageBox.Show("Sie müssen einen Wert für " + mediumDataGridView.Columns[e.ColumnIndex].HeaderText + " eingeben.");
                    //den Fehlertext setzen
                    mediumDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Die Zelle darf nicht leer sein!";
                    //die Aktion abbrechen
                    e.Cancel = true;
                }
            }
        }
    }
}
