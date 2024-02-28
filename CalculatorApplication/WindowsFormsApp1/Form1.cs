using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double resultValue = 0;
        string OperationPerformed = "";
        bool isOperationPerformed = false;


        public Form1()
        {
            InitializeComponent();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       private void button16_Click(object sender, EventArgs e)
{
    // Check if the display textbox is not empty
    if (tbDisplayResult.Text.Length > 0)
    {
        // Remove the last character
        tbDisplayResult.Text = tbDisplayResult.Text.Substring(0, tbDisplayResult.Text.Length - 1);
        
        // If the textbox becomes empty, display "0"
        if (tbDisplayResult.Text.Length == 0)
            tbDisplayResult.Text = "0";
    }
}

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Clear the display if a new number is starting or an operation was performed
            if (tbDisplayResult.Text == "0" || isOperationPerformed)
            {
                tbDisplayResult.Clear();
                isOperationPerformed = false;
            }

            // Append the clicked button's text to the display textbox
            if (button.Text == ".")
            {
                // If the textbox doesn't already contain a decimal point
                if (!tbDisplayResult.Text.Contains("."))
                    tbDisplayResult.Text += button.Text;
            }
            else
            {
                tbDisplayResult.Text += button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OperationPerformed = button.Text;
            resultValue = Double.Parse(tbDisplayResult.Text);
            lbCurrentOp.Text = resultValue + " " + OperationPerformed;
            isOperationPerformed = true;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text= "0";
            resultValue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tbDisplayResult.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(OperationPerformed == "+")
            {
                tbDisplayResult.Text = (resultValue + double.Parse(tbDisplayResult.Text)).ToString();


            }else if (OperationPerformed == "-")
            {
                tbDisplayResult.Text = (resultValue - double.Parse(tbDisplayResult.Text)).ToString();

            }
            else if(OperationPerformed == "X")
            {
                tbDisplayResult.Text = (resultValue * double.Parse(tbDisplayResult.Text)).ToString();

            }
            else
            {
                tbDisplayResult.Text = (resultValue / double.Parse(tbDisplayResult.Text)).ToString();

            }
        }
    }
    }

