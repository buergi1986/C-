using System;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class Mediumdetail : Form
    {
        public void DetailsLaden(int nummer)
        {
            this.mediumTableAdapter.FillBymediumDetail(this.buch2020DataSet.Medium, nummer);
        }

        public Mediumdetail()
        {
            InitializeComponent();
        }

        private void mediumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void MediumEinzel_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);

        }

        private void buttonSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
