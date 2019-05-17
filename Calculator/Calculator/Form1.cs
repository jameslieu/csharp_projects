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
    public partial class CalculatorForm : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (outputTextBox.Text == "0" || operationPressed)
            {
                outputTextBox.Clear();
            }

            operationPressed = false;
            Button button = (Button)sender;
            outputTextBox.Text = outputTextBox.Text + button.Text;

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = double.Parse(outputTextBox.Text);
            operationPressed = true;
            equation.Text = value + " " + operation;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            if (operation == "/" && (value == 0 || double.Parse(outputTextBox.Text) == 0))
            {
                MessageBox.Show("Cannot divide by 0");
            }
            else
            {
                outputTextBox.Text =  OperatorSelector.HandleEquation(operation, value, outputTextBox.Text);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = "0";
            value = 0;
        }
    }
}
