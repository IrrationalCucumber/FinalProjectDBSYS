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
    public partial class adminArtowrkList : Form
    {
        SqlConnection con;
        public adminArtowrkList()
        {
            InitializeComponent();
        }

        private void adminArtowrkList_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORK", con);
            DataTable dtbl = new DataTable();
            sqlData.Fill(dtbl);

            dataGridView1.DataSource = dtbl;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (cbVerified.Checked == true)
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORK WHERE artTitle = '" + tbSearch.Text + "' AND artVerification = 'verified'", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
            else
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from ARTWORKS WHERE artTitle = '" + tbSearch.Text + "'", con);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
            }
        }
    }
}
