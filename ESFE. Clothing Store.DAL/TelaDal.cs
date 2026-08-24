using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.DAL;
using ESFE._Clothing_Store.EN;

namespace ESFE.Clothing_Store.DAL
{
    public static class TelaDal
    {
        public static int Insertar(Tela entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();

                int nuevoId;
                using (IDbCommand cmdId = cn.CreateCommand())
                {
                    cmdId.CommandText = "SELECT ISNULL(MAX(Id_Tela), 0) + 1 FROM [dbo].[Tela]";
                    cmdId.CommandType = CommandType.Text;
                    nuevoId = Convert.ToInt32(cmdId.ExecuteScalar());
                }

                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tela_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@Id_Tela"; p1.Value = nuevoId; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Tipo_de_tela"; p2.Value = entidad.Tipodetela ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

                    cmd.ExecuteNonQuery();
                    return nuevoId;
                }
            }
        }

        public static int Actualizar(Tela entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tela_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@Id_Tela"; p1.Value = entidad.idTela; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@Tipo_de_tela"; p2.Value = entidad.Tipodetela ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int idTela)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tela_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@Id_Tela"; p1.Value = idTela; cmd.Parameters.Add(p1);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static Tela ObtenerPorId(int idTela)
        {
            Tela item = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tela_ObtenerPorId";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@Id_Tela"; p1.Value = idTela; cmd.Parameters.Add(p1);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            item = new Tela
                            {
                                idTela = dr.GetInt32(dr.GetOrdinal("Id_Tela")),
                                Tipodetela = dr.IsDBNull(dr.GetOrdinal("Tipo_de_tela")) ? null : dr.GetString(dr.GetOrdinal("Tipo_de_tela"))
                            };
                        }
                    }
                }
            }

            return item;
        }

        public static List<Tela> ObtenerTodos()
        {
            var lista = new List<Tela>();
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tela_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Tela
                            {
                                idTela = dr.GetInt32(dr.GetOrdinal("Id_Tela")),
                                Tipodetela = dr.IsDBNull(dr.GetOrdinal("Tipo_de_tela")) ? null : dr.GetString(dr.GetOrdinal("Tipo_de_tela"))
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
