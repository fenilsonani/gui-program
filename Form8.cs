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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show(radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show(radioButton3.Text);
            }
            else if (radioButton4.Checked == true)
            {
                MessageBox.Show(radioButton4.Text);
            }
            else if (radioButton5.Checked == true)
            {
                MessageBox.Show(radioButton5.Text);
            }
            else if (radioButton6.Checked == true)
            {
                MessageBox.Show(radioButton6.Text);
            }

            else if (radioButton7.Checked == true)
            {
                MessageBox.Show(radioButton7.Text);
            }
            else if (radioButton8.Checked == true)
            {
                MessageBox.Show(radioButton8.Text);
            }
            else
            {
                MessageBox.Show("You have not selected any option");
            }
        }
    }
}
