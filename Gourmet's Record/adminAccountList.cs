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
    public partial class adminAccountList : Form
    {
        SqlConnection con;
        public adminAccountList()
        {
            InitializeComponent();
        }

        private void cbVerified_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            if (cbVerified.Checked == true)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS WHERE username = '" + tbSearch.Text + "' AND accountVerification = 'verified'", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            else {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS WHERE username = '" + tbSearch.Text + "'", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void adminAccountList_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }
    }
}
