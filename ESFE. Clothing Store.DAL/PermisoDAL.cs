using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public static class PermisoDAL
    {
        public static int Insertar(Permiso entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Permiso (id_permiso, Nivel_permiso) VALUES (@id_permiso, @Nivel_permiso)";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter();
                    p.ParameterName = "@id_permiso";
                    p.Value = entidad.id_permiso;
                    cmd.Parameters.Add(p);

                    p = cmd.CreateParameter();
                    p.ParameterName = "@Nivel_permiso";
                    p.Value = entidad.Nivel_permiso ?? (object)DBNull.Value;
                    cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Actualizar(Permiso entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Permiso SET Nivel_permiso = @Nivel_permiso WHERE id_permiso = @id_permiso";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter();
                    p.ParameterName = "@id_permiso";
                    p.Value = entidad.id_permiso;
                    cmd.Parameters.Add(p);

                    p = cmd.CreateParameter();
                    p.ParameterName = "@Nivel_permiso";
                    p.Value = entidad.Nivel_permiso ?? (object)DBNull.Value;
                    cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int id)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Permiso WHERE id_permiso = @id_permiso";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter();
                    p.ParameterName = "@id_permiso";
                    p.Value = id;
                    cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Permiso> ObtenerTodos()
        {
            var lista = new List<Permiso>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT id_permiso, Nivel_permiso FROM Permiso";
                    cmd.CommandType = CommandType.Text;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Permiso
                            {
                                id_permiso = dr["id_permiso"] != DBNull.Value ? Convert.ToInt32(dr["id_permiso"]) : 0,
                                Nivel_permiso = dr["Nivel_permiso"] != DBNull.Value ? dr["Nivel_permiso"].ToString() : string.Empty
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        public static Permiso ObtenerPorId(int id)
        {
            Permiso entidad = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT id_permiso, Nivel_permiso FROM Permiso WHERE id_permiso = @id_permiso";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter();
                    p.ParameterName = "@id_permiso";
                    p.Value = id;
                    cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad = new Permiso
                            {
                                id_permiso = dr["id_permiso"] != DBNull.Value ? Convert.ToInt32(dr["id_permiso"]) : 0,
                                Nivel_permiso = dr["Nivel_permiso"] != DBNull.Value ? dr["Nivel_permiso"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }

            return entidad;
        }
    }
}
