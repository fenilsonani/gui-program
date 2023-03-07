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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //like Employee
            //ID, First Name, Last Name, City, Contact No., Date of Joining and Salary using
            listView1.View = View.Details;
            listView1.GridLines= true;
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("First Name", 100);
            listView1.Columns.Add("Last Name", 100);
            listView1.Columns.Add("City", 100);
            listView1.Columns.Add("Contact No.", 100);
            listView1.Columns.Add("Date of Joining", 100);
            listView1.Columns.Add("Salary", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem i;
            string[] str = new string[7];
            str[0]=textBox1.Text;
            str[1]=textBox2.Text;
            str[2]=textBox3.Text;
            str[3]=textBox4.Text;
            str[4]=textBox5.Text;
            str[5]=dateTimePicker1.Text;
            str[6] = textBox7.Text;
            i = new ListViewItem(str);
            listView1.Items.Add(i);
        }
    }
}
