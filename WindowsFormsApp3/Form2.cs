using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.DAO;
using WindowsFormsApp3.Entidad;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Recordar)
            {
                Usu.Text = Properties.Settings.Default.Usuario;
                Contra.Text = Properties.Settings.Default.Contra;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

            string Correo= Usu.Text;
            string Contrasena = Contra.Text;
            int Verificar = 0;
            int Verificar2 = 0;
            int Verificar3 = 0;
            if (manini.Checked)
            {
                // Si se ha marcado el CheckBox de recordar usuario, guardar la información
                Properties.Settings.Default.Usuario = Correo;
                Properties.Settings.Default.Contra = Contrasena;
                Properties.Settings.Default.Save(); // Guarda los cambios en la configuración
            }
            Verificar = UsuarioDAO.VerificarUsuario(Correo, Contrasena);

            if (-1== Verificar)
            {
                Properties.Settings.Default.Correo = Correo;
                Program.form2.Hide();
                var cam = new Form4();
                cam.ShowDialog();

            }
            else
            {
                if (1 == Verificar)
                {
                    Properties.Settings.Default.Correo = Correo;

                    Verificar2=ContraPDAO.GenerarContra(UsuarioDAO.ObtenerUsuariosPorCorreo(Properties.Settings.Default.Correo));
                    if (0 != Verificar2)
                    {

                        Verificar3 = ContraPDAO.ObtenerContra(UsuarioDAO.ObtenerUsuariosPorCorreo(Properties.Settings.Default.Correo));
                        if (0 != Verificar2)
                        {
                            Program.form2.Hide();
                            var cam = new Form10();
                            cam.ShowDialog();


                        }

                    }
                        

                   

                }

            }
            
            
            

           
        }

        private void Resgistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Program.form2.Hide();
            var cam1 = new Form3();
            cam1.ShowDialog();

        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void manini_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Recordar = manini.Checked;
            if (!manini.Checked)
            {
                Properties.Settings.Default.Usuario = "";
                Properties.Settings.Default.Contra = "";
            }
            Properties.Settings.Default.Save();


        }
    }
}
