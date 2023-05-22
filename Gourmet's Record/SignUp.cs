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
                if (tbUsername.Text != string.Empty || tbPassword.Text != string.Empty || tbConfirm.Text != string.Empty) {
                    
                    
                    if(tbPassword.Text == tbConfirm.Text){
                        cmd = new SqlCommand("select * from ACCOUNTS where username='" + tbUsername.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (!dr.Read())
                        {
                            dr.Close();
                            string UserName = tbUsername.Text;
                            string Password = Encryption.Encrypt(tbPassword.Text.ToString());
                            string type = cbAcctType.SelectedItem.ToString();
                            con.Close();
                            con.Open();
                            cmd = new SqlCommand("insert into ACCOUNTS values(@username,@password, accountType, dateAdded)", con);
                            cmd.Parameters.AddWithValue("username", UserName);
                            cmd.Parameters.AddWithValue("password", Password);
                            cmd.Parameters.AddWithValue("accountType", type);
                            cmd.Parameters.AddWithValue("dateAdded", DateTime.Now);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SignIn si = new SignIn();
                            this.Close();
                            si.Show();

                            /*
                            con.Open();
                            SqlCommand cmd = new SqlCommand("Insert into Accounts(username, password  ,accountType, dateAdded) Values ('" + tbUsername.Text + "','" + tbPassword.Text + "','" + cbAcctType.SelectedItem.ToString() + "','" + DateTime.Now + "')", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Success!!!");
                            */
                        }
                        else
                        {
                            lbMessage.Visible = true;
                            lbMessage.Text = "Username already exist.";
                        }
                    }
                    else
                    {
                        lbMessage.Visible = true;
                        lbMessage.Text = "Password mismatch.";
                    }
                }
                else
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = "Some fields are missing.";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

      //  private void tbAccT_TextChanged(object sender, EventArgs e)
      //  {

      //  }

//textbox and combo box for user input
        //account type combobox
        private void cbAcctType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkSU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn si = new SignIn();
            this.Close();
            si.Show();
        }
    }
}
