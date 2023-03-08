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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //image location F:\Dev\c#\WindowsFormsApp2\imag1.jpg
            pictureBox1.ImageLocation = "F:/Dev/c#/WindowsFormsApp2/imag1.jpg";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "F:/Dev/c#/WindowsFormsApp2/img2.jpg";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "F:/Dev/c#/WindowsFormsApp2/img3.jpg";
        }
    }
}
