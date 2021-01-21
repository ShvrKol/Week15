using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_Week_15
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        string input = string.Empty;
        string calc = string.Empty;
        string calc2 = string.Empty;
        char calculation;
        string calculation2;
        double result = 0.0;

        private void number1_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += "1";
            this.textboxcenter.Text += input;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += "2";
            this.textboxcenter.Text += input;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += "3";
            this.textboxcenter.Text += input;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += "4";
            this.textboxcenter.Text += input;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += "5";
            this.textboxcenter.Text += input;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += "6";
            this.textboxcenter.Text += input;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += "7";
            this.textboxcenter.Text += input;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += "8";
            this.textboxcenter.Text += input;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += "9";
            this.textboxcenter.Text += input;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += "0";
            this.textboxcenter.Text += input;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            calc = input;
            calculation = '+';
            input = String.Empty;
            Button btn = (Button)sender;
            string btntext = btn.Text;
            textBoxhist.Text = string.Format("{0} {1}", textboxcenter.Text, btntext);
            textboxcenter.Text = "";
        }

        private void buttonmin_Click(object sender, EventArgs e)
        {
            calc = input;
            calculation = '-';
            input = String.Empty;
            Button btn = (Button)sender;
            string btntext = btn.Text;
            textBoxhist.Text = string.Format("{0} {1}", textboxcenter.Text, btntext);
            textboxcenter.Text = "";
        }

        private void buttontms_Click(object sender, EventArgs e)
        {
            calc = input;
            calculation = '*';
            input = String.Empty;
            Button btn = (Button)sender;
            string btntext = btn.Text;
            textBoxhist.Text = string.Format("{0} {1}", textboxcenter.Text, btntext);
            textboxcenter.Text = "";
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            calc = input;
            calculation = '/';
            input = String.Empty;
            Button btn = (Button)sender;
            string btntext = btn.Text;
            textBoxhist.Text = string.Format("{0} {1}", textboxcenter.Text, btntext);
            textboxcenter.Text = "";
        }

        private void buttonplsmin_Click(object sender, EventArgs e)
        {
            calc = input;
            calculation = '±';
            input = String.Empty;
            Button btn = (Button)sender;
            string btntext = btn.Text;
            textBoxhist.Text = string.Format("{0} {1}", textboxcenter.Text, btntext);
            textboxcenter.Text = "";
        }

        private void buttonsqr_Click(object sender, EventArgs e)
        {
            calc = input;
            calculation = '√';
            input = String.Empty;
            Button btn = (Button)sender;
            string btntext = btn.Text;
            textBoxhist.Text = string.Format("{0} {1}", textboxcenter.Text, btntext);
            textboxcenter.Text = "";
        }

        private void buttonperc_Click(object sender, EventArgs e)
        {
            calc = input;
            calculation = '%';
            input = String.Empty;
            Button btn = (Button)sender;
            string btntext = btn.Text;
            textBoxhist.Text = string.Format("{0} {1}", textboxcenter.Text, btntext);
            textboxcenter.Text = "";
        }

        private void buttononeper_Click(object sender, EventArgs e)
        {
            calc = input;
            calculation2 = "1/";
            input = String.Empty;
            Button btn = (Button)sender;
            string btntext = btn.Text;
            textBoxhist.Text = string.Format("{0} {1}", textboxcenter.Text, btntext);
            textboxcenter.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textboxcenter.Text = "0";
        }

        private void textboxcenter_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttoneq_Click(object sender, EventArgs e)
        {
            calc2 = input;
            double num1, num2;
            double.TryParse(calc, out num1);
            double.TryParse(calc2, out num2);
            if (calculation == '+')
            {
                result = num1 + num2;
                textboxcenter.Text = result.ToString();
            }
            else if (calculation == '-')
            {
                result = num1 - num2;
                textboxcenter.Text = result.ToString();
            }
            else if (calculation == '*')
            {
                result = num1 * num2;
                textboxcenter.Text = result.ToString();
            }
            else if (calculation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textboxcenter.Text = result.ToString();
                }
                else
                {
                    textboxcenter.Text = "0";
                }
            }
            else if (calculation == '%')
            {
                result = num1/100;
                textboxcenter.Text = result.ToString();
            }

        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            this.textboxcenter.Text = "";
            input += ".";
            this.textboxcenter.Text += input;
        }
    }
}
