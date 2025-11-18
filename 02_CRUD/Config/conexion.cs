
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace _02_CRUD.Config
{
    public class conexion
    {
        //server
        //uid => User Id
        //pwd => Password
        //database
        private readonly string cadena_conexion = 
            "server=.;uid=sa;Password=123;database=cuarto25m26";

        public SqlConnection obtenerConexion() {
            SqlConnection sqlConnection = new SqlConnection(cadena_conexion);
            return sqlConnection;
        }
      
    }


}
//cuarto25m26