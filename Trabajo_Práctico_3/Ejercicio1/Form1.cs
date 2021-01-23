using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            String servidor = txtServidor.Text;
            String puerto = txtPuerto.Text;
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;
            String bd = txtBb.Text;
            String cadenaConexion = "Database = " + bd + "; Data Source = " + servidor + "; Port = " + puerto + "; User Id = " + usuario + "; Password = " + password;
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null;
            String data = null;
            try
            {
                String consulta = "SHOW DATABASES";
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Connection = conexionBD;
                conexionBD.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    data += reader.GetString(0) + "\n";
                }
                MessageBox.Show(data);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
