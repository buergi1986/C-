using System;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class ListenanzeigeMedien : Form
    {
        public ListenanzeigeMedien()
        {
            InitializeComponent();
        }

        private void mediumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mediumBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void ListenanzeigeMedien_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);

        }
    }
}
