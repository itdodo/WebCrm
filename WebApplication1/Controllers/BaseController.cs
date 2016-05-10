using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Do.Web.Backend.Fliter;

namespace Do.Web.Backend.Controllers
{
    [CustomAuthorize]
    public class BaseController : Controller
    {

         public BaseController()
        {
            //if(HttpContext==null)
            //    RedirectToAction("Login", "Home");
            //if (HttpContext.Request==null)
            // {
            //     RedirectToAction("Login", "Home");
            // }
            //Response.Write(HttpContext.User.Identity.IsAuthenticated);
        }

    }
}