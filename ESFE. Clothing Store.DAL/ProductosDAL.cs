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
                    cmd.CommandText = "INSERT INTO [dbo].[Productos] (CodigoProducto, NombreProducto, Precio, id_Tipo_Producto, Id_tallas, Id_Tela, Id_Color) " +
                                      "VALUES (@codigo, @nombre, @precio, @tipoProducto, @tallas, @tela, @color)";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@codigo"; p.Value = entidad.CodigoProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@nombre"; p.Value = entidad.NombreProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@precio"; p.Value = entidad.precio ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@tipoProducto"; p.Value = entidad.idTipoProducto; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@tallas"; p.Value = entidad.idtallas; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@tela"; p.Value = entidad.idtelas; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@color"; p.Value = entidad.idcolor; cmd.Parameters.Add(p);

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
                    cmd.CommandText = "UPDATE [dbo].[Productos] SET NombreProducto=@nombre, Precio=@precio, id_Tipo_Producto=@tipoProducto, " +
                                      "Id_tallas=@tallas, Id_Tela=@tela, Id_Color=@color WHERE CodigoProducto=@codigo";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@codigo"; p.Value = entidad.CodigoProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@nombre"; p.Value = entidad.NombreProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@precio"; p.Value = entidad.precio ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@tipoProducto"; p.Value = entidad.idTipoProducto; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@tallas"; p.Value = entidad.idtallas; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@tela"; p.Value = entidad.idtelas; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@color"; p.Value = entidad.idcolor; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Elimina un producto de la base de datos.
        /// </summary>
        public static int Eliminar(string codigoProducto)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [dbo].[Productos] WHERE CodigoProducto=@codigo";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@codigo"; p.Value = codigoProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p);

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
                    cmd.CommandText = "SELECT CodigoProducto, NombreProducto, Precio, id_Tipo_Producto, Id_tallas, Id_Tela, Id_Color FROM [dbo].[Productos]";
                    cmd.CommandType = CommandType.Text;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Productos
                            {
                                CodigoProducto = dr["CodigoProducto"] != DBNull.Value ? dr["CodigoProducto"].ToString() : string.Empty,
                                NombreProducto = dr["NombreProducto"] != DBNull.Value ? dr["NombreProducto"].ToString() : string.Empty,
                                precio = dr["Precio"] != DBNull.Value ? dr["Precio"].ToString() : string.Empty,
                                idTipoProducto = dr["id_Tipo_Producto"] != DBNull.Value ? Convert.ToInt32(dr["id_Tipo_Producto"]) : 0,
                                idtallas = dr["Id_tallas"] != DBNull.Value ? Convert.ToInt32(dr["Id_tallas"]) : 0,
                                idtelas = dr["Id_Tela"] != DBNull.Value ? Convert.ToInt32(dr["Id_Tela"]) : 0,
                                idcolor = dr["Id_Color"] != DBNull.Value ? Convert.ToInt32(dr["Id_Color"]) : 0
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
        public static Productos ObtenerPorId(string codigoProducto)
        {
            Productos item = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "SELECT CodigoProducto, NombreProducto, Precio, id_Tipo_Producto, Id_tallas, Id_Tela, Id_Color FROM [dbo].[Productos] WHERE CodigoProducto=@codigo";
                    cmd.CommandType = CommandType.Text;

                    var p = cmd.CreateParameter(); p.ParameterName = "@codigo"; p.Value = codigoProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            item = new Productos
                            {
                                CodigoProducto = dr["CodigoProducto"] != DBNull.Value ? dr["CodigoProducto"].ToString() : string.Empty,
                                NombreProducto = dr["NombreProducto"] != DBNull.Value ? dr["NombreProducto"].ToString() : string.Empty,
                                precio = dr["Precio"] != DBNull.Value ? dr["Precio"].ToString() : string.Empty,
                                idTipoProducto = dr["id_Tipo_Producto"] != DBNull.Value ? Convert.ToInt32(dr["id_Tipo_Producto"]) : 0,
                                idtallas = dr["Id_tallas"] != DBNull.Value ? Convert.ToInt32(dr["Id_tallas"]) : 0,
                                idtelas = dr["Id_Tela"] != DBNull.Value ? Convert.ToInt32(dr["Id_Tela"]) : 0,
                                idcolor = dr["Id_Color"] != DBNull.Value ? Convert.ToInt32(dr["Id_Color"]) : 0
                            };
                        }
                    }
                }
            }

            return item;
        }
    }
}
