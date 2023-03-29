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
            num1.Text = "0";
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number1 =Convert.ToInt32(num1.Text);
            int number2 = Convert.ToInt32(num2.Text);
            int result,result2;
            if (multiplication.IsChecked == true && addition.IsChecked == true)
            {
                result = number1 * number2;

                result2 = number1 + number2;
                Result.Content = $"Multipli={result} Addition={result2}";

            }
            else if (multiplication.IsChecked==true) 
            {
                result=number1*number2;
                Result.Content = $"Multipli= {result}";
            }

            else if(addition.IsChecked==true)
            { 
                result = number1+number2;
                Result.Content = $"Addition= {result}";
            }
            

            else { Result.Content = "Please select one"; }
           


        }


    }
}
