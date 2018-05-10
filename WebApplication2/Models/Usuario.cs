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
        public DataTable consultartemas(int a)
        {
            string sql = "select tema.idtema, tema.tema,tema.fecha,tema.tiempo from tema inner join tema_evento on tema_evento.tema_idtema=tema.idtema inner join evento on tema_evento.evento_idevento=evento.idevento and evento.idevento=" + a;
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable ConsultarEventos()
        {
            string sql = "select evento.idevento,evento.fechafin, evento.nombre_e, evento.fechainicio,evento.hora,recurso.tipo, usuario.nombre from evento inner join recurso_evento on evento.idevento=recurso_evento.evento_idevento inner join recurso on recurso_evento.recurso_idrecurso=recurso.idrecurso inner join usuario on usuario.idusuario=evento.usuario;";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public bool creartema(string nombre, string fecha, string hora, int idevento)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`crear_temas`('" + nombre + "','" + fecha + "','" + hora + "'," + idevento + ")";
            return co.RealizarTransaccion(sql);
        }
        public bool registrar(string usuario, string contrasena, string nombre, string apellido, string correo)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`pr_crearpersona`('" + nombre + "','" + apellido + "','" + usuario + "'," + contrasena + ",'" + correo + "')";
            return co.RealizarTransaccion(sql);
        }
        public bool registrarusuarioadmin(string usuario, string contrasena, string nombre, string apellido, string correo, int rol)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`pr_crearpersonaadmin`('" + nombre + "','" + apellido + "','" + usuario + "'," + contrasena + ",'" + correo + "'," + rol + ")";
            return co.RealizarTransaccion(sql);
        }
        public bool crearevento(string nombre, string fechainicio, string fechafin, string hora, string lugar, int iduser)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`crear_eventoAdmin`('" + nombre + "','" + fechainicio + "','" + fechafin + "','" + hora + "','" + lugar + "'," + iduser + ")";
            return co.RealizarTransaccion(sql);
        }

        public DataTable menu(string idCuenta)
        {

            string sql = "select menu.`idMenu`,menu.Titulo,menu.Icono,vista.idVista,vista.nombre,vista.url,vista.icono,vista.Menu_idMenu  from menu inner join vista on menu.`idMenu`=vista.Menu_idMenu inner join rol_vista on vista.idVista = rol_vista.vista_idVista inner join rol on rol.idRol = rol_vista.rol_idRol inner join usuario_rol on usuario_rol.Rol_idRol = rol.idRol inner join usuario on usuario.idusuario = usuario_rol.Usuario_idUsuario where usuario.idusuario =" + idCuenta + "; ";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable consultarnombreusuario(string nombre)
        {
            string sql = "SELECT * FROM usuario WHERE usuario = '" + nombre + "';";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }

        public DataTable inscribirevento(int iduser, int idboton)
        {
            string sql = "SELECT * FROM evento_usuario WHERE usuario_idusuario = " + iduser + " and evento_idevento=" + idboton + ";";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }
        public bool registrarevento(int iduser, int idevent)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`registrar_evento`(" + idevent + "," + iduser + ")";
            return co.RealizarTransaccion(sql);
        }
        public DataTable consultartemas(string idevento)
        {
            string sql = "select evento.idevento,evento.fechafin, evento.nombre, evento.fechainicio,evento.hora,recurso.lugar, recurso.tipo,recurso.digital,recurso_evento.duracion from evento inner join recurso_evento on evento.idevento=recurso_evento.evento_idevento inner join recurso on recurso_evento.recurso_idrecurso=recurso.idrecurso;";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable consutaruserevento(int a)
        {
            string sql = "select evento_usuario.idevento_usuario,usuario.nombre, usuario.apellido, usuario.usuario from usuario inner join evento_usuario on evento_usuario.usuario_idusuario=usuario.idusuario inner join evento on evento_usuario.evento_idevento=evento.idevento and evento.idevento=" + a;
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
    }

}