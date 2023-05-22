using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gourmet_s_Record
{
    public partial class UserProfile : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        byte[] imageData;
        public UserProfile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("");
            con.Open();
            
            if(SignIn.isBuyer == true)
            {
                btnGallery.Visible = false;
            }

            cmd = new SqlCommand("SELECT username, LastName, FirstName, email, contactNum, userBio, addressProvince, addressCity, addressBarangay, addressStreet, addressHome, profileImage" +
                "WHERE username = '"+ SignIn.accountName +"'",con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string Username = dr["username"].ToString();
                string FN = dr["FirstName"].ToString();
                string LN = dr["LastName"].ToString();
                string Email = dr["email"].ToString();
                string CN = dr["contactNum"].ToString();
                string bio = dr["userBio"].ToString();
                string House = dr["addressHome"].ToString();
                string Street = dr["addressStreet"].ToString();
                string Brngy = dr["addressBarangay"].ToString();
                string city = dr["addressCity"].ToString();
                string Prov = dr["addressProvince"].ToString();
                imageData = (byte[])dr["profileImage"];

                tbUsername.Text = Username;
                tbLN.Text = LN;
                tbFN.Text = FN;
                tbEmail.Text = Email;
                tbCN.Text = CN;
                tbBio.Text = bio;
                tbHouse.Text = House;
                tbStreet.Text = Street;
                tbBrngy.Text = Brngy;
                tbCity.Text = city;
                tbProv.Text = Prov;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Set the image of the picture box
                    pbProfilePic.Image = Image.FromStream(ms);
                }
            }
        }

//buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            General_Home home = new General_Home();
            this.Close();
            home.Show();
        }
//buttons
        private void btnGallery_Click(object sender, EventArgs e)
        {
            Artist_personal_gallery artist_Personal_Gallery = new Artist_personal_gallery();
            this.Close();
            artist_Personal_Gallery.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            User_Transaction_list user_Transaction_List = new User_Transaction_list();
            this.Close();
            user_Transaction_List.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != string.Empty || tbFN.Text != string.Empty || tbLN.Text != string.Empty || tbEmail.Text != string.Empty || tbCN.Text != string.Empty || tbHouse.Text != string.Empty || tbStreet.Text != string.Empty || tbBrngy.Text != string.Empty || tbCity.Text != string.Empty || tbProv.Text != string.Empty)
            {

                dr.Close();
                string Username = tbUsername.Text;
                string FN = tbFN.Text;
                string LN = tbLN.Text;
                string Email = tbEmail.Text;
                string CN = tbCN.Text;
                string bio = tbBio.Text;
                    string House = tbHouse.Text;
                    string Street = tbStreet.Text;
                    string Brngy = tbBrngy.Text;
                string city = tbCity.Text;
                    string Prov = tbProv.Text;

                //string date = DateTime.Now.ToString();
                //cn.Close();
                //cn.Open();
                cmd = new SqlCommand("update ACCOUNTS " +
                        "SET LastName = '" + FN + "', " +
                        "FirstName ='" + LN + "'," +
                        "email ='" + Email + "'," +
                        "contactNum='" + CN + "'" +
                        "userBio = '" + bio+ "'" +
                        "addressHouse = '" +House + "'" +
                        "addressStreet = '"+ Street +"'" +
                        "addressBarangay ='"+ Brngy +"'" +
                        "addressCity = '"+ city +"'" +
                        "addressProvince = '" + Prov +"'" +
                        "profileImage ='"+ imageData +"'"+
                        "WHERE username ='" + Username + "'", con);
                    cmd.ExecuteNonQuery();

                    //cn.Close();
                    MessageBox.Show("Book information has been updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            else
            {
                MessageBox.Show("Missing fields", "Okay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbUsername.ReadOnly = false;
            tbLN.ReadOnly = false;
            tbFN.ReadOnly = false;
            tbEmail.ReadOnly = false;
            tbCN.ReadOnly = false;
            tbBio.ReadOnly = false;
            tbHouse.ReadOnly = false;
            tbStreet.ReadOnly = false;
            tbBrngy.ReadOnly = false;
            tbCity.ReadOnly = false;
            tbProv.ReadOnly = false;
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image";
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Convert the image to a byte array
                //byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    Image image = Image.FromFile(filePath);
                    image.Save(ms, ImageFormat.Jpeg); // Change this to the format of your choice
                    imageData = ms.ToArray();
                }
            }
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }
        //user profile pic

    }
}
