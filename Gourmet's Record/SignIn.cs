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
        public string accountName;
        public int id;
        Thread th;
        public SignIn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GTBF9M5;Initial Catalog=online_art_gallery_database_final;Integrated Security=True");
        public void gotoHome(object obj)
        {
            Application.Run(new Homepage());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbMessage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static string AccountName;

        private void btSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand CheckifExist = new SqlCommand("Select * from [dbo].[ACCOUNTS] where username = '" + tbUsername.Text + "' and password='" + tbPassword.Text + "'", con);
                CheckifExist.Parameters.AddWithValue("@username", tbUsername.Text);
                CheckifExist.Parameters.AddWithValue("@password", tbPassword.Text);

                CheckifExist.Connection = con;
                con.Open();
                SqlDataReader dt = CheckifExist.ExecuteReader();
                if (tbUsername.Text == "" && tbPassword.Text == "")
                {
                    MessageBox.Show("Please provide username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!dt.HasRows)
                {
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
                        AccountName = tbUsername.Text;
                        this.Close();
                        adminHome home = new adminHome();
                        home.Show();
                    }

                    else if (type == "Artist")
                    {
                        MessageBox.Show("Success! Welcome user: " + tbUsername.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isArtist = true;
                        AccountName = tbUsername.Text;
                        this.Close();
                        th = new Thread(gotoHome);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                    else
                    {
                        MessageBox.Show("Success! Welcome user: " + tbUsername.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isBuyer = true;
                        AccountName = tbUsername.Text;
                        this.Close();
                        th = new Thread(gotoHome);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp si = new SignUp();
            this.Close();
            si.Show();
        }
    }
    private string GetUserType(string username)
    {
        string userType = string.Empty;
        string query = "SELECT accountType FROM ACCOUNTS WHERE username = @username";

        using (con)
        {
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
}
