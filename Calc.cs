using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        int x, y, result;
        string btn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(btn.ToString() == "+")
            {
                y = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(x + y);
            }
            if (btn.ToString() == "-")
            {
                y = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(x - y);
            }
            if (btn.ToString() == "*")
            {
                y = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(x * y);
            }
            if (btn.ToString() == "/")
            {
                y = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(x /y);
            }
            
        }
        private void button10_Click(object sender, EventArgs e)
        {
           x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "+";
            textBox1.Clear(); 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "*";
            textBox1.Clear();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "/";
            textBox1.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            textBox1.Text = string.Empty;
            btn = "-";
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
    }
}
