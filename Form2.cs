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
    public partial class Form2 : Form
    {
        int count = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 == null)
            {
                MessageBox.Show("Please enter a name");
                return;
            }
            else
            {
                treeView1.Nodes.Add(textBox1.Text);
                count++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2 == null)
            {
                MessageBox.Show("Please enter a name");
                return;
            }
            else
            {
                treeView1.SelectedNode.Nodes.Add(textBox2.Text);
                count++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            count = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
            count--;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label8.Text = treeView1.SelectedNode.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(count.ToString());
        }
    }
}
