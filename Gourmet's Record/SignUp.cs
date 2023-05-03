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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");

        public string AccountName;
        public int userID;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Enter Username
        private void UptbUsername_TextChanged(object sender, EventArgs e)
        {

        }
        //Enter Password
        private void UptbEnPassword_TextChanged(object sender, EventArgs e)
        {

        }

        //Error message sa password
        private void lbMessage_Click(object sender, EventArgs e)
        {

        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            try {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Accounts(username, password , LastName,FirstName, email ,accountType) Values ('" + tbUsername.Text + "','" + tbPassword.Text+ "','" + tbLastname.Text + "','" + tbFirstname.Text + "','" + tbEmail.Text + "','" + tbAccT.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
