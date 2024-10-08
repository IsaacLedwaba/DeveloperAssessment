using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ContactContext
    {
        private string _connectionString;

        public ContactContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddContact(Contact contact)
        {
            // Code for inserting contact into the database
            string query = "INSERT INTO Contacts (ClientID, ContactType, ContactNumber) VALUES (@ClientID, @ContactType, @ContactNumber)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClientID", contact.ClientID);
                    cmd.Parameters.AddWithValue("@ContactType", contact.ContactType);
                    cmd.Parameters.AddWithValue("@ContactNumber", contact.ContactNumber);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateContact(Contact contact)
        {
            // Code for updating contact into the database using SqlCommand
            string query = "UPDATE Contacts SET ContactType = @ContactType, ContactNumber = @ContactNumber WHERE ContactID = @ContactID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ContactType", contact.ContactType);
                    cmd.Parameters.AddWithValue("@ContactNumber", contact.ContactNumber);
                    cmd.Parameters.AddWithValue("@ContactID", contact.ContactID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void RemoveContact(int contactId)
        {
            // Code for removing contact into the database using SqlCommand
            string query = "DELETE FROM Contacts WHERE ContactID = @ContactID";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ContactID", contactId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
