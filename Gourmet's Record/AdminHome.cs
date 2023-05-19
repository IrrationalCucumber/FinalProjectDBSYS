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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void msName_Click(object sender, EventArgs e)
        {

        }

        private void accountListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            this.Close();
            userList.Show();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account_List accountList = new Account_List();
            this.Close();
            accountList.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'Verified'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
