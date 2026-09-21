using System;
using System.Collections.Generic;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.LN
{
    public class UsuarioLN
    {
        // Instancia global de la capa de acceso a datos
        private readonly UsuarioDAL _usuarioDAL = new UsuarioDAL();

        public Usuario ValidarLogin(string correo, string clave)
        {
            return _usuarioDAL.ValidarLogin(correo, clave);
        }

        public Usuario ObtenerPorCorreo(string correo)
        {
            return _usuarioDAL.ObtenerPorCorreo(correo);
        }

        public int ObtenerSiguienteId()
        {
            return _usuarioDAL.ObtenerSiguienteId();
        }

        public int AgregarUsuario(Usuario pUsuario)
        {
            // Asignar el ID autogenerado
            pUsuario.id_Usuario = _usuarioDAL.ObtenerSiguienteId();

            // Regla de Negocio: Asignación automática de id_Rol según el correo
            if (pUsuario.correo.StartsWith("admin", StringComparison.OrdinalIgnoreCase))
            {
                pUsuario.id_Rol = 101; // Rol Administrador
            }
            else if (pUsuario.correo.EndsWith("@maisonelite.com", StringComparison.OrdinalIgnoreCase))
            {
                pUsuario.id_Rol = 303; // Rol Vendedor
            }
            else
            {
                pUsuario.id_Rol = 202; // Rol Cliente
            }

            return _usuarioDAL.AgregarUsuario(pUsuario);
        }

        public List<Usuario> ObtenerTodos()
        {
            return _usuarioDAL.ObtenerTodos();
        }

        public Usuario ObtenerPorId(int id)
        {
            return _usuarioDAL.ObtenerPorId(id);
        }
    }
}