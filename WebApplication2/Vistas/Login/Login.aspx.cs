using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace PaginaWeb.Vistas.Login
{

    public partial class Login : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        DataTable dt;
        DataRow dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (Session["Estado"].ToString().Equals("OK"))
                {
                    Response.Redirect("../Menu/Evento.aspx");
                }
            }
            catch (Exception)
            {
            }
        }

        protected void IniciarSesion(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usua.Text) && !string.IsNullOrWhiteSpace(contra.Text))
            {
                dt = u.ValidarPersona(usua.Text, contra.Text);
                if (dt.Rows.Count >0)
                {
                    dr = dt.Rows[0];
                    Session["Nombre"] = dr["nombre"].ToString() + " "+ dr["apellido"].ToString();
                    Session["Estado"] = "OK";
                    Session["IDUSER"]=dr["idusuario"].ToString();
                    Response.Redirect("../Menu/Evento.aspx");
                }
                else if (u.ValidarPersona(usua.Text, contra.Text).Rows.Count == 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Usuario Invalido');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Error Al Conectar al Servidor');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Datos ingresados no validos');", true);
            }
        }
    }
}