using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ESFE._Clothing_Store.LN;

namespace ESFE.WEB.Controllers
{
    public class LoginController : Controller
    {
        private readonly UsuarioLN _usuarioLN = new UsuarioLN();


        // ==============================
        // LOGIN
        // ==============================

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string correo, string clave)
        {
            if (string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(clave))
            {
                ViewBag.Mensaje =
                    "Por favor ingrese su correo y contraseña.";

                return View();
            }


            try
            {
                var usuario =
                    _usuarioLN.ValidarLogin(
                        correo.Trim(),
                        clave
                    );


                if (usuario != null)
                {
                    // ==============================
                    // GUARDAR SESIÓN
                    // ==============================

                    HttpContext.Session.SetString(
                        "Usuario",
                        usuario.usuario ?? correo.Trim()
                    );

                    HttpContext.Session.SetInt32(
                        "IdUsuario",
                        usuario.id_Usuario
                    );

                    HttpContext.Session.SetInt32(
                        "Rol",
                        usuario.id_Rol
                    );


                    // ==============================
                    // 303 = VENDEDOR
                    // ==============================

                    if (usuario.id_Rol == 303)
                    {
                        return RedirectToAction(
                            "Catalogo",
                            "Home"
                        );
                    }


                    // ==============================
                    // 101 = ADMINISTRADOR
                    // ==============================

                    if (usuario.id_Rol == 101)
                    {
                        return RedirectToAction(
                            "AdminDashboard",
                            "Home"
                        );
                    }


                    // ==============================
                    // 202 = CLIENTE
                    // ==============================

                    if (usuario.id_Rol == 202)
                    {
                        return RedirectToAction(
                            "Cliente",
                            "Home"
                        );
                    }


                    // ==============================
                    // ROL NO CONFIGURADO
                    // ==============================

                    ViewBag.Mensaje =
                        "El usuario existe, pero su panel todavía no está disponible.";

                    return View();
                }

                // Si la validación falla, comprobar si el correo existe para dar
                // un mensaje más preciso sin cambiar el diseño de la vista.
                var usuarioExistente = _usuarioLN.ObtenerPorCorreo(correo.Trim());

                if (usuarioExistente != null)
                {
                    ViewBag.Mensaje = "Contraseña incorrecta.";
                }
                else
                {
                    ViewBag.Mensaje = "El correo no está registrado.";
                }

                return View();
            }
            catch (Exception)
            {
                ViewBag.Mensaje =
                    "No se pudo conectar con la base de datos. " +
                    "Verifica que SQL Server/LocalDB y TIENDA_ROPA estén disponibles.";

                return View();
            }
        }


        // ==============================
        // CERRAR SESIÓN
        // ==============================

        [HttpGet]
        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Clear();

            return RedirectToAction(
                "Index",
                "Login"
            );
        }


        // ==============================
        // LOGIN SIMULADO GOOGLE
        // ==============================

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SimularGoogleLogin()
        {
            HttpContext.Session.SetString(
                "Usuario",
                "Usuario Google"
            );

            HttpContext.Session.SetInt32(
                "Rol",
                202
            );

            return RedirectToAction(
                "Cliente",
                "Home"
            );
        }
    }
}