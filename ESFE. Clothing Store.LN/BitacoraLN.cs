using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class BitacoraLN
    {
        public int Insertar(Bitacora entidad)
        {
            return BitacoraDAL.Insertar(entidad);
        }

        public List<Bitacora> ObtenerTodos()
        {
            return BitacoraDAL.ObtenerTodos();
        }

        public List<Bitacora> ObtenerPorUsuario(int idUsuario)
        {
            return BitacoraDAL.ObtenerPorUsuario(idUsuario);
        }
    }
}

