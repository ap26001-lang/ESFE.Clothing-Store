using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public static class VentasDAL
    {
        public static int Insertar(Ventas entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Ventas_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Codigo_de_Venta"; p.Value = entidad.Codigo_de_Venta ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Fecha_y_Hora"; p.Value = entidad.Fecha_y_Hora; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Cantidad_de_productos"; p.Value = entidad.Cantidad_de_productos; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@id_Tipo_Producto"; p.Value = entidad.id_Tipo_Producto; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@id_cliente"; p.Value = entidad.id_cliente; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Actualizar(Ventas entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Ventas_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Codigo_de_Venta"; p.Value = entidad.Codigo_de_Venta ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Fecha_y_Hora"; p.Value = entidad.Fecha_y_Hora; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Cantidad_de_productos"; p.Value = entidad.Cantidad_de_productos; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@id_Tipo_Producto"; p.Value = entidad.id_Tipo_Producto; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@id_cliente"; p.Value = entidad.id_cliente; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(string codigoVenta)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Ventas_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Codigo_de_Venta"; p.Value = codigoVenta ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Ventas> ObtenerTodos()
        {
            var lista = new List<Ventas>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Ventas_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Ventas
                            {
                                Codigo_de_Venta = dr["Codigo_de_Venta"] != DBNull.Value ? dr["Codigo_de_Venta"].ToString() : string.Empty,
                                Fecha_y_Hora = dr["Fecha_y_Hora"] != DBNull.Value ? Convert.ToDateTime(dr["Fecha_y_Hora"]) : DateTime.MinValue,
                                Cantidad_de_productos = dr["Cantidad_de_productos"] != DBNull.Value ? Convert.ToInt32(dr["Cantidad_de_productos"]) : 0,
                                id_Tipo_Producto = dr["id_Tipo_Producto"] != DBNull.Value ? Convert.ToInt32(dr["id_Tipo_Producto"]) : 0,
                                id_cliente = dr["id_cliente"] != DBNull.Value ? Convert.ToInt32(dr["id_cliente"]) : 0
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        public static Ventas ObtenerPorCodigo(string codigoVenta)
        {
            Ventas entidad = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Ventas_ObtenerPorCodigo";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Codigo_de_Venta"; p.Value = codigoVenta ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad = new Ventas
                            {
                                Codigo_de_Venta = dr["Codigo_de_Venta"] != DBNull.Value ? dr["Codigo_de_Venta"].ToString() : string.Empty,
                                Fecha_y_Hora = dr["Fecha_y_Hora"] != DBNull.Value ? Convert.ToDateTime(dr["Fecha_y_Hora"]) : DateTime.MinValue,
                                Cantidad_de_productos = dr["Cantidad_de_productos"] != DBNull.Value ? Convert.ToInt32(dr["Cantidad_de_productos"]) : 0,
                                id_Tipo_Producto = dr["id_Tipo_Producto"] != DBNull.Value ? Convert.ToInt32(dr["id_Tipo_Producto"]) : 0,
                                id_cliente = dr["id_cliente"] != DBNull.Value ? Convert.ToInt32(dr["id_cliente"]) : 0
                            };
                        }
                    }
                }
            }

            return entidad;
        }
    }
}
