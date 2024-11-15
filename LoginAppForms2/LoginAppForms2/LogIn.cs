using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using LoginAppForms2;

namespace LoginAppForms2
{
    public partial class LogIn : Form
    {
        private string connectionString = @"Data Source=TREYSPC\SQLEXPRESS;Initial Catalog=VendorLogin;Integrated Security=True;";

        public LogIn()
        {
            InitializeComponent();
        }

        private bool ValidateUser(string username, string passwords)
        {
            // VendorCredentials is the table name; Username and Password are the column names
            string query = @"SELECT COUNT(*) AS UserCount FROM VendorCredentials WHERE Username = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", passwords);

                // Open the connection and execute the command
                connection.Open();
                int userCount = (int)command.ExecuteScalar();

                // Return true if we have at least one user matching the credentials
                return userCount > 0;
            }
        }

        // Defines the event handler for the 'Click' event of button1
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateUser(txtUsername.Text, txtPasswords.Text))
            {
                if (comboBoxType.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid user type.");
                    comboBoxType.Focus();
                    return;
                }

                string userSelectedType = comboBoxType.Text; // Get the selected user type from the ComboBox

                // Fetch user type from the database for the given username
                string userTypeQuery = "SELECT Type FROM VendorCredentials WHERE Username = @Username";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(userTypeQuery, connection);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);

                    // Open the connection and execute the command
                    connection.Open();
                    string sqlType = (string)command.ExecuteScalar();

                    // Check if the user-selected type matches the one from the database
                    if (userSelectedType == sqlType)
                    {
                        // User type is correct
                        if (userSelectedType == "Admin")
                        {
                            new Admin().Show();
                            this.Hide();
                        }
                        else if (userSelectedType == "Vendor")
                        {
                            new VendorInfo().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User type is incorrect! Please select the correct user type.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or passwords!");
                txtPasswords.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPasswords.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPasswords.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPasswords.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPasswords.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPasswords.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}