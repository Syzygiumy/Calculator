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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }

            public double a;
            public double b;
            public char c;



            private void btnNum1_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "1";
            }

            private void btnNum2_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "2";
            }

            private void btnNum3_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "3";
            }

            private void btnNum4_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "4";
            }

            private void btnNum5_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "5";
            }

            private void btnNum6_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "6";
            }

            private void btnNum7_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "7";
            }

            private void btnNum8_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "8";
            }

            private void btnNum9_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "9";
            }

            private void btnNum0_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "0";
            }

            private void btnNum00_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += "00";
            }

            private void btnNumCom_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Text += ",";
            }

            private void btnSumm_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    a = Convert.ToDouble(tbxNum.Text);
                    c = '+';
                    tbxNum.Text = "";
                }
                catch (Exception)
                {

                }
            }

            private void btnMin_Click(object sender, RoutedEventArgs e)
            {
                try
                {

                    a = Convert.ToDouble(tbxNum.Text);
                    c = '-';
                    tbxNum.Text = "";
                }
                catch (Exception)
                {

                }
            }

            private void btnMulti_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    a = Convert.ToDouble(tbxNum.Text);
                    c = '*';
                    tbxNum.Text = "";
                }
                catch (Exception)
                {

                }
            }

            private void btnDiv_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    a = Convert.ToDouble(tbxNum.Text);
                    c = ':';
                    tbxNum.Text = "";
                }
                catch (Exception)
                {

                }
            }

            private void btnPerc_Click(object sender, RoutedEventArgs e)
            {
                try
                {
                    a = Convert.ToDouble(tbxNum.Text);
                    c = '%';
                    tbxNum.Text = "";
                    tbxNum.Text = Convert.ToString(Math.Round(a / 100));
                }
                catch (Exception)
                {

                }
            }

            private void btnEqual_Click(object sender, RoutedEventArgs e)
            {
                b = Convert.ToDouble(tbxNum.Text);
                tbxNum.Text = "";
                switch (c)
                {
                    case '+':
                        tbxNum.Text = Convert.ToString(a + b);
                        break;
                    case '-':
                        tbxNum.Text = Convert.ToString(a - b);
                        break;
                    case '*':
                        tbxNum.Text = Convert.ToString(a * b);
                        break;
                    case ':':
                        tbxNum.Text = Convert.ToString(a / b);
                        break;
                    case '%':
                        tbxNum.Text = Convert.ToString(a / 100);
                        break;
                }
            }

            private void btnRad_Click(object sender, RoutedEventArgs e)
            {
                a = Convert.ToDouble(tbxNum.Text);
                tbxNum.Text = Convert.ToString(Math.Sqrt(a));
            }

            private void btnClear_Click(object sender, RoutedEventArgs e)
            {
                tbxNum.Clear();
            }
        }
}
