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

            using (IDbConnection cn = _Clothing_Store.DAL.DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tela_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@tipo_de_tela"; p1.Value = entidad.Tipodetela ?? (object)DBNull.Value; cmd.Parameters.Add(p1);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Modificar(Tela entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = _Clothing_Store.DAL.DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tela_Modificar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@idtela"; p1.Value = entidad.idTela 
                        ; cmd.Parameters.Add(p1);
                    var p2 = cmd.CreateParameter(); p2.ParameterName = "@tipo_de_tela"; p2.Value = entidad.tipo_de_tela ?? (object)DBNull.Value; cmd.Parameters.Add(p2);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int idtela)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Tela_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p1 = cmd.CreateParameter(); p1.ParameterName = "@idtela"; p1.Value = idtela; cmd.Parameters.Add(p1);

                    return cmd.ExecuteNonQuery();
                }
            }
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
                                idtela = dr.GetInt32(dr.GetOrdinal("idtela")),
                                tipo_de_tela = dr.IsDBNull(dr.GetOrdinal("tipo_de_tela")) ? null : dr.GetString(dr.GetOrdinal("tipo_de_tela"))
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
