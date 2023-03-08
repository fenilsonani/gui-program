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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int daynum = Convert.ToInt32(textBox1.Text);
            switch (daynum)
            {
                case 1:
                    label1.Text = "Monday";
                    break;
                case 2:
                    label1.Text = "TuesDay";
                    break;
                case 3:
                    label1.Text = "WednesDay";
                    break;
                case 4:
                    label1.Text = "ThrusDay";
                    break;
                case 5:
                    label1.Text = "Friday";
                    break;
                case 6:
                    label1.Text = "Sunday";
                    break;
                case 7:
                    label1.Text = "WednesDay";
                    break;
                default:
                    label1.Text = "Invalid Number Select Between 1 to 7";
                    break;

            }
        }
    }
}
