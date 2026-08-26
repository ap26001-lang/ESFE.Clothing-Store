using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class RolesLN
    {
        public int Insertar(Roles entidad)
        {
            return RolesDAL.Insertar(entidad);
        }

        public int Actualizar(Roles entidad)
        {
            return RolesDAL.Actualizar(entidad);
        }

        public int Eliminar(int idRol)
        {
            return RolesDAL.Eliminar(idRol);
        }

        public List<Roles> ObtenerTodos()
        {
            return RolesDAL.ObtenerTodos();
        }

        public Roles ObtenerPorId(int idRol)
        {
            return RolesDAL.ObtenerPorId(idRol);
        }
    }
}
