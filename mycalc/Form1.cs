using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        double a = 0, b = 0, c = 0;
        char znak = '+';

        public double getc()
        {
            return c;
        }

        public double geta()
        {
            return a;
        }

        public void seta(double value)
        {
            a = value;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);

            c = perform_Operation(znak, a, b);
            
            textBox1.Text = c.ToString();
        }

        public double perform_Operation(char znak, double a, double b)
        {
            double c = 0;
            switch (znak)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '×':
                    c = a * b;
                    break;
                case '÷':
                    c = a / b;
                    break;
            }
            return c;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "-");
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else textBox1.Text = '-' + textBox1.Text;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "");
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }
    }
}
