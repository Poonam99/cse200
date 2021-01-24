using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           Console.WriteLine("hellow world");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = (firstNumber * secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = (firstNumber + secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = (firstNumber - secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void Div_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = (firstNumber/ secondNumber);
            resultTextBox.Text = result.ToString();
        }
    }
}
