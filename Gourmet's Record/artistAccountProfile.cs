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
    public partial class ArtistAccountProfile : Form
    {
        public ArtistAccountProfile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btCancel.Visible = true;
            btSave.Visible = true;
            tbUsername.ReadOnly = false;
            tbFN.ReadOnly = false;
            tbLN.ReadOnly = false;
            tbEmail.ReadOnly = false;
            tbCN.ReadOnly = false;
            tbProv.ReadOnly = false;
            tbCity.ReadOnly = false;
            tbBrngy.ReadOnly = false;
            tbStreet.ReadOnly = false;
            tbHouse.ReadOnly = false;
            tbDesc.ReadOnly = false;
        }

        private void ArtistAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            this.Close();
            hm.Show();
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image";
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pbArtist.Image = Image.FromFile(filePath);
            }
        }

        private void pbArtist_Click(object sender, EventArgs e)
        {

        }
    }
}
