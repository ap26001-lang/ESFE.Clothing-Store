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
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tallas_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@talla_producto"; p1.Value = entidad.TallaProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p1);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Modificar(Tallas entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tallas_Modificar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@idtallas"; p1.Value = entidad.idTallas; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@talla_producto"; p2.Value = entidad.TallaProducto ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int idtallas)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tallas_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@idtallas"; p1.Value = idtallas; cmd.Parameters.Add(p1);

                    return cmd.ExecuteNonQuery();
                }
            }
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
                            item.idTallas = dr.GetInt32(dr.GetOrdinal("idtallas"));
                            item.TallaProducto = dr.IsDBNull(dr.GetOrdinal("talla_producto")) ? null : dr.GetString(dr.GetOrdinal("talla_producto"));
                            lista.Add(item);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
