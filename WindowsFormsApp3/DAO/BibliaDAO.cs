using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Entidad;

namespace WindowsFormsApp3.DAO
{
    public class BibliaDAO
    {
        public static void Definir(string idTestamento, int idUsuario, string idioma)
        {


            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC DefinirIdioma @idTestamento, @idUsuario, @idioma";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idTestamento", idTestamento);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                comando.Parameters.AddWithValue("@idioma", idioma);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }

        public static List<Testamento> ObtenerTestamento()
        {
            List<Testamento> lista = new List<Testamento>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT Nombre FROM VistaTestamento";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Testamento testamento = new Testamento();

                    testamento.Nombre = reader.GetString(0);


                    lista.Add(testamento);

                }
                return lista;

            }


        }

        public static List<Libro> ObtenerLibro()
        {
            List<Libro> lista = new List<Libro>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT NombreLibro, NumeroLibro, idTestamento, NombreTestamento FROM VistaLibro";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro();

                    libro.Nombre = reader.GetString(0);
                    libro.idLibro = reader.GetInt32(1);
                    libro.idTestamento = reader.GetString(2);
                    libro.NombreTestamento = reader.GetString(3);

                    lista.Add(libro);

                }
                return lista;

            }




        }

        public static List<Capitulo> ObtenerCapitulo()
        {
            List<Capitulo> lista = new List<Capitulo>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT NumeroCapitulo, NombreCapitulo, idLibro, NombreLibro FROM VistaCapitulo";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Capitulo capitulo = new Capitulo();

                    capitulo.Nombre = reader.GetString(1);
                    capitulo.idCapitulo = reader.GetInt32(0);
                    capitulo.idLibro = reader.GetInt32(2);
                    capitulo.NombreLibro = reader.GetString(3);

                    lista.Add(capitulo);

                }
                return lista;

            }

        }


        public static List<Versiculo> ObtenerVersiculo()
        {
            List<Versiculo> lista = new List<Versiculo>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT NumeroVersiculo, CitaVersiculo, ContenidoVersiculo, idCapitulo, NombreCapitulo FROM VistaVersiculo";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Versiculo versiculo = new Versiculo();

                    versiculo.cita = reader.GetString(1);
                    versiculo.idVersiculo = reader.GetInt32(0);
                    versiculo.idCapitulo = reader.GetInt32(3);
                    versiculo.contenido = reader.GetString(2);
                    versiculo.NombreCapitulo = reader.GetString(4);

                    lista.Add(versiculo);

                }
                return lista;

            }

        }


        public static List<Versiculo> Buscar(string Palabra)
        {
            List<Versiculo> lista = new List<Versiculo>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC BuscarVersiculo @PalabraClave";
                SqlCommand comando = new SqlCommand(query, conexion);
                try
                {
                    comando.Parameters.AddWithValue("@PalabraClave", Palabra);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Versiculo versiculo = new Versiculo();

                        versiculo.cita = reader.GetString(1);
                        versiculo.idVersiculo = reader.GetInt32(0);
                        versiculo.idCapitulo = reader.GetInt32(3);
                        versiculo.contenido = reader.GetString(2);
                        versiculo.NombreCapitulo = reader.GetString(4);

                        lista.Add(versiculo);
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            return lista;
        }



        public static void Historial(int idUsuario, string Palabra)
        {
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC RegistrarHistorial  @idUsuario, @palabra";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                comando.Parameters.AddWithValue("@palabra", Palabra);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }


        public static List<Historial> MostrarHistorial()
        {
            List<Historial> lista = new List<Historial>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT NombreUsuario, PalabraBuscada, FechaBusqueda FROM VistaHistorial";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Historial historial = new Historial();

                    historial.Usuario = reader.GetString(0);
                    historial.palabra = reader.GetString(1);
                    historial.Fecha = reader.GetDateTime(2);


                    lista.Add(historial);

                }
                return lista;

            }

        }


        public static List<Historial> OrdenarH()
        {
            List<Historial> lista = new List<Historial>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC OrdenarHistorial";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Historial historial = new Historial();

                   
                    historial.palabra = reader.GetString(0);
                    historial.Fecha = reader.GetDateTime(1);


                    lista.Add(historial);

                }
                return lista;

            }




        }

        public static List<Historial> OrdenarHM()
        {
            List<Historial> lista = new List<Historial>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC OrdenarHistorialMes";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Historial historial = new Historial();


                    historial.palabra = reader.GetString(0);
                    historial.Fecha = reader.GetDateTime(1);


                    lista.Add(historial);

                }
                return lista;

            }




        }


        public static List<Historial> OrdenarHA()
        {
            List<Historial> lista = new List<Historial>();
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC OrdenarHistorialAn";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Historial historial = new Historial();


                    historial.palabra = reader.GetString(0);
                    historial.Fecha = reader.GetDateTime(1);


                    lista.Add(historial);

                }
                return lista;

            }




        }

        public static void EliminarH(int id)
        {
            
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC EliminarHistorial @id";
                SqlCommand comando = new SqlCommand(query, conexion);
          
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    comando.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }




        }


    }
}
