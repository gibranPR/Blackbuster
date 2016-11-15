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
    public partial class Renta : Form
    {
        public Renta()
        {
            InitializeComponent();
        }

        private void Renta_Load(object sender, EventArgs e)
        {
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            agregando();
        }

        private void agregando()
        {
            Peliculas peli = new Peliculas();
            peli.Show();
        }
        

        private void Renta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                agregando();
            }   
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            string consulta = "Select Nombre from cliente where Id = " + txtNumero.Value + ";";
            ConectaBD accion = new ConectaBD();
            DataSet aux = accion.Select(consulta);
            String name = aux.Tables[0].Rows[0].ItemArray[0].ToString();
            txtNombre.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
