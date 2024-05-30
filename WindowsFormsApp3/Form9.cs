using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.DAO;
using WindowsFormsApp3.Entidad;

namespace WindowsFormsApp3
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<Versiculo> versiculos = BibliaDAO.ObtenerVersiculo();


            // Limpiar el ListBox antes de llenarlo
            Resultado.Items.Clear();

            // Llenar el ListBox con los versículos
            foreach (Versiculo versiculo in versiculos)
            {


                Resultado.Items.Add(versiculo.contenido);

                
            }
        }

        private void favoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var cam3 = new Form5();
            cam3.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var cam5 = new Form9();
            cam5.ShowDialog();
        }

        private void favoritosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            var cam6 = new Form7();
            cam6.ShowDialog();
        }

        private void historialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            var cam7 = new Form8();
            cam7.ShowDialog();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var cam10 = new Form11();
            cam10.ShowDialog();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            List<Testamento> testamentos = BibliaDAO.ObtenerTestamento();



            TestBusq.Items.Clear();

            foreach (Testamento testamento in testamentos)
            {
                TestBusq.Items.Add(testamento.Nombre);

                if (Properties.Settings.Default.UsuaTest == 0)
                {
                    BibliaDAO.Definir(testamento.Nombre, UsuarioDAO.ObtenerUsuariosPorCorreo(Properties.Settings.Default.Correo), "Español");
                    Properties.Settings.Default.UsuaTest = 1;

                }


            }






            // Añadir un manejador de eventos para cuando se cambie la selección
            TestBusq.SelectedIndexChanged += TestBusq_SelectedIndexChanged;




        }

        private void Acepbusq_Click(object sender, EventArgs e)
        {
            string palabra =  busqueda.Text;

            List<Versiculo> versiculos =BibliaDAO.Buscar(palabra);

            
            Resultado.Items.Clear();

            foreach (Versiculo versiculo in versiculos)
            {

                Resultado.Items.Add(versiculo.contenido);


            }

            BibliaDAO.Historial(UsuarioDAO.ObtenerUsuariosPorCorreo(Properties.Settings.Default.Correo), palabra);

        }

        private void TestBusq_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTestamento = TestBusq.SelectedItem.ToString();
            List<Libro> libros = BibliaDAO.ObtenerLibro();

            libBusq.Items.Clear();

            foreach (Libro libro in libros)
            {

                if (libro.NombreTestamento == selectedTestamento)
                {

                    libBusq.Items.Add(libro.Nombre);

                }

            }





        }

        private void Resultado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void libBusq_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLibro = libBusq.SelectedItem.ToString();
            List<Capitulo> capitulos = BibliaDAO.ObtenerCapitulo();

            Resultado.Items.Clear();

            foreach (Capitulo capitulo in capitulos)
            {

                if (capitulo.NombreLibro == selectedLibro)
                {

                    Resultado.Items.Add(capitulo.Nombre);

                }

            }





        }
    }
}
