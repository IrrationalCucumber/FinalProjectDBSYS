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
    public partial class Update_Password : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Update_Password()
        {
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (tbNewPassword1.Text != string.Empty || tbNewPassword2.Text != string.Empty || tbUsername.Text != string.Empty || tbOldPassword.Text != string.Empty)
            {
                if (tbNewPassword1.Text != tbOldPassword.Text)
                {
                    
                    string UserName = SignIn.accountName;
                    string Password = Encryption.Encrypt(tbNewPassword1.Text.ToString());
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("update ACCOUNTS" +
                        "set password = '" + tbNewPassword1 + "'" +
                        "WHERE username = '" + tbUsername + "'", con);
                    //cmd.Parameters.AddWithValue("username", UserName);
                    //cmd.Parameters.AddWithValue("password", Password);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your Account has been updated .\n Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
                else
                {
                    lbUsernameMessage.Text = "New password and old password must not be the same";
                }
            }
            else
            {
                lbUsernameMessage.Text = "Please enter value in all field.";
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Update_Password_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.Open();
        }
    }
}
