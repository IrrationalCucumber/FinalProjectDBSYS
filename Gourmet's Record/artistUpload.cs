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
    public partial class artistUpload : Form
    {
        public artistUpload()
        {
            InitializeComponent();
        }

        private void artistUpload_Load(object sender, EventArgs e)
        {
            //store art info on database
            /*
                                 string connectionString = "your connection string";
                    string query = "INSERT INTO ArtTable (artTitle, artWidth, artLength, artPrice, artType, artDescription, artImage) VALUES (@Title, @Width, @Length, @Price, @Type, @Description, @Image)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Set the parameter values
                            command.Parameters.AddWithValue("@Title", "Art Title");
                            command.Parameters.AddWithValue("@Width", 100);
                            command.Parameters.AddWithValue("@Length", 150);
                            command.Parameters.AddWithValue("@Price", 500);
                            command.Parameters.AddWithValue("@Type", "Art Type");
                            command.Parameters.AddWithValue("@Description", "Art Description");
        
                            // Set the image parameter as byte array
                            byte[] imageData; // Replace with the byte array of the image
                            command.Parameters.AddWithValue("@Image", imageData);

                            // Execute the query
                            command.ExecuteNonQuery();
                        }
                    }

             */
            //upload pic by user
            /*
             private void buttonUpload_Click(object sender, EventArgs e)
{
    OpenFileDialog openFileDialog = new OpenFileDialog();
    openFileDialog.Title = "Select an image";
    openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

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

        // Display the image in the picture box
        pictureBox.Image = Image.FromFile(filePath);
    }
}

             */
        }
    }
}
