using System;
using System.Windows;

namespace MaxOfThreeNumbers
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindMaxButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(SecondNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(ThirdNumberTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите все три числа.");
                return; 
            }

            try
            {
                int number1 = int.Parse(FirstNumberTextBox.Text);
                int number2 = int.Parse(SecondNumberTextBox.Text);
                int number3 = int.Parse(ThirdNumberTextBox.Text);

                int maxNumber = Math.Max(number1, Math.Max(number2, number3));

                ResultTextBlock.Text = $"Максимальное число: {maxNumber}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные целые числа.");
            }
        }

        private void ClearFieldsButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumberTextBox.Clear();
            SecondNumberTextBox.Clear();
            ThirdNumberTextBox.Clear();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumberTextBox.Clear();
            SecondNumberTextBox.Clear();
            ThirdNumberTextBox.Clear();
            ResultTextBlock.Text = string.Empty; 
        }
    }
}