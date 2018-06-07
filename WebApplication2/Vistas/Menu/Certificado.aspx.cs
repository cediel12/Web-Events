using PaginaWeb.Reportes;
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
    public partial class Certificado : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        Certificad certi;
        DataTable data, dt, dtr;
        public DataTable dtconsulta = new DataTable();
        public DataTable dtuser = new DataTable();
        public DataRow drconsulta, druser, dr, drr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["IDUSER"].ToString());
                dtconsulta = u.ConsultarEventosInscritos(id);
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
        public Certificado()
        {
            certi = new Certificad();
        }
        protected void Reporte(Object sender, EventArgs e)
        {
            int a = 0;
            string tex = "";
            int duracion = 0;
            if (eventos.SelectedIndex > 0)
            {
                tex = eventos.SelectedItem.Text;
                dtuser = u.consultareventopornombre(tex);
                if (dtuser.Rows.Count > 0)
                {
                    druser = dtuser.Rows[0];
                    a = Convert.ToInt32(druser["idevento"]);
                    duracion = Convert.ToInt32(druser["duracion"]);
                    int id = Convert.ToInt32(Session["IDUSER"].ToString());
                    dt = u.inscribirevento(id, a);
                    if (dt.Rows.Count > 0)
                    {
                        dr = dt.Rows[0];
                        int idregistro = Convert.ToInt32(dr["idevento_usuario"].ToString());
                        dtr = u.validarcertificado(idregistro);
                        if (dtr.Rows.Count > 0)
                        {
                            drr = dtr.Rows[0];
                            if (duracion == Convert.ToInt32(drr["total"].ToString()))
                            {
                                data = u.certificado(Convert.ToInt32(Session["IDUSER"].ToString()), a);
                                if (data.Rows.Count > 0)
                                {
                                    certi.SetDataSource(data);
                                    certi.SetParameterValue("Mi parámetro", tex);
                                    CrystalReportViewer1.ReportSource = certi;
                                }
                            }
                            else
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('No cumplio con todas las asistencias para certificar');", true);
                            }
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('No se encuentra registrado o No cumplio la participacion necesaria');", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Seleccione un Evento');", true);
            }
        }
    }
}