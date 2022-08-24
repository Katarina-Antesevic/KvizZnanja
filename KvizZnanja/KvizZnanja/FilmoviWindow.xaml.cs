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
    /// Interaction logic for FilmoviWindow.xaml
    /// </summary>
    public partial class FilmoviWindow : Window
    {

        int correctAnswer;
        int questionNumber = 1;
        int score=0;
        int percentage;
        int totalQuestions;
        int pomocKliknuta = 0;
        string odgovor = "";

        public FilmoviWindow()
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
                    
                    

                    pitanje.Content=  new TextBlock() { Text = "Koje od navedene djece nije bilo izabrano da obidje cokoladnu fabriku Willy-a Wonke?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "Billy Warp";
                    odgovor2.Content = "Veruca Salt";
                    odgovor3.Content = "Mike Teavee";
                    odgovor4.Content = "Charlie Bucket";

                    odgovor1.Tag = "1";
                    correctAnswer = 1;
                    odgovor2.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";

                    break;
                case 2:
                    slika.Source = new BitmapImage(new Uri("Images/kum.jpg", UriKind.Relative));
                    pitanje.Content = "Kome je pripadala macka iz filma The Godfather?";

                    odgovor1.Content = "Franciu Ford Coppola-i";
                    odgovor2.Content = "Diani Keaton";
                    odgovor3.Content = "Al Pachino-u";
                    odgovor4.Content = "Nije imala vlasnika";

                    odgovor4.Tag = "1";
                    correctAnswer = 4;
                    odgovor2.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor1.Tag = "0";

                    break;

                case 3:

                    slika.Source = new BitmapImage(new Uri("Images/joker.jpg", UriKind.Relative));

                    pitanje.Content = "Koji glumac nije glumio Joker-a?";

                    odgovor1.Content = "Jack Nicholson";
                    odgovor2.Content = "Sean Penn";
                    odgovor3.Content = "Jared Leto";
                    odgovor4.Content = "Mark Hamil";

                    odgovor2.Tag = "";
                    correctAnswer = 2;
                    odgovor1.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 4:

                    slika.Source = new BitmapImage(new Uri("Images/elle.jpg", UriKind.Relative));


                    pitanje.Content = new TextBlock() { Text = "Koliko je bodova imala Elle Woods na testu LSAT u filmu Legaly blonde?", TextWrapping = TextWrapping.Wrap };

                    odgovor1.Content = "172";
                    odgovor2.Content = "167";
                    odgovor3.Content = "179";
                    odgovor4.Content = "155";

                    odgovor3.Tag = "1";
                    correctAnswer = 3;
                    odgovor2.Tag = "0";
                    odgovor1.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 5:

                    slika.Source = new BitmapImage(new Uri("Images/cady.jpg", UriKind.Relative));

                    pitanje.Content = "U filmu Mean Girls, sa kojeg kontinenta se doselila Cady?";

                    odgovor1.Content = "Australija";
                    odgovor2.Content = "Afrika";
                    odgovor3.Content = "Evropa";
                    odgovor4.Content = "Azija";

                    odgovor2.Tag = "1";
                    correctAnswer = 2;
                    odgovor1.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 6:

                    slika.Source = new BitmapImage(new Uri("Images/ring.jpg", UriKind.Relative));

                    pitanje.Content = new TextBlock() { Text = "Koliko dana zivota je ostalo ljudima koji su pogledali ukletu kasetu u filmu The Ring?", TextWrapping = TextWrapping.Wrap };


                    odgovor1.Content = "5";
                    odgovor2.Content = "6";
                    odgovor3.Content = "7";
                    odgovor4.Content = "8";

                    odgovor3.Tag = "1";
                    correctAnswer = 3;
                    odgovor2.Tag = "0";
                    odgovor1.Tag = "0";
                    odgovor4.Tag = "0";

                    break;

                case 7:

                    slika.Source = new BitmapImage(new Uri("Images/oscar.jpg", UriKind.Relative));

                    pitanje.Content = "Ko je najmladja osoba koja je osvojila oskar?";

                    odgovor1.Content = "Jennifer Lawrence";
                    odgovor2.Content = "Mickey Rooney";
                    odgovor3.Content = "Haley Joel Osment";
                    odgovor4.Content = "Tatum O’Neal";

                    odgovor4.Tag = "1";
                    correctAnswer = 4;
                    odgovor2.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor1.Tag = "0";

                    break;

                case 8:

                    slika.Source = new BitmapImage(new Uri("Images/os.jpg", UriKind.Relative));

                    pitanje.Content = "Koja glumica ima najvise osvojinih oskara?";

                    odgovor1.Content = "Katharine Hepburn";
                    odgovor1.Content = "Meryl Streep";
                    odgovor1.Content = "Ingrid Bergman";
                    odgovor1.Content = "Elizabeth Taylor";

                    odgovor1.Tag = "1";
                    correctAnswer = 1;
                    odgovor2.Tag = "0";
                    odgovor3.Tag = "0";
                    odgovor4.Tag = "0";

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
                        odgovor = (String) odgovor1.Content;
                        break;

                    case 2:
                        odgovor = (String) odgovor2.Content;
                        break;

                    case 3:
                        odgovor = (String) odgovor3.Content;
                        break;

                    case 4:
                        odgovor = (String) odgovor4.Content;
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
