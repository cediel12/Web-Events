using MySql.Data.MySqlClient;
using PaginaWeb.Models;
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
        public string contra;
        public string nombre;
        public string apellido;
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
        public DataTable ConsultarRol(string fk)
        {
            string sql = "SELECT * FROM usuario_rol WHERE idusuario_rol = '" + fk + "';";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable ConsultarUsuarios()
        {
            string sql = "SELECT * FROM usuario;";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable ConsultarEventos()
        {
            string sql = "select evento.idevento,evento.fechafin, evento.nombre, evento.fechainicio,evento.hora,recurso.lugar, recurso.tipo,recurso.digital,recurso_evento.duracion from evento inner join recurso_evento on evento.idevento=recurso_evento.evento_idevento inner join recurso on recurso_evento.recurso_idrecurso=recurso.idrecurso;";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public bool registrar(string usuario, string contrasena, string nombre, string apellido, string correo)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`pr_crearpersona`('" + nombre + "','" + apellido + "','" + usuario + "'," + contrasena + ",'" + correo + "')";
            return co.RealizarTransaccion(sql);
        }
        public bool crearevento(string nombre, string fehca, string hora, string nombrerec, string tiporecurso, string digitar, string duracion, string tipo, string fechafin)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`crear_evento`('" + nombre + "','" + fehca + "','" + hora + "','" + nombrerec + "','" + tiporecurso + "','" + digitar + "','" + duracion + "','" + tipo + "','" + fechafin + "')";
            return co.RealizarTransaccion(sql);
        }

        public DataTable menu(string idCuenta)
        {
            string sql = "select menu.`idMenu`,menu.Titulo,menu.Icono,vista.idVista,vista.nombre,vista.url,vista.icono,vista.Menu_idMenu  from menu inner join vista on menu.`idMenu`=vista.Menu_idMenu inner join rol_vista on vista.idVista = rol_vista.vista_idVista inner join rol on rol.idRol = rol_vista.rol_idRol inner join usuario_rol on usuario_rol.Rol_idRol = rol.idRol inner join usuario on usuario.idusuario = usuario_rol.Usuario_idUsuario where usuario.idusuario =" + idCuenta + "; ";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }
        
        public DataTable consultarevento(string nombre)
        {
            string sql = "SELECT * FROM evento WHERE nombre = '" + nombre + "';";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }

       
        
    }

}