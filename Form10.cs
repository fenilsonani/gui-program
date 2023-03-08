using System.Windows.Forms;

//Write a C# code for the form, when the user click on ADD button, a list item should be moved
//from the first ListBox to the second ListBox. When the user click on REMOVE button, the list
//item should again move back to the original List. Design an interface for this form.

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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Item1");
            listBox1.Items.Add("Item2");
            listBox1.Items.Add("Item3");
            listBox1.Items.Add("Item4");
            listBox1.Items.Add("Item5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //all listbox1 items to listbox2
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }
    }
}
