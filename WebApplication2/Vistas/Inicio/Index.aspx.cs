using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace WebApplication2
{
    public partial class Index : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void IniciarSesion(object sender, EventArgs e)
        {

            //if (!string.IsNullOrWhiteSpace(contra.Text) && !string.IsNullOrWhiteSpace(usua.Text))
            //{
            //    if (u.ValidarPersona(usua.Text, contra.Text) == 1)
            //    {
            //        Session["Nombre"] = u.getnombre();
            //        Session["Estado"] = "OK";
            //        Response.Redirect("vista.aspx");
            //        //ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El nombre de usuario es " + u.getnombre()+"');", true);
            //    }
            //    else if (u.ValidarPersona(usua.Text, contra.Text) == 0)
            //    {
            //        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Usuario Invalido');", true);
            //    }
            //    else
            //    {
            //        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Error Al Conectar al Servidor');", true);
            //    }
            //}else
            //{
            //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Datos ingresados no validos');", true);
            //}
        }
        protected void Registrar(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

    }

}