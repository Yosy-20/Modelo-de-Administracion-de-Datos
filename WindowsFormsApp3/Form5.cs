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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();


        }

        private void Acepconst_Click(object sender, EventArgs e)
        {
            string selectedCap = capcons.SelectedItem.ToString();
            Properties.Settings.Default.Versiculo = selectedCap;
            this.Hide();
            var cam4 = new Form6();
            cam4.ShowDialog();
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
            var cam6=new Form7();
            cam6.ShowDialog();
        }

        private void historialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            var cam7 = new Form8();
            cam7.ShowDialog();
        }

        private void favoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var cam3 = new Form5();
            cam3.ShowDialog();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var cam10 = new Form11();
            cam10.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            List<Testamento> testamentos = BibliaDAO.ObtenerTestamento();



            testcons.Items.Clear();

            foreach (Testamento testamento in testamentos)
            {
                testcons.Items.Add(testamento.Nombre);

                if (Properties.Settings.Default.UsuaTest == 0)
                {
                    BibliaDAO.Definir(testamento.Nombre, UsuarioDAO.ObtenerUsuariosPorCorreo(Properties.Settings.Default.Correo), "Español");
                    Properties.Settings.Default.UsuaTest = 1;

                }


            }
            
            




            // Añadir un manejador de eventos para cuando se cambie la selección
            testcons.SelectedIndexChanged += Testcons_SelectedIndexChanged;
        }
        private void Testcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTestamento = testcons.SelectedItem.ToString();
            List<Libro> libros = BibliaDAO.ObtenerLibro();

            libcons.Items.Clear();
            
            foreach (Libro libro in libros)
            {

                if (libro.NombreTestamento== selectedTestamento)
                {

                    libcons.Items.Add(libro.Nombre);

                }
                    
            }

            // Añadir un manejador de eventos para cuando se cambie la selección
            libcons.SelectedIndexChanged += Libcons_SelectedIndexChanged;

        }

        private void Libcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLibro = libcons.SelectedItem.ToString();
            List<Capitulo> capitulos = BibliaDAO.ObtenerCapitulo();

            capcons.Items.Clear();

            foreach (Capitulo capitulo in capitulos)
            {

                if (capitulo.NombreLibro == selectedLibro)
                {

                    capcons.Items.Add(capitulo.Nombre);

                }

            }

            

        }





    }
}
