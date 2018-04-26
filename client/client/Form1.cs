using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void cmdregister_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();


            if (chkadmin.CheckState == CheckState.Unchecked)
            {
                server.registeruser(txtusername.Text, txtpassword.Text);
                if (string.IsNullOrWhiteSpace(txtusername.Text) && string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Empty");
                }
                else
                {

                    MessageBox.Show("Registered As User");

                }
            }
            else
            {
                server.registeradmin(txtusername.Text, txtpassword.Text);
                if (string.IsNullOrWhiteSpace(txtusername.Text) && string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Empty");
                }
                else
                {
                    
                        MessageBox.Show("Registered as admin");
                     
                }
            }
           
        }

        private void lbllogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void chkadmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
