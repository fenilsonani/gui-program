//Write a C# code to calculate the division of two numbers using try_catch statement. When the//
//user enters a non-numeric values into the textboxes, the error message must be display "One of
//the entries is not a number! Try again!”. If no error occurs, it will display the correct answer.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double result = (num1 / num2);
                label2.Text = result.ToString();
            }catch(Exception ex)
            {
                label2.Text =ex.Message;
            }
        }
    }
}
