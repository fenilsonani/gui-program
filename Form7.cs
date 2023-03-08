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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random= new Random();
            int[] randomList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int num1 = random.Next(0, 9);
            int finalNum= randomList[num1];
            label1.Text ="Random"+ finalNum.ToString();
            if (finalNum == 9)
            {
                pictureBox1.ImageLocation = null;
                //place image location
                //pictureBox1.ImageLocation = "C:\Users\user\source\repos\WindowsFormsApp2\WindowsFormsApp2\bin\Debug\9.jpg";
            }
            else
            {
                pictureBox1.ImageLocation = null;
            }
        }
    }
}
