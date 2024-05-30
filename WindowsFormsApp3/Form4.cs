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

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void español_Click(object sender, EventArgs e)
        {
          

            this.Hide();
            var cam3 = new Form5();
            cam3.ShowDialog();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
