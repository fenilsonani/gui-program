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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1 == null)
            {
                MessageBox.Show("Please select a file");
                return;
            }
            else
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if (fontDialog1 == null)
            {
                MessageBox.Show("Please select a font");
                return;
            }
            else
            {
                label2.Font = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1 == null)
            {
                MessageBox.Show("please select any color");
                return;
            }
            else
            {
                label2.ForeColor = colorDialog1.Color;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = richTextBox1.Text;
        }
    }
}
