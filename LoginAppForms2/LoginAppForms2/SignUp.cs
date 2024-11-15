using System;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;
using Access = Microsoft.Office.Interop.Access;

namespace LoginAppForms2
{
    public partial class SignUp : Form
    {
        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=TREYSPC\SQLEXPRESS; Initial Catalog=VendorLogin; Integrated Security=True; TrustServerCertificate=True;";

        public SignUp()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);

            // Ensure this event is wired up to handle form closure
            this.FormClosed += SignUp_FormClosed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the password matches with the confirm password
            if (txtNewPasswords.Text != txtConfirmPasswords.Text)  // Use correct control names here
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Insert new user into the database
            try
            {
                sqlConnection.Open();
                var username = txtNewUsername.Text;
                var password = txtNewPasswords.Text;  // Use correct control names here

                string query = $"INSERT INTO VendorCredentials (Username, Password) VALUES (@username, @password)";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("User registered successfully! Please go back and log in.");
                new LogIn().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to register: " + ex.Message);
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sqlConnection != null)
            {
                sqlConnection.Close();
                sqlConnection = null;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
    }
}