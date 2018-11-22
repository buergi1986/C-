using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMARegisTry_Backup
{
    public partial class Success : Form
    {
        public Success(string message)
        {
            InitializeComponent();
            richTextBox1.Text = message;
        }

        private void Success_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
