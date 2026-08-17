using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public static class ProductosDAL
    {
        /// <summary>
        /// Inserta un nuevo producto en la base de datos.
        /// </summary>
        public static int Insertar(Productos entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Productos_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@NombreProducto"; p.Value = entidad.NombreProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@precio"; p.Value = entidad.precio ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@idTipoProducto"; p.Value = entidad.idTipoProducto; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@idtallas"; p.Value = entidad.idtallas; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@idtelas"; p.Value = entidad.idtelas; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@idcolor"; p.Value = entidad.idcolor; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Actualiza un producto existente en la base de datos.
        /// </summary>
        public static int Actualizar(Productos entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Productos_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@CodigoProducto"; p.Value = entidad.CodigoProducto; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@NombreProducto"; p.Value = entidad.NombreProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@precio"; p.Value = entidad.precio ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@idTipoProducto"; p.Value = entidad.idTipoProducto; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@idtallas"; p.Value = entidad.idtallas; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@idtelas"; p.Value = entidad.idtelas; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@idcolor"; p.Value = entidad.idcolor; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Elimina un producto de la base de datos.
        /// </summary>
        public static int Eliminar(int codigoProducto)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Productos_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@CodigoProducto"; p.Value = codigoProducto; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Obtiene todos los productos de la base de datos.
        /// </summary>
        public static List<Productos> ObtenerTodos()
        {
            var lista = new List<Productos>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Productos_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Productos
                            {
                                CodigoProducto = dr["CodigoProducto"] != DBNull.Value ? Convert.ToInt32(dr["CodigoProducto"]) : 0,
                                NombreProducto = dr["NombreProducto"] != DBNull.Value ? dr["NombreProducto"].ToString() : string.Empty,
                                precio = dr["precio"] != DBNull.Value ? dr["precio"].ToString() : string.Empty,
                                idTipoProducto = dr["idTipoProducto"] != DBNull.Value ? Convert.ToInt32(dr["idTipoProducto"]) : 0,
                                idtallas = dr["idtallas"] != DBNull.Value ? Convert.ToInt32(dr["idtallas"]) : 0,
                                idtelas = dr["idtelas"] != DBNull.Value ? Convert.ToInt32(dr["idtelas"]) : 0,
                                idcolor = dr["idcolor"] != DBNull.Value ? Convert.ToInt32(dr["idcolor"]) : 0
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        /// <summary>
        /// Obtiene un producto específico por su código.
        /// </summary>
        public static Productos ObtenerPorId(int codigoProducto)
        {
            Productos item = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Productos_ObtenerPorId";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@CodigoProducto"; p.Value = codigoProducto; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            item = new Productos
                            {
                                CodigoProducto = dr["CodigoProducto"] != DBNull.Value ? Convert.ToInt32(dr["CodigoProducto"]) : 0,
                                NombreProducto = dr["NombreProducto"] != DBNull.Value ? dr["NombreProducto"].ToString() : string.Empty,
                                precio = dr["precio"] != DBNull.Value ? dr["precio"].ToString() : string.Empty,
                                idTipoProducto = dr["idTipoProducto"] != DBNull.Value ? Convert.ToInt32(dr["idTipoProducto"]) : 0,
                                idtallas = dr["idtallas"] != DBNull.Value ? Convert.ToInt32(dr["idtallas"]) : 0,
                                idtelas = dr["idtelas"] != DBNull.Value ? Convert.ToInt32(dr["idtelas"]) : 0,
                                idcolor = dr["idcolor"] != DBNull.Value ? Convert.ToInt32(dr["idcolor"]) : 0
                            };
                        }
                    }
                }
            }

            return item;
        }

        /// <summary>
        /// Obtiene productos filtrados por tipo de producto.
        /// </summary>
        public static List<Productos> ObtenerPorTipo(int idTipoProducto)
        {
            var lista = new List<Productos>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Productos_ObtenerPorTipo";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@idTipoProducto"; p.Value = idTipoProducto; cmd.Parameters.Add(p);
                    cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Productos
                            {
                                CodigoProducto = dr["CodigoProducto"] != DBNull.Value ? Convert.ToInt32(dr["CodigoProducto"]) : 0,
                                NombreProducto = dr["NombreProducto"] != DBNull.Value ? dr["NombreProducto"].ToString() : string.Empty,
                                precio = dr["precio"] != DBNull.Value ? dr["precio"].ToString() : string.Empty,
                                idTipoProducto = dr["idTipoProducto"] != DBNull.Value ? Convert.ToInt32(dr["idTipoProducto"]) : 0,
                                idtallas = dr["idtallas"] != DBNull.Value ? Convert.ToInt32(dr["idtallas"]) : 0,
                                idtelas = dr["idtelas"] != DBNull.Value ? Convert.ToInt32(dr["idtelas"]) : 0,
                                idcolor = dr["idcolor"] != DBNull.Value ? Convert.ToInt32(dr["idcolor"]) : 0
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
