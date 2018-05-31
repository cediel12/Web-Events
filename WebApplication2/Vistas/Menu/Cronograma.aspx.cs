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
    public partial class Cronograma : System.Web.UI.Page
    {
        public DataTable dtconsulta = new DataTable();
        public DataTable dtemas = new DataTable();
        public DataRow drconsulta;
        public DataRow drtemas;
        public int eventoid;
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Estado"].ToString() != "OK")
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
            dtconsulta = u.ConsultarEventos();
            if (dtconsulta.Rows.Count > 0)
            {
                drconsulta = dtconsulta.Rows[0];
            }
        }
        public DataTable vertemas()
        {
            eventoid = Convert.ToInt32(Session["eventoid"]);
            dtemas = u.consultartemas(eventoid);
            if (dtemas.Rows.Count > 0)
            {
                drtemas = dtemas.Rows[0];
            }
            return dtemas;
        }
    }
}