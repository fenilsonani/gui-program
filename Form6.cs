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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox1.Text);
            string grade;
            if (num > 75)
            {
                grade = "Distinction";
            }else if (num > 60)
            {
                grade = "First";
            }else if (num > 35)
            {
                grade = "Second";
            }
            else
            {
                grade = "Fail";
            }
            label1.Text = "Categorey : " + grade;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            
        }
    }
}
