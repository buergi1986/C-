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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonListenansicht_Click(object sender, EventArgs e)
        {
            Kundenliste kListe = new Kundenliste();

            try
            {
                kListe.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void buttonEinzel_Click(object sender, EventArgs e)
        {
            Kundeneinzel kEinzel = new Kundeneinzel();

            try
            {
                kEinzel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonListenMedien_Click(object sender, EventArgs e)
        {
            Medienliste mListe = new Medienliste();

            try
            {
                mListe.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEinzelMedien_Click(object sender, EventArgs e)
        {
            Medieneinzel mEinzel = new Medieneinzel();

            try
            {
                mEinzel.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMedien_Click(object sender, EventArgs e)
        {
            ListenanzeigeMedien mListenanzeige = new ListenanzeigeMedien();

            try
            {
                mListenanzeige.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
