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
    public partial class General_Home : Form
    {
        public General_Home()
        {
            InitializeComponent();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
//filter price
        private void cbPriceRange1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPriceRange2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPriceRange3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPriceRange4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPriceRange5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPriceRange6_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void chStyle1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbStyle2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbStyle3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbStyle4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbStyle5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbStyle6_CheckedChanged(object sender, EventArgs e)
        {

        }
//buttons
        private void btnProfile_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            this.Close();
            profile.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
//filter
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
//combobox
        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
