using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class Sign_Up : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con;
        Thread th;
        public Sign_Up()
        {
            InitializeComponent();
        }
        
        public int userID;

        public void gotoSignIn(object obj)
        {
            Application.Run(new SignIn());
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            //con.Open();
            con = new SqlConnection("Data Source=DESKTOP-01\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            con.Open();
        }


        private void btSignIn_Click(object sender, EventArgs e)
        {
            /*
            try {
                con.Open();
                //SqlCommand cmd = new SqlCommand("Insert into Accounts(username, password , LastName,FirstName, email ,accountType) Values ('" + tbUsername.Text + "','" + tbPassword.Text+ "','" + tbLastname.Text + "','" + tbFirstname.Text + "','" + tbEmail.Text + "','" + .Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           */
            try
            {
                if (tbPassword.Text != string.Empty || tbConfirm.Text != string.Empty || tbUsername.Text != string.Empty)
                {
                    if (tbConfirm.Text == tbPassword.Text)
                    {
                        cmd = new SqlCommand("select * from ACCOUNTS where username='" + tbUsername.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            lbMessage.Visible = true;
                            lbMessage.Text = "Username Already exist please try another";
                        }
                        else
                        {
                            dr.Close();
                            string UserName = tbUsername.Text;
                            string Password = tbPassword.Text;
                            //string Password = Encryption.Encrypt(tbPassword.Text.ToString());
                            string type = cbAcctType.SelectedItem.ToString();

                            con.Close();
                            con.Open();
                            cmd = new SqlCommand("INSERT INTO ACCOUNTS (username, password, accountType, dateAdded) VALUES (@username, @password, @accountType, @dateAdded)", con);
                            cmd.Parameters.AddWithValue("@username", UserName);
                            cmd.Parameters.AddWithValue("@password", Password);
                            cmd.Parameters.AddWithValue("@accountType", type);
                            cmd.Parameters.AddWithValue("@dateAdded", DateTime.Now);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            th = new Thread(gotoSignIn);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                    }
                    else
                    {
                        lbMessage.Visible = true;
                        lbMessage.Text = "Please enter both password same ";
                    }
                }
                else
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = "Please enter value in all field.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(gotoSignIn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
