using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public static class EstadoDAL
    {
        public static int Insertar(Estado entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    // Al igual que Color, id_estado no es IDENTITY por el modelo relacional.
                    // Buscamos el ID máximo y le sumamos 1 de manera simple.
                    cmd.CommandText = "SELECT ISNULL(MAX(id_estado), 0) + 1 FROM [dbo].[Estado]";
                    int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = "INSERT INTO [dbo].[Estado] (id_estado, Estado) VALUES (@id_estado, @Estado)";
                    cmd.CommandType = CommandType.Text;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@id_estado"; p1.Value = nuevoId; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Estado"; p2.Value = entidad.estado ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0 ? nuevoId : 0;
                }
            }
        }

        public static int Actualizar(Estado entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE [dbo].[Estado] SET Estado = @Estado WHERE id_estado = @id_estado";
                    cmd.CommandType = CommandType.Text;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@id_estado"; p1.Value = entidad.id_estado; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Estado"; p2.Value = entidad.estado ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int idEstado)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [dbo].[Estado] WHERE id_estado = @id_estado";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_estado"; p.Value = idEstado; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Estado> ObtenerTodos()
        {
            var lista = new List<Estado>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT id_estado, Estado FROM [dbo].[Estado]";
                    cmd.CommandType = CommandType.Text;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Estado
                            {
                                id_estado = dr["id_estado"] != DBNull.Value ? Convert.ToInt32(dr["id_estado"]) : 0,
                                estado = dr["Estado"] != DBNull.Value ? dr["Estado"].ToString() : string.Empty
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        public static Estado ObtenerPorId(int idEstado)
        {
            Estado entidad = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT id_estado, Estado FROM [dbo].[Estado] WHERE id_estado = @id_estado";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_estado"; p.Value = idEstado; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad = new Estado
                            {
                                id_estado = dr["id_estado"] != DBNull.Value ? Convert.ToInt32(dr["id_estado"]) : 0,
                                estado = dr["Estado"] != DBNull.Value ? dr["Estado"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }

            return entidad;
        }
    }
}
