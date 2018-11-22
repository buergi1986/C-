using System.Windows;
using System.ComponentModel;
using System;

namespace feldinlabel_cshp15c
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private decimal _ersteZahl;
        private decimal _zweiteZahl;

        public decimal ersteZahl
        {
            get { return _ersteZahl; }
            set
            {
                _ersteZahl = value;
                OnPropertyChanged("ersteZahl");
            }
        }

        public decimal zweiteZahl
        {
            get { return _zweiteZahl; }
            set
            {
                _zweiteZahl = value;
                OnPropertyChanged("zweiteZahl");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string v)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(v));
        }
    }
}
