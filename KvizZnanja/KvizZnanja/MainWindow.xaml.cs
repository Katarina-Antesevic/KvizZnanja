using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KvizZnanja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zapocni_Kviz(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Zapocnimo kviz, {(NameTextBox.Text.Trim().Equals("Ime takmicara") ? "Katarina" : NameTextBox.Text.Trim())}!");

            Window kategorije = new Kategorije();
            kategorije.Show();
            this.Hide();
        }

        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "Ime takmicara")
                txtBox.Text = string.Empty;
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
