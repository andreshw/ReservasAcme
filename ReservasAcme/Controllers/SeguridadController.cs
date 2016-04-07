using ReservasAcme.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReservasAcme.Controllers
{
    public class SeguridadController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidarInformacionUsuario(string nombreUsuario, string clave)
        {
            Session[Constantes.SessionUsuario] = nombreUsuario;
            return new RedirectResult("/home");
        }
    }
}
