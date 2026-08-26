using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class ProductosLN
    {
        public int Insertar(Productos entidad)
        {
            return ProductosDAL.Insertar(entidad);
        }

        public int Actualizar(Productos entidad)
        {
            return ProductosDAL.Actualizar(entidad);
        }

        public int Eliminar(string codigoProducto)
        {
            return ProductosDAL.Eliminar(codigoProducto);
        }

        public List<Productos> ObtenerTodos()
        {
            return ProductosDAL.ObtenerTodos();
        }

        public Productos ObtenerPorId(string codigoProducto)
        {
            return ProductosDAL.ObtenerPorId(codigoProducto);
        }
    }
}
