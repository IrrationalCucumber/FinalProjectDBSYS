using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class UserProfile : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        byte[] imageData;
        Thread th;
        public UserProfile()
        {
            InitializeComponent();
        }
        public void gotohome(object obj)
        {
            Application.Run(new General_Home());
        }
        public void gotoGallery(object obj) { Application.Run(new Artist_personal_gallery()); }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-I525U4NK\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            // con = new SqlConnection("Data Source=DESKTOP-01\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            con.Open();

            if (SignIn.isBuyer == true)
            {
                btnGallery.Visible = false;
            }

            cmd = new SqlCommand("SELECT LastName, FirstName, email, contactNum, userBio, addressProvince, addressCity, addressBarangay, addressStreet, addressHome, profileImage FROM ACCOUNTS WHERE username = '" + SignIn.accountName + "'", con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //string Username = dr["username"].ToString();
                string LN = dr["LastName"].ToString();
                string FN = dr["FirstName"].ToString();
                string Email = dr["email"].ToString();
                string bio = dr["userBio"].ToString();
                string CN = dr["contactNum"].ToString();
                string house = dr["addressHome"].ToString();
                string Street = dr["addressStreet"].ToString();
                string Brngy = dr["addressBarangay"].ToString();
                string city = dr["addressCity"].ToString();
                string Prov = dr["addressProvince"].ToString();

                //object profileImageValue = dr["profileImage"];
                imageData = (byte[])dr["profileImage"];



                msAccount.Text = SignIn.accountName;
                tbLN.Text = LN;
                tbFN.Text = FN;
                tbEmail.Text = Email;
                tbCN.Text = CN;
                tbBio.Text = bio;
                tbHouse.Text = house;
                tbStreet.Text = Street;
                tbBrngy.Text = Brngy;
                tbCity.Text = city;
                tbProv.Text = Prov;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pbProfilePic.Image = Image.FromStream(ms);
                }
            }

        }

        //buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            th = new Thread(gotohome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        //buttons
        private void btnGallery_Click(object sender, EventArgs e)
        {
            this.Hide();
            th = new Thread(gotoGallery);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            User_Transaction_list user_Transaction_List = new User_Transaction_list();
            this.Hide();
            user_Transaction_List.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbFN.Text != string.Empty || tbLN.Text != string.Empty || tbEmail.Text != string.Empty || tbCN.Text != string.Empty || tbHouse.Text != string.Empty || tbStreet.Text != string.Empty || tbBrngy.Text != string.Empty || tbCity.Text != string.Empty || tbProv.Text != string.Empty)
            {

                dr.Close();
                string Username = SignIn.accountName;
                string FN = tbFN.Text;
                string LN = tbLN.Text;
                string Email = tbEmail.Text;
                int CN = Int32.Parse(tbCN.Text);
                string bio = tbBio.Text;
                string House = tbHouse.Text;
                string Street = tbStreet.Text;
                string Brngy = tbBrngy.Text;
                string city = tbCity.Text;
                string Prov = tbProv.Text;

                //string date = DateTime.Now.ToString();
                //cn.Close();
                //cn.Open();
                // ...
                cmd = new SqlCommand("UPDATE ACCOUNTS " +
                    "SET LastName = @LastName, " +
                    "FirstName = @FirstName," +
                    "email = @Email," +
                    "contactNum = @ContactNum," +
                    "userBio = @UserBio," +
                    "addressHome = @AddressHome," +
                    "addressStreet = @AddressStreet," +
                    "addressBarangay = @AddressBarangay," +
                    "addressCity = @AddressCity," +
                    "addressProvince = @AddressProvince," +
                    "profileImage = @ProfileImage " +
                    "WHERE username = @Username", con);

                cmd.Parameters.AddWithValue("@LastName", LN);
                cmd.Parameters.AddWithValue("@FirstName", FN);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@ContactNum", CN);
                cmd.Parameters.AddWithValue("@UserBio", bio);
                cmd.Parameters.AddWithValue("@AddressHome", House);
                cmd.Parameters.AddWithValue("@AddressStreet", Street);
                cmd.Parameters.AddWithValue("@AddressBarangay", Brngy);
                cmd.Parameters.AddWithValue("@AddressCity", city);
                cmd.Parameters.AddWithValue("@AddressProvince", Prov);
                cmd.Parameters.AddWithValue("@ProfileImage", imageData);
                cmd.Parameters.AddWithValue("@Username", Username);

                cmd.ExecuteNonQuery();
                // ...


                //cn.Close();
                MessageBox.Show("Account updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEdit.Visible = true;

            }
            else
            {
                MessageBox.Show("Missing fields", "Okay", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //tbUsername.ReadOnly = false;
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

            //enavle control
            tbLN.Enabled = true;
            tbFN.Enabled = true;
            tbEmail.Enabled = true;
            tbCN.Enabled = true;
            tbBio.Enabled = true;
            tbHouse.Enabled = true;
            tbStreet.Enabled = true;
            tbBrngy.Enabled = true;
            tbCity.Enabled = true;
            tbProv.Enabled = true;
            btnSave.Visible = true;
            btnEdit.Visible = false;
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

                pbProfilePic.Image = Image.FromFile(filePath);
            }
        }

        private void editPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Password up = new Update_Password();
            up.Show();
        }

        private void miSO_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.Show();
        }

        private void pbProfilePic_Click(object sender, EventArgs e)
        {

        }
        //user profile pic

    }
}
