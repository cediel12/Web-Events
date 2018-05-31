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
    public partial class Asistent : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Estado"].ToString() != "OK")
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
            if (!IsPostBack)
            {
                lista.DataSource = u.consutaruserevento(Convert.ToInt32(Session["ideventoseccionado"].ToString()));
                lista.DataBind();
            }
        }
        public void Unnamed_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName.Equals("asistencia"))
            {
                int idusuario = Convert.ToInt32(e.CommandArgument.ToString());

                if (u.realizarasistencia(idusuario, Convert.ToInt32(Session["ideventoseccionado"].ToString())) == true)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Se realizao la participacion');", true);
                }
            }

        }
    }
}