using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class General_Home : Form
    {
        Thread th;
        SqlConnection con;
        SqlCommand cmd;
        public General_Home()
        {
            InitializeComponent();
        }
        public static int artID;

        public void gotoProfile(object obj)
        {
            Application.Run(new UserProfile());
        }

        public void gotoSignIn(object obj)
        {
            Application.Run(new SignIn());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //filter price
        private void cbPriceRange1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange2.Checked == false && cbPriceRange3.Checked == false && cbPriceRange4.Checked == false && cbPriceRange5.Checked == false && cbPriceRange6.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (0,200)" +
                    "ORDER BY artPrice ASC", con);
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (0,200)" +
                    "ORDER BY artPrice ASC", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbPriceRange2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange1.Checked == false && cbPriceRange3.Checked == false && cbPriceRange4.Checked == false && cbPriceRange5.Checked == false && cbPriceRange6.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (200,400)" +
                    "ORDER BY artPrice ASC", con);
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (200,400)" +
                    "ORDER BY artPrice ASC", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbPriceRange3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange1.Checked == false && cbPriceRange2.Checked == false && cbPriceRange4.Checked == false && cbPriceRange5.Checked == false && cbPriceRange6.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (400,600)" +
                    "ORDER BY artPrice ASC", con);
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (400,600)" +
                    "ORDER BY artPrice ASC", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbPriceRange4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange1.Checked == false && cbPriceRange2.Checked == false && cbPriceRange3.Checked == false && cbPriceRange5.Checked == false && cbPriceRange6.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (600,800)" +
                    "ORDER BY artPrice ASC", con);
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (600,800)" +
                    "ORDER BY artPrice ASC", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbPriceRange5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange1.Checked == false && cbPriceRange2.Checked == false && cbPriceRange3.Checked == false && cbPriceRange4.Checked == false && cbPriceRange6.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (800,1000)" +
                    "ORDER BY artPrice ASC", con);
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (800,1000)" +
                    "ORDER BY artPrice ASC", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void cbPriceRange6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPriceRange1.Checked == false && cbPriceRange2.Checked == false && cbPriceRange3.Checked == false && cbPriceRange4.Checked == false && cbPriceRange5.Checked == false)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (1000,99999999)" +
                    "ORDER BY artPrice ASC", con);
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerified = 'verified'" +
                    "AND artPrice IN (1000,99999999)" +
                    "ORDER BY artPrice ASC", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }


        //buttons

        //filter
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //combobox
        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' OR artVerified = 'verified' AND artType = '" + cbStyle.SelectedItem.ToString() + "'", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void General_Home_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            con = new SqlConnection("Data Source=LAPTOP-I525U4NK\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            //con = new SqlConnection("Data Source=DESKTOP-01\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            con.Open();

            //display all verified artworks
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artVerified = 'verified'", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            //dataGridView1.DataSource = dtbl;

            if (SignIn.isBuyer == true || SignIn.isArtist == true)
            {
                msName.Text = SignIn.accountName;

            }
            else
            {
                msName.Text = "Sign In";
                this.Close();
                th = new Thread(gotoProfile);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            if (SignIn.isBuyer == true)
            { btUpload.Visible = false; }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void accountListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(gotoProfile);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void miSO_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(gotoProfile);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            Artist_Upload_Artwork upload = new Artist_Upload_Artwork(); ;
            upload.Show();
        }
    }
}
