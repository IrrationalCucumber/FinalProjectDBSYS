using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class AdminHome : Form
    {
        SqlConnection cn;
        Thread th;
        public static int artID;
        public AdminHome()
        {
            InitializeComponent();
        }
        public void gotoArtList(object obj)
        {
            Application.Run(new adminArtworkList());
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem.Equals("Artist"))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE username = '" + tbSearch.Text + "' AND artVerified = 'Verified'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            else
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'Verified'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            // con = new SqlConnection("Data Source=DESKTOP-01\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            cn = new SqlConnection("Data Source=LAPTOP-I525U4NK\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            //con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            cn.Open();
            msName.Text = SignIn.accountName;

            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artVerified = 'verified'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artVerified='verified' AND artAvailable = 'Available'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void cbPriceRange1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange2.Checked == false && cbPriceRange3.Checked == false && cbPriceRange4.Checked == false && cbPriceRange5.Checked == false && cbPriceRange6.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (0,200)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                cbPriceRange2.Checked = false;
                cbPriceRange3.Checked = false;
                cbPriceRange4.Checked = false;
                cbPriceRange5.Checked = false;
                cbPriceRange6.Checked = false;
                cbPriceRange1.Checked = true;
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (0,200)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbPriceRange2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange1.Checked == false && cbPriceRange3.Checked == false && cbPriceRange4.Checked == false && cbPriceRange5.Checked == false && cbPriceRange6.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (200,400)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                cbPriceRange2.Checked = true;
                cbPriceRange1.Checked = false;
                cbPriceRange3.Checked = false;
                cbPriceRange4.Checked = false;
                cbPriceRange5.Checked = false;
                cbPriceRange6.Checked = false;
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (200,400)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbPriceRange3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange1.Checked == false && cbPriceRange2.Checked == false && cbPriceRange4.Checked == false && cbPriceRange5.Checked == false && cbPriceRange6.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (400,600)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                cbPriceRange3.Checked = true;
                cbPriceRange2.Checked = false;
                cbPriceRange1.Checked = false;
                cbPriceRange4.Checked = false;
                cbPriceRange5.Checked = false;
                cbPriceRange6.Checked = false;
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (400,600)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbPriceRange4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange1.Checked == false && cbPriceRange2.Checked == false && cbPriceRange3.Checked == false && cbPriceRange5.Checked == false && cbPriceRange6.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (600,800)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                cbPriceRange4.Checked = true;
                cbPriceRange2.Checked = false;
                cbPriceRange3.Checked = false;
                cbPriceRange1.Checked = false;
                cbPriceRange5.Checked = false;
                cbPriceRange6.Checked = false;
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (600,800)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbPriceRange5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange1.Checked == false && cbPriceRange2.Checked == false && cbPriceRange3.Checked == false && cbPriceRange4.Checked == false && cbPriceRange6.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (800,1000)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                cbPriceRange5.Checked = true;
                cbPriceRange2.Checked = false;
                cbPriceRange3.Checked = false;
                cbPriceRange4.Checked = false;
                cbPriceRange1.Checked = false;
                cbPriceRange6.Checked = false;
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (800,1000)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbPriceRange6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange1.Checked == false && cbPriceRange2.Checked == false && cbPriceRange3.Checked == false && cbPriceRange4.Checked == false && cbPriceRange5.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (1000,99999999)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                cbPriceRange6.Checked = true;
                cbPriceRange2.Checked = false;
                cbPriceRange3.Checked = false;
                cbPriceRange4.Checked = false;
                cbPriceRange5.Checked = false;
                cbPriceRange1.Checked = false;
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (1000,99999999)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artType = '" + cbFilter.SelectedItem.ToString() + "' AND artVerification = 'verified'", cn);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            //dataGridView1.DataSource = dtbl;
        }

        private void mToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            th = new Thread(gotoArtList);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void accountListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
