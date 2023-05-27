using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class adminArtworkList : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public adminArtworkList()
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'unverified'", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else if (cbVerified.Checked == true && tbSearch.Text == string.Empty)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artVerified = 'unverified'", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "'", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            //dataGridView1.DataSource = dtbl;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(tbID.Text);
            string title = tbArtworkTitle.Text;
            string artist = TbArtist.Text;
            string verify = "";
            if (tbVerify.Checked == true)
            {
                verify = "verified";
            }
            else {
                verify = "unverified";
            }

            cmd = new SqlCommand("UPDATE ARTWORKS " +
                "SET artVerified = '" + verify + "' " +
                "WHERE artID = '" + ID + "' AND artTitle = '" + title + "' AND username ='" + artist + "'", con);
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'unverified'AND dateAdded = @date", con);
                sqlData.SelectCommand.Parameters.AddWithValue("@date", date); // use a parameterized query to avoid SQL injection
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            else if (cbVerified.Checked == false && tbSearch.Text != string.Empty) //verify is uncheck and searchbar is not empty
            {
                string date = dtp.Value.ToString("yyyy-MM-dd"); // format the date value as yyyy-MM-dd
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND dateAdded = @date", con);
                sqlData.SelectCommand.Parameters.AddWithValue("@date", date); // use a parameterized query to avoid SQL injection
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            else if (cbVerified.Checked == true && tbSearch.Text == string.Empty)
            {
                string date = dtp.Value.ToString("yyyy-MM-dd"); // format the date value as yyyy-MM-dd
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE AND artVerified = 'unverified'AND dateAdded = @date", con);
                sqlData.SelectCommand.Parameters.AddWithValue("@date", date); // use a parameterized query to avoid SQL injection
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            else
            {
                string date = dtp.Value.ToString("yyyy-MM-dd"); // format the date value as yyyy-MM-dd
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE dateAdded = @date", con);
                sqlData.SelectCommand.Parameters.AddWithValue("@date", date); // use a parameterized query to avoid SQL injection
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void Account_List_Load(object sender, EventArgs e)
        {
            // con = new SqlConnection("Data Source=DESKTOP-01\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            con = new SqlConnection("Data Source=LAPTOP-I525U4NK\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            //con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            con.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }
    }
}
