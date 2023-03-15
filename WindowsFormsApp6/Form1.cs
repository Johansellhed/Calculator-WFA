using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1;

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = 1;
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = 2;
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = 3;
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = 4;
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = 5;
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = 6;
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = 7;
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = 8;
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            num1 = 9;
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void C_MouseClick(object sender, MouseEventArgs e)
        {
            string num1 = "";
            textBox1.Text = (num1);
        }

        private void buttondot_MouseClick(object sender, MouseEventArgs e)
        {

            string num1 = ".";
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void buttonequal_MouseClick(object sender, MouseEventArgs e)
        {
            string value = new DataTable().Compute(textBox1.Text, null).ToString();
            MessageBox.Show(value);
        }

        private void buttondivision_MouseClick(object sender, MouseEventArgs e)
        {
            string num1 = "/";
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void buttonmulti_MouseClick(object sender, MouseEventArgs e)
        {
            string num1 = "*";
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void buttonminus_MouseClick(object sender, MouseEventArgs e)
        {
            string num1 = "-";
            textBox1.Text = textBox1.Text + (num1.ToString());
        }

        private void buttonplus_MouseClick(object sender, MouseEventArgs e)
        {
            string num1 = "+";
            textBox1.Text = textBox1.Text + (num1.ToString());
        }
    }
}
