using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Tickets
{
    class ClassConexion
    {
        public static SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenadeconexion"].ToString());
                conectar.Open();
                return conectar;
            }
            catch (Exception)
            {

                throw new Exception("Error en la conexion"); ;
            }
        }
        public static SqlConnection CerrarConexion()
        {
            SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenadeconexion"].ToString());
            conectar.Close();
            return conectar;
        }
    }
}
