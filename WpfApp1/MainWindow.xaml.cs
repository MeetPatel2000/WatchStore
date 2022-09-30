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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string number = UserInput.Text;
            float a = float.Parse(number);
            float b = (float)(a * 9.8);
            float c = (float)((a / 1000) * 9.8);
            Solution.Content = b;

            if (KGToWeight.IsChecked == true)
            {
                Result.Content = b < 10 ? "It's Too light" : b > 1000?"It's heavy weight" : "Its normal weight";
            }
            else if (GramToWeight.IsChecked == true)
            {
                Solution.Content = c;
                Result.Content = GramToWeight.IsChecked == true && c < 10 ? "its light" : c > 1000 ? "Its heavy" : "its normal";
            }
            else if (KGToWeight.IsChecked == false && GramToWeight.IsChecked == false)
            {
                Result.Content = b < 10 ? "It's Too light" : b > 1000 ? "It's too heavy" : "Its normal" ;
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            UserInput.Clear();
            Result.Content = "";
            Solution.Content = "";
        }
    }
}
