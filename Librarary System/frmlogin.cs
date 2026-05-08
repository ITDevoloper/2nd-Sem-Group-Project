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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lnklblId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 registerForm = new Form2();
            registerForm.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // get what user typed
            string user = textBox1.Text;
            string pass = textBox2.Text;

            // check if empty
            if (user == "" && pass == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            if (user == "")
            {
                MessageBox.Show("Please enter username.");
                return;
            }

            if (pass == "")
            {
                MessageBox.Show("Please enter password.");
                return;
            }
        }
    }
}
