using ESFE._Clothing_Store.EN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESFE._Clothing_Store.DAL
{
    public static class TallasDal
    {
        public static int Insertar(Tallas entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();

                int nuevoId;
                using (IDbCommand cmdId = cn.CreateCommand())
                {
                    cmdId.CommandText = "SELECT ISNULL(MAX(id_tallas), 0) + 1 FROM [dbo].[Tallas]";
                    cmdId.CommandType = CommandType.Text;
                    nuevoId = Convert.ToInt32(cmdId.ExecuteScalar());
                }

                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tallas_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@id_tallas"; p1.Value = nuevoId; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Talla_Producto"; p2.Value = entidad.TallaProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

                    cmd.ExecuteNonQuery();
                    return nuevoId;
                }
            }
        }

        public static int Actualizar(Tallas entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tallas_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@id_tallas"; p1.Value = entidad.idTallas; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Talla_Producto"; p2.Value = entidad.TallaProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int idTallas)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tallas_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@id_tallas"; p1.Value = idTallas; cmd.Parameters.Add(p1);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static Tallas ObtenerPorId(int idTallas)
        {
            Tallas item = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tallas_ObtenerPorId";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@id_tallas"; p1.Value = idTallas; cmd.Parameters.Add(p1);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            item = new Tallas
                            {
                                idTallas = dr.GetInt32(dr.GetOrdinal("id_tallas")),
                                TallaProducto = dr.IsDBNull(dr.GetOrdinal("Talla_Producto")) ? null : dr.GetString(dr.GetOrdinal("Talla_Producto"))
                            };
                        }
                    }
                }
            }

            return item;
        }

        public static List<Tallas> ObtenerTodos()
        {
            var lista = new List<Tallas>();
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tallas_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Tallas();
                            item.idTallas = dr.GetInt32(dr.GetOrdinal("id_tallas"));
                            item.TallaProducto = dr.IsDBNull(dr.GetOrdinal("Talla_Producto")) ? null : dr.GetString(dr.GetOrdinal("Talla_Producto"));
                            lista.Add(item);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
