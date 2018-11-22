using System;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class Vertrageinzel : Form
    {
        public Vertrageinzel()
        {
            InitializeComponent();
        }

        private void vertragBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void Vertrageinzel_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Vertrag". Sie können sie bei Bedarf verschieben oder entfernen.
            this.vertragTableAdapter.Fill(this.buch2020DataSet.Vertrag);
            if (mNummerComboBox.Items.Count == 0)
            {
                MessageBox.Show("Es gibt keine ausleihbaren Medien mehr!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            else
            {
                //einen neuen Datensatz erzeugen
                vertragBindingSource.AddNew();
                //die Einträge für den Kunden und das Medium setzen
                kNummerComboBox.SelectedIndex = 0;
                mNummerComboBox.SelectedIndex = 0;
                //den Wert für das Ausleihdatum setzen
                ausleihDatumDateTimePicker.Value = DateTime.Now;
                //den Wert für das Rückgabedatum setzen
                //hier 30 Tage auf das aktuelle Datum addieren
                rueckgabeDatumDateTimePicker.Value = DateTime.Now.AddDays(30);
            }
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vertragBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);
            //die Update-Abfrage ausführen
            this.mediumTableAdapter.ausgeliehenSetzen(Convert.ToInt32(mNummerComboBox.SelectedValue));
            Close();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonKundenDetail_Click(object sender, EventArgs e)
        {
            Kundendetail detailAnzeigeKunden = new Kundendetail();
            detailAnzeigeKunden.DetailsLaden(Convert.ToInt32(kNummerComboBox.SelectedValue));
            detailAnzeigeKunden.ShowDialog();
        }

        private void buttonMediumDetail_Click(object sender, EventArgs e)
        {
            Mediumdetail detailAnzeigeMedium = new Mediumdetail();
            detailAnzeigeMedium.DetailsLaden(Convert.ToInt32(mNummerComboBox.SelectedValue));
            detailAnzeigeMedium.ShowDialog();
        }
    }
}
