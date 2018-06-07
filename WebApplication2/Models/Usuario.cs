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
            string sql = "select concat(usuario.nombre,' ',usuario.apellido) as nombrecompeto,usuario.usuario,usuario.correo, usuario.cedula from usuario;";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable Consultaruser(string username)
        {
            string sql = "select * from usuario where usuario.usuario='" + username + "';";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable consultareventopornombre(string username)
        {
            string sql = "SELECT evento.idevento,date_format(curdate(), ' %d/%c/%Y') as fechaactual, evento.nombre_e, evento.duracion from evento where evento.nombre_e='" + username + "';";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable consultarponentes()
        {
            string sql = "select usuario.usuario,usuario.idusuario,usuario.nombre, usuario.apellido from usuario inner join usuario_rol on usuario_rol.usuario_idusuario=usuario.idusuario inner join rol on rol.idrol=usuario_rol.rol_idrol and rol.idrol=3";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable consultartemas(int a)
        {
            string sql = "select tema.idtema, tema.tema,date_format(tema.fecha,' %d-%c-%Y') as fechatema, time_format(tema.tiempo, '%h:%i %p') as horatema,concat(usuario.nombre,' ',usuario.apellido) as nombrecompeto from tema_evento inner join tema on tema_evento.tema_idtema=tema.idtema left join tema_usuario on tema_usuario.tema_idtema=tema.idtema left join usuario on usuario.idusuario=tema_usuario.usuario_idusuario where tema_evento.evento_idevento=" + a;
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable ConsultarEventos()
        {
            string sql = "select evento.idevento,date_format(evento.fechafin,' %d-%c-%Y') as fechafin , evento.nombre_e,date_format(evento.fechainicio, ' %d-%c-%Y') as fechainicio,time_format(evento.hora, '%h:%i %p') as horaevento,recurso.tipo, usuario.nombre from evento inner join recurso_evento on evento.idevento=recurso_evento.evento_idevento inner join recurso on recurso_evento.recurso_idrecurso=recurso.idrecurso inner join usuario on usuario.idusuario=evento.usuario and evento.fechainicio > curdate();";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable eventosdirector(int iduser)
        {
            string sql = "select evento.idevento,date_format(evento.fechafin,' %d-%c-%Y') as fechafin , evento.nombre_e,date_format(evento.fechainicio, ' %d-%c-%Y') as fechainicio,time_format(evento.hora, '%h:%i %p') as horaevento,recurso.tipo, usuario.nombre from evento inner join recurso_evento on evento.idevento=recurso_evento.evento_idevento inner join recurso on recurso_evento.recurso_idrecurso=recurso.idrecurso inner join usuario on usuario.idusuario=evento.usuario and evento.fechainicio > curdate() and evento.usuario=" +iduser + ";";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable ConsultarEventostodos()
        {
            string sql = "select evento.idevento,date_format(evento.fechafin,' %d-%c-%Y') as fechafin , evento.nombre_e,date_format(evento.fechainicio, ' %d-%c-%Y') as fechainicio,time_format(evento.hora, '%h:%i %p') as horaevento,recurso.tipo, usuario.nombre from evento inner join recurso_evento on evento.idevento=recurso_evento.evento_idevento inner join recurso on recurso_evento.recurso_idrecurso=recurso.idrecurso inner join usuario on usuario.idusuario=evento.usuario;";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable ConsultarEventosiniciados()
        {
            string sql = "SELECT * FROM web.evento where fechainicio<=CURDATE() and fechafin>=CURDATE();";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable ConsultarEventosiniciadosdirector(int iduser)
        {
            string sql = "SELECT * FROM web.evento where fechainicio<=CURDATE() and fechafin>=CURDATE() and evento.usuario=" + iduser + ";";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable ConsultarEventosInscritos(int a)
        {
            string sql = "select evento.idevento,date_format(evento.fechafin,' %d-%c-%Y') as fechafin , evento.nombre_e,date_format(evento.fechainicio, ' %d-%c-%Y') as fechainicio,time_format(evento.hora, '%h:%i %p') as horaevento,recurso.tipo, usuario.nombre from evento inner join recurso_evento on evento.idevento=recurso_evento.evento_idevento inner join recurso on recurso_evento.recurso_idrecurso=recurso.idrecurso inner join usuario on usuario.idusuario=evento.usuario inner join evento_usuario on evento_usuario.evento_idevento=evento.idevento and evento.fechainicio > curdate() and evento_usuario.usuario_idusuario=" + a + ";";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }

        public bool creartema(string nombre, string fecha, string hora, int idevento, int iduser)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`crear_temas`('" + nombre + "','" + fecha + "','" + hora + "'," + idevento + "," + iduser + ")";
            return co.RealizarTransaccion(sql);
        }
        public bool registrar(string usuario, string contrasena, string nombre, string apellido, string correo, int cedula)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`pr_crearpersona`('" + nombre + "','" + apellido + "','" + usuario + "'," + contrasena + ",'" + correo + "," + cedula + "')";
            return co.RealizarTransaccion(sql);
        }
        public bool registrarusuarioadmin(string usuario, string contrasena, string nombre, string apellido, string correo, int rol, int cedula)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`pr_crearpersonaadmin`('" + nombre + "','" + apellido + "','" + usuario + "'," + contrasena + ",'" + correo + "'," + rol + "," + cedula + ")";
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

        public DataTable inscribirevento(int iduser, int idevento)
        {
            string sql = "SELECT * FROM evento_usuario WHERE usuario_idusuario = " + iduser + " and evento_idevento=" + idevento + ";";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }
        public DataTable consultarasistencia(int idregistro)
        {
            string sql = "select * from ingreso_refrigerio where evento_usuarioid=" + idregistro + " and fecha=CURDATE();";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }
        public DataTable buscardelet(int iduser, int idevento)
        {
            string sql = "select evento_usuario.idevento_usuario from evento_usuario where evento_usuario.evento_idevento=" + idevento + " and evento_usuario.usuario_idusuario=" + iduser + ";";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }
        public bool actualizarinscripcionmañana(int idregistro)
        {
            string[] sql = new string[1];
            sql[0] = "update web.ingreso_refrigerio set ingreso_refrigerio.asistenciamañana=1 where evento_usuarioid=" + idregistro + ";";
            return co.RealizarTransaccion(sql);
        }
        public bool actualizarusuario(string nombre,string apellido, string correo, int cedula, int idregistro)
        {
            string[] sql = new string[1];
            sql[0] = "update web.usuario set nombre='"+nombre+"',apellido='"+apellido+"',correo='"+correo+"',cedula="+cedula+ " where idusuario=" + idregistro + ";";
            return co.RealizarTransaccion(sql);
        }
        public bool actualizarrefrigeriomañana(int idregistro)
        {
            string[] sql = new string[1];
            sql[0] = "update web.ingreso_refrigerio set ingreso_refrigerio.meriendamañana=1 where evento_usuarioid=" + idregistro + ";";
            return co.RealizarTransaccion(sql);
        }
        public bool actualizarrefrigeriotarde(int idregistro)
        {
            string[] sql = new string[1];
            sql[0] = "update web.ingreso_refrigerio set ingreso_refrigerio.meriandatarde=1 where evento_usuarioid=" + idregistro + ";";
            return co.RealizarTransaccion(sql);
        }
        public bool actualizarinscripciontarde(int idregistro)
        {
            string[] sql = new string[1];
            sql[0] = "update web.ingreso_refrigerio set ingreso_refrigerio.asistenciatarde=1 where evento_usuarioid=" + idregistro + ";";
            return co.RealizarTransaccion(sql);
        }
        public bool registrarevento(int iduser, int idevent)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`registrar_evento`(" + idevent + "," + iduser + ")";
            return co.RealizarTransaccion(sql);
        }
        public bool registrarmañana(int idregistro)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`inscribirmañana`(" + idregistro + ",CURDATE())";
            return co.RealizarTransaccion(sql);
        }
        public bool registrartarde(int idregistro)
        {
            string[] sql = new string[1];
            sql[0] = "CALL `web`.`inscribirtarde`(" + idregistro + ",CURDATE())";
            return co.RealizarTransaccion(sql);
        }
        public DataTable consultartemas(string idevento)
        {
            string sql = "select evento.idevento,evento.fechafin, evento.nombre, evento.fechainicio,evento.hora,recurso.lugar, recurso.tipo,recurso.digital,recurso_evento.duracion from evento inner join recurso_evento on evento.idevento=recurso_evento.evento_idevento inner join recurso on recurso_evento.recurso_idrecurso=recurso.idrecurso;";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable consutaruserevento(int a)
        {
            string sql = "select usuario.idusuario, concat(usuario.nombre,' ',usuario.apellido) as nombrecompeto, usuario.usuario,usuario.correo, usuario.cedula from usuario inner join evento_usuario on evento_usuario.usuario_idusuario=usuario.idusuario inner join evento on evento_usuario.evento_idevento=evento.idevento and evento.idevento=" + a;
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable consultardirectores()
        {
            string sql = "select usuario.idusuario, concat(usuario.nombre,' ',usuario.apellido) as nombrecompeto from usuario inner join usuario_rol on usuario_rol.usuario_idusuario=usuario.idusuario where usuario_rol.rol_idrol=4;";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable consultarusuarioid(int a)
        {
            string sql = "select concat(usuario.nombre,' ',usuario.apellido)  as nombrecompeto from usuario where usuario.idevento=" + a;
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable asistenciaevento(int a)
        {
            string sql = "select distinct concat(usuario.nombre,' ',usuario.apellido) as nombrecompeto,  usuario.cedula from usuario inner join evento_usuario on evento_usuario.usuario_idusuario=usuario.idusuario inner join evento on evento_usuario.evento_idevento=evento.idevento inner join ingreso_refrigerio on ingreso_refrigerio.evento_usuarioid=evento_usuario.idevento_usuario and evento.idevento="+a+" and ingreso_refrigerio.asistenciamañana=1 and ingreso_refrigerio.asistenciatarde=1;";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable certificado(int iduser, int ideevento)
        {
            string sql = "select concat(usuario.nombre,' ',usuario.apellido) as nombrecompeto,  usuario.cedula from usuario inner join evento_usuario on evento_usuario.usuario_idusuario=usuario.idusuario inner join evento on evento_usuario.evento_idevento=evento.idevento and evento.idevento=" + ideevento + " and idusuario=" + iduser + ";";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable validarcertificado(int a)
        {
            string sql = "select count(idingreso_refrigerio) as total from ingreso_refrigerio where ingreso_refrigerio.evento_usuarioid="+a+" and asistenciamañana=1 and asistenciatarde=1;";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable buscarevento(int idevento)
        {
            string sql = "select evento.nombre_e from evento where evento.idevento=" + idevento + ";";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public DataTable buscaruserid(int iduser)
        {
            string sql = "SELECT * FROM usuario where usuario.idusuario=" + iduser + ";";
            return co.EjecutarConsulta(sql, CommandType.Text);

        }
        public bool realizarasistencia(int a, int b)
        {
            string[] sql = new string[1];
            sql[0] = "call web.asistencia(" +a +","+ b+");" ;
            return co.RealizarTransaccion(sql);

        }
        public bool eliminarinscripcion(int idevento)
        {
            string[] sql = new string[1];
            sql[0] = "call web.eliminarinscripcion(" + idevento + "); ";
            return co.RealizarTransaccion(sql);

        }

        public bool actualizarimagen(string nombreimagen, string ruta, string fecha, int estado, int usu)
        {
            string[] sql = new string[1];
            sql[0] = "call web.Insertar_imagen('" + nombre + "', '" + ruta + "', '" + fecha + "'," + estado + "," + usu + ");";
            return co.RealizarTransaccion(sql);
        }
        public DataTable Consultarevento(int dia, int mes, int ano)
        {
            string sql = "SELECT DAY(e.fechainicio) as dia,YEAR(e.fechainicio) as ano, e.hora, e.duracion, e.nombre_e FROM web.evento e WHERE MONTH(e.fechainicio) = " + mes + " and YEAR(e.fechainicio) = " + ano + " and DAY(e.fechainicio) = " + dia + " ORDER BY DAY(e.fechainicio) asc, e.hora asc ; ";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }
        public DataTable consultarimageeven(int id)
        {
            string sql = "SELECT i.ruta,i.estado,e.idevento, e.icono FROM evento e left join imagen i on e.icono = i.Id where i.estado = 1 and e.idevento =" + id + "; ";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }
        public DataTable consultarimageusu(int id)
        {
            string sql = "SELECT i.ruta,i.estado,u.idusuario, u.imagen FROM usuario u left join imagen i on u.imagen = i.Id where i.estado = 1 and u.idusuario =" + id + ";";
            return co.EjecutarConsulta(sql, CommandType.Text);
        }
    }

}