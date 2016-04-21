using System.Web.Mvc;

namespace Do.Web.Controllers.Backend
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