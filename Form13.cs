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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            //Write a C# code to get the sum of N numbers. If N value crosses the limit (100000), then
            //exception must occur.Display the proper error message for the exception.
            //how to throw exception for n>100000
            // answer  :- 
            
         }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                int n = Convert.ToInt32(textBox1.Text);
                if (n > 100000)
                {
                    throw new Exception("Number is greater than 100000");
                }
                else
                {
                    for (int i = 0; i <= n; i++)
                    {
                        sum = sum + i;
                    }
                }
                label1.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }

        }
    }
}
