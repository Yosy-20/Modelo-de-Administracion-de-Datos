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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();



            genreg.Items.Add("Masculino");
            genreg.Items.Add("Femenino");


        }

        private void Acepreg_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Nombre = nomreg.Text + apereg.Text;
            usuario.FechaNam = datereg.Value.Date;
            usuario.Correo = correg.Text;
            usuario.Contra = contrareg.Text;
            usuario.Genero = genreg.SelectedItem?.ToString();
            usuario.NomUsua = usureg.Text;
            usuario.Estatus = 1;

            UsuarioDAO.InsertarUsuario(usuario);

            Program.form2.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.form2.Show();
            this.Close();
        }

       


    }
}
