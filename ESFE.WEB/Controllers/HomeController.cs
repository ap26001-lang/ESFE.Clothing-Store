using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ESFE.WEB.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // ==============================
        // ADMINISTRADOR
        // ==============================

        [HttpGet]
        public IActionResult AdminDashboard()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }


        // ==============================
        // VENDEDOR
        // ==============================

        [HttpGet]
        public IActionResult Catalogo()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 303)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }


        [HttpGet]
        public IActionResult Clientes()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 303)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }


        [HttpGet]
        public IActionResult PuntoDeVenta()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 303)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }


        [HttpGet]
        public IActionResult HistorialVentas()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 303)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }


        [HttpGet]
        public IActionResult Reportes()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 303)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }


        [HttpGet]
        public IActionResult Bitacora()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 303)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }


        [HttpGet]
        public IActionResult Respaldos()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 303)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }


        // ==============================
        // CLIENTE
        // 202 = Cliente
        // ==============================

        [HttpGet]
        public IActionResult Cliente()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 202)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.Usuario =
                HttpContext.Session.GetString("Usuario")
                ?? "Cliente";

            return View();
        }
    }
}