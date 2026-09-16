using Microsoft.AspNetCore.Mvc;

namespace ESFE.WEB.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: Procesar Inicio de Sesión Tradicional
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string Email, string Password)
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                ViewBag.Error = "Por favor, ingresa tu correo y contraseña.";
                return View("Index");
            }

            // Comprobación de administrador en memoria
            if (Email == "admin@maisonelite.com" && Password == "Admin123")
            {
                return RedirectToAction("AdminDashboard");
            }

            // Comprobar credenciales en la base de datos
            ESFE._Clothing_Store.DAL.UsuarioDAL usuarioDAL = new ESFE._Clothing_Store.DAL.UsuarioDAL();
            var usuario = usuarioDAL.ValidarLogin(Email, Password);

            if (usuario != null)
            {
                return RedirectToAction("AdminDashboard");
            }

            ViewBag.Error = "Credenciales incorrectas.";
            return View("Index");
        }

        [HttpGet]
        public IActionResult AdminDashboard()
        {
            return View();
        }

        public IActionResult Catalogo()
        {
            return View();
        }

        public IActionResult Clientes()
        {
            return View();
        }

        public IActionResult PuntoDeVenta()
        {
            return View();
        }

        public IActionResult HistorialVentas()
        {
            return View();
        }

        public IActionResult Reportes()
        {
            return View();
        }

        public IActionResult Bitacora()
        {
            return View();
        }

        public IActionResult Respaldos()
        {
            return View();
        }
    }
}