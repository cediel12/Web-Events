using MySql.Data.MySqlClient;
using PaginaWeb.Models;
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

       
        public bool Transaction(Transaction[] list)
        {
            bool state = false;
            MySqlConnection conn = new MySqlConnection();
            MySqlCommand cmd = null;
            conn = ConexionMySQL();

            MySqlTransaction Transa = conn.BeginTransaction();

            try
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] == null) continue;

                    cmd = new MySqlCommand(list[i].Procedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (Parameter obj in list[i].Parameters)
                    {
                        cmd.Parameters.Add(obj.Name, obj.Value);

                    }
                    cmd.Transaction = Transa;
                    cmd.ExecuteNonQuery();
                }
                Transa.Commit();
                conn.Close();
                conn.Dispose();
                Transa.Dispose();
                state = true;
            }
            catch (Exception)
            {
                Transa.Rollback();
                conn.Close();
                conn.Dispose();
                state = false;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
            return state;
        }

        public bool RealizarTransaccion(string[] cadena)
        {
            bool state = false;
            if (Conectar())
            {
                MySqlTransaction Transa = conexion.BeginTransaction();
                MySqlCommand cmd = null;
                try
                {
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        if (cadena[i].Length > 0)
                        {
                            cmd = new MySqlCommand(cadena[i], conexion);
                            cmd.Transaction = Transa;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Transa.Commit();
                    conexion.Close();
                    conexion.Dispose();
                    Transa.Dispose();
                    Desconectar();
                    state = true;
                }
                catch
                {
                    Transa.Rollback();
                    conexion.Close();
                    conexion.Dispose();
                    Desconectar();
                    state = false;
                }
                finally
                {
                    // Recolectamos objetos para liberar su memoria.
                    if (cmd != null)
                    {
                        cmd.Dispose();
                    }
                }
            }
            return state;
        }
    }
}