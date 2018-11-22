using System;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class Rueckgabe : Form
    {
        public Rueckgabe()
        {
            InitializeComponent();
        }

        private void mediumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mediumBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void Rueckgabe_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);
            //gibt es überhaupt Medien, für die eine Rückgabe vorgenommen werden kann?
            if (mNummerComboBox.Items.Count == 0)
            {
                MessageBox.Show("Es gibt keine Medien für eine Rückgabe!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }


        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonUebernehmen_Click(object sender, EventArgs e)
        {
            //die UPDATE-Abfrage ausführen
            this.mediumTableAdapter.rueckgabeSetzen(Convert.ToInt32(mNummerComboBox.SelectedValue));
            Close();
        }

        private void buttonDetailMedium_Click(object sender, EventArgs e)
        {
            Mediumdetail detailAnzeigeMedium = new Mediumdetail();
            detailAnzeigeMedium.DetailsLaden(Convert.ToInt32(mNummerComboBox.SelectedValue));
            detailAnzeigeMedium.ShowDialog();
        }
    }
}
