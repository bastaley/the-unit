using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheUnit.Controllers
{
    [Authorize(Roles = "Staff,Admin")]
    public class CMSController : Controller
    {
        // GET: CMS
        public ActionResult Index()
        {
            return View();
        }
    }
}