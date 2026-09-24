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

            return View("AdminDashboard");
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

        // POST: Recibir y procesar la edición de prenda desde el modal
        [HttpPost]
        public IActionResult EditarPrenda(string Codigo_Product, string Nombre_Produc, decimal Precio)
        {
            // Aquí tus compañeros pueden conectar la llamada a la BD cuando agreguen el método de actualizar en el DAL.
            // Redirige de vuelta al panel correspondiente según el rol para mantener aislamiento.
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol == 101)
            {
                return RedirectToAction("AdminCatalogo");
            }

            if (rol == 303)
            {
                return RedirectToAction("Catalogo");
            }

            return RedirectToAction("Index", "Login");
        }

        // POST: Recibir y procesar el guardado de nueva prenda desde el modal
        [HttpPost]
        public IActionResult GuardarPrenda(string Codigo_Product, string Nombre_Produc, decimal Precio)
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol == 101)
            {
                return RedirectToAction("AdminCatalogo");
            }

            if (rol == 303)
            {
                return RedirectToAction("Catalogo");
            }

            return RedirectToAction("Index", "Login");
        }

        // POST: Recibir y procesar el registro de un nuevo cliente desde el modal
        [HttpPost]
        public IActionResult GuardarCliente(string Nombre, string Correo, string Telefono)
        {
            // Aquí tus compañeros conectarán la llamada a la BD (DAL) para guardar el cliente
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol == 101)
            {
                return RedirectToAction("AdminClientes");
            }

            if (rol == 303)
            {
                return RedirectToAction("Clientes");
            }

            return RedirectToAction("Index", "Login");
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


        // ==============================
        // ADMIN - PANEL AISLADO
        // ==============================

        [HttpGet]
        public IActionResult AdminCatalogo()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            return View("AdminCatalogo");
        }

        [HttpGet]
        public IActionResult AdminClientes()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            return View("AdminClientes");
        }

        [HttpGet]
        public IActionResult AdminPuntoDeVenta()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            return View("AdminPuntoDeVenta");
        }

        [HttpGet]
        public IActionResult AdminHistorialVentas()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            return View("AdminHistorialVentas");
        }

        [HttpGet]
        public IActionResult AdminReportes()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            return View("AdminReportes");
        }

        [HttpGet]
        public IActionResult AdminBitacora()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            return View("AdminBitacora");
        }

        [HttpGet]
        public IActionResult AdminRespaldos()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            return View("AdminRespaldos");
        }
    }
}