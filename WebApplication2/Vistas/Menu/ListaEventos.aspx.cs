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
        protected void Page_Load(object sender, EventArgs e)
        {
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

                Response.Redirect("TemasEvento.aspx");
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
    }
}