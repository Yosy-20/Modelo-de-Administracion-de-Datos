using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void favoritosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            var cam6 = new Form7();
            cam6.ShowDialog();
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
    }
}
