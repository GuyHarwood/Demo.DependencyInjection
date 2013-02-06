using System.Web.Mvc;

namespace Infonetica.ContactApp.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Contact");
        }

    }
}
