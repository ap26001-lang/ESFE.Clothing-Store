using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public class UsuarioDAL
    {
        public Usuario ValidarLogin(string correo, string clave)
        {
            Usuario usuario = null;
            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    // Usando las columnas reales: Correo, Clave, Usuario, id_Rol, Id_Usuario
                    cmd.CommandText = "SELECT Id_Usuario, Usuario, Correo, Clave, id_Rol FROM Usuario WHERE Correo = @correo AND Clave = @clave";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@correo"; p.Value = correo ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@clave"; p2.Value = clave ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

                    using (IDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario();
                            usuario.id_Usuario = reader["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(reader["Id_Usuario"]) : 0;
                            // Nombre de usuario real almacenado en la columna 'Usuario'
                            usuario.usuario = reader["Usuario"] != DBNull.Value ? reader["Usuario"].ToString() : string.Empty;
                            // Guardar también el correo en la propiedad 'correo'
                            usuario.correo = reader["Correo"] != DBNull.Value ? reader["Correo"].ToString() : string.Empty;
                            usuario.clave = reader["Clave"] != DBNull.Value ? reader["Clave"].ToString() : null;
                            usuario.id_Rol = reader["id_Rol"] != DBNull.Value ? Convert.ToInt32(reader["id_Rol"]) : 0;
                            usuario.Estado = true; // Por defecto ya que no existe columna estado
                        }
                    }
                }
            }

            return usuario;
        }

        public Usuario ObtenerPorCorreo(string correo)
        {
            Usuario usuario = null;

            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT Id_Usuario, Usuario, Correo, Clave, id_Rol FROM Usuario WHERE Correo = @correo";

                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@correo"; p.Value = correo ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    using (IDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario();
                            usuario.id_Usuario = reader["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(reader["Id_Usuario"]) : 0;
                            usuario.usuario = reader["Usuario"] != DBNull.Value ? reader["Usuario"].ToString() : string.Empty;
                            usuario.correo = reader["Correo"] != DBNull.Value ? reader["Correo"].ToString() : string.Empty;
                            usuario.clave = reader["Clave"] != DBNull.Value ? reader["Clave"].ToString() : null;
                            usuario.id_Rol = reader["id_Rol"] != DBNull.Value ? Convert.ToInt32(reader["id_Rol"]) : 0;
                            usuario.Estado = true;
                        }
                    }
                }
            }

            return usuario;
        }

        public int ObtenerSiguienteId()
        {
            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT ISNULL(MAX(Id_Usuario), 0) + 1 FROM Usuario";
                    cmd.CommandType = CommandType.Text;
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 1;
                }
            }
        }

        public int AgregarUsuario(Usuario usuario)
        {
            return Insertar(usuario);
        }

        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();

            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT Id_Usuario, Usuario, Correo, Clave, id_Rol FROM Usuario";

                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;

                    using (IDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario u = new Usuario();
                            u.id_Usuario = reader["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(reader["Id_Usuario"]) : 0;
                            u.usuario = reader["Usuario"] != DBNull.Value ? reader["Usuario"].ToString() : string.Empty;
                            u.correo = reader["Correo"] != DBNull.Value ? reader["Correo"].ToString() : string.Empty;
                            u.clave = reader["Clave"] != DBNull.Value ? reader["Clave"].ToString() : null;
                            u.id_Rol = reader["id_Rol"] != DBNull.Value ? Convert.ToInt32(reader["id_Rol"]) : 0;
                            u.Estado = true;

                            lista.Add(u);
                        }
                    }
                }
            }

            return lista;
        }

        public Usuario ObtenerPorId(int id)
        {
            Usuario usuario = null;

            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT Id_Usuario, Usuario, Correo, Clave, id_Rol FROM Usuario WHERE Id_Usuario = @id";

                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id"; p.Value = id; cmd.Parameters.Add(p);

                    using (IDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario();
                            usuario.id_Usuario = reader["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(reader["Id_Usuario"]) : 0;
                            usuario.usuario = reader["Usuario"] != DBNull.Value ? reader["Usuario"].ToString() : string.Empty;
                            usuario.correo = reader["Correo"] != DBNull.Value ? reader["Correo"].ToString() : string.Empty;
                            usuario.clave = reader["Clave"] != DBNull.Value ? reader["Clave"].ToString() : null;
                            usuario.id_Rol = reader["id_Rol"] != DBNull.Value ? Convert.ToInt32(reader["id_Rol"]) : 0;
                            usuario.Estado = true;
                        }
                    }
                }
            }

            return usuario;
        }

        public static int Insertar(Usuario usuario)
        {
            int result = 0;

            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Usuario (Usuario, Correo, Clave, id_Rol) VALUES (@nombre, @correo, @clave, @idRol)";

                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@nombre"; p.Value = usuario.usuario ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@correo"; p.Value = usuario.correo ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@clave"; p.Value = usuario.clave ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@idRol"; p.Value = usuario.id_Rol; cmd.Parameters.Add(p);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }

        public static int Actualizar(Usuario usuario)
        {
            int result = 0;

            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Usuario SET Usuario = @nombre, Correo = @correo, Clave = @clave, id_Rol = @idRol WHERE Id_Usuario = @id";

                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id"; p.Value = usuario.id_Usuario; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@nombre"; p.Value = usuario.usuario ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@correo"; p.Value = usuario.usuario ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@clave"; p.Value = usuario.clave ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@idRol"; p.Value = usuario.id_Rol; cmd.Parameters.Add(p);

                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }

        public static int Eliminar(int id)
        {
            int result = 0;

            using (IDbConnection conn = DBComun.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Usuario WHERE Id_Usuario = @id";

                using (IDbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id"; p.Value = id; cmd.Parameters.Add(p);
                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }
    }
}