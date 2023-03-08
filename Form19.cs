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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Fenil Sonani"); 
            listBox1.Items.Add("Priyank Sutariya");
            listBox1.Items.Add("Kushal Pipliya");
            listBox1.Items.Add("jay Raval");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code that will remove selected item from listbox
           //code that will show promp you want to delete this item if yes then delete else not delete
           //prompt code
            Boolean answer= MessageBox.Show("Do you want to delete this item", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK;
            if (answer)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Items Is not Removed");
            }
           
        }
    }
}
