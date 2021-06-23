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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string sigh = "";
        double num_1;
        double num_2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button selectedbuton = (Button)e.Source;

            switch (selectedbuton.Content)
            {
                case "+":
                    if ((string)Display_1.Content != "")
                    {
                        Display_2.Content = Display_1.Content + " + ";
                        num_1 = double.Parse((string)Display_1.Content);
                        Display_1.Content = "";
                        sigh = (string)selectedbuton.Content;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "-":
                    if ((string)Display_1.Content != "")
                    {
                        Display_2.Content = Display_1.Content + " - ";
                        num_1 = double.Parse((string)Display_1.Content);
                        Display_1.Content = "";
                        sigh = (string)selectedbuton.Content;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "+/-":
                    if ((string)Display_1.Content != "")
                    {
                        Display_1.Content = Calculation.ReverseNumber(Display_1.Content.ToString());
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "X":
                    if ((string)Display_1.Content != "")
                    {
                        Display_2.Content = Display_1.Content + " X ";
                        num_1 = double.Parse((string)Display_1.Content);
                        Display_1.Content = "";
                        sigh = (string)selectedbuton.Content;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "/":
                    if ((string)Display_1.Content != "")
                    {
                        Display_2.Content = Display_1.Content + " / ";
                        num_1 = double.Parse((string)Display_1.Content);
                        Display_1.Content = "";
                        sigh = (string)selectedbuton.Content;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "%":
                    if ((string)Display_1.Content != "")
                    {
                        Display_2.Content = Display_1.Content + " % ";
                        num_1 = double.Parse((string)Display_1.Content);
                        Display_1.Content = "";
                        sigh = (string)selectedbuton.Content;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case ">":
                    if ((string)Display_1.Content != "")
                    {
                        Display_1.Content = Convert.ToString(Convert.ToInt32(Display_1.Content) / 10);
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "=":
                    if ((string)Display_1.Content != "" && (string)Display_2.Content != "")
                    {
                        Display_2.Content += Display_1.Content + " =";
                        num_2 = double.Parse((string)Display_1.Content);
                        Display_1.Content = Calculation.Calculate(num_1, num_2, sigh);
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case "C":
                    Display_1.Content = Calculation.DeleteAll();
                    Display_2.Content = Calculation.DeleteAll();
                    break;
                default:
                    if ((string)Display_1.Content == "0")
                    {
                        Display_1.Content = selectedbuton.Content.ToString();
                    }
                    else
                    {
                        Display_1.Content += selectedbuton.Content.ToString();
                    }
                   
                    break;
            }
        }
    }
}
