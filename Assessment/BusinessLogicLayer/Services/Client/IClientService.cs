using DataAccessLayer;
using System.Collections.Generic;
using System.ServiceModel;

namespace BusinessLogicLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        Client GetClientById(int clientId);

        [OperationContract]
        void AddClient(Client client);

        [OperationContract]
        void RemoveClient(int clientId);

        [OperationContract]
        void UpdateClient(Client client);

        [OperationContract]
        List<Client> GetClientList();
    }
}
