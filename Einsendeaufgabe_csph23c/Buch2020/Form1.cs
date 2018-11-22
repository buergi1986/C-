using System;
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
            kListe.ShowDialog();
        }

        private void buttonEinzelansicht_Click(object sender, EventArgs e)
        {
            Kundeneinzel kEinzel = new Kundeneinzel();
            kEinzel.ShowDialog();
        }

        private void buttonMListenansicht_Click(object sender, EventArgs e)
        {
            Medienliste mListe = new Medienliste();
            mListe.ShowDialog();
        }

        private void buttonMEinzelansicht_Click(object sender, EventArgs e)
        {
            Medieneinzel mEinzel = new Medieneinzel();
            mEinzel.ShowDialog();
        }

        private void buttonMedienliste_Click(object sender, EventArgs e)
        {
            ListenanzeigeMedien medienliste = new ListenanzeigeMedien();
            medienliste.ShowDialog();
        }

        private void buttonAusleihe_Click(object sender, EventArgs e)
        {
            Vertrageinzel vEinzel = new Vertrageinzel();
            vEinzel.ShowDialog();
        }

        private void buttonRueckgabe_Click(object sender, EventArgs e)
        {
            Rueckgabe rueck = new Rueckgabe();
            rueck.ShowDialog();
        }

        private void buttonReservierungAnlegen_Click(object sender, EventArgs e)
        {
            Reservierung reserv = new Reservierung();
            reserv.ShowDialog();
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            Suchfunktion suchen = new Suchfunktion();
            suchen.ShowDialog();
        }
    }
}
