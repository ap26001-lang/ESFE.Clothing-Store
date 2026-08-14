using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public static class ColorDAL
    {
        public static int Insertar(Color entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Color_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@color"; p.Value = entidad.color ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Actualizar(Color entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Color_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Id_Color"; p.Value = entidad.Id_Color; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@color"; p.Value = entidad.color ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int idColor)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Color_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Id_Color"; p.Value = idColor; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Color> ObtenerTodos()
        {
            var lista = new List<Color>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Color_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Color
                            {
                                Id_Color = dr["Id_Color"] != DBNull.Value ? Convert.ToInt32(dr["Id_Color"]) : 0,
                                color = dr["color"] != DBNull.Value ? dr["color"].ToString() : string.Empty
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        public static Color ObtenerPorId(int idColor)
        {
            Color entidad = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Color_ObtenerPorId";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Id_Color"; p.Value = idColor; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad = new Color
                            {
                                Id_Color = dr["Id_Color"] != DBNull.Value ? Convert.ToInt32(dr["Id_Color"]) : 0,
                                color = dr["color"] != DBNull.Value ? dr["color"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }

            return entidad;
        }
    }
}
