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
    /// Interaction logic for GeografijaWindow.xaml
    /// </summary>
    /// 

    public partial class GeografijaWindow : Window
    {

        int correctAnswer;
        int questionNumber = 1;
        int score = 0;
        int percentage;
        int totalQuestions;
        int pomocKliknuta = 0;
        string odgovor = "";

        public GeografijaWindow()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            progressBar.Value = 0;
            totalQuestions = 8;
            tacniOdgovori.Content = "Broj tacnih odgovora je: 0";
        }

        private void provjeriOdgovor(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                ++score;

                tacniOdgovori.Content = "Broj tacnih odgovora: " + score;

            }

            progressBar.Value = questionNumber;

            MainWindow mw = (MainWindow)Application.Current.MainWindow;

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show((mw.NameTextBox.Text.Trim().Equals("Ime takmicara") ? "Katarina" : mw.NameTextBox.Text) + " zavrsili ste kviz!" + Environment.NewLine +
                                "Imate " + score + " tacnih odgovora!" + Environment.NewLine +
                                "Postotak vase tacnosti je " + percentage + " %" + Environment.NewLine +
                                "Kliknite Ok da biste ponovo igrali!"

                    );



                Window categories = new Kategorije();
                categories.Show();
                this.Hide();

                score = 0;
            }

            questionNumber++;

            askQuestion(questionNumber);



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

        public void askQuestion(int num)
        {
            switch (num)
            {

                case 1:



                    pitanje.Content = new TextBlock() { Text = "Koliko vremenskih zona ima Kina?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "1";
                    odgovor2.Content = "3";
                    odgovor3.Content = "5";
                    odgovor4.Content = "7";

                    odgovor1.Tag = "1";
                    correctAnswer = 1;
                    odgovor2.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";

                    break;
                case 2:
                    slika.Source = new BitmapImage(new Uri("Images/najmanja.jpg", UriKind.Relative));
                    pitanje.Content = "Koja je najmanja drzava na svijetu?";

                    odgovor1.Content = "Luksemburg";
                    odgovor2.Content = "Vatikan";
                    odgovor3.Content = "Monako";
                    odgovor4.Content = "Nauru";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor1.Tag = "0";
                    odgovor4.Tag = "0";
                    odgovor3.Tag = "0";

                    break;

                case 3:

                    slika.Source = new BitmapImage(new Uri("Images/cccp.jpg", UriKind.Relative));

                    pitanje.Content = new TextBlock() { Text = "Koja drzava nije bila dio Sovjetskog Saveza?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "Ukrajina";
                    odgovor2.Content = "Gruzija";
                    odgovor3.Content = "Rumunija";
                    odgovor4.Content = "Turkmenistan";

                    odgovor3.Tag = "1";
                    correctAnswer = 3;
                    odgovor1.Tag = "0";
                    odgovor2.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 4:

                    slika.Source = new BitmapImage(new Uri("Images/stepenice.jpeg", UriKind.Relative));


                    pitanje.Content = new TextBlock() { Text = "U kom gradu se nalaze ``Spanske stepenice``?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "Madridu";
                    odgovor2.Content = "Rimu";
                    odgovor3.Content = "Barseloni";
                    odgovor4.Content = "Milanu";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor4.Tag = "0";
                    odgovor1.Tag = "0";
                    odgovor3.Tag = "0";

                    break;

                case 5:

                    slika.Source = new BitmapImage(new Uri("Images/United-Kingdom.jpg", UriKind.Relative));

                    pitanje.Content = "Koliko drzava cine Ujedinjeno Kraljevstvo?";

                    odgovor1.Content = "3";
                    odgovor2.Content = "4";
                    odgovor3.Content = "5";
                    odgovor4.Content = "6";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor1.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 6:

                    slika.Source = new BitmapImage(new Uri("Images/rusija.jpg", UriKind.Relative));

                    pitanje.Content = new TextBlock() { Text = "Koliko vremenskih zona ima Rusija?", TextWrapping = TextWrapping.Wrap };


                    odgovor1.Content = "8";
                    odgovor2.Content = "9";
                    odgovor3.Content = "10";
                    odgovor4.Content = "11";

                    odgovor4.Tag = "1";
                    correctAnswer = 4;
                    odgovor3.Tag = "0";
                    odgovor2.Tag = "0";
                    odgovor1.Tag = "0";

                    break;

                case 7:

                    slika.Source = new BitmapImage(new Uri("Images/australija.jpg", UriKind.Relative));

                    pitanje.Content = "Koji grad je glavni grad Australije?";

                    odgovor1.Content = "Sydney";
                    odgovor2.Content = "Canberra";
                    odgovor3.Content = "Melbourne";
                    odgovor4.Content = "Perth";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";
                    odgovor1.Tag = "0";

                    break;

                case 8:

                    slika.Source = new BitmapImage(new Uri("Images/zastava.jpg", UriKind.Relative));

                    pitanje.Content = "Koliko zvjezdica ima na zastavi SAD-a?";

                    odgovor1.Content = "49";
                    odgovor2.Content = "50";
                    odgovor3.Content = "51";
                    odgovor4.Content = "52";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor4.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor1.Tag = "0";

                    break;

            }


        }

        public void pomozi(object sender, RoutedEventArgs e)
        {
            if (pomocKliknuta < 4)
            {
                switch (correctAnswer)
                {
                    case 1:
                        odgovor = (String)odgovor1.Content;
                        break;

                    case 2:
                        odgovor = (String)odgovor2.Content;
                        break;

                    case 3:
                        odgovor = (String)odgovor3.Content;
                        break;

                    case 4:
                        odgovor = (String)odgovor4.Content;
                        break;
                }


                MessageBox.Show("Tacan odgovor je: " + odgovor);
                pomocKliknuta++;
            }
            else
            {
                MessageBox.Show("Iskoristili ste pravo na pomoc!");
            }

        }
    }
}