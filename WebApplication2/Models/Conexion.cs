using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebProgramacion.Models
{
    public class Conexion
    {
        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["Event_Connection"].ConnectionString);
        private string stringConnection = ConfigurationManager.ConnectionStrings["Event_Connection"].ConnectionString;
        private bool Conectar()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void Desconectar()
        {
            conexion.Close();
        }

        public MySqlConnection ConexionMySQL()
        {
            MySqlConnection Connection = new MySqlConnection(stringConnection);

            try
            {
                Connection.Open();
            }
            catch (Exception exc)
            {
                throw new Exception("No se realizó la conexión a la base de pameters: " + exc.Message);
            }

            return Connection;
        }

        public DataTable EjecutarConsulta(string sentencia, CommandType TipoComando)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = new MySqlCommand(sentencia, conexion);
            adaptador.SelectCommand.CommandType = TipoComando;

            DataSet resultado = new DataSet();
            adaptador.Fill(resultado);

            return resultado.Tables[0];
        }
    }
}