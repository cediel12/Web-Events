using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace PaginaWeb.Vistas.Menu
{
    public partial class ListaEventos : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        public string idpe;
        public int crece = 1;
        DataTable dt;
        public int a;
        private DataTable dtuser;
        private DataRow druser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Estado"].ToString() != "OK")
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
            if (!IsPostBack)
            {
                lista.DataSource = u.ConsultarEventos();
                lista.DataBind();
            }
        }
        public void Unnamed_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName.Equals("registrar"))
            {
                int id = Convert.ToInt32(e.CommandArgument.ToString());
                int iduser = Convert.ToInt32(Session["IDUSER"].ToString());
                dt = u.inscribirevento(iduser, id);
                if (dt.Rows.Count > 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Ya se encuentra inscrito en este evento');", true);
                }
                else
                {
                    if (u.registrarevento(iduser, id) == true)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Su registro fue exitoso');", true);
                        confirmarinscripcion(Session["correo"].ToString(),buscar(id));
                    }
                }
            }

        }
        public void vertemas(object sender, CommandEventArgs e)
        {
            if (e.CommandName.Equals("ver"))
            {
                Session["idtema"]= Convert.ToInt32(e.CommandArgument.ToString());
                a = Convert.ToInt32(e.CommandArgument.ToString());

                Response.Redirect("TemasEvento.aspx");
            }
        }

        public void creartema(object sender, CommandEventArgs e)
        {
            if (e.CommandName.Equals("creartema"))
            {
                Session["creartema"] = Convert.ToInt32(e.CommandArgument.ToString());
                a = Convert.ToInt32(e.CommandArgument.ToString());

                Response.Redirect("CrearTema.aspx");
            }
        }
        public void veruser(object sender, CommandEventArgs e)
        {
            if (e.CommandName.Equals("listausereventos"))
            {
                Session["verusertema"] = Convert.ToInt32(e.CommandArgument.ToString());
                a = Convert.ToInt32(e.CommandArgument.ToString());

                Response.Redirect("ListaInscritos.aspx");
            }
        }
        public void confirmarinscripcion(string correo, string evento)
        {
            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(correo);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Su Inscripcion fue Exitosa";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            //mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = "Su registro al Evento " + evento + " fue exitoso, se solicita asistir todos los dias para poder obtener su certificacion";
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress("victorcediel87@gmail.com");


            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.Credentials =
                new System.Net.NetworkCredential("victorcediel87@gmail.com", "3125196614");

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail

            cliente.Port = 587;
            cliente.EnableSsl = true;


            cliente.Host = "smtp.gmail.com"; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {

                cliente.Send(mmsg);
            }
            catch (System.Net.Mail.SmtpException)
            {
            }
        }
        public string buscar(int a)
        {
            string tex="";
            dtuser = u.buscarevento(a);
            if (dtuser.Rows.Count > 0)
            {
                druser = dtuser.Rows[0];
                tex = druser["nombre_e"].ToString();
            }
            return tex;
        }
    }
}