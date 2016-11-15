using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace BlackBuster
{
    class ConectaBD
    {
        private MySqlConnection conexion;
        private string servidor;
        private string basedatos;
        private string usuario;
        private string password;

        //Constructor
        public ConectaBD()
        {
            Initialize();
        }

        //inicializar valores
        private void Initialize()
        {
            servidor = "localhost";
            basedatos = "blackbuster";
            usuario = "admin";
            password = "123";
            string connectionString;
            connectionString = "SERVER=" + servidor + ";" + "DATABASE=" +
            basedatos + ";" + "UID=" + usuario + ";" + "PASSWORD=" + password + ";";

            conexion = new MySqlConnection(connectionString);
        }

        //Abrir conexion a la base de datos
        private bool abrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("No se pudo realizar la conexion");
                        break;

                    case 1045:
                        System.Windows.Forms.MessageBox.Show("El usuario o contraseña no es valido, intentelo de nuevo.");
                        break;
                }
                return false;
            }
        }

        //Cerrar conexion
        private bool cerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insertar(String consulta)
        {
            if (this.abrirConexion() == true)
            {
                //crear comandero y asignar consultas
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                //Ejecutar consulta del comandero
                cmd.ExecuteNonQuery();
                //cerrar consulta
                this.cerrarConexion();
            }
        }

        //Update statement
        public void Update(String consulta)
        {
            if (this.abrirConexion() == true)
            {
                //Crear el comandero
                MySqlCommand cmd = new MySqlCommand();
                //Asignar la consulta al comandero
                cmd.CommandText = consulta;
                //Asignar la conexion al comandero
                cmd.Connection = conexion;
                //Ejecutar consulta
                cmd.ExecuteNonQuery();
                //Cerrar conexion
                this.cerrarConexion();
            }
        }

        //Delete statement
        public void Delete(String consulta)
        {
            if (this.abrirConexion() == true)
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.ExecuteNonQuery();
                this.cerrarConexion();
            }
        }
        public DataSet Select(String consulta)
        {
            DataSet list = new DataSet();
            if (this.abrirConexion() == true)
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                da.Fill(list);
                return list;
            }
            else
            {
                return list;
            }
        }
        public int Count(String consulta)
        {
            int Count = -1;

            //Open Connection
            if (this.abrirConexion() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.cerrarConexion();

                return Count;
            }
            else
            {
                return Count;
            }
        }
    }
}
