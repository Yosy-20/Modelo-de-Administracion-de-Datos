using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.DAO;

namespace WindowsFormsApp3
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {


        }

        private void Ingex_Click(object sender, EventArgs e)
        {
            string Correo = Usuario.Text;
            string ContrasenaP = ContraP.Text;
            int Verificar = 0;

            Verificar = ContraPDAO.VerificarIngreso(Correo, ContrasenaP);

            if (0!= Verificar)
            {
                this.Hide();
                var cam = new nuvcontra();
                cam.ShowDialog();


            }
           


        }
    }
}
