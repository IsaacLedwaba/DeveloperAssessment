using DataAccessLayer;
using System.ServiceModel;

namespace BusinessLogicLayer.Services
{
    [ServiceContract]
    public interface IAddressService
    {
        [OperationContract]
        void AddAddress(Address address);

        [OperationContract]
        void UpdateAddress(Address address);

        [OperationContract]
        void RemoveAddress(int addressId);
    }
}
