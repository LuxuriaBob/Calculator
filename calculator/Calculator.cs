using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace calculator
{
    public partial class Calculator : Form
    {
        private Rectangle TextResultOriginalRect;
        private Rectangle TextHistOriginalRect;
        private Rectangle ButtonSecondOriginalRect;
        private Rectangle ButtonPiOriginalRect;
        private Rectangle ButtonEulerOriginalRect;
        private Rectangle ButtonCOriginalRect;
        private Rectangle ButtonDeleteOriginalRect;
        private Rectangle ButtonXSquaredOriginalRect;
        private Rectangle ButtonOneOverOriginalRect;
        private Rectangle ButtonAbsoluteValueOriginalRect;
        private Rectangle ButtonExponentOriginalRect;
        private Rectangle ButtonModuloOriginalRect;
        private Rectangle ButtonRootSquareOriginalRect;
        private Rectangle ButtonLeftParanthesisOriginalRect;
        private Rectangle ButtonRightParanthesisOriginalRect;
        private Rectangle ButtonFactorialOriginalRect;
        private Rectangle ButtonDivisionOriginalRect;
        private Rectangle ButtonPowerOriginalRect;
        private Rectangle Button7OriginalRect;
        private Rectangle Button8OriginalRect;
        private Rectangle Button9OriginalRect;
        private Rectangle ButtonMultiplicationOriginalRect;
        private Rectangle ButtonPowerOfTenOriginalRect;
        private Rectangle Button4OriginalRect;
        private Rectangle Button5OriginalRect;
        private Rectangle button6OriginalRect;
        private Rectangle ButtonMinusOriginalRect;
        private Rectangle ButtonLogOriginalRect;
        private Rectangle Button1OriginalRect;
        private Rectangle Button2OriginalRect;
        private Rectangle Button3OriginalRect;
        private Rectangle ButtonPlusOriginalRect;
        private Rectangle ButtonLnOriginalRect;
        private Rectangle ButtonPlusMinusOriginalRect;
        private Rectangle Button0OriginalRect;
        private Rectangle ButtonCommaOriginalRect;
        private Rectangle ButtonEqualsOriginalRect;
        private Rectangle MenuStripOriginalRect;
        private Rectangle formOriginalSize;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            textResult.BorderStyle = 0;
            textResult.BackColor = this.BackColor;
            textHist.BorderStyle = 0;
            textHist.BackColor = this.BackColor;
            TrgMenuStrip.BackColor = this.BackColor;

            formOriginalSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            TextResultOriginalRect = new Rectangle(textResult.Location.X, textResult.Location.Y, textResult.Width, textResult.Height);
            TextHistOriginalRect = new Rectangle(textHist.Location.X, textHist.Location.Y, textHist.Width, textHist.Height);
            ButtonSecondOriginalRect = new Rectangle(ButtonSecond.Location.X, ButtonSecond.Location.Y, ButtonSecond.Width, ButtonSecond.Height);
            ButtonPiOriginalRect = new Rectangle(ButtonPi.Location.X, ButtonPi.Location.Y, ButtonPi.Width, ButtonPi.Height);
            ButtonEulerOriginalRect = new Rectangle(ButtonEuler.Location.X, ButtonEuler.Location.Y, ButtonEuler.Width, ButtonEuler.Height);
            ButtonCOriginalRect = new Rectangle(ButtonC.Location.X, ButtonC.Location.Y, ButtonC.Width, ButtonC.Height);
            ButtonDeleteOriginalRect = new Rectangle(ButtonDelete.Location.X, ButtonDelete.Location.Y, ButtonDelete.Width, ButtonDelete.Height);
            ButtonXSquaredOriginalRect = new Rectangle(ButtonXSquared.Location.X, ButtonXSquared.Location.Y, ButtonXSquared.Width, ButtonXSquared.Height);
            ButtonOneOverOriginalRect = new Rectangle(ButtonOneOver.Location.X, ButtonOneOver.Location.Y, ButtonOneOver.Width, ButtonOneOver.Height);
            ButtonAbsoluteValueOriginalRect = new Rectangle(ButtonAbsoluteValue.Location.X, ButtonAbsoluteValue.Location.Y, ButtonAbsoluteValue.Width, ButtonAbsoluteValue.Height);
            ButtonExponentOriginalRect = new Rectangle(ButtonExponent.Location.X, ButtonExponent.Location.Y, ButtonExponent.Width, ButtonExponent.Height);
            ButtonModuloOriginalRect = new Rectangle(ButtonModulo.Location.X, ButtonModulo.Location.Y, ButtonModulo.Width, ButtonModulo.Height);
            ButtonRootSquareOriginalRect = new Rectangle(ButtonRootSquare.Location.X, ButtonRootSquare.Location.Y, ButtonRootSquare.Width, ButtonRootSquare.Height);
            ButtonLeftParanthesisOriginalRect = new Rectangle(ButtonGraph.Location.X, ButtonGraph.Location.Y, ButtonGraph.Width, ButtonGraph.Height);
            ButtonRightParanthesisOriginalRect = new Rectangle(ButtonX.Location.X, ButtonX.Location.Y, ButtonX.Width, ButtonX.Height);
            ButtonFactorialOriginalRect = new Rectangle(ButtonFactorial.Location.X, ButtonFactorial.Location.Y, ButtonFactorial.Width, ButtonFactorial.Height);
            ButtonDivisionOriginalRect = new Rectangle(ButtonDivision.Location.X, ButtonDivision.Location.Y, ButtonDivision.Width, ButtonDivision.Height);
            ButtonPowerOriginalRect = new Rectangle(ButtonPower.Location.X, ButtonPower.Location.Y, ButtonPower.Width, ButtonPower.Height);
            Button7OriginalRect = new Rectangle(Button7.Location.X, Button7.Location.Y, Button7.Width, Button7.Height);
            Button8OriginalRect = new Rectangle(Button8.Location.X, Button8.Location.Y, Button8.Width, Button8.Height);
            Button9OriginalRect = new Rectangle(Button9.Location.X, Button9.Location.Y, Button9.Width, Button9.Height);
            ButtonMultiplicationOriginalRect = new Rectangle(ButtonMultiplication.Location.X, ButtonMultiplication.Location.Y, ButtonMultiplication.Width, ButtonMultiplication.Height);
            ButtonPowerOfTenOriginalRect = new Rectangle(ButtonPowerOfTen.Location.X, ButtonPowerOfTen.Location.Y, ButtonPowerOfTen.Width, ButtonPowerOfTen.Height);
            Button4OriginalRect = new Rectangle(Button4.Location.X, Button4.Location.Y, Button4.Width, Button4.Height);
            Button5OriginalRect = new Rectangle(Button5.Location.X, Button5.Location.Y, Button5.Width, Button5.Height);
            button6OriginalRect = new Rectangle(Button6.Location.X, Button6.Location.Y, Button6.Width, Button6.Height);
            ButtonMinusOriginalRect = new Rectangle(ButtonMinus.Location.X, ButtonMinus.Location.Y, ButtonMinus.Width, ButtonMinus.Height);
            ButtonLogOriginalRect = new Rectangle(ButtonLog.Location.X, ButtonLog.Location.Y, ButtonLog.Width, ButtonLog.Height);
            Button1OriginalRect = new Rectangle(Button1.Location.X, Button1.Location.Y, Button1.Width, Button1.Height);
            Button2OriginalRect = new Rectangle(Button2.Location.X, Button2.Location.Y, Button2.Width, Button2.Height);
            Button3OriginalRect = new Rectangle(Button3.Location.X, Button3.Location.Y, Button3.Width, Button3.Height);
            ButtonPlusOriginalRect = new Rectangle(ButtonPlus.Location.X, ButtonPlus.Location.Y, ButtonPlus.Width, ButtonPlus.Height);
            ButtonLnOriginalRect = new Rectangle(ButtonLn.Location.X, ButtonLn.Location.Y, ButtonLn.Width, ButtonLn.Height);
            ButtonPlusMinusOriginalRect = new Rectangle(ButtonPlusMinus.Location.X, ButtonPlusMinus.Location.Y, ButtonPlusMinus.Width, ButtonPlusMinus.Height);
            Button0OriginalRect = new Rectangle(Button0.Location.X, Button0.Location.Y, Button0.Width, Button0.Height);
            ButtonCommaOriginalRect = new Rectangle(ButtonComma.Location.X, ButtonComma.Location.Y, ButtonComma.Width, ButtonComma.Height);
            ButtonEqualsOriginalRect = new Rectangle(ButtonEquals.Location.X, ButtonEquals.Location.Y, ButtonEquals.Width, ButtonEquals.Height);
            MenuStripOriginalRect = new Rectangle(TrgMenuStrip.Location.X, TrgMenuStrip.Location.Y, TrgMenuStrip.Width, TrgMenuStrip.Height);
        }
        private void ResizeChildrenControls()
        {
            ResizeControl(TextResultOriginalRect, textResult);
            ResizeControl(TextHistOriginalRect, textHist);
            ResizeControl(ButtonSecondOriginalRect, ButtonSecond);
            ResizeControl(ButtonPiOriginalRect, ButtonPi);
            ResizeControl(ButtonEulerOriginalRect, ButtonEuler);
            ResizeControl(ButtonCOriginalRect, ButtonC);
            ResizeControl(ButtonDeleteOriginalRect, ButtonDelete);
            ResizeControl(ButtonXSquaredOriginalRect, ButtonXSquared);
            ResizeControl(ButtonOneOverOriginalRect, ButtonOneOver);
            ResizeControl(ButtonAbsoluteValueOriginalRect, ButtonAbsoluteValue);
            ResizeControl(ButtonExponentOriginalRect, ButtonExponent);
            ResizeControl(ButtonModuloOriginalRect, ButtonModulo);
            ResizeControl(ButtonRootSquareOriginalRect, ButtonRootSquare);
            ResizeControl(ButtonLeftParanthesisOriginalRect, ButtonGraph);
            ResizeControl(ButtonRightParanthesisOriginalRect, ButtonX);
            ResizeControl(ButtonFactorialOriginalRect, ButtonFactorial);
            ResizeControl(ButtonDivisionOriginalRect, ButtonDivision);
            ResizeControl(ButtonPowerOriginalRect, ButtonPower);
            ResizeControl(Button7OriginalRect, Button7);
            ResizeControl(Button8OriginalRect, Button8);
            ResizeControl(Button9OriginalRect, Button9);
            ResizeControl(ButtonMultiplicationOriginalRect, ButtonMultiplication);
            ResizeControl(ButtonPowerOfTenOriginalRect, ButtonPowerOfTen);
            ResizeControl(Button4OriginalRect, Button4);
            ResizeControl(Button5OriginalRect, Button5);
            ResizeControl(button6OriginalRect, Button6);
            ResizeControl(ButtonMinusOriginalRect, ButtonMinus);
            ResizeControl(ButtonLogOriginalRect, ButtonLog);
            ResizeControl(Button1OriginalRect, Button1);
            ResizeControl(Button2OriginalRect, Button2);
            ResizeControl(Button3OriginalRect, Button3);
            ResizeControl(ButtonPlusOriginalRect, ButtonPlus);
            ResizeControl(ButtonLnOriginalRect, ButtonLn);
            ResizeControl(ButtonPlusMinusOriginalRect, ButtonPlusMinus);
            ResizeControl(Button0OriginalRect, Button0);
            ResizeControl(ButtonCommaOriginalRect, ButtonComma);
            ResizeControl(ButtonEqualsOriginalRect, ButtonEquals);
            ResizeControl(MenuStripOriginalRect, TrgMenuStrip);
        }
        private void ResizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }
        private void Calculator_Resize(object sender, EventArgs e)
        {
            ResizeChildrenControls();
        }

        public static string SetValueForB = "";
        public static string SetValueForA = "";
        public static int minus = 0; 
        float num1, ans;
        int count, clear, second, graph;
        int zero = 1;
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
        private float Exponent(float x, float y)
        {
            float z = 1;
            for (int i = 0; i < y; ++i)
            {
                z *= 10;
            }
            float output = x * z;
            return output;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (zero == 1)
            {
                textResult.Clear();
                zero = 0;
            }
            if (clear == 1)
            {
                textResult.Clear();
                textHist.Clear();
                clear = 0;
            }
            textResult.Text += 1;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (zero == 1)
            {
                textResult.Clear();
                zero = 0;
            }
            if (clear == 1)
            {
                textResult.Clear();
                textHist.Clear();
                clear = 0;
            }
            textResult.Text += 2;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (zero == 1)
            {
                textResult.Clear();
                zero = 0;
            }
            if (clear == 1)
            {
                textResult.Clear();
                textHist.Clear();
                clear = 0;
            }
            textResult.Text += 3;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (zero == 1)
            {
                textResult.Clear();
                zero = 0;
            }
            if (clear == 1)
            {
                textResult.Clear();
                textHist.Clear();
                clear = 0;
            }
            textResult.Text += 4;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            if (zero == 1)
            {
                textResult.Clear();
                zero = 0;
            }
            if (clear == 1)
            {
                textResult.Clear();
                textHist.Clear();
                clear = 0;
            }
            textResult.Text += 5;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            if (zero == 1)
            {
                textResult.Clear();
                zero = 0;
            }
            if (clear == 1)
            {
                textResult.Clear();
                textHist.Clear();
                clear = 0;
            }
            textResult.Text += 6;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if (zero == 1)
            {
                textResult.Clear();
                zero = 0;
            }
            if (clear == 1)
            {
                textResult.Clear();
                textHist.Clear();
                clear = 0;
            }
            textResult.Text += 7;
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            if (zero == 1)
            {
                textResult.Clear();
                zero = 0;
            }
            if (clear == 1)
            {
                textResult.Clear();
                textHist.Clear();
                clear = 0;
            }
            textResult.Text += 8;
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            if (zero == 1)
            {
                textResult.Clear();
                zero = 0;
            }
            if (clear == 1)
            {
                textResult.Clear();
                textHist.Clear();
                clear = 0;
            }
            textResult.Text += 9;
        }
        private void Button0_Click(object sender, EventArgs e)
        {
            if (zero == 1)
            {
                textResult.Clear();
                zero = 0;
            }
            if (clear == 1)
            {
                textResult.Clear();
                textHist.Clear();
                clear = 0;
            }
            textResult.Text += 0;
        }
        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            textResult.Text = "-" + textResult.Text;
        }
        private void ButtonPi_Click(object sender, EventArgs e)
        {
            textResult.Clear();
            textResult.Text += Math.PI;
        }
        private void ButtonEuler_Click(object sender, EventArgs e)
        {
            textResult.Clear();
            textResult.Text += Math.E;
        }
        private void ButtonX_Click(object sender, EventArgs e)
        {
            textResult.Text += "X";
            int textResultLength = textResult.TextLength;
            num1 = float.Parse((textResult.Text.Remove(textResultLength - 1)));
            SetValueForA = (textResult.Text.Remove(textResultLength - 1));
            graph = 1;
        }
        private void ButtonGraph_Click(object sender, EventArgs e)
        {
            SetValueForB = textResult.Text;
            if(minus == 1)
            {
                SetValueForB = textResult.Text;
            }
            graph = 0;
            zero = 0;
            textHist.Text += textResult.Text;
            textResult.Clear();
            var graphicsForm = new GraphForm();
            graphicsForm.Show();
            clear = 1;
        }
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if(graph == 1)
            {
                textHist.Text += num1 + " X + ";
                textResult.Clear(); 
            } else {
                num1 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
                textHist.Text += num1 + " + ";
                textResult.Clear();
                textResult.Focus();
                count = 1;
            }
        }
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (textResult.Text != "")
            {
                if (graph == 1)
                {
                    textHist.Text += num1 + " X - ";
                    textResult.Clear();
                    minus = 1;

                } else {
                    num1 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
                    textHist.Text += num1 + " - ";
                    textResult.Clear();
                    textResult.Focus();
                    count = 2;
                    minus = 1;
                }
            }
        }
        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
            textHist.Text += num1 + " * ";
            textResult.Clear();
            textResult.Focus();
            count = 3;
        }
        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
            textHist.Text += num1 + " ÷ ";
            textResult.Clear();
            textResult.Focus();
            count = 4;
        }
        private void ButtonModulo_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
            textHist.Text += num1 + " % ";
            textResult.Clear();
            textResult.Focus();
            count = 5;
        }
        private void ButtonPower_Click(object sender, EventArgs e)
        {
            if(second == 1)
            {
                num1 = float.Parse(textResult.Text);
                textHist.Text += num1 + " ʸ√x ";
                textResult.Clear();
                textResult.Focus();
                count = 6;
            } else {
                num1 = float.Parse(textResult.Text);
                textHist.Text += num1 + " x^y ";
                textResult.Clear();
                textResult.Focus();
                count = 6;
            }
        }
        private void ButtonExponent_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textResult.Text);
            textHist.Text += num1 + "E";
            textResult.Clear();
            textResult.Focus();
            count = 7;
            clear = 1;
        }
        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textResult.Text);
            textHist.Text += num1 + "!";
            textResult.Clear();
            ans = Factorial(num1);
            textResult.Text = ans.ToString();
            clear = 1;
        }
        private void ButtonAbsoluteValue_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textResult.Text);
            textHist.Text += "(abs)" + num1;
            textResult.Clear();
            ans = Absolute(num1);
            textResult.Text = ans.ToString();
            clear = 1;
        }
        private void ButtonOneOver_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textResult.Text);
            textHist.Text += num1 + "1/x";
            textResult.Clear();
            ans = OneOver(num1);
            textResult.Text = ans.ToString();
            clear = 1;
        }
        private void ButtonXSquared_Click(object sender, EventArgs e)
        {
            if(second == 1)
            {
                num1 = float.Parse(textResult.Text);
                textResult.Clear();
                textHist.Text += num1 + "x³";
                ans = num1 * num1 * num1;
                textResult.Text = ans.ToString();
                clear = 1;
            } else {
                num1 = float.Parse(textResult.Text);
                textResult.Clear();
                textHist.Text += num1 + "x²";
                ans = num1 * num1;
                textResult.Text = ans.ToString();
                clear = 1;
            }
        }
        private void ButtonPowerOfTen_Click(object sender, EventArgs e)
        {
            if (second == 1)
            {
                num1 = float.Parse(textResult.Text);
                textResult.Clear();
                textHist.Text += num1 + "2˟";
                ans = (float)Math.Pow(2,num1);
                textResult.Text = ans.ToString();
                clear = 1;
            }
            else
            {
                num1 = float.Parse(textResult.Text);
                textResult.Clear();
                textHist.Text += num1 + "10˟";
                ans = (float)Math.Pow(10, num1);
                textResult.Text = ans.ToString();
                clear = 1;
            }   
        }
        private void ButtonRootSquare_Click(object sender, EventArgs e)
        {
            if(second == 1)
            {
                num1 = float.Parse(textResult.Text);
                textResult.Clear();
                textHist.Text += "∛(" + num1 + ")";
                ans = (float)Math.Pow(num1, 0.3333333333333333);
                textResult.Text = ans.ToString();
                clear = 1;
            } else {
                num1 = float.Parse(textResult.Text);
                textResult.Clear();
                textHist.Text += "√(" + num1 + ")";
                ans = (float)Math.Sqrt(num1);
                textResult.Text = ans.ToString();
                clear = 1;
            }
        }
        private void ButtonLog_Click(object sender, EventArgs e)
        {
            if(second == 1)
            {
                num1 = float.Parse(textResult.Text);
                textResult.Clear();
                textHist.Text += "logᵧ(" + num1 + ")";
                count = 8;
            } else {
                num1 = float.Parse(textResult.Text);
                textResult.Clear();
                textHist.Text += "log(" + num1 + ")";
                ans = (float)Math.Log10(num1);
                textResult.Text = ans.ToString();
                clear = 1;
            }
        }
        private void ButtonLn_Click(object sender, EventArgs e)
        {
            if(second == 1)
            {
                num1 = float.Parse(textResult.Text);
                textResult.Clear();
                textHist.Text += "e^(" + num1 + ")";
                ans = (float)Math.Pow(Math.E, num1);
                textResult.Text = ans.ToString();
                clear = 1;
            } else {
                num1 = float.Parse(textResult.Text);
                textResult.Clear();
                textHist.Text += "ln(" + (double)num1 + ")";
                ans = (float)Math.Log(num1);
                textResult.Text = ans.ToString();
                clear = 1;
            }
        }
        private void ButtonSecond_Click(object sender, EventArgs e)
        {
            if (ButtonLn.Text == "ln")
            {
                ButtonXSquared.Text = "x³";
                ButtonRootSquare.Text = "∛x";
                ButtonPower.Text = "ʸ√x";
                ButtonPowerOfTen.Text = "2˟";
                ButtonLog.Text = "logᵧx";
                ButtonLn.Text = "e˟";
                second = 1;
            } else if (ButtonLn.Text == "e˟") {
                
                ButtonXSquared.Text = "x²";
                ButtonRootSquare.Text = "√x";
                ButtonPower.Text = "xʸ";
                ButtonPowerOfTen.Text = "10˟";
                ButtonLog.Text = "log";
                ButtonLn.Text = "ln";
                second = 0;
            }
        }
        private void SinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textHist.Text = "sin(" + textResult.Text + ")";
            textResult.Text = Math.Sin(float.Parse(textResult.Text)*Math.PI/180).ToString();
            clear = 1;
        }
        private void CosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textHist.Text = "cos(" + textResult.Text + ")";
            textResult.Text = Math.Cos(float.Parse(textResult.Text) * Math.PI / 180).ToString();
            clear = 1;
        }
        private void TanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textHist.Text = "tan(" + textResult.Text + ")";
            textResult.Text = Math.Tan(float.Parse(textResult.Text) * Math.PI / 180).ToString();
            clear = 1;
        }
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            Compute(count);
            clear = 1;
        }
        public void Compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 + float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
                    textHist.Text = num1 + " + " + float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat) + " =";
                    textResult.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 - float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
                    textHist.Text = num1 + " - " + float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat) + " =";
                    textResult.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
                    textHist.Text = num1 + " x " + float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat) + " =";
                    textResult.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
                    textHist.Text = num1 + " ÷ " + float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat) + " =";
                    textResult.Text = ans.ToString();
                    break;
                case 5:
                    ans = num1 % float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat);
                    textHist.Text = num1 + " % " + float.Parse(textResult.Text, CultureInfo.InvariantCulture.NumberFormat) + " =";
                    textResult.Text = ans.ToString();
                    break;
                case 6:
                    if(second == 1)
                    {
                        ans = (float)Math.Pow(num1, 1/(float.Parse(textResult.Text)));
                        textHist.Text = num1 + " ^ 1/" + textResult.Text + " =";
                        textResult.Text = ans.ToString();
                    } else {
                        ans = (float)Math.Pow(num1, float.Parse(textResult.Text));
                        textHist.Text = num1 + " ^ " + textResult.Text + " =";
                        textResult.Text = ans.ToString();
                    }
                    break;
                case 7:
                    ans = Exponent(num1, float.Parse(textResult.Text));
                    textHist.Text = ans.ToString() + " =";
                    textResult.Text = ans.ToString();
                    break;
                case 8:
                    ans = (float)Math.Log(num1, float.Parse(textResult.Text));
                    textHist.Text = textHist.Text = "logᵧ" + num1 + "=";
                    textResult.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (textResult.Text != string.Empty)
            {
                int textlength = textResult.Text.Length;
                if (textlength != 1)
                {
                    textResult.Text = textResult.Text.Remove(textlength - 1);
                }
                else
                {
                    textResult.Text = 0.ToString();
                }
                zero = 1;
            }
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            textResult.Clear();
            textHist.Clear();
            count = 0;
            zero = 1;
            textResult.Text = "0";
        }
        private void ButtonComma_Click(object sender, EventArgs e)
        {
            int c = textResult.TextLength;
            int flag = 0;
            string text = textResult.Text;
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
                textResult.Text += ".";
            }
        }
    }
}