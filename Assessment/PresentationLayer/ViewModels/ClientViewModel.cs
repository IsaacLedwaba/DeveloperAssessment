using System.Collections.Generic;

namespace PresentationLayer.ViewModels
{
    public class ClientViewModel
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string Gender { get; set; }
        public string OtherDetails { get; set; }

        public List<AddressViewModel> Addresses { get; set; } = new List<AddressViewModel>();
        public List<ContactViewModel> Contacts { get; set; } = new List<ContactViewModel>();
    }
}