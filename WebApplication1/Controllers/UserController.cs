using System.Web.Mvc;

namespace Do.Web.Backend.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
    }
}