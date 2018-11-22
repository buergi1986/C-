using System;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class Kundendetail : Form
    {
        public void DetailsLaden(int nummer)
        {
            this.kundeTableAdapter.FillBykundeDetail(this.buch2020DataSet.Kunde, nummer);
        }

        public Kundendetail()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void Kundendetail_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
        }

        private void buttonSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
