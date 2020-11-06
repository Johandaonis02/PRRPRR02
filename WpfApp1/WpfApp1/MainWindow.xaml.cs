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
            
            switch(Grid.GetColumn(button) + 4 * Grid.GetRow(button)){
                case 3:
                    if (JaText.Text.Length != 0){
                        JaText.Text = JaText.Text.Remove(JaText.Text.Length - 1);
                    }
                    else{
                        JaText.Text = "error";
                    }
                    break;
                case 7:
                    JaText.Text = "";
                    break;
                case 11:
                    if (JaText.Text[JaText.Text.Length - 1] != '+'){
                        if (JaText.Text.Length != 0){
                            JaText.Text += '+';
                        }
                    }
                    break;
                case 15:
                    int result = 0;
                    int theNumberIWantToAdd = 0;

                    while(JaText.Text.Length > 0) {
                        if(JaText.Text[0] == '+'){
                            result += theNumberIWantToAdd;
                            theNumberIWantToAdd = 0;
                        }
                        else{
                            theNumberIWantToAdd = theNumberIWantToAdd * 10 + int.Parse(JaText.Text[0].ToString());
                        }

                        JaText.Text.Remove(0);
                    }
                    
                    JaText.Text = result.ToString();
                   
                    break;
                default:
                    JaText.Text += Grid.GetColumn(button) + 3 * Grid.GetRow(button);
                    break;
            }

            
        

        }

    }
}
