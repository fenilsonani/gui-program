using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Write a C# code to check whether the number is Palindrome or not without using string reverse operation.
            int num = Convert.ToInt32(textBox1.Text);
            int temp = num;
            int rev = 0;
            if (num > 0)
            {
                while (num > 0)
                {
                    int rem = num % 10;
                    rev = rev * 10 + rem;
                    num = num / 10;
                }
                if (temp == rev)
                {
                    label2.Text=("Palindrome");
                }
                else
                {
                    label2.Text = ("Not Palindrome");
                }
            }
            else
            {
                label2.Text = ("Enter a positive number");
            }
        }
    }
}
