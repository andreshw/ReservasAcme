using ReservasAcme.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservasAcme.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session[Constantes.SessionUsuario] == null)
            {
                return new RedirectResult("seguridad/login");
            }
            else
            {
                return View();
            }
        }
    }
}
