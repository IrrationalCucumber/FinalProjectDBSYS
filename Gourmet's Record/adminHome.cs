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
    public partial class adminHome : Form
    {
        SqlConnection cn;
        public adminHome()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            msName.Text = SignIn.AccountName;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btAccounts_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void comboBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
           
        }

        private void accountListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            adminAccountList al = new adminAccountList();
            al.Show();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            adminArtowrkList at = new adminArtowrkList();
            at.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem.ToString() == "Artist")
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE username = '" + tbSearch.Text + "' AND artVerification = 'verified'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
            else
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
            else {
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
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'" +
                    "AND artPrice IN (1000,99999999)" +
                    "ORDER BY artPrice ASC", cn);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                //dataGridView1.DataSource = dtbl;
            }
        }
    }
}
