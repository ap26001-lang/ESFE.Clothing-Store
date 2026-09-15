using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ESFE._Clothing_Store.LN; // Si te marca rojo este, cámbialo por: using ESFE.LN;
using ESFE._Clothing_Store.EN; // Si te marca rojo este, cámbialo por: using ESFE.EN;

namespace ESFE.WEB.Controllers
{
    public class LoginController : Controller
    {
        private readonly UsuarioLN _usuarioLN = new UsuarioLN();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string correo, string clave)
        {
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave))
            {
                ViewBag.Mensaje = "Por favor ingrese su correo y contraseña.";
                return View();
            }

            var usuario = _usuarioLN.ValidarLogin(correo, clave);

            if (usuario != null)
            {
                HttpContext.Session.SetString("Usuario", usuario.usuario ?? "");
                HttpContext.Session.SetInt32("IdUsuario", usuario.id_Usuario);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Mensaje = "Correo o contraseña incorrectos.";
            return View();
        }

        [HttpPost]
        public IActionResult SimularGoogleLogin()
        {
            HttpContext.Session.SetString("Usuario", "Usuario Google");
            return RedirectToAction("Index", "Home");
        }
    }
}