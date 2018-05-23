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

namespace BMI.WPF
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void h_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void clear1_Click(object sender, RoutedEventArgs e)
        {
            hei.Text = "0";
            hei.Background = Brushes.White;
            slider1.Value = 0;
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                w.Text = slider2.Value.ToString();
                hei.Text = slider1.Value.ToString();
                //定義變數
                double H, W;
                H = Convert.ToInt32(slider1.Value);
                W = Convert.ToInt32(slider2.Value);
                //單位轉換
                double h = H / 100;
                //BMI公式計算
                double r = (W / (h * h));
                result.Text = r.ToString();
                hei.Background = Brushes.GreenYellow;
                w.Background = Brushes.GreenYellow;
                if (r > 30)
                {
                    result.Background = Brushes.Red;
                }
                if (17 <= r && r <= 30)
                {
                    result.Background = Brushes.Green;
                }
                if (17 > r)
                {
                    result.Background = Brushes.Blue;
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字喔!");
            }
        }

        private void w_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clear2_Click(object sender, RoutedEventArgs e)
        {
            w.Text = "0";
            w.Background = Brushes.White;
            slider2.Value = 0;
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                hei.Text = slider1.Value.ToString();
                w.Text = slider2.Value.ToString();
                //定義變數
                double H, W;
                H = Convert.ToInt32(slider1.Value);
                W = Convert.ToInt32(slider2.Value);
                //單位轉換
                double h = H / 100;
                //BMI公式計算
                double r = (W / (h * h));
                result.Text = r.ToString();
                hei.Background = Brushes.GreenYellow;
                w.Background = Brushes.GreenYellow;
                hei.Background = Brushes.GreenYellow;
                w.Background = Brushes.GreenYellow;
                if (r > 30)
                {
                    result.Background = Brushes.Red;
                }
                if (17 <= r && r <= 30)
                {
                    result.Background = Brushes.Green;
                }
                if (17 > r)
                {
                    result.Background = Brushes.Blue;
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字喔!");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //定義變數
                double H, W;
                H = Convert.ToInt32(hei.Text);
                W = Convert.ToInt32(w.Text);
                //單位轉換
                double h = H / 100;
                //BMI公式計算
                double r = (W / (h * h));
                result.Text = r.ToString();
                if (r > 30)
                {
                    result.Background = Brushes.Red;
                }
                if (17 <= r && r <= 30)
                {
                    result.Background = Brushes.Green;
                }
                if (17 > r)
                {
                    result.Background = Brushes.Blue;
                }
            }
            //除錯,處理非數字例外情況
            catch
            {
                MessageBox.Show("請輸入數字喔!");
            }
        }

        private void RB1_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = true;
            result.IsEnabled = true;
        }

        private void hei_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
