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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
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

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var cam5 = new Form9();
            cam5.ShowDialog();
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

        private void Form8_Load(object sender, EventArgs e)
        {

            List<Historial> histo = BibliaDAO.MostrarHistorial();


            Historial.Items.Clear();

            foreach (Historial historial in histo)
            {
                string item = $"Usuario: {historial.Usuario} - Palabra: {historial.palabra} - Fecha: {historial.Fecha}";

                Historial.Items.Add(item);


            }



        }

        private void FechaR_CheckedChanged(object sender, EventArgs e)
        {
            List<Historial> histo = BibliaDAO.OrdenarH();


            Historial.Items.Clear();

            foreach (Historial historial in histo)
            {
                string item = $"Palabra: {historial.palabra} - Fecha: {historial.Fecha}";

                Historial.Items.Add(item);


            }




        }

        private void Allhist_CheckedChanged(object sender, EventArgs e)
        {
            List<Historial> histo = BibliaDAO.MostrarHistorial();


            Historial.Items.Clear();

            foreach (Historial historial in histo)
            {
                string item = $"Usuario: {historial.Usuario} - Palabra: {historial.palabra} - Fecha: {historial.Fecha}";

                Historial.Items.Add(item);


            }
        }

        private void Meshist_CheckedChanged(object sender, EventArgs e)
        {
            List<Historial> histo = BibliaDAO.OrdenarHM();


            Historial.Items.Clear();

            foreach (Historial historial in histo)
            {
                string item = $"Palabra: {historial.palabra} - Fecha: {historial.Fecha}";

                Historial.Items.Add(item);


            }


        }

        private void Anhist_CheckedChanged(object sender, EventArgs e)
        {
            List<Historial> histo = BibliaDAO.OrdenarHA();


            Historial.Items.Clear();

            foreach (Historial historial in histo)
            {
                string item = $"Palabra: {historial.palabra} - Fecha: {historial.Fecha}";

                Historial.Items.Add(item);


            }


        }

        private void Elimhist_Click(object sender, EventArgs e)
        {
            int idSeleccionado;
            if (int.TryParse(Properties.Settings.Default.select, out idSeleccionado))
            {
                BibliaDAO.EliminarH(idSeleccionado);
            }
            else
            {
                MessageBox.Show("El ID seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Historial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHistorial = Historial.SelectedItem.ToString();

            Properties.Settings.Default.select=selectedHistorial;

        }
    }
}
