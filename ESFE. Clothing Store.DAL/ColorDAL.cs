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
                    // Como la columna Id_Color no tiene IDENTITY, buscaremos el valor del ID máximo actual y sumaremos 1 de manera simple.
                    cmd.CommandText = "SELECT ISNULL(MAX(Id_Color), 0) + 1 FROM [dbo].[Color]";
                    int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = "INSERT INTO [dbo].[Color] (Id_Color, Color) VALUES (@Id_Color, @Color)";
                    cmd.CommandType = CommandType.Text;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@Id_Color"; p1.Value = nuevoId; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Color"; p2.Value = entidad.color ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0 ? nuevoId : 0;
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
                    cmd.CommandText = "UPDATE [dbo].[Color] SET Color = @Color WHERE Id_Color = @Id_Color";
                    cmd.CommandType = CommandType.Text;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@Id_Color"; p1.Value = entidad.Id_Color; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Color"; p2.Value = entidad.color ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

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
                    cmd.CommandText = "DELETE FROM [dbo].[Color] WHERE Id_Color = @Id_Color";
                    cmd.CommandType = CommandType.Text;

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
                    cmd.CommandText = "SELECT Id_Color, Color FROM [dbo].[Color]";
                    cmd.CommandType = CommandType.Text;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Color
                            {
                                Id_Color = dr["Id_Color"] != DBNull.Value ? Convert.ToInt32(dr["Id_Color"]) : 0,
                                color = dr["Color"] != DBNull.Value ? dr["Color"].ToString() : string.Empty
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
                    cmd.CommandText = "SELECT Id_Color, Color FROM [dbo].[Color] WHERE Id_Color = @Id_Color";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Id_Color"; p.Value = idColor; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad = new Color
                            {
                                Id_Color = dr["Id_Color"] != DBNull.Value ? Convert.ToInt32(dr["Id_Color"]) : 0,
                                color = dr["Color"] != DBNull.Value ? dr["Color"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }

            return entidad;
        }
    }
}
