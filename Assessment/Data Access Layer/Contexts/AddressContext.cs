using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class AddressContext
    {
        private string _connectionString;

        public AddressContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddAddress(Address address)
        {
            // Code for inserting address into the database
            string query = "INSERT INTO Addresses (ClientID, AddressType, Street, City, PostalCode) VALUES (@ClientID, @AddressType, @Street, @City, @PostalCode)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClientID", address.ClientID);
                    cmd.Parameters.AddWithValue("@AddressType", address.AddressType);
                    cmd.Parameters.AddWithValue("@Street", address.Street);
                    cmd.Parameters.AddWithValue("@City", address.City);
                    cmd.Parameters.AddWithValue("@PostalCode", address.PostalCode);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateAddress(Address address)
        {
            // Code for updating address into the database using SqlCommand
            string query = "UPDATE Addresses SET AddressType = @AddressType, Street = @Street, City = @City, PostalCode = @PostalCode WHERE AddressID = @AddressID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AddressType", address.AddressType);  // Convert enum to string
                    cmd.Parameters.AddWithValue("@Street", address.Street);
                    cmd.Parameters.AddWithValue("@City", address.City);
                    cmd.Parameters.AddWithValue("@PostalCode", address.PostalCode);
                    cmd.Parameters.AddWithValue("@AddressID", address.AddressID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RemoveAddress(int addressId)
        {
            // Code for removing address into the database using SqlCommand
            string query = "DELETE FROM Addresses WHERE AddressID = @AddressID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AddressID", addressId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
