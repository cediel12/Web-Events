using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebProgramacion.Models
{
    public class Usuario
    {
        public string usuario;
        public string contrasena;
        public string nombre;
        public string fk;
        public string correo;

        public Usuario()
        {

        }

        Conexion co = new Conexion();


        public DataTable ValidarPersona(string usuario, string contrasenia)
        {

            string sql = "SELECT * FROM usuario WHERE usuario = '" + usuario + "' AND contraseña = '" + contrasenia + "';";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }

        public int registrar(string usuario, string contrasena, string nombre, string apellido, string correo)
        {
            DataTable dt;
            string sql = "CALL `web`.`pr_crearpersona`('"+nombre+"','"+ apellido+"','" + usuario +"','" + contrasena +"','" + correo + "')";
            co.EjecutarConsulta(sql, CommandType.Text);
            dt = ValidarPersona(usuario,contrasena);
            if (dt.Rows.Count>0)
            {
            return 1;

            }
            else
            {
                return 2;
            }
        }

        public DataTable menu(string idCuenta)
        {
            string sql= "select menu.`idMenu`,menu.Titulo,menu.Icono,vista.idVista,vista.nombre,vista.url,vista.icono,vista.Menu_idMenu  from menu inner join vista on menu.`idMenu`=vista.Menu_idMenu inner join rol_vista on vista.idVista = rol_vista.vista_idVista inner join rol on rol.idRol = rol_vista.rol_idRol inner join usuario_rol on usuario_rol.Rol_idRol = rol.idRol inner join usuario on usuario.idusuario = usuario_rol.Usuario_idUsuario where usuario.idusuario =" + idCuenta+"; ";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }
    }

}