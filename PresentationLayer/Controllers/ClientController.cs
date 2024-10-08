using PresentationLayer.AssessmentService;
using PresentationLayer.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PresentationLayer.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController()
        {
            _clientService = new ClientServiceClient();
        }

        // GET: Client
        public ActionResult ClientList()
        {
            var clients = _clientService.GetClientList();

            List<ClientViewModel> clientViewModels = new List<ClientViewModel>();

            foreach (var client in clients)
            {
                clientViewModels.Add(new ClientViewModel
                {
                    ClientID = client.ClientID,
                    ClientName = client.ClientName,
                    Gender = client.Gender,
                    OtherDetails = client.OtherDetails
                });
            }

            return View(clientViewModels);
        }

        // GET: Client/Create
        public ActionResult ClientCreate()
        {
            return View(new ClientViewModel());
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult ClientCreate(ClientViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    // Convert the view model to the actual Client, Address, and Contact models.
                    Client client = new Client
                    {
                        ClientName = model.ClientName,
                        OtherDetails = model.OtherDetails,
                        Gender = model.Gender,
                        Addresses = model.Addresses.Select(a => new Address
                        {
                            AddressType = a.AddressType,
                            Street = a.Street,
                            City = a.City,
                            PostalCode = a.PostalCode
                        }).ToArray(),
                        Contacts = model.Contacts.Select(c => new Contact
                        {
                            ContactType = c.ContactType,
                            ContactNumber = c.ContactNumber
                        }).ToArray()
                    };

                    _clientService.AddClient(client);

                    return RedirectToAction("ClientList");
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult ClientEdit(int id)
        {
            var client = _clientService.GetClientById(id);

            var model = new ClientViewModel
            {
                ClientID = client.ClientID,
                ClientName = client.ClientName,
                Gender = client.Gender,
                OtherDetails = client.OtherDetails
            };

            model.Addresses = client.Addresses.Select(a => new AddressViewModel {
                AddressType = a.AddressType,
                Street = a.Street,
                City = a.City,
                PostalCode = a.PostalCode
            }).ToList();
            model.Contacts = client.Contacts.Select(c => new ContactViewModel {
                ContactType = c.ContactType,
                ContactNumber = c.ContactNumber
            }).ToList();

            return View(model);
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult ClientEdit(ClientViewModel model)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var updatedClient = new Client
                    {
                        ClientID = model.ClientID,
                        ClientName = model.ClientName,
                        Gender = model.Gender,
                        OtherDetails = model.OtherDetails
                    };

                    _clientService.UpdateClient(updatedClient);

                    return RedirectToAction("ClientList");
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult ClientDelete(int id)
        {
            var client = _clientService.GetClientById(id);

            var model = new ClientViewModel
            {
                ClientID = client.ClientID,
                ClientName = client.ClientName,
                Gender = client.Gender,
                OtherDetails = client.OtherDetails
            };

            return View(model);
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult DeleteClient(int id)
        {
            try
            {
                // TODO: Add delete logic here
                _clientService.RemoveClient(id);

                return RedirectToAction("ClientList");
            }
            catch
            {
                return View();
            }
        }
    }
}
