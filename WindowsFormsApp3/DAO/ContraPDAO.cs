using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Entidad;

namespace WindowsFormsApp3.DAO
{
    public class ContraPDAO
    {
        public static int GenerarContra(int idUsuario)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC GenerarContraseñaP @idUsuario";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                try
                {
                    retorno = comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

            return retorno;
        }


        public static int ObtenerContra(int idUsuario)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC ObtenerContraseñaPporIdUsuario @idUsuario";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                SqlDataReader reader = comando.ExecuteReader();

                try
                {
                    if (reader.Read())
                    {

                        string contraseña = reader["Contraseña"].ToString();
                        MessageBox.Show("Contraseña: " + contraseña, "Contraseña Provisional", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retorno = 1;

                    }
                    else
                    {
                        MessageBox.Show("No se encontró la contraseña para el usuario especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

            return retorno;
        }


        public static int VerificarIngreso(string Correo, string ContraP)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC VerificarIngreso @Correo, @ContraseñaProvisional";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Correo", Correo);
                comando.Parameters.AddWithValue("@ContraseñaProvisional", ContraP);


                try
                {
                    comando.ExecuteReader();
                    MessageBox.Show("Establece una nueva contraseña ", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    retorno = 1;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

            return retorno;
        }



    }
}
