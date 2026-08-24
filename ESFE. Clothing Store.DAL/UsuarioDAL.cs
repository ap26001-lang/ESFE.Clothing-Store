using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public static class UsuarioDAL
    {
        public static int Insertar(Usuario entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();

                int nuevoId;
                using (IDbCommand cmdMax = cn.CreateCommand())
                {
                    cmdMax.CommandText = "SELECT ISNULL(MAX(Id_Usuario), 0) + 1 FROM Usuario";
                    cmdMax.CommandType = CommandType.Text;
                    object result = cmdMax.ExecuteScalar();
                    nuevoId = result != null && result != DBNull.Value ? Convert.ToInt32(result) : 1;
                }

                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Usuario_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Id_Usuario"; p.Value = nuevoId; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Usuario"; p.Value = entidad.usuario ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Actualizar(Usuario entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Usuario_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Id_Usuario"; p.Value = entidad.id_Usuario; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Usuario"; p.Value = entidad.usuario ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int idUsuario)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Usuario_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Id_Usuario"; p.Value = idUsuario; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Usuario> ObtenerTodos()
        {
            var lista = new List<Usuario>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Usuario_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Usuario
                            {
                                id_Usuario = dr["id_Usuario"] != DBNull.Value ? Convert.ToInt32(dr["id_Usuario"]) : 0,
                                usuario = dr["usuario"] != DBNull.Value ? dr["usuario"].ToString() : string.Empty
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        public static Usuario ObtenerPorId(int idUsuario)
        {
            Usuario entidad = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Usuario_ObtenerPorId";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Id_Usuario"; p.Value = idUsuario; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad = new Usuario
                            {
                                id_Usuario = dr["id_Usuario"] != DBNull.Value ? Convert.ToInt32(dr["id_Usuario"]) : 0,
                                usuario = dr["usuario"] != DBNull.Value ? dr["usuario"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }

            return entidad;
        }
    }
}
