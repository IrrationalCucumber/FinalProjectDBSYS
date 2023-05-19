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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gourmet_s_Record
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

      
//buttons


        private void btnHome_Click(object sender, EventArgs e)
        {
            General_Home home = new General_Home();
            this.Close();
            home.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
//textbox
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHouse_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBrngy_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbProv_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBio_TextChanged(object sender, EventArgs e)
        {

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
                //   cmd = new SqlCommand("select * from ARTWORK where art='" + tbBookTitle.Text + "' AND bookId ='" + lbBookId.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    int Username = Int32.Parse(tbUsername.Text);
                    string FN = tbFN.Text;
                    string LN = tbLN.Text;
                    string Email = tbEmail.Text;
                    string CN = tbCN.Text;
                    string House = tbHouse.Text;
                    string Street = tbStreet.Text;
                    string Brngy = tbBrngy.Text;
                    string Prov = tbProv.Text;
                    string Available = "Available";
                    string username = SignIn.AccountName;
                    string date = DateTime.Now.ToString();
                    string CBArtType = "Update Book";
                    if (rStatusB.Checked) 
                    {
                        bookStatus = "Borrowed";
                    }
                    else if (rStatusA.Checked)
                    {
                        bookStatus = "Available";
                    }
                    //string date = DateTime.Now.ToString();
                    //cn.Close();
                    //cn.Open();
                    cmd = new SqlCommand("update BOOKS " +
                        "set bookTitle = '" + bookTitle + "', " +
                        "bookAuthor='" + bookAuthor + "'," +
                        "bookgenre='" + bookGenre + "'," +
                        "bookStatus='" + bookStatus + "'" +
                        "WHERE bookId='" + bookID + "'", cn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into TRANSACTIONS values(@user, @TransactionType, @bookTitle, @TransactionDate)", cn);
                    cmd.Parameters.AddWithValue("user", username);
                    cmd.Parameters.AddWithValue("TransactionType", type);
                    cmd.Parameters.AddWithValue("bookTitle", bookTitle);
                    cmd.Parameters.AddWithValue("TransactionDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    //cn.Close();
                    MessageBox.Show("Book information has been updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                lbMessage.Text = "Please enter value in all field.";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btUpload_Click(object sender, EventArgs e)
        {

        }
//user profile pic
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
