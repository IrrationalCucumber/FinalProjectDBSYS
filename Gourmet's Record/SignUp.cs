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
        SqlCommand cmd;
        SqlDataReader dr;

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
                /*
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Accounts(username, password, accountType, accountVerified) Values ('" + tbUsername.Text + "','" + tbPassword.Text+ "','" + tbLastname.Text + "','" + tbFirstname.Text + "','" + tbEmail.Text + "','" + tbAccT.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!!!");
                */

                if (tbPassword.Text != string.Empty || tbUsername.Text != string.Empty)
                {
                    if(tbPassword.Text != tbPassword1.Text)
                    {
                        if (IsStrongPassword(tbPassword.Text))
                        {
                            cmd = new SqlCommand("select * from ACCOUNTS where username='" + tbUsername.Text + "'", con);
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                dr.Close();
                                lbMessage.Text = "Username Already exist please try another";
                            }
                            else
                            {
                                dr.Close();
                                string UserName = tbUsername.Text;
                                string Password = Encryption.Encrypt(tbPassword.Text.ToString());
                                string type = cbType.SelectedItem.ToString();
                                con.Close();
                                con.Open();
                                cmd = new SqlCommand("insert into ACCOUNTS values(@username,@password, @accountType, @dateAdded)", con);
                                cmd.Parameters.AddWithValue("username", UserName);
                                cmd.Parameters.AddWithValue("password", Password);
                                cmd.Parameters.AddWithValue("accountType", type);
                                cmd.Parameters.AddWithValue("dateAdded", DateTime.Now);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SignIn si = new SignIn();
                                si.Show();
                                this.Hide();
                            }
                        }
                        else {
                            lbMessage.Text = "Password id too weak.\n Combine numbers, special characters and, upper and lower case letters";
                        }
                    }
                    else
                    {
                        lbMessage.Text = "Please enter both password same ";
                    }
                }
                else
                {
                    lbMessage.Text = "Please enter value in all field.";
                }
            }
            catch(Exception ex)
            {
                lbMessage.Text = ex.Message;
            }
           

        }
        public static bool IsStrongPassword(string password)
        {
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (Char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                else if (Char.IsLower(c))
                {
                    hasLowerCase = true;
                }
                else if (Char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (Char.IsSymbol(c) || Char.IsPunctuation(c))
                {
                    hasSpecialChar = true;
                }
            }

            return hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            SignIn si = new SignIn();
            si.Show();
        }

        private void lbMessage_Click_1(object sender, EventArgs e)
        {

        }
    }
}
