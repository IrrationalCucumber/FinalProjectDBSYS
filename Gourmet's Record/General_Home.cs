using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        }

        private void cbPriceRange2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPriceRange3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPriceRange4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPriceRange5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPriceRange6_CheckedChanged(object sender, EventArgs e)
        {

        }

 
//buttons

//filter
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
//combobox
        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void General_Home_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection("");
            //con.Open();
            con = new SqlConnection("Data Source=DESKTOP-01\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            con.Open();

            if (SignIn.isBuyer == true || SignIn.isArtist == true)
            {
                msName.Text = SignIn.accountName;
            }
            else {
                msName.Text = "Sign In";
                this.Close();
                th = new Thread(gotoProfile);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void accountListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (SignIn.isBuyer != true || SignIn.isArtist != true)
            {
                miProfile.Visible = false;
            }
            else {
                this.Close();
                th = new Thread(gotoProfile);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void miSO_Click(object sender, EventArgs e)
        {
            if (SignIn.isBuyer != true || SignIn.isArtist != true)
            {
                miSO.Visible = false;
            }
            else
            {
                this.Close();
                th = new Thread(gotoProfile);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
    }
}
