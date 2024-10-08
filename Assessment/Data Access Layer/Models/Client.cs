using System.Collections.Generic;

namespace DataAccessLayer
{
    public class Client
    {
        public int ClientID { get; set; }

        public string ClientName { get; set; }

        public string Gender { get; set; }

        public string OtherDetails { get; set; }

        // Collection for multiple addresses
        public List<Address> Addresses { get; set; }

        // Collection for multiple contacts
        public List<Contact> Contacts { get; set; }

        public Client()
        {
            Addresses = new List<Address>();
            Contacts = new List<Contact>();
        }
    }
}
