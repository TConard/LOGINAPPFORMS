using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginAppForms2
{
    public partial class VendorInfo : Form
    {
        // Replace the Excel.Application with SqlConnection
        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=TREYSPC\SQLEXPRESS;Initial Catalog=VendorLogin;Integrated Security=True;";

        public VendorInfo()
        {
            InitializeComponent();

            // Initialize the SqlConnection here
            sqlConnection = new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlCommandText = @"INSERT INTO VendorInfo (ID, Name, Company, Cell, City, Products, Diary_products, Delivery, Payment) 
                              VALUES (@ID, @Name, @Company, @Cell, @City, @Products, @Diary_products, @Delivery, @Payment)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                // Get the next ID
                long nextId = GetNextId(sqlConnection);
                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                {
                    // Convert ID explicitly to long if it's a bigint in SQL Server
                    sqlCommand.Parameters.AddWithValue("@ID", nextId);

                    // Add other parameters as strings or as their appropriate types
                    sqlCommand.Parameters.AddWithValue("@Name", txtName.Text);
                    sqlCommand.Parameters.AddWithValue("@Company", txtCompany.Text);
                    sqlCommand.Parameters.AddWithValue("@Cell", txtCell.Text);
                    sqlCommand.Parameters.AddWithValue("@City", listBox1.GetItemText(listBox1.SelectedItem));

                    string product = rdCoffee.Checked ? "Coffee" : rdGreen.Checked ? "Green Tea" : rdHerbs.Checked ? "Herbs" : "";
                    sqlCommand.Parameters.AddWithValue("@Products", product);

                    string dairyProduct = rdMilk.Checked ? "Milk" : rdCream.Checked ? "Cream" : "";
                    sqlCommand.Parameters.AddWithValue("@Diary_products", dairyProduct);

                    string deliveryStatus = ckDelayed.Checked ? "Delayed" : ckOntime.Checked ? "On Time" : "";
                    sqlCommand.Parameters.AddWithValue("@Delivery", deliveryStatus);

                    string paymentStatus = ckPaid.Checked ? "Paid" : ckUnpaid.Checked ? "Unpaid" : "";
                    sqlCommand.Parameters.AddWithValue("@Payment", paymentStatus);

                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Vendor information saved successfully!");
                sqlConnection.Close();
            }
        }
        private int GetNextId(SqlConnection sqlConnection)
        {
            sqlConnection.Open();

            string query = "SELECT ISNULL(MAX(ID), 0) + 1 FROM VendorInfo";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            // Use ExecuteScalar to get the next ID, and explicitly convert it to int
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        private void btnBack_Click(Object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Close();
        }
    }  
}