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
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        float a, b;
        private void GraphForm_Load(object sender, EventArgs e)
        {
            if (Calculator.SetValueForA != "")
            {
                b = float.Parse(Calculator.SetValueForA);
            }
            if (Calculator.SetValueForB != "")
            {
                if (Calculator.minus == 1)
                {
                    b = -(float.Parse(Calculator.SetValueForB));
                } else {
                    b = float.Parse(Calculator.SetValueForB);
                }
            }
        }
        private void GraphForm_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics G = this.CreateGraphics())
            {
                using (Pen blackpen = new Pen(Color.Black))
                {
                    Point verticalStartPoint = new Point(200, 0);
                    Point verticalEndPoint = new Point(200, 300);
                    Point horizontalStartPoint = new Point(0, 150);
                    Point horizontalEndPoint = new Point(400, 150);
                    G.DrawLine(blackpen, verticalStartPoint, verticalEndPoint);
                    G.DrawLine(blackpen, horizontalStartPoint, horizontalEndPoint);
                }
                using (Pen redpen = new Pen(Color.Red))
                {
                    if (Calculator.SetValueForB != "" && Calculator.SetValueForA != "")
                    {
                        a = float.Parse(Calculator.SetValueForA);
                        b = float.Parse(Calculator.SetValueForB);
                        if(Calculator.minus == 1)
                        {
                            EquationLabel.Text = a + "X-" + b;
                            Point lineStartPoint = new Point((int)(200 - ((150 - b) / a)), 300);
                            Point lineEndPoint = new Point((int)(200 + ((150 + b) / a)), 0);
                            G.DrawLine(redpen, lineStartPoint, lineEndPoint);
                        } else {
                            EquationLabel.Text = a + "X+" + b;
                            Point lineStartPoint = new Point((int)(200 - ((150 + b) / a)), 300);
                            Point lineEndPoint = new Point((int)(200 + ((150 - b) / a)), 0);
                            G.DrawLine(redpen, lineStartPoint, lineEndPoint);
                        }
                    }
                }
            }
        }
    }
}
