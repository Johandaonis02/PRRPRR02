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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void OkButton_Click(object sender, RoutedEventArgs e){
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
                case 13:
                    JaText.Text += "ans";
                    break;
                case 4:
                case 9:
                case 14:
                case 19:
                    char operatorMini = 'J';

                    switch (Grid.GetColumn(button) + 5 * Grid.GetRow(button))
                    {
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

                    if (JaText.Text[JaText.Text.Length - 1] != '+' && JaText.Text[JaText.Text.Length - 1] != '-' && JaText.Text[JaText.Text.Length - 1] != '*' && JaText.Text[JaText.Text.Length - 1] != '/')
                    {
                        if (JaText.Text.Length != 0)
                        {
                            JaText.Text += operatorMini;
                        }
                    }
                    break;


                default:
                    JaText.Text += Grid.GetColumn(button) + 3 * Grid.GetRow(button);
                    break;
            }
        }
    }
}
