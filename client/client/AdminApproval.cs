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
    public partial class AdminApproval : Form
    {
        public AdminApproval()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 server = new localhost.Service1();
            bool postidspecified = true;
            if (e.ColumnIndex == 0)
            {
                localhost.Post post = server.getpost(e.RowIndex , postidspecified);
                Post_Details pd = new Post_Details();
                
                pd.Show();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void AdminApproval_Load(object sender, EventArgs e)
        {
            showPosts();
        }

        public void showPosts()
        {
            localhost.Service1 server = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = server.getpostlist();
            dataGridView1.DataSource = bs;

           // dataGridView1.Columns[2].Visible = false;
        }
    }
}
