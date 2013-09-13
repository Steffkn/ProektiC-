using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }


        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!labelScreen.Text.Contains("."))
            {
                labelScreen.Text += ".";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "0";
        }


        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btn0_Click(sender, e);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btn1_Click(sender, e);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btn2_Click(sender, e);
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    MessageBox.Show("3");
                    btn3_Click(sender, e);
                    break;

                case Keys.D4:
                case Keys.NumPad4:
                    btn4_Click(sender, e);
                    break;

                case Keys.D5:
                case Keys.NumPad5:
                    btn5_Click(sender, e);
                    break;

                case Keys.D6:
                case Keys.NumPad6:
                    btn6_Click(sender, e);
                    break;

                case Keys.D7:
                case Keys.NumPad7:
                    btn7_Click(sender, e);
                    break;

                case Keys.D8:
                case Keys.NumPad8:
                    btn8_Click(sender, e);
                    break;

                case Keys.D9:
                case Keys.NumPad9:
                    btn9_Click(sender, e);
                    break;
            }

            e.Handled = false;
        }


        // make the background gradient
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                            Color.FromArgb(237, 244, 252),
                                                                            Color.FromArgb(217, 228, 241),
                                                                            90F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            labelScreen.Text = SolveMathExpression.Calculate(labelScreen.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "*";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "/";
        }

        private void btnMC_Click(object sender, EventArgs e)
        {

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            labelScreen.Text = string.Format("sqrt({0})",labelScreen.Text);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            labelScreen.Text = "";
        }

        private void btnReciprochno_Click(object sender, EventArgs e)
        {
            labelScreen.Text = string.Format("1/({0})", labelScreen.Text);
        }


    }
}
