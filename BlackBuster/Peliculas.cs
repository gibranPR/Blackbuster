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
            string consulta = "SELECT `video`.`codigo`, `video`.`Descripcion`, `video`.`Precio`, `tipo`.`NombreTipo` FROM `video` inner join `tipo` on `tipo`.`Id` = `video`.`Tipo` order by `video`.`codigo`;";
            ConectaBD accion = new ConectaBD();
            DataSet aux = accion.Select(consulta);
            tablinha.DataSource = aux.Tables[0];
            tablinha.Columns[0].Width = 45;
            tablinha.Columns[1].Width = 145;
            tablinha.Columns[2].Width = 70;
            tablinha.Columns[3].Width = 90;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < pelicula.Length; i++)
                pelicula[i] = tablinha.CurrentRow.Cells[i].Value.ToString();
            Renta.rent.insertaTablao(pelicula);
        }
    }
}
