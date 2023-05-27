using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class UserList : Form
    {
        SqlConnection cn;
        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"");
            cn.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            //dataGridView1.DataSource = dtbl;
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

            //dataGridView1.DataSource = dtbl;
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            if (cbVerified.Checked == true)
            {
                //string date = dtp.Value.ToString("yyyy-MM-dd");
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS WHERE username = '" + tbSearch.Text + "' AND accountVerified = 'verified'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS WHERE username = '" + tbSearch.Text + "'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }

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
            if (cbVerified.Checked == true)
            {
                string date = dtp.Value.ToString("yyyy-MM-dd"); // format the date value as yyyy-MM-dd
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS WHERE username = '" + tbSearch.Text + "' AND accountVerified = 'verified'AND dateAdded = @date", cn);
                sqlData.SelectCommand.Parameters.AddWithValue("@date", date); // use a parameterized query to avoid SQL injection
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                string date = dtp.Value.ToString("yyyy-MM-dd"); // format the date value as yyyy-MM-dd
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ACCOUNTS WHERE username = '" + tbSearch.Text + "' AND accountVerified = 'verified'AND dateAdded = @date", cn);
                sqlData.SelectCommand.Parameters.AddWithValue("@date", date); // use a parameterized query to avoid SQL injection
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }
        //datagrid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
