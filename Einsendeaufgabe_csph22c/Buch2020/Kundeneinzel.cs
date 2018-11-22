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
    public partial class Kundeneinzel : Form
    {
        public Kundeneinzel()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kundeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void Kundeneinzel_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);

        }
    }
}
