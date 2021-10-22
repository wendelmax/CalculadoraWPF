using System;
using System.Windows;

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool sinal = true;
        char operador;
        double num1=0, num2=0;
        public MainWindow()
        {
            InitializeComponent();
            display.Content = "";
            displayOp.Content = "";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            display.Content += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            display.Content += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            display.Content += "9";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            display.Content += "6";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            display.Content += "5";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            display.Content += "4";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            display.Content += "3";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            display.Content += "2";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            display.Content += "1";
        }

        private void btnMaisMenos_Click(object sender, RoutedEventArgs e)
        {
            if (display.Content.ToString().Contains("- "))
            {
                display.Content = display.Content.ToString().Replace("- ","");
            }
            else
            {
                display.Content = "- " + display.Content;
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            display.Content += "0";
        }

        private void btnVirgula_Click(object sender, RoutedEventArgs e)
        {
            if (!display.Content.ToString().Contains(","))
            {
                if (display.Content.ToString().Length < 1)
                {
                    display.Content += "0,";
                }
                else
                {
                    display.Content += ",";
                }
            }
        }

        private void btnPercentual_Click(object sender, RoutedEventArgs e) 
        {
            if (displayOp.Content != null && !sinal && display.Content.ToString().Length > 0)
            {
                display.Content = (Convert.ToDouble(display.Content) / 100).ToString().Replace(".",",");
            }
            else
            {
                display.Content = "ERROR";
                desabilitaBtn();
            }

        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            display.Content = "";
            displayOp.Content = "";
            habilitaBtn();
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (display.Content.ToString().Length > 0)
            {
                display.Content = display.Content.ToString().Remove(display.Content.ToString().Length - 1);
            }
            
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (sinal)
            {
                if (display.Content.ToString().EndsWith(","))
                {
                    display.Content += "0";
                }
                num1 = Double.Parse(display.Content.ToString());
                displayOp.Content += display.Content + " ÷ ";
                display.Content = "";
                sinal = false;
                operador = 'd';
            }
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            if (sinal)
            {
                if (display.Content.ToString().EndsWith(","))
                {
                    display.Content += "0";
                }
                num1 = Double.Parse(display.Content.ToString());
                displayOp.Content += display.Content + " x ";
                display.Content = "";
                sinal = false;
                operador = 'm';
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            if (sinal)
            {
                if (display.Content.ToString().EndsWith(","))
                {
                    display.Content += "0";
                }
                num1 = Double.Parse(display.Content.ToString());
                displayOp.Content += display.Content + " - ";
                display.Content = "";
                sinal = false;
                operador = 's';
            }
        }

        private void btnSoma_Click(object sender, RoutedEventArgs e)
        {
            if (sinal)
            {
                if (display.Content.ToString().EndsWith(","))
                {
                    display.Content += "0";
                }
                num1 = Double.Parse(display.Content.ToString());
                displayOp.Content += display.Content + " + ";
                display.Content = "";
                sinal = false;
                operador = 'a';
            }
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            if (display.Content.ToString().EndsWith(","))
            {
                display.Content += "0";
            }
            num2 = Double.Parse(display.Content.ToString());
            displayOp.Content += display.Content.ToString();
            display.Content = "";

            switch (operador)
            {
                case 'a':
            
                    displayOp.Content += " = ";
                    display.Content = num1 + num2;
                    break;
                case 's':
                    displayOp.Content += " = ";
                    display.Content = num1 - num2;
                    break;
                case 'm':
                    displayOp.Content += " = ";
                    display.Content = num1 * num2;
                    break;
                case 'd':
                    displayOp.Content += " = ";
                    display.Content = num1 / num2;
                    break;
            }
            sinal = true;
        }

        private void desabilitaBtn()
        {
            btn0.IsEnabled = false;
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
            btnMaisMenos.IsEnabled = false;
            btnVirgula.IsEnabled = false;
            btnIgual.IsEnabled = false;
            btnSoma.IsEnabled = false;
            btnSub.IsEnabled = false;
            btnMult.IsEnabled = false;
            btnDiv.IsEnabled = false;
            btnBackSpace.IsEnabled = false;
            btnPercentual.IsEnabled = false;
        }

        private void habilitaBtn()
        {
            btn0.IsEnabled = true;
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            btnMaisMenos.IsEnabled = true;
            btnVirgula.IsEnabled = true;
            btnIgual.IsEnabled = true;
            btnSoma.IsEnabled = true;
            btnSub.IsEnabled = true;
            btnMult.IsEnabled = true;
            btnDiv.IsEnabled = true;
            btnBackSpace.IsEnabled = true;
            btnPercentual.IsEnabled = true;
        }
    }
}
