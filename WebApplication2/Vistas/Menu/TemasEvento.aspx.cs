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
    public partial class TemasEvento : System.Web.UI.Page
    {
        public DataTable dtconsulta = new DataTable();
        public DataRow drconsulta;
        Usuario u = new Usuario();
        ListaEventos li = new ListaEventos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Estado"].ToString() != "OK")
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
            int id = Convert.ToInt32(Session["idtema"].ToString());
            dtconsulta = u.consultartemas(id);
            if (dtconsulta.Rows.Count > 0)
            {
                drconsulta = dtconsulta.Rows[0];
            }
        }
    }
}