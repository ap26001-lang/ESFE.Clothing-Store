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
                    cmd.CommandText = @"INSERT INTO [dbo].[Bitacora] (Accion, Id_Usuario, Fecha_y_hora)
VALUES (@Accion, @Id_Usuario, @Fecha_y_hora);
SELECT SCOPE_IDENTITY();";
                    cmd.CommandType = CommandType.Text;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@Accion"; p1.Value = entidad.Accion ?? (object)DBNull.Value; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Id_Usuario"; p2.Value = entidad.Id_Usuario; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@Fecha_y_hora"; p3.Value = entidad.Fecha_y_hora; cmd.Parameters.Add(p3);

                    var result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int newId))
                        return newId;
                    return 0;
                }
            }
        }

        public static int Actualizar(Bitacora entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = @"UPDATE [dbo].[Bitacora]
SET Accion = @Accion, Id_Usuario = @Id_Usuario, Fecha_y_hora = @Fecha_y_hora
WHERE id_actividad = @id_actividad";
                    cmd.CommandType = CommandType.Text;

                    var p0 = cmd.CreateParameter(); p0.ParameterName = "@id_actividad"; p0.Value = entidad.id_actividad; cmd.Parameters.Add(p0);
                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@Accion"; p1.Value = entidad.Accion ?? (object)DBNull.Value; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Id_Usuario"; p2.Value = entidad.Id_Usuario; cmd.Parameters.Add(p2);
                    var p3 = cmd.CreateParameter(); p3.ParameterName = "@Fecha_y_hora"; p3.Value = entidad.Fecha_y_hora; cmd.Parameters.Add(p3);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int idActividad)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [dbo].[Bitacora] WHERE id_actividad = @id_actividad";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_actividad"; p.Value = idActividad; cmd.Parameters.Add(p);

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
                    cmd.CommandText = "SELECT * FROM [dbo].[Bitacora]";
                    cmd.CommandType = CommandType.Text;
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
                    cmd.CommandText = "SELECT * FROM [dbo].[Bitacora] WHERE Id_Usuario = @Id_Usuario";
                    cmd.CommandType = CommandType.Text;
                    var p = cmd.CreateParameter(); p.ParameterName = "@Id_Usuario"; p.Value = idUsuario; cmd.Parameters.Add(p);

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

