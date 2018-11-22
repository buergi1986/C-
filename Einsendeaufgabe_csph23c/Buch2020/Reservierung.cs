using System;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class Reservierung : Form
    {
        public Reservierung()
        {
            InitializeComponent();
        }

        private void reservierungenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservierungenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void Reservierung_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Reservierungen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.reservierungenTableAdapter.Fill(this.buch2020DataSet.Reservierungen);
		    //gibt es überhaupt Medien, für die eine Reservierung vorgenommen werden kann?
		    if (mNummerComboBox.Items.Count == 0)
		    {
			    MessageBox.Show("Es gibt keine Medien für eine Reservierung!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			    Close();
		    }
		    else
		    {
			    //einen neuen Datensatz erzeugen
			    reservierungenBindingSource.AddNew();
			    //den Wert für das Medium setzen
			    mNummerComboBox.SelectedIndex = 0;
			    //den Wert für den Kunden setzen
			    kNummerComboBox.SelectedIndex = 0;
			    //den Wert für das Reservierungsdatum setzen
			    //hier 30 Tage auf das aktuelle Datum addieren
			    gueltigBisDateTimePicker.Value = DateTime.Now.AddDays(30);
		    }
        }

        private void buttonUebernehmen_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservierungenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);
            Close();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDetailMedium_Click(object sender, EventArgs e)
        {
            Mediumdetail detailAnzeigeMedium = new Mediumdetail();
            detailAnzeigeMedium.DetailsLaden(Convert.ToInt32(mNummerComboBox.SelectedValue));
            detailAnzeigeMedium.ShowDialog();
        }

        private void buttonDetailKunde_Click(object sender, EventArgs e)
        {
            Kundendetail detailAnzeigeKunde = new Kundendetail();
            detailAnzeigeKunde.DetailsLaden(Convert.ToInt32(kNummerComboBox.SelectedValue));
            detailAnzeigeKunde.ShowDialog();
        }
    }
}
