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
    public partial class Selecciona : Form
    {
        public static int opcion = 0;
        private ConectaBD accion = new ConectaBD();
        public Selecciona(int o)
        {
            opcion = o;
            InitializeComponent();
            carga();
        }
        public void setOpcion(int o)
        {
            opcion = o;
        }
        private void carga()
        {
            switch (opcion)
            {
                case 1:
                    totalCliente();
                    break;
                case 2:
                    totalTipo();
                    break;
                case 3:
                    totalMembresia();
                    break;
            }
        }

        private void totalMembresia()
        {
            lblAux.Text = "Selecciona el tipo de membresia \ny genera el reporte del total vendido.";
            string consulta = "SELECT * FROM `membresia`;";
            DataSet aux = accion.Select(consulta);
            cmbAux.DataSource = aux.Tables[0];
            cmbAux.ValueMember = "Id";
            cmbAux.DisplayMember = "Nombre";
        }

        private void totalTipo()
        {
            lblAux.Text = "Selecciona el tipo de pelicula \ny genera el reporte del total vendido.";
            string consulta = "SELECT * FROM `tipo`;";
            DataSet aux = accion.Select(consulta);
            cmbAux.DataSource = aux.Tables[0];
            cmbAux.ValueMember = "Id";
            cmbAux.DisplayMember = "NombreTipo";
        }

        private void totalCliente()
        {
            lblAux.Text = "Selecciona el número de cliente \ny genera el reporte del total vendido.";
            string consulta = "SELECT * FROM `cliente`;";
            DataSet aux = accion.Select(consulta);
            cmbAux.DataSource = aux.Tables[0];
            cmbAux.ValueMember = "Id";
            cmbAux.DisplayMember = "Id";
        }
        private String getElemento()
        {
            return cmbAux.SelectedValue.ToString();
        }
        private String generaTotal(String consulta)
        {
            DataSet aux = accion.Select(consulta);
            String total = aux.Tables[0].Rows[0].ItemArray[0].ToString();
            if (total == "")
                return "0.00";
            return total;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            switch(opcion)
            {
                case 1:
                    MessageBox.Show("$ "+generaTotal("SELECT sum(video.Precio) from renta inner join cliente on cliente.Id = renta.Cliente INNER JOIN detalle_renta on detalle_renta.Folio = renta.Folio INNER JOIN video on video.Codigo = detalle_renta.Video where cliente.Id = " + getElemento()));
                    break;
                case 2:
                    MessageBox.Show("$ " + generaTotal("SELECT sum(video.Precio) from renta inner join cliente on cliente.Id = renta.Cliente INNER JOIN detalle_renta on detalle_renta.Folio = renta.Folio INNER JOIN video on video.Codigo = detalle_renta.Video INNER JOIN tipo on tipo.Id = video.Tipo where Tipo.Id = " + getElemento()));
                    break;
                case 3:
                    MessageBox.Show("$ " + generaTotal("SELECT sum(video.Precio) from renta inner join cliente on cliente.Id = renta.Cliente INNER JOIN detalle_renta on detalle_renta.Folio = renta.Folio INNER JOIN video on video.Codigo = detalle_renta.Video INNER JOIN membresia on membresia.Id = cliente.Membresia where Membresia.Id = " + getElemento()));
                    break;
            }    
        }
    }
}
