namespace DataAccessLayer
{
    public class Address
    {
        public int AddressID { get; set; }

        public int ClientID { get; set; }

        public string AddressType { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }
    }
}
