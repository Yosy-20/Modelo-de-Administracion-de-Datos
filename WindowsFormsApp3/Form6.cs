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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void regresarcon_Click(object sender, EventArgs e)
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

        private void Form6_Load(object sender, EventArgs e)
        {
            string selectedCap= Properties.Settings.Default.Versiculo;
            List<Versiculo> versiculos =BibliaDAO.ObtenerVersiculo();

           

            // Limpiar el ListBox antes de llenarlo
            cita.Items.Clear();

            // Llenar el ListBox con los versículos
            foreach (Versiculo versiculo in versiculos)
            {
                if (versiculo.NombreCapitulo == selectedCap)
                {

                    cita.Items.Add(versiculo.cita);

                }

            }

            cita.SelectedIndexChanged += Cita_SelectedIndexChanged;


        }

        private void Cita_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCita = cita.SelectedItem.ToString();

            List<Versiculo> versiculos = BibliaDAO.ObtenerVersiculo();



            // Limpiar el ListBox antes de llenarlo
            Versiculo.Items.Clear();

            // Llenar el ListBox con los versículos
            foreach (Versiculo versiculo in versiculos)
            {
                if (versiculo.cita == selectedCita)
                {

                    Versiculo.Items.Add(versiculo.contenido);

                }

            }


        }

        private void limcons_Click(object sender, EventArgs e)
        {
            Versiculo.Items.Clear();
            cita.Items.Clear();



        }
    }
}
