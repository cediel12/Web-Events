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
    public partial class CrearEvento : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        DataTable dt, dtd;
        DataRow drd;
        int dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Estado"].ToString() != "OK")
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
            if (!IsPostBack)
            {
                //dtd = u.consultardirectores();
                //if (dtd.Rows.Count>0)
                //{
                //    for (int i=0;i< dtd.Rows.Count;i++)
                //    {
                director.DataSource = u.consultardirectores();
                director.DataTextField = ("nombrecompeto");
                director.DataValueField = ("idusuario");
                director.DataBind();
                //    }
                //}
            }
        }
        protected void Registrar(object sender, EventArgs e)
        {
            int iddirector = Convert.ToInt32(director.SelectedValue);
            if (director.SelectedIndex > 0)
            {
                if (u.crearevento(nombre.Text, fechainicio.Text, fechafin.Text, hora.Text, lugar.Text, iddirector) == true)
                {
                    dt = u.consultareventopornombre(nombre.Text);
                    if (dt.Rows.Count>0)
                    {
                        drd = dt.Rows[0];
                        Session["ideventoimagen"]= drd["idevento"];
                    }
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El evento se creo correctamente');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El evento no se creo correctamente');", true);
                }
            }

        }
    }
}