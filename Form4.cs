//question bank 3 

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            //code for factorial
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            label3.Text = fact.ToString();
        }
    }
}
