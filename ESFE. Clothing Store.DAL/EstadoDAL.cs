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
                    cmd.CommandText = "sp_Estado_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@estado"; p.Value = entidad.estado ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
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
                    cmd.CommandText = "sp_Estado_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_estado"; p.Value = entidad.id_estado; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@estado"; p.Value = entidad.estado ?? (object)DBNull.Value; cmd.Parameters.Add(p);

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
                    cmd.CommandText = "sp_Estado_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

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
                    cmd.CommandText = "sp_Estado_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Estado
                            {
                                id_estado = dr["id_estado"] != DBNull.Value ? Convert.ToInt32(dr["id_estado"]) : 0,
                                estado = dr["estado"] != DBNull.Value ? dr["estado"].ToString() : string.Empty
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
                    cmd.CommandText = "sp_Estado_ObtenerPorId";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_estado"; p.Value = idEstado; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad = new Estado
                            {
                                id_estado = dr["id_estado"] != DBNull.Value ? Convert.ToInt32(dr["id_estado"]) : 0,
                                estado = dr["estado"] != DBNull.Value ? dr["estado"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }

            return entidad;
        }
    }
}
