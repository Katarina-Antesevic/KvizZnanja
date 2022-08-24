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
    /// Interaction logic for IstorijaWindow.xaml
    /// </summary>
    public partial class IstorijaWindow : Window
    {
        int correctAnswer;
        int questionNumber = 1;
        int score = 0;
        int percentage;
        int totalQuestions;
        int pomocKliknuta = 0;
        string odgovor = "";

        public IstorijaWindow()
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



                    pitanje.Content = new TextBlock() { Text = "Koje godine je poceo prvi svjetski rat?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "1912";
                    odgovor2.Content = "1913";
                    odgovor3.Content = "1914";
                    odgovor4.Content = "1915";

                    odgovor3.Tag = "1";
                    correctAnswer = 3;
                    odgovor2.Tag = "0";
                    odgovor1.Tag = "0";
                    odgovor4.Tag = "0";

                    break;
                case 2:
                    slika.Source = new BitmapImage(new Uri("Images/hirosima.jpg", UriKind.Relative));
                    pitanje.Content = "Na koje mjesto je bacena prva atomska bomba?";

                    odgovor1.Content = "Hirosima";
                    odgovor2.Content = "Nagasaki";
                    odgovor3.Content = "Osaka";
                    odgovor4.Content = "Kyushu";

                    odgovor1.Tag = "1";
                    correctAnswer = 1;
                    odgovor2.Tag = "0";
                    odgovor4.Tag = "0";
                    odgovor3.Tag = "0";

                    break;

                case 3:

                    slika.Source = new BitmapImage(new Uri("Images/kolumbbo.jpg", UriKind.Relative));

                    pitanje.Content = new TextBlock() { Text = "Koje godine je Cristopher Columbus doplovio do obale Amerike prvi put?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "1494";
                    odgovor2.Content = "1492";
                    odgovor3.Content = "1496";
                    odgovor4.Content = "1498";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor1.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 4:

                    slika.Source = new BitmapImage(new Uri("Images/Ivo.jpg", UriKind.Relative));


                    pitanje.Content = new TextBlock() { Text = "Koje godine je Ivo Andric dobio Nobelovu nagradu za knjizevnost?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "1963";
                    odgovor2.Content = "1971";
                    odgovor3.Content = "1973";
                    odgovor4.Content = "1961";

                    odgovor4.Tag = "1";
                    correctAnswer = 4;
                    odgovor2.Tag = "0";
                    odgovor1.Tag = "0";
                    odgovor3.Tag = "0";

                    break;

                case 5:

                    slika.Source = new BitmapImage(new Uri("Images/titanik.jpg", UriKind.Relative));

                    pitanje.Content = "Koje godine je potonuo brod Titanik?";

                    odgovor1.Content = "1911";
                    odgovor2.Content = "1912";
                    odgovor3.Content = "1913";
                    odgovor4.Content = "1914";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor1.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 6:

                    slika.Source = new BitmapImage(new Uri("Images/alkatraz.jpg", UriKind.Relative));

                    pitanje.Content = new TextBlock() { Text = "Koje godine je u potrunosti prestao sa radom zatvor Alkatraz?", TextWrapping = TextWrapping.Wrap };


                    odgovor1.Content = "1963";
                    odgovor2.Content = "1965";
                    odgovor3.Content = "1973";
                    odgovor4.Content = "1976";

                    odgovor1.Tag = "1";
                    correctAnswer = 1;
                    odgovor3.Tag = "0";
                    odgovor2.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 7:

                    slika.Source = new BitmapImage(new Uri("Images/zastava.jpg", UriKind.Relative));

                    pitanje.Content = "Kako se zvao 3. americki predsjednik?";

                    odgovor1.Content = "George Washington";
                    odgovor2.Content = "Thomas Jefferson";
                    odgovor3.Content = "James Madison";
                    odgovor4.Content = "Andrew Jackson";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";
                    odgovor1.Tag = "0";

                    break;

                case 8:

                    slika.Source = new BitmapImage(new Uri("Images/bijelaKuca.jpg", UriKind.Relative));

                    pitanje.Content = "Koje godine je ukinuto ropstvo u SAD-u?";

                    odgovor1.Content = "1798";
                    odgovor2.Content = "1819";
                    odgovor3.Content = "1853";
                    odgovor4.Content = "1863";

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
