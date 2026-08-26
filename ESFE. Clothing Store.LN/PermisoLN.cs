using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class PermisoLN
    {
        public int Insertar(Permiso entidad)
        {
            return PermisoDAL.Insertar(entidad);
        }

        public int Actualizar(Permiso entidad)
        {
            return PermisoDAL.Actualizar(entidad);
        }

        public int Eliminar(int idPermiso)
        {
            return PermisoDAL.Eliminar(idPermiso);
        }

        public List<Permiso> ObtenerTodos()
        {
            return PermisoDAL.ObtenerTodos();
        }

        public Permiso ObtenerPorId(int idPermiso)
        {
            return PermisoDAL.ObtenerPorId(idPermiso);
        }
    }
}
