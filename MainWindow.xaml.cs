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

namespace GA_2_StephanieLopezz
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

        private void btnFullName_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string fullName = $"{firstName} {lastName}";

            // Display full name on button click
            MessageBox.Show(fullName);
        } //btnFullName-Click

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            string sign = "+";
            string equalSign = "=";
            int result = num1 + num2;

            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            bblEquation.Content = equation;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            string sign = "-"; // Changes + to -
            string equalSign = "=";
            int result = num1 - num2; // Changed + to -

            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            bblEquation.Content = equation;
        }

        private void txtWord_TextChanged(object sender, TextChangedEventArgs e)
        {
            string usersWord = txtWord.Text; // Getting users word
            int stringLength = usersWord.Length; // Getting how many characters are in the wor  d
            int lastIndex = stringLength - 1; // Getting the last index of the word
            string formatedString = $"Enter a number between 0 and {lastIndex}"; // Displaying the range of 0 to the last index

            // Displaying it to our label
            lblNumberOfLetters.Content = formatedString;
        }

        private void btnDisplayLetter_Click(object sender, RoutedEventArgs e)
        {
            string userWord = txtWord.Text;
            // Grabbing the word and parsing in one line
            int usersNumber = int.Parse(txtCharIndex.Text);
            char selectedChar = userWord[usersNumber];

            txtDisplayLetter.Text = selectedChar.ToString();
        }
    }
}
