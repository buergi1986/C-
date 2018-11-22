using System.Windows.Forms;

namespace Bildbetrachter
{
    public partial class FormMax : Form
    {
        public FormMax()
        {
            InitializeComponent();
        }

        public void BildLaden(string bildname)
        {
            pictureBoxFormMax.Load(bildname);
        }
    }
}
