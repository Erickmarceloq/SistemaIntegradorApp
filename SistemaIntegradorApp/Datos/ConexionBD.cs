using System;
using System.Data.SqlClient;

namespace SistemaIntegradorApp.Datos
{
    public class ConexionBD
    {
        // Cadena de conexión usando el servidor localdb de tu máquina
        private readonly string cadenaConexion = @"Server=(localdb)\MSSQLLocalDB;Database=SistemaIntegradorDb;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}