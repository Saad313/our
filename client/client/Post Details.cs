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
    public partial class Post_Details : Form
    {
        public Post_Details()
        {
            InitializeComponent();
        }

        private void Post_Details_Load(object sender, EventArgs e)
        {
            localhost.Post p = new localhost.Post();
            
        }
    }
}
