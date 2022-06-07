using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {

        string output = string.Empty;
        string number1 = string.Empty;
        string number2 = string.Empty; 
        string operand = string.Empty;


        public Calculator()
        {
            InitializeComponent();
        }

        private void Division(float x, float y)
        {
            float output = x / y;
            this.label1.Text = output.ToString();
        }

        private void Multiplication(float x, float y)
        {
            float output = x * y;
            this.label1.Text = output.ToString();
        }

        private void Summation(float x, float y)
        {
            float output = x + y;
            this.label1.Text = output.ToString();
        }

        private void Extraction(float x, float y)
        {
            float output = x - y;
            this.label1.Text = output.ToString();
        }

        private float Factorial(float x)
        {
            if(x < 2)
            {
                if (x < 0)
                {
                    return -1;
                }
                return 1;
            }
            return x*Factorial(x - 1);
        }

        private void OneOver(float x)
        {
            float output = 1 / x;
            this.label1.Text = output.ToString();
        }

        private float Absolute(float x)
        {
            return (x < 0) ? -x : x;
        }

        private void Modulo(float x, float y)
        {
            float output = x % y;
            this.label1.Text = output.ToString();
        }

        private void Power(float x, float y)
        {
            float output = 1;

            for(int i = 0; i < y; ++i)
            {
                output *= x;
            }
            this.label1.Text = output.ToString();
        }

        private void Exponent(float x, float y)
        {
            float z = 1;
            float output = 0;
            for (int i = 0; i < y; ++i)
            {
                z *= 10;
            }

            output = x * z;
            this.label1.Text = output.ToString();
        }

        private void Euler()
        {
            output = "2.7182818284590452353602874713527";
            this.label1.Text = output;
        }

        private void Pi()
        {
            output = "3.1415926535897932384626433832795";
            this.label1.Text = output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number1 += "1";
                this.label1.Text += number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number2 += "1";
                this.label1.Text += number2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number1 += "2";
                this.label1.Text += number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number2 += "2";
                this.label1.Text += number2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number1 += "3";
                this.label1.Text += number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number2 += "3";
                this.label1.Text += number2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number1 += "4";
                this.label1.Text += number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number2 += "4";
                this.label1.Text += number2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number1 += "5";
                this.label1.Text += number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number2 += "5";
                this.label1.Text += number2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number1 += "6";
                this.label1.Text += number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number2 += "6";
                this.label1.Text += number2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number1 += "7";
                this.label1.Text += number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number2 += "7";
                this.label1.Text += number2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number1 += "8";
                this.label1.Text += number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number2 += "8";
                this.label1.Text += number2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number1 += "9";
                this.label1.Text += number1;
            }
            
            if (!String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number2 += "9";
                this.label1.Text += number2;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number1 += "0";
                this.label1.Text += number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                this.label1.Text = "";
                number2 += "0";
                this.label1.Text += number2;
            }
        }

        private void buttondivision_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            operand += "/";
            this.label1.Text += operand;
        }

        private void buttonmultiplication_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            operand += "*";
            this.label1.Text += operand;
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            operand += "-";
            this.label1.Text += operand;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            operand += "+";
            this.label1.Text += operand;
        }

        private void buttonmodulo_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            operand += "%";
            this.label1.Text += operand;
        }

        private void buttonfactorial_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            operand += "!";
            this.label1.Text += operand;
        }

        private void buttonabsolutevalue_Click(object sender, EventArgs e)
        {
            float z = Absolute(-7.4F);
            output = z.ToString();
            label1.Text = output;
        }

        private void buttononeover_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            operand += "1/x";
            this.label1.Text += operand;
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            float number3 = float.Parse(number1);
            float number4 = float.Parse(number2);
            

            switch (operand)
            {
                case "+":
                    Summation(number3, number4);
                    break;
                case "-":
                    Extraction(number3, number4);
                    break;
                case "/":
                    Division(number3, number4);
                    break;
                case "*":
                    Multiplication(number3, number4);
                    break;
                case "%":
                    Modulo(number3, number4);
                    break;
                case "!":
                    Factorial(number3);
                    break;
                case "1/x":
                    OneOver(number3);
                    break;
                case "x^y":
                    Power(number3, number4);
                    break;
                case "exp":
                    Exponent(number3, number4);
                    break;
                default:
                    Console.WriteLine("unexpected error");
                    break;
            }
            /*
            number1 = number2;
            number2 = String.Empty; 
            */
        }

        private void buttonpi_Click(object sender, EventArgs e)
        {
            Pi();

            if (String.IsNullOrEmpty(operand))
            {
                number1 = output;
                this.label1.Text = number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                number2 = output;
                this.label1.Text = number2;
            }
        }

        private void buttoneuler_Click(object sender, EventArgs e)
        {
            Euler();

            if (String.IsNullOrEmpty(operand))
            {
                number1 = output;
                this.label1.Text = number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                number2 = output;
                this.label1.Text = number2;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            number1 = String.Empty;
            number2 = String.Empty;
            operand = String.Empty;
            output = String.Empty;
            this.label1.Text = output;
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(operand))
            {
                number1 = number1.Remove(number1.Length - 1);
                this.label1.Text = number1;
            }

            if (!String.IsNullOrEmpty(operand))
            {
                if(String.IsNullOrEmpty(number2))
                {
                    number2 = number2.Remove(number2.Length - 1);
                    this.label1.Text = number2;
                }
            }
        }

        private void buttonxsquared_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            operand += "x^2";
            this.label1.Text += operand;
        }

        private void buttonpower_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            operand += "x^y";
            this.label1.Text += operand;
        }

        private void buttonexponent_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            operand += "exp";
            this.label1.Text += operand;
        }
    }
}