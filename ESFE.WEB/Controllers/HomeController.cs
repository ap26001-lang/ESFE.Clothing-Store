using Microsoft.AspNetCore.Mvc;

namespace ESFE.WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // POST: Procesar Inicio de Sesión
        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            // Validación de credenciales para Administrador
            if (Email == "admin@maisonelite.com" && Password == "Admin123")
            {
                // Redirecciona al panel de administración
                return RedirectToAction("AdminDashboard");
            }

            ViewBag.Error = "Credenciales incorrectas.";
            return View("Index");
        }

        // VISTA: Panel de Control del Administrador
        public IActionResult AdminDashboard()
        {
            return View();
        }
    }
}