using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class SignIn : Form
    {
        public static string accountName;
        public int id;
        Thread th;
        public static bool isAdmin;
        public static bool isArtist;
        public static bool isBuyer;
        SqlConnection con;


        public SignIn()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
        public void gotoHome(object obj)
        {
            Application.Run(new General_Home());
        }
        public void gotoAdminHome(object obj)
        {
            Application.Run(new AdminHome());
        }
        public void gotoSignUp(object obj)
        {
            Application.Run(new Sign_Up());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // con = new SqlConnection("Data Source=DESKTOP-01\\SQLEXPRESS;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            //con.Open();
            con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
            con.Open();
        }


        private void btSignIn_Click(object sender, EventArgs e)
        {
            //try
            //{
                SqlCommand CheckifExist = new SqlCommand("Select * from ACCOUNTS where username = '" + tbUsername.Text + "' and password='" + tbPassword.Text + "'", con);
                CheckifExist.Parameters.AddWithValue("@username", tbUsername.Text);
               // CheckifExist.Parameters.AddWithValue("@password", Encryption.Decrypt(tbPassword.Text));
                CheckifExist.Parameters.AddWithValue("@password", tbPassword.Text);

                CheckifExist.Connection = con;
            con.Close();
                con.Open();
                SqlDataReader dt = CheckifExist.ExecuteReader();
                if (tbUsername.Text == "" && tbPassword.Text == "")
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = "Please provide username and password";
                }
                else if (!dt.HasRows)
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = "Username or Password incorrect";
                }

                else if (dt.HasRows)
                {
                    string username = tbUsername.Text;
                    string type = GetUserType(username);

                    if (type == "admin")
                    {
                        MessageBox.Show("Success! Welcome: " + tbUsername.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isAdmin = true;
                        accountName = tbUsername.Text;
                        this.Close();
                        th = new Thread(gotoAdminHome);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }

                    else if (type == "Artist")
                    {
                        MessageBox.Show("Success! Welcome user: " + tbUsername.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isArtist = true;
                        accountName = tbUsername.Text;
                        this.Close();
                        th = new Thread(gotoHome);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                    else
                    {
                        MessageBox.Show("Success! Welcome user: " + tbUsername.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isBuyer = true;
                        accountName = tbUsername.Text;
                        this.Close();
                        th = new Thread(gotoHome);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                }
                con.Close();
//}
            //catch (Exception ex)
            //{
                //MessageBox.Show(ex.Message);
            //

        }
        //method to determin the account type
        private string GetUserType(string username)
        {
            string userType = string.Empty;
            string query = "SELECT accountType FROM ACCOUNTS WHERE username = @username";

            using (con)
            {
                con.Close();
                con.Open();

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    object result = command.ExecuteScalar();
                    userType = result != null ? result.ToString() : string.Empty;
                }
            }

            return userType;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(gotoSignUp);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
    }
}
