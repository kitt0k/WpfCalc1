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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string CopyPaste = null;
        static char[] operators = { '+', '-', '*', '/', '%' };
        double rez = 0, x = 0, y = 0;
        
        public MainWindow()
        {
            InitializeComponent();
                     
        }

        private void btn_deleting_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;
             buf = buf.Remove(buf.Length - 1);
             textBlock_1.Text = buf;
            textBlock_2.Text = "0";
        }
        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "8";

            y = Convert.ToDouble(textBlock_2.Text);

        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "9";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' /*|| buf[buf.Length - 1] == '*'*/ || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf + "/";
                }
            }
            if (y == 0)
            {
                textBlock_1.Text += "/";
            }
            else
            {
                textBlock_1.Text += Convert.ToString(y) + "/";
            }

            if (x == 0)
            {
                rez = y;
            }
            else
            {
                rez = x * y;
            }

            textBlock_2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBlock_2.Text);
            y = 0;
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "4";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "5";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "6";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void btn_multip_Click(object sender, RoutedEventArgs e)
        {
            
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' /*|| buf[buf.Length - 1] == '*'*/ || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf+"*";
                }
            }
            if (y == 0)
            {
                textBlock_1.Text += "*";
            }
            else
            {
                textBlock_1.Text += Convert.ToString(y) + "*";
            }

            if (x == 0)
            {
                rez = y;
            }
            else
            {
                rez = x * y;
            }

            textBlock_2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBlock_2.Text);
            y = 0;

        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "1";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "2";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "3";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '*' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf+"-";
                }

            }

            if (y == 0 & buf != "")
            {
                textBlock_1.Text += "-";
            }

            else
            {
                textBlock_1.Text += Convert.ToString(y) + "-";
            }

            if (x == 0)
            {
                rez = y - x;
            }
            else
            {
                rez = x-y;
            }
            textBlock_2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBlock_2.Text);
            y = 0;
          
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }
           
            textBlock_2.Text += "7";

            y = Convert.ToDouble(textBlock_2.Text);
            
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '*' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBlock_1.Text = buf+ "+";
                }
            }

            if (y == 0 & buf != "")
            {
                textBlock_1.Text += "+";
            }

            else
            {
                textBlock_1.Text += Convert.ToString(y) + "+";
            }

            rez = y + x;
            textBlock_2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBlock_2.Text);
            y = 0;

        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBlock_2.Text = null;
                y = 1;
            }

            textBlock_2.Text += "0";

            y = Convert.ToDouble(textBlock_2.Text);
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            textBlock_2.Text = "0";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            textBlock_1.Text = "";
            textBlock_2.Text = "0";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            CopyPaste = textBlock_2.Text;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            textBlock_2.Text = CopyPaste;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void btn_comma_Click(object sender, RoutedEventArgs e)
        {
            textBlock_2.Text += ",";
        }

        private void btn_equally_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBlock_1.Text;
           
            if (buf[buf.Length-1] == '+')
            {     
                y = Convert.ToDouble(textBlock_2.Text);
                rez = x + y;
                textBlock_2.Text = Convert.ToString(rez);
            }
            if (buf[buf.Length - 1] == '-')
            {
                y = Convert.ToDouble(textBlock_2.Text);
                rez = x - y;
                textBlock_2.Text = Convert.ToString(rez);
            }
            if (buf[buf.Length - 1] == '*')
            {
                y = Convert.ToDouble(textBlock_2.Text);
                rez = x * y;
                textBlock_2.Text = Convert.ToString(rez);
            }
            if (buf[buf.Length - 1] == '/')
            {
                y = Convert.ToDouble(textBlock_2.Text);
                rez = x / y;
                textBlock_2.Text = Convert.ToString(rez);
            }
            rez = 0;
            x = 0;y = 0;
            textBlock_1.Text = null;
        }


    }
}
