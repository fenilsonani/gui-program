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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("C++");
            listBox1.Items.Add("C#");
            listBox1.Items.Add("Java");
            listBox1.Items.Add("Python");
            listBox1.Items.Add("PHP");
        }
    }
}
