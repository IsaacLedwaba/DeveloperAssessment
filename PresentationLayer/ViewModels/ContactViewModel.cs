using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentationLayer.ViewModels
{
    public class ContactViewModel
    {
        public int ContactID { get; set; }
        public string ContactType { get; set; }
        public string ContactNumber { get; set; }
    }
}