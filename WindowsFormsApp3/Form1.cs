using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.DAO;

namespace WindowsFormsApp3
{
    public partial class nuvcontra : Form
    {
        public nuvcontra()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void acnueva_Click(object sender, EventArgs e)
        {
            string Correo = Properties.Settings.Default.Correo; 
            string Contrasena = provnuev.Text;
            string ConContrasena = nuevcontra.Text;
            int Verificar = 1;

            if (Contrasena==ConContrasena)
            {

                Verificar= UsuarioDAO.ActualizarContra(Correo, ConContrasena);
                if (1==Verificar)
                {
                    this.Close();
                    Program.form2.Show();

                }


            }
            else
            {

                MessageBox.Show("Las Contraseñas no coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

           
        }
    }
}
