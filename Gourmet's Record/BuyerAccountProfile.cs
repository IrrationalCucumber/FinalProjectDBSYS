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
    public partial class BuyerAccountProfile : Form
    {
        public BuyerAccountProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuyerAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void btEdit_Click(object sender, EventArgs e)
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
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image";
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pbBuyer.Image = Image.FromFile(filePath);
            }
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            /*
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Convert the image to a byte array
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    Image image = Image.FromFile(filePath);
                    image.Save(ms, ImageFormat.Jpeg); // Change this to the format of your choice
                    imageData = ms.ToArray();
                }

                // Save the byte array to the database
                string connectionString = "your connection string";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE YourTable SET Image = @Image WHERE Id = @Id"; // Change "YourTable" and "Id" to the appropriate names
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Image", imageData);
                        command.Parameters.AddWithValue("@Id", yourRecordId); // Replace "yourRecordId" with the ID of the record where you want to store the image
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            */
            }
    }
}
