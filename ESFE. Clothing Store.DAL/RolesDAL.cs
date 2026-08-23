using System;
using System.Collections.Generic;
using System.Data;
using ESFE._Clothing_Store.EN;

namespace ESFE._Clothing_Store.DAL
{
    public static class RolesDAL
    {
        /// <summary>
        /// Inserta un nuevo rol en la base de datos.
        /// </summary>
        public static int Insertar(Roles entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();

                int nuevoId;
                using (IDbCommand cmdId = cn.CreateCommand())
                {
                    cmdId.CommandText = "SELECT ISNULL(MAX(id_rol), 0) + 1 FROM [dbo].[Roles]";
                    cmdId.CommandType = CommandType.Text;
                    nuevoId = Convert.ToInt32(cmdId.ExecuteScalar());
                }

                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Roles_Insertar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_rol"; p.Value = nuevoId; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Descripcion_Rol"; p.Value = entidad.DiscripcionRoles ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    cmd.ExecuteNonQuery();
                    return nuevoId;
                }
            }
        }

        /// <summary>
        /// Actualiza un rol existente en la base de datos.
        /// </summary>
        public static int Actualizar(Roles entidad)
        {
            if (entidad == null) throw new ArgumentNullException(nameof(entidad));

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Roles_Actualizar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_rol"; p.Value = entidad.idRoles; cmd.Parameters.Add(p);
                    p = cmd.CreateParameter(); p.ParameterName = "@Descripcion_Rol"; p.Value = entidad.DiscripcionRoles ?? (object)DBNull.Value; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Elimina un rol de la base de datos.
        /// </summary>
        public static int Eliminar(int idRoles)
        {
            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Roles_Eliminar";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_rol"; p.Value = idRoles; cmd.Parameters.Add(p);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Obtiene todos los roles de la base de datos.
        /// </summary>
        public static List<Roles> ObtenerTodos()
        {
            var lista = new List<Roles>();

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Roles_ObtenerTodos";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Roles
                            {
                                idRoles = dr["id_rol"] != DBNull.Value ? Convert.ToInt32(dr["id_rol"]) : 0,
                                DiscripcionRoles = dr["Descripcion_Rol"] != DBNull.Value ? dr["Descripcion_Rol"].ToString() : string.Empty
                            };
                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        /// <summary>
        /// Obtiene un rol específico por su ID.
        /// </summary>
        public static Roles ObtenerPorId(int idRoles)
        {
            Roles item = null;

            using (IDbConnection cn = DBComun.ObtenerConexion())
            {
                cn.Open();
                using (IDbCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "sp_Roles_ObtenerPorId";
                    cmd.CommandType = CommandType.StoredProcedure;

                    var p = cmd.CreateParameter(); p.ParameterName = "@id_rol"; p.Value = idRoles; cmd.Parameters.Add(p);

                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            item = new Roles
                            {
                                idRoles = dr["id_rol"] != DBNull.Value ? Convert.ToInt32(dr["id_rol"]) : 0,
                                DiscripcionRoles = dr["Descripcion_Rol"] != DBNull.Value ? dr["Descripcion_Rol"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }

            return item;
        }
    }
}

