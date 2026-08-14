using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public static class ClientesDAL
    {
        public static int Insertar(Clientes entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Clientes_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@Nombre"; p.Value = entidad.Nombre ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Dui"; p.Value = entidad.Dui; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Telefono"; p.Value = entidad.Telefono; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Correo"; p.Value = entidad.Correo ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@id_rol"; p.Value = entidad.id_rol; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@id_permiso"; p.Value = entidad.id_permiso; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@id_estado"; p.Value = entidad.id_estado; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Actualizar(Clientes entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Clientes_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_cliente"; p.Value = entidad.id_cliente; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Nombre"; p.Value = entidad.Nombre ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Dui"; p.Value = entidad.Dui; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Telefono"; p.Value = entidad.Telefono; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Correo"; p.Value = entidad.Correo ?? (object)DBNull.Value; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@id_rol"; p.Value = entidad.id_rol; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@id_permiso"; p.Value = entidad.id_permiso; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@id_estado"; p.Value = entidad.id_estado; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Eliminar(int idCliente)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Clientes_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_cliente"; p.Value = idCliente; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Clientes> ObtenerTodos()
        {
            var lista = new List<Clientes>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Clientes_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Clientes
                            {
                                id_cliente = dr["id_cliente"] != DBNull.Value ? Convert.ToInt32(dr["id_cliente"]) : 0,
                                Nombre = dr["Nombre"] != DBNull.Value ? dr["Nombre"].ToString() : string.Empty,
                                Dui = dr["Dui"] != DBNull.Value ? Convert.ToInt32(dr["Dui"]) : 0,
                                Telefono = dr["Telefono"] != DBNull.Value ? Convert.ToInt32(dr["Telefono"]) : 0,
                                Correo = dr["Correo"] != DBNull.Value ? dr["Correo"].ToString() : string.Empty,
                                id_rol = dr["id_rol"] != DBNull.Value ? Convert.ToInt32(dr["id_rol"]) : 0,
                                id_permiso = dr["id_permiso"] != DBNull.Value ? Convert.ToInt32(dr["id_permiso"]) : 0,
                                id_estado = dr["id_estado"] != DBNull.Value ? Convert.ToInt32(dr["id_estado"]) : 0
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        public static Clientes ObtenerPorId(int idCliente)
        {
            Clientes entidad = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Clientes_ObtenerPorId";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_cliente"; p.Value = idCliente; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            entidad = new Clientes
                            {
                                id_cliente = dr["id_cliente"] != DBNull.Value ? Convert.ToInt32(dr["id_cliente"]) : 0,
                                Nombre = dr["Nombre"] != DBNull.Value ? dr["Nombre"].ToString() : string.Empty,
                                Dui = dr["Dui"] != DBNull.Value ? Convert.ToInt32(dr["Dui"]) : 0,
                                Telefono = dr["Telefono"] != DBNull.Value ? Convert.ToInt32(dr["Telefono"]) : 0,
                                Correo = dr["Correo"] != DBNull.Value ? dr["Correo"].ToString() : string.Empty,
                                id_rol = dr["id_rol"] != DBNull.Value ? Convert.ToInt32(dr["id_rol"]) : 0,
                                id_permiso = dr["id_permiso"] != DBNull.Value ? Convert.ToInt32(dr["id_permiso"]) : 0,
                                id_estado = dr["id_estado"] != DBNull.Value ? Convert.ToInt32(dr["id_estado"]) : 0
                            };
                        }
                    }
                }
            }

            return entidad;
        }
    }
}

