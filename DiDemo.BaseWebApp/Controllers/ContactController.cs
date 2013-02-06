using System.Web.Mvc;
using Domain.Models;
using Domain.Services;
using Infonetica.ContactApp.UI.Web.Models;

namespace Infonetica.ContactApp.UI.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactLister _contactLister;
        private readonly IContactCreator _contactCreator;

        public ContactController(IContactLister contactLister, IContactCreator contactCreator)
        {
            _contactLister = contactLister;
            _contactCreator = contactCreator;
        }

        public ActionResult Index()
        {
            var list = _contactLister.GetList();
            return View(new ContactIndexModel()
                {
                    Contacts = list
                });
        }

        public ActionResult Add()
        {
            return View(new ContactAddModel());
        }

        [HttpPost]
        public ActionResult Add(ContactAddModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var contact = new Contact()
                {
                    Name = model.Name
                };
            _contactCreator.Create(contact);
            return RedirectToAction("Index");
        }

    }
}
