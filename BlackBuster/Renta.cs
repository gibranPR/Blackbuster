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
        public static Renta rent;
        ConectaBD accion = new ConectaBD();
        public Renta()
        {
            InitializeComponent();
            rent = this;
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
            
            DataSet aux = accion.Select(consulta);
            try
            {
                String name = aux.Tables[0].Rows[0].ItemArray[0].ToString();
                txtNombre.Text = name;
            }catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show("No se encontró el cliente, "+ex);
            }
            
        }

        public void insertaTablao(String [] si)
        {
            tablao.Rows.Add(si);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int getFolio()
        {
            string consulta = "Select max(folio) from renta;";
            DataSet aux = accion.Select(consulta);
            String num = aux.Tables[0].Rows[0].ItemArray[0].ToString();
            return int.Parse(num);
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            //Agregamos la renta
            String consulta = "INSERT INTO `renta` (`Fecha`, `Cliente`) VALUES ('"+ txtFecha.Value.ToString("yyyy-MM-dd HH:mm") + "', '"+ txtNumero.Value.ToString() + "');";
            accion.Insertar(consulta);
            //Agregamos el detalle de la renta
            for (int i = 0; i < tablao.RowCount-1; i++) {
                consulta = "INSERT INTO `detalle_renta` (`Folio`, `Video`) VALUES ('"+getFolio()+"', '"+tablao.Rows[i].Cells[0].Value.ToString()+"');";
                accion.Insertar(consulta);
            }
        }
    }
}
