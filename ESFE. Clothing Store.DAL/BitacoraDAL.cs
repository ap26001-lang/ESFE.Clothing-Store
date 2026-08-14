using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public static class BitacoraDAL
    {
        public static int Insertar(Bitacora entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    // Usar procedimiento almacenado: sp_Bitacora_Insertar
                    cmd.CommandText = "sp_Bitacora_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter();
                    p1.ParameterName = "@Accion";
                    p1.Value = entidad.Accion ?? (object)DBNull.Value;
                    cmd.Parameters.Add(p1);

                    var p2 = cmd.CreateParameter();
                    p2.ParameterName = "@Id_Usuario";
                    p2.Value = entidad.Id_Usuario;
                    cmd.Parameters.Add(p2);

                    var p3 = cmd.CreateParameter();
                    p3.ParameterName = "@Fecha_y_hora";
                    p3.Value = entidad.Fecha_y_hora;
                    cmd.Parameters.Add(p3);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Bitacora> ObtenerTodos()
        {
            var lista = new List<Bitacora>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    // Usar procedimiento almacenado: sp_Bitacora_ObtenerTodos
                    cmd.CommandText = "sp_Bitacora_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Bitacora
                            {
                                id_actividad = dr["id_actividad"] != DBNull.Value ? Convert.ToInt32(dr["id_actividad"]) : 0,
                                Accion = dr["Accion"] != DBNull.Value ? dr["Accion"].ToString() : string.Empty,
                                Id_Usuario = dr["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(dr["Id_Usuario"]) : 0,
                                Fecha_y_hora = dr["Fecha_y_hora"] != DBNull.Value ? Convert.ToDateTime(dr["Fecha_y_hora"]) : DateTime.MinValue
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        public static List<Bitacora> ObtenerPorUsuario(int idUsuario)
        {
            var lista = new List<Bitacora>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    // Usar procedimiento almacenado: sp_Bitacora_ObtenerPorUsuario
                    cmd.CommandText = "sp_Bitacora_ObtenerPorUsuario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    var p = cmd.CreateParameter();
                    p.ParameterName = "@Id_Usuario";
                    p.Value = idUsuario;
                    cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Bitacora
                            {
                                id_actividad = dr["id_actividad"] != DBNull.Value ? Convert.ToInt32(dr["id_actividad"]) : 0,
                                Accion = dr["Accion"] != DBNull.Value ? dr["Accion"].ToString() : string.Empty,
                                Id_Usuario = dr["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(dr["Id_Usuario"]) : 0,
                                Fecha_y_hora = dr["Fecha_y_hora"] != DBNull.Value ? Convert.ToDateTime(dr["Fecha_y_hora"]) : DateTime.MinValue
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }
    }
}

