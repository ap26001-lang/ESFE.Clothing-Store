using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public static class TipoProductoDAL
    {
        public static int Insertar(Tipo_Producto entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();

                int nuevoId = 1;
                using (IDbCommand cmdMax = cn.CreateCommand())
                {
                    cmdMax.CommandText = "SELECT ISNULL(MAX(id_Tipo_Produc), 0) + 1 FROM Tipo_Producto";
                    cmdMax.CommandType = CommandType.Text;
                    object result = cmdMax.ExecuteScalar();
                    nuevoId = result != null && result != DBNull.Value ? Convert.ToInt32(result) : 1;
                }

                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_TipoProducto_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_Tipo_Produc"; p.Value = nuevoId; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Tipo_de_producto"; p.Value = entidad.Tipo_de_producto ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Actualizar(Tipo_Producto entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_TipoProducto_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_Tipo_Produc"; p.Value = entidad.id_tipo_producto; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Tipo_de_producto"; p.Value = entidad.Tipo_de_producto ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int idTipoProducto)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_TipoProducto_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_Tipo_Produc"; p.Value = idTipoProducto; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Tipo_Producto> ObtenerTodos()
        {
            var lista = new List<Tipo_Producto>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_TipoProducto_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Tipo_Producto
                            {
                                id_tipo_producto = dr["id_Tipo_Produc"] != DBNull.Value ? Convert.ToInt32(dr["id_Tipo_Produc"]) : 0,
                                Tipo_de_producto = dr["Tipo_de_producto"] != DBNull.Value ? dr["Tipo_de_producto"].ToString() : string.Empty
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        public static Tipo_Producto ObtenerPorId(int idTipoProducto)
        {
            Tipo_Producto entidad = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_TipoProducto_ObtenerPorId";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_Tipo_Produc"; p.Value = idTipoProducto; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad = new Tipo_Producto
                            {
                                id_tipo_producto = dr["id_Tipo_Produc"] != DBNull.Value ? Convert.ToInt32(dr["id_Tipo_Produc"]) : 0,
                                Tipo_de_producto = dr["Tipo_de_producto"] != DBNull.Value ? dr["Tipo_de_producto"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }

            return entidad;
        }
    }
}
