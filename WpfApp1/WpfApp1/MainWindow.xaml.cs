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

namespace WpfApp1
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

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {

            var button = e.Source as Button;
            if (JaText.Text == "error"){
                JaText.Text = "";
            }

            switch (Grid.GetColumn(button) + 5 * Grid.GetRow(button)){
                case 3:
                    if (JaText.Text.Length != 0)
                    {
                        JaText.Text = JaText.Text.Remove(JaText.Text.Length - 1);
                    }
                    else
                    {
                        JaText.Text = "error";
                    }
                    break;

                case 8:
                    JaText.Text = "";
                    break;

                case 4:
                case 9:
                case 14:
                case 19:
                    char operatorMini = 'J';

                    switch (Grid.GetColumn(button) + 5 * Grid.GetRow(button)){
                        case 4:
                            operatorMini = '+';
                            break;
                        case 9:
                            operatorMini = '-';
                            break;
                        case 14:
                            operatorMini = '*';
                            break;
                        case 19:
                            operatorMini = '/';
                            break;
                    }

                    if (JaText.Text[JaText.Text.Length - 1] != operatorMini)
                    {
                        if (JaText.Text.Length != 0)
                        {
                            JaText.Text += operatorMini;
                        }
                    }
                    break;

                case 18:
                    JaText.Text += '+';
                    char nextOperator = '+';
                    int result = 0;
                    int theNumberIWantToAdd = 0;

                    while (JaText.Text.Length > 0)
                    {
                        if (JaText.Text[0] == '0' || JaText.Text[0] == '1' || JaText.Text[0] == '2' || JaText.Text[0] == '3' || JaText.Text[0] == '4' || JaText.Text[0] == '5' || JaText.Text[0] == '6' || JaText.Text[0] == '7' || JaText.Text[0] == '8' || JaText.Text[0] == '9')
                        {
                            theNumberIWantToAdd = theNumberIWantToAdd * 10 + int.Parse(JaText.Text[0].ToString());
                        }
                        else
                        {
                            switch (nextOperator)
                            {
                                case '+':
                                    result += theNumberIWantToAdd;
                                    break;
                                case '-':
                                    result -= theNumberIWantToAdd;
                                    break;
                                case '*':
                                    result *= theNumberIWantToAdd;
                                    break;
                                case '/':
                                    result /= theNumberIWantToAdd;
                                    break;
                            }

                            theNumberIWantToAdd = 0;
                            nextOperator = JaText.Text[0];
                        }

                        JaText.Text = JaText.Text.Substring(1);
                    }
                    //result = Math.Round(result * 100)/100;

                    JaText.Text = result.ToString();

                    break;
                default:
                    JaText.Text += Grid.GetColumn(button) + 3 * Grid.GetRow(button);
                    break;
            }
        }
    }
}
