using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp2
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //First Name  Date of Birth
            //Last Name  Gender
            //Address  Contact Number
            // Country  Email ID
            MessageBox.Show("\nfirstame "+textBox1.Text+"\nlastname "+textBox2.Text+"\naddress "+textBox3.Text+"\ncountry "+textBox4.Text+"\nDate of birth "+dateTimePicker1.Value+"\nGender "+comboBox1.Text+"\nContact number "+textBox6.Text+"\nEmail ID "+textBox5.Text);
        }
    }
}
