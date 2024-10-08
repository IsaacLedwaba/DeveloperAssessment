using DataAccessLayer;
using System.Configuration;

namespace BusinessLogicLayer.Services
{
    public class AddressService : IAddressService
    {
        private AddressContext _addressContext;
        private readonly string _connectionString;

        public AddressService() 
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            _addressContext = new AddressContext(_connectionString);
        }
         
        public void AddAddress(Address address)
        {
            _addressContext.AddAddress(address);
        }

        public void RemoveAddress(int addressId)
        {
            _addressContext.RemoveAddress(addressId);
        }

        public void UpdateAddress(Address address)
        {
            _addressContext.UpdateAddress(address);
        }
    }
}
