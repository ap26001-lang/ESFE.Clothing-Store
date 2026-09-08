using ESFE.WEB.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace ESFE.WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string Email, string Password)
        {
            // Definición de roles y usuarios de prueba con nuevos dominios (Clave: 123456)
            string nombre = "";
            string rol = "";

            if (Email == "admin@tienda.com" && Password == "123456")
            {
                nombre = "Administrador del Sistema";
                rol = "Administrador";
            }
            else if (Email == "vendedor@tienda.com" && Password == "123456")
            {
                nombre = "Carlos Rivas (Vendedor)";
                rol = "Vendedor";
            }
            else if (Email == "cliente@gmail.com" && Password == "123456")
            {
                nombre = "Sofía Mendoza (Cliente)";
                rol = "Cliente";
            }

            // Si las credenciales son válidas
            if (!string.IsNullOrEmpty(rol))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, nombre),
                    new Claim(ClaimTypes.Email, Email),
                    new Claim(ClaimTypes.Role, rol)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index");
            }

            // Si las credenciales fallan
            ViewBag.Error = "Correo o contraseña incorrectos";
            return View("Index");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}