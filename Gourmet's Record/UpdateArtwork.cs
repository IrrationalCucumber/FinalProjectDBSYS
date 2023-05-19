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
    public partial class UpdateArtwork : Form
    {
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
                    int bookID = Int32.Parse(lbBookId.Text);
                    string bookTitle = tbBookTitle.Text;
                    string bookAuthor = tbBookAuthor.Text;
                    string bookGenre = tbBookGenre.Text;
                    string bookStatus = "";
                    string username = SignIn.AccountName;
                    string date = DateTime.Now.ToString();
                    string type = "Update Book";
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

        private void UpdateArtwork_Load(object sender, EventArgs e)
        {

        }
    }
}
