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
    /// Interaction logic for SportWindow.xaml
    /// </summary>
    public partial class SportWindow : Window
    {
        int correctAnswer;
        int questionNumber = 1;
        int score = 0;
        int percentage;
        int totalQuestions;
        int pomocKliknuta = 0;
        string odgovor = "";

        public SportWindow()
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



                    pitanje.Content = new TextBlock() { Text = "Koliko cesto se odrzava FIFA Svjetski Kup?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "Svake 2 godine";
                    odgovor2.Content = "Svake 3 godine";
                    odgovor3.Content = "Svake 4 godine";
                    odgovor4.Content = "Svakih 5 godina";

                    odgovor3.Tag = "1";
                    correctAnswer = 3;
                    odgovor2.Tag = "0";
                    odgovor1.Tag = "0";
                    odgovor4.Tag = "0";

                    break;
                case 2:
                    slika.Source = new BitmapImage(new Uri("Images/medal.jpg", UriKind.Relative));
                    pitanje.Content = "Koji sportista ima najvise osvojenih zlatnih olimijskih medalja?";

                    odgovor1.Content = "Larisa Latynina";
                    odgovor2.Content = "Mark Spitz";
                    odgovor3.Content = "Michael Phelps";
                    odgovor4.Content = "Saina Nehwal";

                    odgovor3.Tag = "1";
                    correctAnswer = 3;
                    odgovor2.Tag = "0";
                    odgovor4.Tag = "0";
                    odgovor1.Tag = "0";

                    break;

                case 3:

                    slika.Source = new BitmapImage(new Uri("Images/bolt.jpg", UriKind.Relative));

                    pitanje.Content = new TextBlock() { Text = "Koliko iznosi svjetski rekord koji je postavio Usain Bolt za trcanje na 100m?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "14.35 s";
                    odgovor2.Content = "9.58 s";
                    odgovor3.Content = "9.05 s";
                    odgovor4.Content = "10.12 s";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor1.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 4:

                    slika.Source = new BitmapImage(new Uri("Images/ali.jpg", UriKind.Relative));


                    pitanje.Content = new TextBlock() { Text = "Kojim sportom se bavio Muhammad Ali?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "Dizanje tegova";
                    odgovor2.Content = "Plivanje";
                    odgovor3.Content = "Karate";
                    odgovor4.Content = "Boks";

                    odgovor4.Tag = "1";
                    correctAnswer = 4;
                    odgovor2.Tag = "0";
                    odgovor1.Tag = "0";
                    odgovor3.Tag = "0";

                    break;

                case 5:

                    slika.Source = new BitmapImage(new Uri("Images/fifa.jpg", UriKind.Relative));

                    pitanje.Content = "Kada je odrzan prvi FIFA Svjetski Kup?";

                    odgovor1.Content = "1918";
                    odgovor2.Content = "1930";
                    odgovor3.Content = "1934";
                    odgovor4.Content = "1935";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor1.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 6:

                    slika.Source = new BitmapImage(new Uri("Images/kris.jpg", UriKind.Relative));

                    pitanje.Content = new TextBlock() { Text = "Koje godine se Cristiano Ronaldo pridruzio fudbalskom klubu Juventus?", TextWrapping = TextWrapping.Wrap };


                    odgovor1.Content = "2017";
                    odgovor2.Content = "2018";
                    odgovor3.Content = "2019";
                    odgovor4.Content = "2020";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor3.Tag = "0";
                    odgovor1.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 7:

                    slika.Source = new BitmapImage(new Uri("Images/kris.jpg", UriKind.Relative));

                    pitanje.Content = "Kako glasi puno ime Criatiana Ronalda?";

                    odgovor1.Content = "Cristiano Santos Ronaldo";
                    odgovor2.Content = "Cristiano Ronaldo Santos Aveiro";
                    odgovor3.Content = "Cristiano Ronaldo dos Santos Aveiro";
                    odgovor4.Content = "Cristiano dos Ronaldo";

                    odgovor3.Tag = "1";
                    correctAnswer = 3;
                    odgovor2.Tag = "0";
                    odgovor4.Tag = "0";
                    odgovor1.Tag = "0";

                    break;

                case 8:

                    slika.Source = new BitmapImage(new Uri("Images/kobe.jpg", UriKind.Relative));

                    pitanje.Content = "Za koji klub je igrao Kobe Bryant?";

                    odgovor1.Content = "Chicago Bulls";
                    odgovor2.Content = "Golden State Warriors";
                    odgovor3.Content = "Miami Heat";
                    odgovor4.Content = "Los Angeles Lakers";

                    odgovor4.Tag = "1";
                    correctAnswer = 4;
                    odgovor2.Tag = "0";
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
