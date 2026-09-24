using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;

namespace ESFE._Clothing_Store.DAL
{
    public class DBComun
    {
        // Conexion actualizada para usar la base dbtiendaropa en servidor remoto SOMEE
        // Nota: TrustServerCertificate=True permite confiar en el certificado del servidor.
        public const string _stringCnn = @"Server=dbtiendaropa.mssql.somee.com;Database=dbtiendaropa;User Id=omardk2026_SQLLogin_1;Password=4hoq3mujf4;TrustServerCertificate=True;Connection Timeout=30;";

        /// <summary>
        /// Metodo para obtener base de datos.
        /// </summary>
        /// <returns>Devuelve la  conexion</returns>
        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_stringCnn);
        }

        public static IDataReader ObtenerCommando(IDbConnection pConexion, string pSql)
        {
            SqlCommand _command = new SqlCommand(pSql, pConexion as SqlConnection);
            return _command.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
