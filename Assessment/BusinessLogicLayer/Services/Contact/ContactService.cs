using DataAccessLayer;
using System.Configuration;

namespace BusinessLogicLayer.Services
{
    public class ContactService : IContactService
    {
        private ContactContext _contactContext;
        private readonly string _connectionString;

        public ContactService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            _contactContext = new ContactContext(_connectionString);
        }

        public void AddContact(Contact contact)
        {
            _contactContext.AddContact(contact);
        }

        public void RemoveContact(int contactId)
        {
            _contactContext.RemoveContact(contactId);
        }

        public void UpdateContact(Contact contact)
        {
            _contactContext.UpdateContact(contact);
        }
    }
}
