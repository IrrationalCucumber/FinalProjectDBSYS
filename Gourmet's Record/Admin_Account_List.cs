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
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHome home = new AdminHome();
            this.Close();
            home.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'Verified'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbType_TextChanged(object sender, EventArgs e)
        {

        }
//verify
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbVerified_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
//datagrid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
