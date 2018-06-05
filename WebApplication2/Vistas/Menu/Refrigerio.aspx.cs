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
    public partial class Refrigerio : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        public DataTable dtconsulta = new DataTable();
        public DataRow drconsulta, druser;
        public DataTable dtuser = new DataTable();

        protected void Button2_Click(object sender, EventArgs e)
        {
            string tex = "";
            if (eventos.SelectedIndex > 0)
            {
                tex = eventos.SelectedItem.Text;
                dtuser = u.consultareventopornombre(tex);
                if (dtuser.Rows.Count > 0)
                {
                    druser = dtuser.Rows[0];
                    Session["ideventoseccionado"] = Convert.ToInt32(druser["idevento"]);
                    Session["nombreevento"] = tex;
                    if (jornada.SelectedItem.Text == "Mañana")
                    {
                        Session["jornadarefrigerio"] = 1;
                    }
                    else if (jornada.SelectedItem.Text == "Tarde")
                    {
                        Session["jornadarefrigerio"] = 2;
                    }
                }
            }
            Response.Redirect("../Menu/Refreshment.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Estado"].ToString() != "OK")
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
            dtconsulta = u.ConsultarEventosiniciados();
            if (dtconsulta.Rows.Count > 0)
            {
                drconsulta = dtconsulta.Rows[0];
                for (int i = 0; i < dtconsulta.Rows.Count; i++)
                {
                    drconsulta = dtconsulta.Rows[i];
                    eventos.Items.Add(drconsulta["nombre_e"].ToString().ToUpper());
                }
            }
        }
    }
}