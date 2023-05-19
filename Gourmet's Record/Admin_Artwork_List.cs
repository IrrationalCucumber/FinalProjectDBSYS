using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class Account_List : Form
    {
        public Account_List()
        {
            InitializeComponent();
        }
//buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHome home = new AdminHome();
            this.Close();
            home.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'Verified'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
//checkbox
        private void cbVerified_CheckedChanged(object sender, EventArgs e)
        {

        }
//radio Button
        private void tbVerify_CheckedChanged(object sender, EventArgs e)
        {

        }
//textbox
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbArtworkTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbArtist_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
//database
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
