using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librarary_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new Form1();
            registerForm.Show();
            this.Hide();

            // get what user typed
            string name = textBox3.Text;   // Full Name
            string user = textBox1.Text;   // Username or ID
            string phone = textBox2.Text;   // Phone Number
            string pass = textBox4.Text;   // Password
            string confirm = textBox5.Text;   // Confirm Password
           
        }
    }
}
