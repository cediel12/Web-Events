using PaginaWeb.Reportes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace PaginaWeb.Vistas.Reportes
{
    public partial class ReporteEvent : System.Web.UI.Page
    {
        DataTable data;
        EventoReporte reporte;
        UsuariosInscritos user;
        Usuario u;
        public DataTable dtconsulta = new DataTable();
        public DataTable dtuser = new DataTable();
        public DataRow drconsulta, druser;
        public ReporteEvent()
        {
            data = new DataTable();
            reporte = new EventoReporte();
            user = new UsuariosInscritos();
            u = new Usuario();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            dtconsulta = u.ConsultarEventos();
            if (dtconsulta.Rows.Count > 0)
            {
                drconsulta = dtconsulta.Rows[0];
                for (int i = 0; i < dtconsulta.Rows.Count; i++)
                {
                    drconsulta = dtconsulta.Rows[i];
                    ListBox1.Items.Add(drconsulta["nombre_e"].ToString().ToUpper());
                }
            }
        }

        protected void Reporte(Object sender, EventArgs e)
        {

            if ((Radio2.GroupName == "Reportes"))
            {
                data = u.ConsultarEventos();
                reporte.SetDataSource(data);
                CrystalReportViewer1.ReportSource = reporte;
            }
            if ((Radio3.GroupName == "Reportes"))
            {
                int a = 0;
                string tex = "";
                if (ListBox1.SelectedIndex > -1)
                {
                    tex = ListBox1.SelectedItem.Text;
                    dtuser = u.consultareventopornombre(tex);
                    if (dtuser.Rows.Count > 0)
                    {
                        druser = dtuser.Rows[0];
                        a = Convert.ToInt32(druser["idevento"]);
                    }
                    data = u.consutaruserevento(a);
                    user.SetDataSource(data);
                    user.SetParameterValue("Mi parámetro", tex);
                    CrystalReportViewer1.ReportSource = user;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Seleccione un Evento');", true);
                }
            }
            CrystalReportViewer1.Height = 200;
            CrystalReportViewer1.Width = 400;

        }
    }
}