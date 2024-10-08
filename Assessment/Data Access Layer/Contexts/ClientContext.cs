using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ClientContext
    {
        private string _connectionString;

        public ClientContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddClient(Client client)
        {
            // Code for inserting client into the database using SqlCommand
            string query = "INSERT INTO Clients (ClientName, Gender, OtherDetails) VALUES (@ClientName, @Gender, @OtherDetails); SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                        cmd.Parameters.AddWithValue("@Gender", client.Gender.ToString());
                        cmd.Parameters.AddWithValue("@OtherDetails", client.OtherDetails);

                        connection.Open();
                        // Get the ClientID of the inserted client
                        client.ClientID = Convert.ToInt32(cmd.ExecuteScalar());

                        // Insert addresses
                        foreach (var address in client.Addresses)
                        {
                            string addressQuery = @"INSERT INTO Addresses (ClientId, AddressType, Street, City, PostalCode) 
                                            VALUES (@ClientId, @AddressType, @Street, @City, @PostalCode)";

                            using (SqlCommand command = new SqlCommand(addressQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ClientId", client.ClientID);
                                command.Parameters.AddWithValue("@AddressType", address.AddressType);
                                command.Parameters.AddWithValue("@Street", address.Street);
                                command.Parameters.AddWithValue("@City", address.City);
                                command.Parameters.AddWithValue("@PostalCode", address.PostalCode);

                                command.ExecuteNonQuery();
                            }
                        }

                        // Insert contacts
                        foreach (var contact in client.Contacts)
                        {
                            string contactQuery = @"INSERT INTO Contacts (ClientId, ContactType, ContactValue) 
                                            VALUES (@ClientId, @ContactType, @ContactValue)";

                            using (SqlCommand command = new SqlCommand(contactQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ClientId", client.ClientID);
                                command.Parameters.AddWithValue("@ContactType", contact.ContactType);
                                command.Parameters.AddWithValue("@ContactValue", contact.ContactNumber);

                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    throw new Exception("Error retrieving client data", ex);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void UpdateClient(Client client)
        {
            // Code for updating client into the database using SqlCommand
            string query = "UPDATE Clients SET ClientName = @ClientName, Gender = @Gender, OtherDetails = @OtherDetails WHERE ClientID = @ClientID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                        cmd.Parameters.AddWithValue("@Gender", client.Gender);  // Convert enum to string
                        cmd.Parameters.AddWithValue("@OtherDetails", client.OtherDetails);
                        cmd.Parameters.AddWithValue("@ClientID", client.ClientID);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    // Update addresses
                    foreach (var address in client.Addresses)
                    {
                        if (address.AddressID > 0) // Existing address
                        {
                            string addressQuery = @"UPDATE Addresses 
                                        SET AddressType = @AddressType, Street = @Street, City = @City, PostalCode = @PostalCode 
                                        WHERE AddressId = @AddressId";

                            using (SqlCommand command = new SqlCommand(addressQuery, connection))
                            {
                                command.Parameters.AddWithValue("@AddressId", address.AddressID);
                                command.Parameters.AddWithValue("@AddressType", address.AddressType);
                                command.Parameters.AddWithValue("@Street", address.Street);
                                command.Parameters.AddWithValue("@City", address.City);
                                command.Parameters.AddWithValue("@PostalCode", address.PostalCode);

                                command.ExecuteNonQuery();
                            }
                        }
                        else // New address
                        {
                            string addressQuery = @"INSERT INTO Addresses (ClientId, AddressType, Street, City, PostalCode) 
                                        VALUES (@ClientId, @AddressType, @Street, @City, @PostalCode)";

                            using (SqlCommand command = new SqlCommand(addressQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ClientId", client.ClientID);
                                command.Parameters.AddWithValue("@AddressType", address.AddressType);
                                command.Parameters.AddWithValue("@Street", address.Street);
                                command.Parameters.AddWithValue("@City", address.City);
                                command.Parameters.AddWithValue("@PostalCode", address.PostalCode);

                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    // Update contacts
                    foreach (var contact in client.Contacts)
                    {
                        if (contact.ContactID > 0) // Existing contact
                        {
                            string contactQuery = @"UPDATE Contacts 
                                        SET ContactType = @ContactType, ContactValue = @ContactValue 
                                        WHERE ContactId = @ContactId";

                            using (SqlCommand command = new SqlCommand(contactQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ContactId", contact.ContactID);
                                command.Parameters.AddWithValue("@ContactType", contact.ContactType);
                                command.Parameters.AddWithValue("@ContactValue", contact.ContactNumber);

                                command.ExecuteNonQuery();
                            }
                        }
                        else // New contact
                        {
                            string contactQuery = @"INSERT INTO Contacts (ClientId, ContactType, ContactValue) 
                                        VALUES (@ClientId, @ContactType, @ContactValue)";

                            using (SqlCommand command = new SqlCommand(contactQuery, connection))
                            {
                                command.Parameters.AddWithValue("@ClientId", client.ClientID);
                                command.Parameters.AddWithValue("@ContactType", contact.ContactType);
                                command.Parameters.AddWithValue("@ContactValue", contact.ContactNumber);

                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    throw new Exception("Error retrieving client data", ex);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void RemoveClient(int clientId)
        {
            // Code for removing client into the database using SqlCommand
            string query = "DELETE FROM Clients WHERE ClientID = @ClientID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ClientID", clientId);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    throw new Exception("Error retrieving client data", ex);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public List<Client> GetClientList()
        {
            return new List<Client>();
        }

        public Client GetClientById(int clientId)
        {
            Client client = null;

            string query = @"SELECT ClientId, FirstName, LastName, Gender, DateOfBirth FROM Clients WHERE ClientId = @ClientId";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query))
                    {
                        command.Parameters.AddWithValue("@ClientId", clientId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                client = new Client
                                {
                                    ClientID = Convert.ToInt32(reader["ClientId"]),
                                    ClientName = reader["FirstName"].ToString(),
                                    OtherDetails = reader["LastName"].ToString()
                                };
                            }
                        }
                    }

                    // Fetch addresses
                    if (client != null)
                    {
                        string addressQuery = "SELECT AddressId, AddressType, Street, City, PostalCode FROM Addresses WHERE ClientId = @ClientId";
                        using (SqlCommand command = new SqlCommand(addressQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ClientId", clientId);
                            using (SqlDataReader addressReader = command.ExecuteReader())
                            {
                                while (addressReader.Read())
                                {
                                    var address = new Address
                                    {
                                        AddressID = Convert.ToInt32(addressReader["AddressId"]),
                                        AddressType = addressReader["AddressType"].ToString(),
                                        Street = addressReader["Street"].ToString(),
                                        City = addressReader["City"].ToString(),
                                        PostalCode = addressReader["PostalCode"].ToString()
                                    };
                                    client.Addresses.Add(address);
                                }
                            }
                        }

                        // Fetch contacts
                        string contactQuery = "SELECT ContactId, ContactType, ContactValue FROM Contacts WHERE ClientId = @ClientId";
                        using (SqlCommand command = new SqlCommand(contactQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ClientId", clientId);
                            using (SqlDataReader contactReader = command.ExecuteReader())
                            {
                                while (contactReader.Read())
                                {
                                    var contact = new Contact
                                    {
                                        ContactID = Convert.ToInt32(contactReader["ContactId"]),
                                        ContactType = contactReader["ContactType"].ToString(),
                                        ContactNumber = contactReader["ContactNumber"].ToString()
                                    };
                                    client.Contacts.Add(contact);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception
                    throw new Exception("Error retrieving client data", ex);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return client;
        }
    }
}
