using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class VentasLN
    {
        public int Insertar(Ventas entidad)
        {
            return VentasDAL.Insertar(entidad);
        }

        public int Actualizar(Ventas entidad)
        {
            return VentasDAL.Actualizar(entidad);
        }

        public int Eliminar(string codigoVenta)
        {
            return VentasDAL.Eliminar(codigoVenta);
        }

        public List<Ventas> ObtenerTodos()
        {
            return VentasDAL.ObtenerTodos();
        }

        public Ventas ObtenerPorCodigo(string codigoVenta)
        {
            return VentasDAL.ObtenerPorCodigo(codigoVenta);
        }
    }
}
