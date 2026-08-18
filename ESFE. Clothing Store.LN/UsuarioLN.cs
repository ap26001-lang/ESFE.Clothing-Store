using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class UsuarioLN
    {
        public int Insertar(Usuario entidad)
        {
            return UsuarioDAL.Insertar(entidad);
        }

        public int Actualizar(Usuario entidad)
        {
            return UsuarioDAL.Actualizar(entidad);
        }

        public int Eliminar(int idUsuario)
        {
            return UsuarioDAL.Eliminar(idUsuario);
        }

        public List<Usuario> ObtenerTodos()
        {
            return UsuarioDAL.ObtenerTodos();
        }

        public Usuario ObtenerPorId(int idUsuario)
        {
            return UsuarioDAL.ObtenerPorId(idUsuario);
        }
    }
}
