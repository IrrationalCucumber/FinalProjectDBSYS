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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            button3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // Point x = 113, 359;
            if (groupBox1.Visible == false)
            {
                groupBox1.Show();
                //button2.Location = x;
                button2.Hide();
                button3.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(groupBox1.Visible == true)
            {
                groupBox1.Hide();
                button2.Show();
                button3.Hide();
            }
        }
    }
}
