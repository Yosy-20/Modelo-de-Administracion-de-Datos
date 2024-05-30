using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
   public class BDConexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MAD_PIA;Data Source=DESKTOP-RQM5J9O\\SQLEXPRESS");

            conexion.Open();
            return conexion;
        }


    }
}
