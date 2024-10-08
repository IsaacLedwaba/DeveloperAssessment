using DataAccessLayer;
using System.ServiceModel;

namespace BusinessLogicLayer.Services
{
    [ServiceContract]
    public interface IContactService
    {
        [OperationContract]
        void AddContact(Contact contact);

        [OperationContract]
        void UpdateContact(Contact contact);

        [OperationContract]
        void RemoveContact(int contactId);
    }
}
