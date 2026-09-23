using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ESFE._Clothing_Store.DAL;
using ESFE.Clothing_Store_limpio.Models;

namespace ESFE.Clothing_Store_limpio.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Catalogo()
        {
            // Obtener todos los productos de la BD
            List<Producto> listaProductos = ObtenerProductos();
            return View(listaProductos);
        }

        private List<Producto> ObtenerProductos()
        {
            var listaProductos = new List<Producto>();

            try
            {
                // Usar el DAL para obtener productos
                var productosDAL = ProductosDAL.ObtenerTodos();

                foreach (var prod in productosDAL)
                {
                    listaProductos.Add(new Producto
                    {
                        Codigo_Produc = prod.CodigoProducto,
                        Nombre_Produc = prod.NombreProducto,
                        Precio = decimal.TryParse(prod.precio, out var p) ? p : 0,
                        id_Tipo_Produc = prod.idTipoProducto,
                        id_tallas = prod.idtallas,
                        id_Tela = prod.idtelas,
                        id_Color = prod.idcolor
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener productos: {ex.Message}");
            }

            return listaProductos;
        }

        public IActionResult Clientes()
        {
            return View();
        }

        public IActionResult PuntoVenta()
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
