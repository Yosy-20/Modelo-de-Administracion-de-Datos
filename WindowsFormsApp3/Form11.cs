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
    public partial class Form11 : Form
    {
        int idUsuario = 0;

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            genusu.Items.Add("Masculino");
            genusu.Items.Add("Femenino");
        }
        private void favoritosToolStripMenuItem1_Click(object sender, EventArgs e)
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
            var cam10= new Form11();
            cam10.ShowDialog();
        }

        private void elimusu_Click(object sender, EventArgs e)
        {

            int verificar = 0;
            idUsuario = UsuarioDAO.ObtenerUsuariosPorCorreo(Properties.Settings.Default.Correo);
            verificar = UsuarioDAO.BorrarUsuario(idUsuario, 0);

            if (1== verificar)
            {

                Application.Exit();

            }
           

        }

        private void Aceusu_Click(object sender, EventArgs e)
        {
            idUsuario = UsuarioDAO.ObtenerUsuariosPorCorreo(Properties.Settings.Default.Correo);
           

            Usuario usuario = new Usuario();

            usuario.id = idUsuario;
            usuario.Nombre = nomusu.Text + apeusu.Text;
            usuario.FechaNam = dateusu.Value.Date;
            usuario.Correo = corusu.Text;
            usuario.Genero = genusu.SelectedItem?.ToString();
            usuario.NomUsua = usu.Text;

            UsuarioDAO.EditarUsuario(usuario);

            
        }
    }
}
