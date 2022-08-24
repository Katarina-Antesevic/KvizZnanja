using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KvizZnanja
{
    /// <summary>
    /// Interaction logic for Kategorije.xaml
    /// </summary>
    public partial class Kategorije : Window
    {
        public Kategorije()
        {
            InitializeComponent();
        }

        private void Kategorija_Istorija(object sender, RoutedEventArgs e)
        {
            Window istorija = new IstorijaWindow();
            istorija.Show();
            this.Hide();
        }

        private void Kategorija_Geografija(object sender, RoutedEventArgs e)
        {
            Window geografija = new GeografijaWindow();
            geografija.Show();
            this.Hide();
        }

        private void Kategorija_Sport(object sender, RoutedEventArgs e)
        {
            Window sport = new SportWindow();
            sport.Show();
            this.Hide();
        }

        private void Kategorija_Filmovi(object sender, RoutedEventArgs e)
        {
            Window filmovi = new FilmoviWindow();
            filmovi.Show();
            this.Hide();
        }

        private void Napusti_Igru(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da zelite napustiti kviz?",
                    "",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }

        }
    }
}
