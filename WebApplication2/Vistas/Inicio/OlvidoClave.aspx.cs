using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace PaginaWeb.Vistas.Inicio
{
    public partial class OlvidoClave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Usuario u = new Usuario();
        DataTable dt;
        DataRow dr;
        string usuar, contra, corre;
        public void RestaurarClave(object sender, EventArgs e)
        {
            dt = u.consultarnombreusuario(usua.Text);
            if (dt.Rows.Count > 0)
            {
                dr = dt.Rows[0];
                usuar = dr["usuario"].ToString();
                contra = dr["contraseña"].ToString();
                corre = dr["correo"].ToString();
                //ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('" + usuar + contra + corre + "');", true);

                Restablecerclave(corre,usuar, contra);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Usuario no encontrado');", true);
            }
        }
        public void Restablecerclave(string correo, string usua, string contra)
        {
            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(correo);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Restablecer Contraseña";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            //mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = "Sus datos de inicio de sesion son.  Usuario: " + usua + "  Contraseña: " + contra;
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
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Se envio un correo con la informacion de ingreso');", true);
            }
            catch (System.Net.Mail.SmtpException)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El mensaje no se envio');", true);
            }
        }

        protected void recordarclave(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}