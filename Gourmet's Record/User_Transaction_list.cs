using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class User_Transaction_list : Form
    {
        public User_Transaction_list()
        {
            InitializeComponent();
        }
//buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            General_Home home = new General_Home();
            this.Close();
            home.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
//display image 
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
