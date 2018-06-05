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
    public partial class EventosInscritos : System.Web.UI.Page
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
                lista.DataSource = u.ConsultarEventosInscritos(Convert.ToInt32(Session["IDUSER"].ToString()));
                lista.DataBind();
            }
        }
        public void Unnamed_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName.Equals("registrar"))
            {
                int id = Convert.ToInt32(e.CommandArgument.ToString());
                int iduser = Convert.ToInt32(Session["IDUSER"].ToString());
                dtuser = u.buscardelet(iduser, id);
                if (dtuser.Rows.Count > 0)
                {
                    druser = dtuser.Rows[0];
                    int idregistro = Convert.ToInt32(druser["idevento_usuario"].ToString());
                    if (u.eliminarinscripcion(idregistro))
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Se cancelo la inscripcion correctamente');", true);
                    }
                }
            }
        }
    }
}