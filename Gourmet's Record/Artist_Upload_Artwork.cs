using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class Artist_Upload_Artwork : Form
    {
        public Artist_Upload_Artwork()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
//texboxes 
//kalimot ko unsaon tung naa needed dapat ma fill upan ang textbox katung naay * 

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbArtTitle_TextChanged(object sender, EventArgs e)
        {

        }
        // error message if di ma upload ang image
        private void emImage_Click(object sender, EventArgs e)
        {

        }
        //image upload
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //width
        private void tbWidth_TextChanged(object sender, EventArgs e)
        {

        }
        //length
        private void tbLength_TextChanged(object sender, EventArgs e)
        {

        }
        //type combobox akong gi gamit sa type para ka choose ug unsa na type sa artwork
        private void CBArtType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
//Buttons
        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbArtTitle.Text != string.Empty || tbDescription.Text != string.Empty || tbLength.Text != string.Empty || tbPrice.Text != string.Empty || tbWidth.Text != string.Empty) 
            {
                cn.Close();
                cn.Open();
               // cmd = new SqlCommand("select * from ARTWORKS where artID='" + //.Text + "'", cn);
                dr = cmd.ExecuteReader();
                //if method for invalid input

                if (dr.Read())
                {
                    dr.Close();
                    lbMessage.Text = "Book already exist please try another ";
                }
                else
                {
                    dr.Close();
                    //int bookID = Int32.Parse(tbBookID.Text);
                    string ArtTitle = tbArtTitle.Text;
                    string Description = tbDescription.Text;
                    string Length = tbLength.Text;
                    string Price = tbPrice.Text;
                    string Width =  tbWidth.Text;
                    string username = SignIn.AccountName;
                    //string date = DateTime.Now.ToString();
                    string type = CBArtType.SelectedItem.ToString();
                    cn.Close();
                    cn.Open();
                    //@@bookId,
                    cmd = new SqlCommand("insert into BOOKS values( @username,@artTitle,@artWidth,@artHeight, @artPrice, @artType, @artDescription, @artImage, @artAvailable, @dateAdded)", cn);
                    //cmd.Parameters.AddWithValue("bookId", bookID);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("artTitle", ArtTitle);
                    cmd.Parameters.AddWithValue("artWidth", Width);
                    cmd.Parameters.AddWithValue("artDescription", Description);
                    cmd.Parameters.AddWithValue("Length", Length);
                    cmd.Parameters.AddWithValue("Price", Price);
                    cmd.Parameters.AddWithValue("dateAdded", DateTime.Now);
                    cmd.Parameters.AddWithValue("artAvailable", "Available" );
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Book has been added to the Library", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
