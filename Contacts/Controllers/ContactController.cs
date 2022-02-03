using Contacts.EfStuff.DbModel;
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
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _contactRepository.Save(contact);
            return RedirectToAction("Index");
        }
        public IActionResult Remove(long Id)
        {
            _contactRepository.Remove(Id);
            return RedirectToAction("Index");
        }

    }
}
