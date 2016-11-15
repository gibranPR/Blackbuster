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
    public partial class Peliculas : Form
    {
        public String[] pelicula = new string[4];
        public Peliculas()
        {
            InitializeComponent();
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {
            string consulta = "Select * from Video;";
            ConectaBD accion = new ConectaBD();
            DataSet aux = accion.Select(consulta);
            tablinha.DataSource = aux.Tables[0];
            tablinha.Columns[0].Width = 45;
            tablinha.Columns[1].Width = 145;
            tablinha.Columns[2].Width = 70;
            tablinha.Columns[3].Width = 40;
        }
    }
}
