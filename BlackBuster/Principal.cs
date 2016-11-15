using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlackBuster
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por:\nGibran Piedra\nEduardo Leon\nJorge Navarrete");
        }

        private void totalDeVentasDiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hacerVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Renta renta = new Renta();
            renta.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
