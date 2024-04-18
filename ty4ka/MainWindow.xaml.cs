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

namespace ty4ka
{
    public partial class MainWindow : Window
    {
        int count = 0;
        int tries = 0;
        int a;
        string[] lang_data = { "Русский язык","Английский язык", "Испанский язык", "Французский язык" };
        // Слова
        string[,] words_data = {
                { "Привет", "Hello", "Hola", "Bonjour" },
                { "Как дела?", "How are you?", "¿Cómo estás?", "Comment vas-tu?" },
                { "Как тебя зовут?", "What's your name?", "¿Cómo te llamas?", "Quel est ton nom?" },
                { "Меня зовут:", "My name is", "Mi nombre es:", "Mon nom est:" },
                { "Сколько тебе лет?", "How old are you?", "¿Cuántos años tiene?", "Quel âge as-tu?" },
                { "У меня всё отлично", "I'm great", "Estoy genial", "Je suis génial" },
                { "Как прошёл день?", "How was your day?", "¿Cómo estuvo su día?", "Comment s'est passée ta journée?" },
                { "Телефон", "Telephone", "Teléfono", "Téléphone" },
                { "Интернет", "Internet", "Internet", "l'Internet" },
                { "Человек", "Person", "Persona", "Personne" },
                { "Дружба", "Friendship", "Amistad", "Amitié" }
            };
        public MainWindow()
        {
            InitializeComponent();
            
            translator_page.Visibility = Visibility.Hidden;
            excersizes.Visibility = Visibility.Hidden;




            // Языки
            for (int i = 0; i < lang_data.Length; i++)
            {
                CB.Items.Add(lang_data[i]);
            }
            for (int i = 0;  i < words_data.GetLength(0); i++)
            {
                CB2.Items.Add( words_data[i, 0] );
            }
            for (int i = 0; i < 2; i++)
            {
                SL.Items.Add( lang_data[i] );
            }
            for (int i = 0; i < 2; i++)
            {
                TL.Items.Add( lang_data[i] );
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TT.Text = "";
            switch (CB2.Text)
            {
                case "Привет":
                    if (CB.Text == "Английский язык")
                        TT.Text = "Hello";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "Hola";
                    if (CB.Text == "Французский язык")
                        TT.Text = "Bonjour";
                    break;

                case "Как дела?":
                    if (CB.Text == "Английский язык")
                        TT.Text = "How are you?";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "¿Cómo estás?";
                    if (CB.Text == "Французский язык")
                        TT.Text = "Comment vas-tu?";
                    break;

                case "Как тебя зовут?":
                    if (CB.Text == "Английский язык")
                        TT.Text = "What's your name?";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "¿Cómo te llamas?";
                    if (CB.Text == "Французский язык")
                        TT.Text = "Quel est ton nom?";
                    break;

                case "Меня зовут:":
                    if (CB.Text == "Английский язык")
                        TT.Text = "My name is";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "Mi nombre es:";
                    if (CB.Text == "Французский язык")
                        TT.Text = "Mon nom est:";
                    break;

                case "Сколько тебе лет?":
                    if (CB.Text == "Английский язык")
                        TT.Text = "How old are you?";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "¿Cuántos años tiene?";
                    if (CB.Text == "Французский язык")
                        TT.Text = "Quel âge as-tu?";
                    break;

                case "У меня всё отлично":
                    if (CB.Text == "Английский язык")
                        TT.Text = "I'm great";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "estoy genial";
                    if (CB.Text == "Французский язык")
                        TT.Text = "Je suis génial";
                    break;

                case "Как прошёл день?":
                    if (CB.Text == "Английский язык")
                        TT.Text = "How was your day?";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "¿Cómo estuvo su día?";
                    if (CB.Text == "Французский язык")
                        TT.Text = "Comment s'est passée ta journée?";
                    break;

                case "Телефон":
                    if (CB.Text == "Английский язык")
                        TT.Text = "Telephone";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "Teléfono";
                    if (CB.Text == "Французский язык")
                        TT.Text = "Téléphone";
                    break;

                case "Интернет":
                    if (CB.Text == "Английский язык")
                        TT.Text = "Internet";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "Internet";
                    if (CB.Text == "Французский язык")
                        TT.Text = "l'Internet";
                    break;

                case "Человек":
                    if (CB.Text == "Английский язык")
                        TT.Text = "Person";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "Persona";
                    if (CB.Text == "Французский язык")
                        TT.Text = "Personne";
                    break;

                case "Дружба":
                    if (CB.Text == "Английский язык")
                        TT.Text = "Friendship";
                    if (CB.Text == "Испанский язык")
                        TT.Text = "Amistad";
                    if (CB.Text == "Французский язык")
                        TT.Text = "Amitié";
                    break;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            translator_page.Visibility = Visibility.Hidden;
            excersizes.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            translator_page.Visibility = Visibility.Visible;
            excersizes.Visibility = Visibility.Hidden;

        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void StartEx(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            a = rnd.Next(10);
            if (SL.Text == TL.Text | SL.Text == "" | TL.Text == "")
            {
                MessageBox.Show("Так дела не делаются!");
            }
            else
            {
                if (SL.Text == lang_data[1] && TL.Text == lang_data[0])
                {
                    word.Content = words_data[a, 1];
                }
                if (SL.Text == lang_data[0] && TL.Text == lang_data[1])
                {
                    word.Content = words_data[a, 0];
                }
            }
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tries++;
            if (answer.Text != "")
            {
                if (SL.Text == lang_data[1] && TL.Text == lang_data[0])
                {
                    if (answer.Text == words_data[a, 0])
                    {
                        MessageBox.Show("+");
                        count++;

                    }
                }
                if (SL.Text == lang_data[0] && TL.Text == lang_data[1])
                {
                    if (answer.Text == words_data[a, 1])
                    {
                        MessageBox.Show("545");
                        count++;
                    }
                }
            }
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if(tries != 0 && count != 0)
            {
                double successRate = ((double)count / tries) * 100;
                MessageBox.Show($"Процент успеха {successRate:F2}%");
                count = 0;
                tries = 0;
            }
            else
            {
                MessageBox.Show("Ай-яй-яй так дела тоже не делаются");
            };
        }
    }
}
