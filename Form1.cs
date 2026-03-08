using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MODUL3_103022400076
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private bool isOperatorPressed = false;
        private bool newInput = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void AppendNumber(string number)
        {
            if (newInput)
            {
                label1.Text = number;
                newInput = false;
            }
            else
            {
                if (label1.Text == "0")
                    label1.Text = number;
                else
                    label1.Text += number;
            }
        }

        private void PressPlus()
        {
            if (isOperatorPressed && !newInput)
            {
                double currentNumber = double.Parse(label1.Text);
                firstNumber = firstNumber + currentNumber;
                label1.Text = firstNumber.ToString();
            }
            else
            {
                firstNumber = double.Parse(label1.Text);
            }
            isOperatorPressed = true;
            newInput = true;
        }

        private void PressEquals()
        {
            if (isOperatorPressed)
            {
                double secondNumber = double.Parse(label1.Text);
                double result = firstNumber + secondNumber;
                if (result == Math.Floor(result))
                    label1.Text = ((long)result).ToString();
                else
                    label1.Text = result.ToString();
                firstNumber = result;
                isOperatorPressed = false;
                newInput = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PressPlus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PressEquals();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}