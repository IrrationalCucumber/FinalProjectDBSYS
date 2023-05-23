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

namespace Gourmet_s_Record
{
    public partial class Artist_Upload_Artwork : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        byte[] imageData;
        public Artist_Upload_Artwork()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbArtTitle.Text != string.Empty || tbDescription.Text != string.Empty || tbLength.Text != string.Empty || tbPrice.Text != string.Empty || tbWidth.Text != string.Empty) 
            {
                    //int bookID = Int32.Parse(tbBookID.Text);
                string ArtTitle = tbArtTitle.Text;
                string Description = tbDescription.Text;
                string Length = tbLength.Text;
                string Price = tbPrice.Text;
                string Width =  tbWidth.Text;
                string type = CBArtType.SelectedItem.ToString();
                string username = SignIn.accountName;
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("insert into BOOKS values( @username,@artTitle,@artWidth,@artHeight, @artPrice, @artType, @artDescription, @artImage, @artAvailable, @dateAdded)", con);
                    //cmd.Parameters.AddWithValue("bookId", bookID);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("artTitle", ArtTitle);
                    cmd.Parameters.AddWithValue("artWidth", Width);
                    cmd.Parameters.AddWithValue("artDescription", Description);
                    cmd.Parameters.AddWithValue("Length", Length);
                    cmd.Parameters.AddWithValue("Price", Price);
                cmd.Parameters.AddWithValue("artImage", imageData);
                    cmd.Parameters.AddWithValue("dateAdded", DateTime.Now);
                    cmd.Parameters.AddWithValue("artAvailable", "Available" );
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Artwork added in the Gallery", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            else
            {
                lbMessage.Visible = true;
                lbMessage.Text = "Please enter value in all field.";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            General_Home home = new General_Home();
            this.Close();
            home.Show();
        }

        private void Artist_Upload_Artwork_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("");
            con.Open();
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
    }
}
