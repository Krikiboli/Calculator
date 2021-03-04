using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public bool flag;
        public string act;
        public string left;
        public double deg;
        public string memory;
        public Form1()
        {
            memory = "0";
            flag = false;
            InitializeComponent();
            button_mr.Enabled = false;
            button_mc.Enabled = false;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Text = "0";
            }
            Button key = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = key.Text;
            else
                textBox1.Text = textBox1.Text + key.Text;
        }

        private void button_act(object sender, EventArgs e)
        {
            Button key = (Button)sender;
            act = key.Text;
            left = textBox1.Text;
            flag = true;
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            double num1, num2, res;
            res = 0;
            num1 = Convert.ToDouble(left);
            num2 = Convert.ToDouble(textBox1.Text);
            if (act == "+")
            {
                res = num1 + num2;
            }
            if (act == "-")
            {
                res = num1 - num2;
            }
            if (act == "X")
            {
                res = num1 * num2;
            }
            if (act == "/")
            {
                res = num1 / num2;
            }
            if (act == "deg")
            {
                res = Math.Pow(num1, num2);
            }
            if (act == "sqrt")
            {
                res = Math.Pow(num1, 1/num2);
            }
            act = "=";
            flag = true;
            textBox1.Text = res.ToString();           

        }

        private void button_deg_Click(object sender, EventArgs e)
        {
            act = "deg";
            left = textBox1.Text;
            flag = true;

        }

        private void button_znak_Click(object sender, EventArgs e)
        {
            double num1, res;
            num1 = Convert.ToDouble(textBox1.Text);
            res = -num1;
            textBox1.Text = res.ToString();
        }

        private void button_float_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button_sqr_Click(object sender, EventArgs e)
        {
            act = "sqrt";
            left = textBox1.Text;
            flag = true;
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length;
            if (length != 0)
            { 
                textBox1.Text = textBox1.Text.Remove(length - 1);
                if (length == 1)
                {
                    textBox1.Text = "0";
                }
            }
                
            
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            left = "0";
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button_MS_Click(object sender, EventArgs e)
        {
            memory = textBox1.Text;
            button_mr.Enabled = true;
            button_mc.Enabled = true;
        }

        private void button_mr_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory;
        }

        private void button_mc_Click(object sender, EventArgs e)
        {
            memory = "0";
            button_mr.Enabled = false;
            button_mc.Enabled = false;
        }
    }
}
