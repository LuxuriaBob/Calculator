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
        public Calculator()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;
        private float Factorial(float x)
        {
            if (x < 2)
            {
                if (x < 0)
                {
                    return -1;
                }
                return 1;
            }
            return x * Factorial(x - 1);
        }
        private float OneOver(float x)
        {
            return 1 / x;   
        }
        private float Absolute(float x)
        {
            float z = (x < 0) ? -x : x;
            return z;
        }
        private float Power(float x, float y)
        {
            float output = 1;

            for (int i = 0; i < y; ++i)
            {
                output *= x;
            }
            return output;
        }
        private float Exponent(float x, float y)
        {
            float z = 1;
            float output = 0;
            for (int i = 0; i < y; ++i)
            {
                z *= 10;
            }
            output = x * z;
            return output;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }
        private void Button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        private void ButtonPi_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3.1415926535897932384626433832795;
        }
        private void ButtonEuler_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2.7182818284590452353602874713527;
        }
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox2.Text += num1 + "+";
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
        }
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox2.Text += num1 + "-";
                textBox1.Clear();
                textBox1.Focus();
                count = 2;
            }
        }
        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox2.Text += num1 + "*";
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }
        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox2.Text += num1 + "/";
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }
        private void ButtonModulo_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox2.Text += num1 + "%";
            textBox1.Clear();
            textBox1.Focus();
            count = 5;
        }
        private void ButtonPower_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox2.Text += num1 + "x^y";
            textBox1.Clear();
            textBox1.Focus();
            count = 6;
        }
        private void ButtonExponent_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox2.Text += num1 + "E";
            textBox1.Clear();
            textBox1.Focus();
            count = 7;
        }
        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox2.Text += num1 + "!";
            textBox1.Clear();
            ans = Factorial(num1);
            textBox1.Text = ans.ToString();
        }
        private void ButtonAbsoluteValue_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox2.Text += num1 + "|n|";
            textBox1.Clear();
            ans = Absolute(num1);
            textBox1.Text = ans.ToString();
        }
        private void ButtonOneOver_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox2.Text += num1 + "1/x";
            textBox1.Clear();
            ans = OneOver(num1);
            textBox1.Text = ans.ToString();
        }
        private void ButtonXSquared_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox2.Text += num1 + "x²";
            ans = num1 * num1;
            textBox1.Text = ans.ToString();
        }
        private void ButtonPowerOfTen_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox2.Text += num1 + "10^x";
            ans = Power(10, num1);
            textBox1.Text = ans.ToString();
        }
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            Compute(count);
        }
        public void Compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 5:
                    ans = num1 % float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 6:
                    ans = Power(num1, float.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;
                case 7:
                    ans = Exponent(num1, float.Parse(textBox1.Text));
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
        private void buttondelete_Click(object sender, EventArgs e)
        {
            //textBox1.Text.Remove(textBox1.Text - 1);
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }
        private void ButtonComma_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text += ".";
            }
        }
    }
}