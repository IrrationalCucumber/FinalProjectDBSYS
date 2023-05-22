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
        SqlConnection cn;
        SqlCommand cmd;
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
            if (cbVerified.Checked == true)
            {
                //string date = dtp.Value.ToString("yyyy-MM-dd");
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else if (cbVerified.Checked == true && tbSearch.Text == string.Empty)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artVerified = 'verified'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            //dataGridView1.DataSource = dtbl;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(tbID.Text);
            string title = tbArtworkTitle.Text;
            string artist = TbArtist.Text;

            cmd = new SqlCommand("UPDATE ARTWORKS" +
                "SET artVerified = 'verified'" +
                "WHERE artID = '" + ID + "' AND artTitle = '" + title + "' AND username ='" + artist + "'", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Artwork verified", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void TbArtist_TextChanged(object sender, EventArgs e)
        {

        }
//database
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cbVerified.Checked == true && tbSearch.Text != string.Empty) //if search bar is not empty and verify is checked
            {
                string date = dtp.Value.ToString("yyyy-MM-dd"); // format the date value as yyyy-MM-dd
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'AND dateAdded = @date", cn);
                sqlData.SelectCommand.Parameters.AddWithValue("@date", date); // use a parameterized query to avoid SQL injection
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else if (cbVerified.Checked == false && tbSearch.Text != string.Empty) //verify is uncheck and searchbar is not empty
            {
                string date = dtp.Value.ToString("yyyy-MM-dd"); // format the date value as yyyy-MM-dd
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND dateAdded = @date", cn);
                sqlData.SelectCommand.Parameters.AddWithValue("@date", date); // use a parameterized query to avoid SQL injection
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else if (cbVerified.Checked == true && tbSearch.Text == string.Empty)
            {
                string date = dtp.Value.ToString("yyyy-MM-dd"); // format the date value as yyyy-MM-dd
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE AND artVerified = 'verified'AND dateAdded = @date", cn);
                sqlData.SelectCommand.Parameters.AddWithValue("@date", date); // use a parameterized query to avoid SQL injection
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else {
                string date = dtp.Value.ToString("yyyy-MM-dd"); // format the date value as yyyy-MM-dd
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE dateAdded = @date", cn);
                sqlData.SelectCommand.Parameters.AddWithValue("@date", date); // use a parameterized query to avoid SQL injection
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void Account_List_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("");
            cn.Open();
        }
    }
}
