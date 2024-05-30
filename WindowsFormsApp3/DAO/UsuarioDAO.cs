using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Entidad;

namespace WindowsFormsApp3.DAO
{
    public class UsuarioDAO
    {
        private static int contadorIntentosFallidos = 0;

        public static int InsertarUsuario(Usuario usuario)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC InsertarUsuario  @Nombre = '" + usuario.Nombre + "', @Correo = '" + usuario.Correo + "', @Contraseña = '" + usuario.Contra + "', @Genero = '" + usuario.Genero + "', @Estatus = '" + usuario.Estatus + "', @FechaNam = '" + usuario.FechaNam.Date.ToString("yyyy-MM-dd") + "', @NomUsua = " + usuario.NomUsua + "; ";
                SqlCommand comando = new SqlCommand(query, conexion);
                
                try
                {
                    retorno = comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error de Registro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }

            return retorno;
        }

     

        public static int ObtenerUsuariosPorCorreo(string Correo)
        {
            int idUsuario = 0;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC ObtenerUsuarioPorCorreo @Correo" ;
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Correo", Correo);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    idUsuario = reader.GetInt32(0);
                   

                  

                }
                return idUsuario;

            }

        }


        public static int VerificarUsuario(string Correo, string Contra)
        {
            
            int retorno = 0;
            
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC VerificarUsuario @Correo, @Contraseña";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Correo", Correo);
                comando.Parameters.AddWithValue("@Contraseña", Contra);


                try
                {
                    retorno = comando.ExecuteNonQuery();
                 

                    contadorIntentosFallidos = 0;
                   



                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("Contraseña Incorrecta."))
                    {
                        contadorIntentosFallidos++;
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (contadorIntentosFallidos >= 3)
                        {
                            MessageBox.Show("Ha alcanzado el número máximo de intentos fallidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            retorno = 1;

                        }
                    }
                    else
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            
                    

                   

                }
            }
            return retorno;
        }

        public static int EditarUsuario(Usuario usuario)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC  EditarUsuario  @id = '" + usuario.id + "', @Nombre = '" + usuario.Nombre + "', @Correo = '" + usuario.Correo + "', @Genero = '" + usuario.Genero +  "', @FechaNam = '" + usuario.FechaNam.Date.ToString("yyyy-MM-dd") + "', @NomUsua = " + usuario.NomUsua + "; ";
                SqlCommand comando = new SqlCommand(query, conexion);

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Editar Cuenta?", "Confirmación de Edicion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        retorno = comando.ExecuteNonQuery();

                        MessageBox.Show("Cambios Guardados.", "Edicion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       

                    }
                    else
                    {

                        MessageBox.Show("Edicion Cancelada.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retorno = 0;
                    }


                   
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error de Edicion: ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            return retorno;
        }




        public static int BorrarUsuario(int usuarioId, int Estatus)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC BorrarUsuario  @id , @Estatus ";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", usuarioId);
                comando.Parameters.AddWithValue("@Estatus", Estatus);

                try
                {
                   
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar tu cuenta?", "Confirmación de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        
                        MessageBox.Show("Cuenta eliminado.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comando.ExecuteNonQuery();
                        retorno = 1;

                    }
                    else
                    {
                       
                        MessageBox.Show("Eliminación cancelada.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retorno = 0;
                    }

                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            return retorno;
        }


        public static int ActualizarContra(string correo, string Contra)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC ActualizarContraseña  @Correo,  @NuevaContraseña ";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@NuevaContraseña", Contra);

                try
                {

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cambio Exitoso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        retorno = 1;

                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            return retorno;
        }

    }
}
