using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Gourmet_s_Record
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SignIn.isBuyer == true)
            {
                this.Close();
                BuyerAccountProfile ap = new BuyerAccountProfile();
                ap.Show();
            }
            else if (SignIn.isArtist == true)
            {
                this.Close();
                //artistAccountPage ap = new artistAccountPage();
                //ap.show();
            }
            else {
                SignIn si = new SignIn();
                si.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            
            if (SignIn.isBuyer == true || SignIn.isArtist == true)
            {
                btAP.Text = SignIn.AccountName;
                if (SignIn.isArtist == true)
                {
                    btUpload.Visible = true;
                }
            }
            else{
                btAP.Text = "Sign In";
                btSI.Visible = false;
            }

        }

        private void btSI_Click(object sender, EventArgs e)
        {
            SignIn si = new SignIn();
            si.Show();
        }
    }
}
