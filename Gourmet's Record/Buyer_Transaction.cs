using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class Buyer_Transaction : Form
    {
        public Buyer_Transaction()
        {
            InitializeComponent();
        }


        private void tbBTaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuyerTransaction_Load(object sender, EventArgs e)
        {
            //hello
        }

        private void tbBTContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBTFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBTLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBTemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBTTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }
//label
        private void lbArtist_Click(object sender, EventArgs e)
        {

        }
        private void lbArtTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            General_Home home = new General_Home();
            this.Close();
            home.Show();
        }
    }
}
