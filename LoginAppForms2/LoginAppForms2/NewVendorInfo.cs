using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient; // adding SQL object

namespace LoginAppForms2
{
    public partial class NewVendorInfo : Form
    {
        // Replace the Excel.Application with SqlConnection
        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=TREYSPC\SQLEXPRESS;Initial Catalog=VendorLogin;Integrated Security=True;";

        public NewVendorInfo()
        {
            InitializeComponent();

            // Initialize the SqlConnection here
            sqlConnection = new SqlConnection(connectionString);
        }

        // Function to retrieve the next ID from the database
        private int GetNextId(SqlConnection sqlConnection)
        {
            sqlConnection.Open();

            string query = "SELECT ISNULL(MAX(New_VID), 0) + 1 FROM NewVendorsDB";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            return (int)cmd.ExecuteScalar();
        }
        private byte[] GetPhoto()
        {
            if (pictureBox1.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    // Save image to stream in PNG format
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    return stream.ToArray(); // Converts the image in memory stream to byte array
                }
            }
            return null; // Return null if no image is loaded
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Initialize SQL command and set the command text for insertion
            string sqlCommandText = @"INSERT INTO NewVendorsDB (POC_Name, POC_JobTitle, POC_Email, POC_Phone, POC_Company, POC_ComAddress, City, Photo)
                              VALUES (@POC_Name, @POC_JobTitle, @POC_Email, @POC_Phone, @POC_Company, @POC_ComAddress, @City, @Photo)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open(); // Make sure the connection is open

                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@POC_Name", txtPOCName.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_JobTitle", txtPOCJobTitle.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_Email", txtPOCEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_Phone", txtPOCPhone.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_Company", txtPOCCompany.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_ComAddress", txtCompanyAddress.Text);
                    sqlCommand.Parameters.AddWithValue("@City", listBox1.GetItemText(listBox1.SelectedItem));

                    // Check if a photo is loaded in pictureBox1
                    byte[] photoBytes = GetPhoto();
                    if (photoBytes != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@Photo", photoBytes); // Add the photo if available
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@Photo", DBNull.Value); // Handle the case when no photo is available
                    }

                    sqlCommand.ExecuteNonQuery(); // Execute the query to insert the record
                }

                MessageBox.Show("New vendor information saved successfully!");
            }

            sqlConnection.Close(); // Close the connection
        }
        private void button4_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Close();
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            // Open the file dialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the image into the PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load the photo: " + ex.Message);
                }
            }
        }
    }
}