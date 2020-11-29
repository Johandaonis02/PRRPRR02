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

        //This is a simple base 12 calculator

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {

            var button = e.Source as Button;
            if (DisplayOfNumbers.Text == "Error"){
                DisplayOfNumbers.Text = "";
            }
            
            switch (Grid.GetColumn(button) + 5 * Grid.GetRow(button)){
                case 3:
                    if (DisplayOfNumbers.Text.Length != 0){
                        DisplayOfNumbers.Text = DisplayOfNumbers.Text.Remove(DisplayOfNumbers.Text.Length - 1);
                    }
                    break;

                case 8:
                    DisplayOfNumbers.Text = "";
                    break;

                case 13:
                    if (DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '0' || DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '1' || DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '2' ||
                        DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '3' || DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '4' || DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '5' || 
                        DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '6' || DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '7' || DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '8' || 
                        DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '9' || DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '↊' || DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] == '↋'){
                        DisplayOfNumbers.Text += '.';
                    }
                    break;

                case 4:
                case 9:
                case 14:
                case 19:

                    if (DisplayOfNumbers.Text.Length != 0)
                    {
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

                        if (DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] != '+' && DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] != '-' && DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] != '*' && DisplayOfNumbers.Text[DisplayOfNumbers.Text.Length - 1] != '/')
                        {
                            if (DisplayOfNumbers.Text.Length != 0)
                            {
                                DisplayOfNumbers.Text += operatorMini;
                            }
                        }
                    }
                    break;

                case 18:
                    DisplayOfNumbers.Text += '+';
                    char nextOperator = '+';
                    double result = 0;
                    double theNumberIWantToAdd = 0;
                    bool duodecimals = false;
                    double positionBehindDuodecimal = 1;
                    while (DisplayOfNumbers.Text.Length > 0){
                        
                        if (duodecimals && !(DisplayOfNumbers.Text[0] == '+' || DisplayOfNumbers.Text[0] == '-' || DisplayOfNumbers.Text[0] == '*' || DisplayOfNumbers.Text[0] == '/')){
                            //Number after the decimal
                            if (DisplayOfNumbers.Text[0] == '0' || DisplayOfNumbers.Text[0] == '1' || DisplayOfNumbers.Text[0] == '2' ||
                                DisplayOfNumbers.Text[0] == '3' || DisplayOfNumbers.Text[0] == '4' || DisplayOfNumbers.Text[0] == '5' ||
                                DisplayOfNumbers.Text[0] == '6' || DisplayOfNumbers.Text[0] == '7' || DisplayOfNumbers.Text[0] == '8' ||
                                DisplayOfNumbers.Text[0] == '9'){
                                theNumberIWantToAdd += double.Parse(DisplayOfNumbers.Text[0].ToString()) * Math.Pow(1.0/12.0, positionBehindDuodecimal);
                            }
                            else if (DisplayOfNumbers.Text[0] == '↊'){
                                theNumberIWantToAdd += 10 * Math.Pow(1.0/12.0, positionBehindDuodecimal);
                            }
                            else if (DisplayOfNumbers.Text[0] == '↋'){
                                theNumberIWantToAdd += 11 * Math.Pow(1.0/12.0, positionBehindDuodecimal);
                            }

                            positionBehindDuodecimal++;
                        }
                        //Number before the decimal
                        else if (DisplayOfNumbers.Text[0] == '0' || DisplayOfNumbers.Text[0] == '1' || DisplayOfNumbers.Text[0] == '2' || DisplayOfNumbers.Text[0] == '3' || DisplayOfNumbers.Text[0] == '4' || DisplayOfNumbers.Text[0] == '5' || DisplayOfNumbers.Text[0] == '6' || DisplayOfNumbers.Text[0] == '7' || DisplayOfNumbers.Text[0] == '8' || DisplayOfNumbers.Text[0] == '9'){
                            theNumberIWantToAdd = theNumberIWantToAdd * 12 + double.Parse(DisplayOfNumbers.Text[0].ToString());
                        }
                        else if(DisplayOfNumbers.Text[0] == '↊'){
                            theNumberIWantToAdd = theNumberIWantToAdd * 12 + 10;
                        }
                        else if (DisplayOfNumbers.Text[0] == '↋'){
                            theNumberIWantToAdd = theNumberIWantToAdd * 12 + 11;
                        }
                        else if (DisplayOfNumbers.Text[0] == '.'){
                            duodecimals = true;
                        }
                        else{
                            switch (nextOperator){
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
                                    if(theNumberIWantToAdd == 0){
                                        DisplayOfNumbers.Text = "Error";
                                    }
                                    result /= theNumberIWantToAdd;
                                    break;
                            }

                            duodecimals = false;
                            positionBehindDuodecimal = 1;

                            theNumberIWantToAdd = 0;
                            nextOperator = DisplayOfNumbers.Text[0];
                        }

                        DisplayOfNumbers.Text = DisplayOfNumbers.Text.Substring(1);
                    }

                    DisplayOfNumbers.Text = decToDuoDec(result);

                    break;

                case 16:
                    DisplayOfNumbers.Text += '↊';
                    break;

                case 17:
                    DisplayOfNumbers.Text += '↋';
                    break;

                default:
                    DisplayOfNumbers.Text += Grid.GetColumn(button) + 3 * Grid.GetRow(button);
                    break;

                    
            }
        }

        public string decToDuoDec(double dec) {

            string DuoDecResult = "";

            //Text before the duodecimal
            while (dec >= 1)
            {
                if (Math.Floor(dec % 12) == 10)
                {
                    DuoDecResult = '↊' + DuoDecResult;
                }
                else if (Math.Floor(dec % 12) == 11)
                {
                    DuoDecResult = '↋' + DuoDecResult;
                }
                else
                {
                    DuoDecResult = Math.Floor(dec % 12) + DuoDecResult;
                }
                dec -= Math.Floor(dec % 12);
                dec = Math.Floor(dec/12) + dec - Math.Floor(dec);
            }

            double MaxDuodecimals = 10;

            //Fix rounding issue
            if (double.MaxValue > dec * Math.Pow(12.0, MaxDuodecimals)){
                dec *= Math.Pow(12, MaxDuodecimals);
                dec = Math.Round(dec);
                dec /= Math.Pow(12, MaxDuodecimals);
            }

            //Text after the duodecimal
            DuoDecResult += '.';
            double positionBehindDuodecimal = 0;
            while (positionBehindDuodecimal < MaxDuodecimals)
            {
                positionBehindDuodecimal++;
                dec *= 12;

                if (Math.Floor(dec) == 10.0){
                    DuoDecResult = DuoDecResult + '↊';
                }
                else if (Math.Floor(dec) == 11.0){
                    DuoDecResult = DuoDecResult + '↋';
                }
                else{
                    DuoDecResult = DuoDecResult + Math.Floor(dec);
                }
                dec -= Math.Floor(dec);
            }

            //Remove useless zeros
            while(DuoDecResult.Last() == '0'){
                DuoDecResult = DuoDecResult.Remove(DuoDecResult.Length - 1);
            }
            if (DuoDecResult.Last() == '.')
            {
                DuoDecResult = DuoDecResult.Remove(DuoDecResult.Length - 1);
            }

            return DuoDecResult;
        }
    }
}
