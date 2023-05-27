using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class UpdateArtwork : Form
    {
        byte[] imageData;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con;
        public int id;
        public UpdateArtwork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            General_Home home = new General_Home();
            this.Close();
            home.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbArtTitle.Text != string.Empty || tbDescription.Text != string.Empty || tbLength.Text != string.Empty || tbPrice.Text != string.Empty || tbWidth.Text != string.Empty)
            {
                //   cmd = new SqlCommand("select * from ARTWORK where art='" + tbBookTitle.Text + "' AND bookId ='" + lbBookId.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    int artID = id;
                    string username = SignIn.accountName;
                    string title = tbArtTitle.Text;
                    string price = tbPrice.Text;
                    string length = tbLength.Text;
                    string width = tbWidth.Text;
                    string desc = tbDescription.Text;
                    string type = CBArtType.SelectedItem.ToString();

                    //string date = DateTime.Now.ToString();
                    //cn.Close();
                    //cn.Open();
                    cmd = new SqlCommand("update ARTWORKS " +
                        "set artTitle = '" + title + "', " +
                        "artPrice='" + price + "'," +
                        "artLength='" + length + "'," +
                        "artWidth='" + width + "'" +
                        "artDescription = '" + desc + "'" +
                        "artType ='" + type + "'" +
                        "artImage ='" + imageData + "'" +
                        "WHERE artID='" + artID + "'", con);

                    //cn.Close();
                    MessageBox.Show("Book information has been updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                lbMessage.Text = "Please enter value in all field.";
            }
        }

        private void UpdateArtwork_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("");
            con.Open();

            if (AdminHome.artID != 0)
            {
                id = AdminHome.artID;
            }
            else if (Artist_personal_gallery.artID != 0)
            {
                id = Artist_personal_gallery.artID;
            }
        }
    }
}
