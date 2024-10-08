using DataAccessLayer;
using System.Collections.Generic;
using System.Configuration;

namespace BusinessLogicLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ClientService : IClientService
    {
        private ClientContext _clientContext;
        private readonly string _connectionString;

        public ClientService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            _clientContext = new ClientContext(_connectionString);
        }

        public Client GetClientById(int clientId)
        {
           return _clientContext.GetClientById(clientId);
        }

        public void AddClient(Client client)
        {
            _clientContext.AddClient(client);
        }

        public void RemoveClient(int clientId)
        {
            _clientContext.RemoveClient(clientId);
        }

        public void UpdateClient(Client client)
        {
            _clientContext.UpdateClient(client);
        }

        public List<Client> GetClientList() 
        {
            return _clientContext.GetClientList();
        }
    }
}
