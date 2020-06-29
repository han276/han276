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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double heightnumber;
        double weightnumber;
        double resultnumber;
        double bmi;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if ((double.TryParse(height.Text, out double result) == true) && (double.TryParse(weight.Text, out double d) == true))
            {
                heightnumber = Convert.ToDouble(height.Text);
                weightnumber = Convert.ToDouble(weight.Text);
                bmi = weightnumber / Math.Pow(heightnumber, 2);
                resultnumber = Math.Round(bmi);
                finalresult.Text = resultnumber.ToString();
                if (bmi <= 18)
                {
                    criteria.Content = "やせ型";
                }
                else if (bmi > 18 && bmi <= 22)
                {
                    criteria.Content = "標準";
                }
                else if (bmi > 22)
                {
                    criteria.Content = "肥満";
                }
            }
            else
            {
                criteria.Content = "身長体重に数値を入力してください";
            }
        }

              

    }
}
