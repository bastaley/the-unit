using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheUnit.Models;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace TheUnit.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        // GET: 
        [AllowAnonymous]
        public ActionResult _LoginPartial(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return PartialView();
        }
    }
}