using Contacts.EfStuff.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controllers
{
    public class ContactController : Controller
    {
        private ContactRepository _contactRepository;
        public ContactController(ContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        
        public IActionResult Index()
        {
            var contacts = _contactRepository.GetAll();
            return View(contacts);
        }


    }
}
