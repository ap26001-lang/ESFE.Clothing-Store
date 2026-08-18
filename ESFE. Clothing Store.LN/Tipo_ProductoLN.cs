using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class Tipo_ProductoLN
    {
        public int Insertar(Tipo_Producto entidad)
        {
            return TipoProductoDAL.Insertar(entidad);
        }

        public int Actualizar(Tipo_Producto entidad)
        {
            return TipoProductoDAL.Actualizar(entidad);
        }

        public int Eliminar(int idTipoProducto)
        {
            return TipoProductoDAL.Eliminar(idTipoProducto);
        }

        public List<Tipo_Producto> ObtenerTodos()
        {
            return TipoProductoDAL.ObtenerTodos();
        }

        public Tipo_Producto ObtenerPorId(int idTipoProducto)
        {
            return TipoProductoDAL.ObtenerPorId(idTipoProducto);
        }
    }
}
