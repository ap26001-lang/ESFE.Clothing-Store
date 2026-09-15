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

            if (Email == "admin@maisonelite.com" && Password == "Admin123")
            {
                return RedirectToAction("AdminDashboard");
            }

            ViewBag.Error = "Credenciales incorrectas.";
            return View("Index");
        }

        // POST: Simulación de Inicio de Sesión con Google
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SimularGoogleLogin()
        {
            // Guardamos datos simulados en ViewBag/TempData para mostrarlos en el Dashboard
            TempData["UsuarioSimulado"] = "Usuario de Google";
            TempData["EmailSimulado"] = "usuario.google@gmail.com";

            // Redirige directamente al panel de administración/dashboard
            return RedirectToAction("AdminDashboard");
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