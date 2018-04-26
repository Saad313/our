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
    public partial class AddPost : Form
    {
        public AddPost()
        {
            InitializeComponent();
        }

        private void txtposttitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdaddpost_Click(object sender, EventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            //server.addpost(txtposttitle.Text , txtpostcategory.Text ,txtpostdescription.Text);
            localhost.Post po = new localhost.Post();

            po.Title = txtposttitle.Text;
            po.Category = txtpostcategory.Text;
            po.Description = txtpostdescription.Text;
            server.postingthepost(po);
            if (string.IsNullOrWhiteSpace(txtposttitle.Text) && string.IsNullOrWhiteSpace(txtpostcategory.Text) && string.IsNullOrWhiteSpace(txtpostdescription.Text))
            {
                MessageBox.Show("Empty");
            }
            else
            {
                MessageBox.Show("Posted Succesfully Now Wait For Approval");
                
            }
            txtposttitle.Text = "";
            txtpostcategory.Text = "";
            txtpostdescription.Text = "";
        }

        private void AddPost_Load(object sender, EventArgs e)
        {
       
            
        }

        private void lblapprovelrequest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminApproval adminapproval = new AdminApproval();
            this.Hide();
            adminapproval.Show();
        }
    }
}
