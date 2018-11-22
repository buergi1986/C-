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
    public partial class Kundenliste : Form
    {
        Color alteFarbe;

        public Kundenliste()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kundeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.buch2020DataSet);
            }
            catch
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten!\nBitte überprüfen Sie Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Kundenliste_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
        }

        private void kundeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //für die zusätzlichen Prüfung der Postleitzahl
            bool fehlerKeinEintrag = false;
            int postleitzahltemp = 0;
            int telefontemp = 0;
            //überprüft werden nur die Spalten 2 bis 6
            //der Index beginnt immer bei 0!
            if ((e.ColumnIndex > 0) && (e.ColumnIndex < 6))
            {
                //ist der Eintrag leer?
                if (e.FormattedValue.ToString() == string.Empty)
                {
                    //eine Meldung anzeigen
                    //bitte jeweils in einer Zeile eingeben
                    MessageBox.Show("Sie müssen einen Wert für " + kundeDataGridView.Columns[e.ColumnIndex].HeaderText + " eingeben.");
                    //den Fehlertext setzen
                    kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Die Zelle darf nicht leer sein!";
                    //die Aktion abbrechen
                    e.Cancel = true;
                    //fehlerKeinEintrag wird true, da die weiteren Prüfungen
                    //für die Postleitzahl nicht mehr erforderlich sind
                    fehlerKeinEintrag = true;
                }
            }
            //die Detailprüfung für die Postleitzahl
            //sind wird in der Spalte für die Postleitzahl und ist ein
            //Eintrag vorhanden?
            if ((e.ColumnIndex == 4) && (fehlerKeinEintrag == false))
            {
                //ist der Eintrag exakt fünf Zeichen lang?
                //sonst eine Meldung anzeigen und die Verarbeitung abbrechen
                if (e.FormattedValue.ToString().Length != 5)
                {
                    //bitte in einer Zeile eingeben
                    MessageBox.Show("Die Postleitzahl muss 5 Ziffern lang sein!");
                    e.Cancel = true;
                }
                //sind es nur Ziffern
                else
                {
                    ////bitte jeweils in einer Zeile eingeben
                    if (Int32.TryParse(e.FormattedValue.ToString(), out postleitzahltemp) == false)
                    {
                        MessageBox.Show("Das Format der Postleitzahl ist ungültig!");
                        e.Cancel = true;
                    }
                }
            }
            //der Name maximale 50 Anzahl und Format nur String ausnahmweiser Nummer und Symbol bei der Adresse
            else if ((e.ColumnIndex > 0) && (e.ColumnIndex < 4) || (e.ColumnIndex == 5) && fehlerKeinEintrag == false)
            {
               if (e.ColumnIndex == 3)
               {
                   foreach (var textNummer in e.FormattedValue.ToString())
                   {
                       if (!char.IsControl(textNummer) && !char.IsLetterOrDigit(textNummer))
                       {
                           if (textNummer == '.' || textNummer == ' ')
                           {
                               //rückgabewert
                               return;
                           }
                           else
                           {
                               MessageBox.Show("Das Format der Adresse ist ungültig!");
                               e.Cancel = true;
                               return;
                           }
                       }
                   }
               }
               else
               {
                   foreach (var charakter in e.FormattedValue.ToString())
                   {
                       if (!char.IsControl(charakter) && !char.IsLetter(charakter))
                       {
                           MessageBox.Show(String.Format("Das Format den {0} ist ungültig!", kundeDataGridView.Columns[e.ColumnIndex].HeaderText));
                           e.Cancel = true;
                           return;
                       }
                   }
               }                  
            }
            //Telefon nur mit dem Nummer
            else if ((e.ColumnIndex > 5) && fehlerKeinEintrag == false)
            {
                if (Int32.TryParse(e.FormattedValue.ToString(), out telefontemp) == false)
                {
                    if (e.FormattedValue.ToString() == string.Empty)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Das Format der {0} ist ungültig!", kundeDataGridView.Columns[e.ColumnIndex].HeaderText));
                        e.Cancel = true;
                    }                        
                }               
            }
        }

        private void kundeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //bitte jeweils in einer Zeile eingeben
            if (kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText != string.Empty)
            {
                kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
            }
        }

        private void kundeDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //befindet sich die Maus über einer Zeile?
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                //für den leichteren Zugriff
                //bitte in einer Zeile eingeben
                DataGridViewCell zelle = kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //die alte Farbe sichern
                alteFarbe = zelle.Style.BackColor;
                //die neue Farbe setzen
                zelle.Style.BackColor = Color.LightBlue;
            }
        }

        private void kundeDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //befindet sich die Maus über einer Zelle?
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                //für den leichteren Zugriff
                //bitte in einer Zeile eingeben
                DataGridViewCell zelle = kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //die alte Farbe wiederherstellen
                zelle.Style.BackColor = alteFarbe;
            }
        }
    }
}
