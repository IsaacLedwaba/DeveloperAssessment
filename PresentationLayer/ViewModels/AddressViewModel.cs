using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.ViewModels
{
    public class AddressViewModel
    {
        public int AddressID { get; set; }
        public string AddressType { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}