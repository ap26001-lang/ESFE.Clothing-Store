using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Linq;
using System.Text.Json;
using ESFE._Clothing_Store.EN;
using ESFE._Clothing_Store.LN;

namespace ESFE.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductosLN _productosLN = new ProductosLN();
        private readonly ClientesLN _clientesLN = new ClientesLN();
        private readonly VentasLN _ventasLN = new VentasLN();
        private readonly BitacoraLN _bitacoraLN = new BitacoraLN();
        private readonly UsuarioLN _usuarioLN = new UsuarioLN();
        private readonly Tipo_ProductoLN _tipoProductoLN = new Tipo_ProductoLN();
        private readonly TallasLN _tallasLN = new TallasLN();
        private readonly TelaLN _telaLN = new TelaLN();
        private readonly ColorLN _colorLN = new ColorLN();

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

        [HttpPost]
        public IActionResult FinalizarVentaAdmin(int id_cliente, string productosSeleccionados)
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            if (!string.IsNullOrWhiteSpace(productosSeleccionados) && id_cliente > 0)
            {
                var codigos = productosSeleccionados
                    .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                    .ToList();

                var productos = _productosLN.ObtenerTodos();

                foreach (var codigo in codigos)
                {
                    var producto = productos.FirstOrDefault(p => p.CodigoProducto == codigo);
                    if (producto == null)
                    {
                        continue;
                    }

                    var venta = new Ventas
                    {
                        Codigo_de_Venta = $"VTA-{DateTime.Now:yyyyMMddHHmmssfff}-{Guid.NewGuid().ToString("N")[..4].ToUpper()}",
                        Fecha_y_Hora = DateTime.Now,
                        Cantidad_de_productos = 1,
                        id_Tipo_Producto = producto.idTipoProducto,
                        id_cliente = id_cliente
                    };

                    _ventasLN.Insertar(venta);
                }
            }

            return RedirectToAction("AdminPuntoDeVenta");
        }

        [HttpPost]
        public IActionResult EditarCliente(int id_cliente, string Nombre, string Dui, string Correo, string Telefono, int id_rol, int id_permiso, int id_estado)
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            var cliente = new Clientes
            {
                id_cliente = id_cliente,
                Nombre = Nombre,
                Dui = Dui,
                Correo = Correo,
                Telefono = Telefono,
                id_rol = id_rol,
                id_permiso = id_permiso,
                id_estado = id_estado
            };

            _clientesLN.Actualizar(cliente);

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

        // POST: Recibir y procesar el guardado de nueva prenda desde el modal
        [HttpPost]
        public IActionResult GuardarPrenda(string Codigo_Product, string Nombre_Produc, decimal Precio)
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            var producto = new Productos
            {
                CodigoProducto = Codigo_Product,
                NombreProducto = Nombre_Produc,
                precio = Precio.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture),
                idTipoProducto = 1,
                idtallas = 1,
                idtelas = 1,
                idcolor = 1
            };

            _productosLN.Insertar(producto);

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
        public IActionResult GuardarCliente(string Nombre, string Dui, string Correo, string Telefono)
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            var cliente = new Clientes
            {
                Nombre = Nombre,
                Dui = Dui,
                Correo = Correo,
                Telefono = Telefono,
                id_rol = 202,
                id_permiso = 1,
                id_estado = 2
            };

            _clientesLN.Insertar(cliente);

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

            ViewBag.TiposProducto = _tipoProductoLN.ObtenerTodos();
            ViewBag.Tallas = _tallasLN.ObtenerTodos();
            ViewBag.Telas = _telaLN.ObtenerTodos();
            ViewBag.Colores = _colorLN.ObtenerTodos();

            var productos = _productosLN.ObtenerTodos();

            return View("AdminCatalogo", productos);
        }

        [HttpGet]
        public IActionResult AdminClientes()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            var clientes = _clientesLN.ObtenerTodos();

            return View("AdminClientes", clientes);
        }

        [HttpGet]
        public IActionResult AdminPuntoDeVenta()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.Clientes = _clientesLN.ObtenerTodos();
            var productos = _productosLN.ObtenerTodos();

            return View("AdminPuntoDeVenta", productos);
        }

        [HttpGet]
        public IActionResult AdminHistorialVentas()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.Clientes = _clientesLN.ObtenerTodos();
            var ventas = _ventasLN.ObtenerTodos();

            return View("AdminHistorialVentas", ventas);
        }

        [HttpGet]
        public IActionResult AdminBitacora()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            var bitacora = _bitacoraLN.ObtenerTodos()
                .OrderByDescending(item => item.Fecha_y_hora)
                .ToList();

            var usuarios = _usuarioLN.ObtenerTodos()
                .GroupBy(u => u.id_Usuario)
                .Select(g => g.First())
                .ToDictionary(u => u.id_Usuario, u => u.usuario ?? $"Usuario #{u.id_Usuario}");

            ViewBag.UsuariosBitacora = usuarios;

            return View("AdminBitacora", bitacora);
        }

        [HttpGet]
        public IActionResult AdminRespaldos()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            var rutaBackups = Path.Combine(Directory.GetCurrentDirectory(), "Backups");
            Directory.CreateDirectory(rutaBackups);

            var respaldos = new DirectoryInfo(rutaBackups)
                .GetFiles("*.bak", SearchOption.TopDirectoryOnly)
                .OrderByDescending(file => file.LastWriteTime)
                .ToList();

            var nombreArchivoSeleccionado = Request.Query["nombreArchivo"].ToString();

            if (!string.IsNullOrWhiteSpace(nombreArchivoSeleccionado) && nombreArchivoSeleccionado.IndexOfAny(Path.GetInvalidFileNameChars()) < 0)
            {
                var rutaArchivoSeleccionado = Path.Combine(rutaBackups, nombreArchivoSeleccionado);

                if (System.IO.File.Exists(rutaArchivoSeleccionado))
                {
                    ViewBag.NombreRespaldoSeleccionado = nombreArchivoSeleccionado;
                    ViewBag.ContenidoRespaldo = System.IO.File.ReadAllText(rutaArchivoSeleccionado);
                }
            }

            return View("AdminRespaldos", respaldos);
        }

        [HttpGet]
        public IActionResult DescargarRespaldo(string nombreArchivo)
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            if (string.IsNullOrWhiteSpace(nombreArchivo) || nombreArchivo.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                return NotFound();
            }

            var rutaBackups = Path.Combine(Directory.GetCurrentDirectory(), "Backups");
            var rutaArchivo = Path.Combine(rutaBackups, nombreArchivo);

            if (!System.IO.File.Exists(rutaArchivo))
            {
                return NotFound();
            }

            var contenido = System.IO.File.ReadAllBytes(rutaArchivo);
            return File(contenido, "application/octet-stream", nombreArchivo);
        }

        [HttpPost]
        public IActionResult CrearRespaldo()
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            var rutaBackups = Path.Combine(Directory.GetCurrentDirectory(), "Backups");
            Directory.CreateDirectory(rutaBackups);

            var fecha = DateTime.Now;
            var nombreArchivo = $"backup_maison_{fecha:yyyyMMdd_HHmmss}.bak";
            var rutaArchivo = Path.Combine(rutaBackups, nombreArchivo);

            var respaldo = new
            {
                GeneradoEn = fecha,
                Usuarios = _usuarioLN.ObtenerTodos(),
                Clientes = _clientesLN.ObtenerTodos(),
                Productos = _productosLN.ObtenerTodos(),
                Ventas = _ventasLN.ObtenerTodos(),
                Bitacora = _bitacoraLN.ObtenerTodos()
            };

            var contenido = JsonSerializer.Serialize(respaldo, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            System.IO.File.WriteAllText(rutaArchivo, contenido);
            TempData["MensajeRespaldo"] = $"Respaldo creado: {nombreArchivo}";

            return RedirectToAction("AdminRespaldos");
        }

        [HttpPost]
        public IActionResult EliminarRespaldo(string nombreArchivo)
        {
            var rol = HttpContext.Session.GetInt32("Rol");

            if (rol != 101)
            {
                return RedirectToAction("Index", "Login");
            }

            if (string.IsNullOrWhiteSpace(nombreArchivo) || nombreArchivo.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                return NotFound();
            }

            var rutaBackups = Path.Combine(Directory.GetCurrentDirectory(), "Backups");
            var rutaArchivo = Path.Combine(rutaBackups, nombreArchivo);

            if (!System.IO.File.Exists(rutaArchivo))
            {
                return NotFound();
            }

            System.IO.File.Delete(rutaArchivo);
            TempData["MensajeRespaldo"] = $"Respaldo eliminado: {nombreArchivo}";

            return RedirectToAction("AdminRespaldos");
        }
    }
}