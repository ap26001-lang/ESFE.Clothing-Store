using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;

namespace ESFE._Clothing_Store.DAL
{
    public class DBComun
    {
            // Conexion actualizada para usar la base TIENDA_ROPA
            // Nota: TrustServerCertificate=True permite confiar en el certificado del servidor (útil en desarrollo).
            public const string _stringCnn = @"Data Source=localhost;Initial Catalog=TIENDA_ROPA;Integrated Security=True;TrustServerCertificate=True";

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

