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
    public partial class Artist_personal_gallery : Form
    {
        SqlConnection con;
        public static int artID;
        public Artist_personal_gallery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            General_Home home = new General_Home();
            this.Close();
            home.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            this.Close();
            profile.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Close();
            signIn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_Transaction_list user_Transaction_List = new User_Transaction_list();
            this.Close();
            user_Transaction_List.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Artist_Upload_Artwork artist_Upload_Artwork = new Artist_Upload_Artwork();
            this.Close();
            artist_Upload_Artwork.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Artist_personal_gallery_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
        }
    }
}
