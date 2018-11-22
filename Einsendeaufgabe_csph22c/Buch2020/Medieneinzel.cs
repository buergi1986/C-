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
    public partial class Medieneinzel : Form
    {
        public Medieneinzel()
        {
            InitializeComponent();
        }

        private void mediumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mediumBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void Medieneinzel_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);

        }

        private void mNummerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void standortTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ausgeliehenCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bestandCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
