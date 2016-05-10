using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Do.Web.Backend.Controllers;

namespace Do.Web.Backend.Areas.Website.Controllers
{
    public class UserController : BaseController
    {
        // GET: Website/User
        public ActionResult Index()
        {
            return View();
        }
    }
}