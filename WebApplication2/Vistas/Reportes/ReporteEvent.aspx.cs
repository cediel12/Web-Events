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
        DataTable data, dt, dtr;
        EventoReporte reporte;
        UsuariosInscritos user;
        TemasReporte tema;
        AsistenciaEventoReporte asistente;
        Certificado certi;
        Usuario u;
        public DataTable dtconsulta = new DataTable();
        public DataTable dtuser = new DataTable();
        public DataRow drconsulta, druser, dr, drr;
        public ReporteEvent()
        {
            data = new DataTable();
            reporte = new EventoReporte();
            user = new UsuariosInscritos();
            tema = new TemasReporte();
            asistente = new AsistenciaEventoReporte();
            certi = new Certificado();
            u = new Usuario();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Estado"].ToString() != "OK")
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
        }


        protected void ver(Object sender, EventArgs e)
        {
            if (Radio3.Checked || Radio4.Checked || Radio1.Checked || Radio5.Checked)
            {
                dtconsulta = u.ConsultarEventostodos();
                if (dtconsulta.Rows.Count > 0)
                {
                    drconsulta = dtconsulta.Rows[0];
                    for (int i = 0; i < dtconsulta.Rows.Count; i++)
                    {
                        drconsulta = dtconsulta.Rows[i];
                        eventos.Items.Add(drconsulta["nombre_e"].ToString().ToUpper());
                    }
                }
                eventos.Visible = true;
            }

        }
        protected void Reporte(Object sender, EventArgs e)
        {


            if (Radio3.Checked && (eventos.SelectedIndex > 0))
            {
                int a = 0;
                string tex = "";
                if (eventos.SelectedIndex > 0)
                {
                    tex = eventos.SelectedItem.Text;
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
            else if (Radio4.Checked && (eventos.SelectedIndex > 0))
            {
                int a = 0;
                string tex = "";
                if (eventos.SelectedIndex > 0)
                {
                    tex = eventos.SelectedItem.Text;
                    dtuser = u.consultareventopornombre(tex);
                    if (dtuser.Rows.Count > 0)
                    {
                        druser = dtuser.Rows[0];
                        a = Convert.ToInt32(druser["idevento"]);
                    }
                    data = u.consultartemas(a);
                    tema.SetDataSource(data);
                    tema.SetParameterValue("Mi parámetro", tex);
                    CrystalReportViewer1.ReportSource = tema;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Seleccione un Evento');", true);
                }
            }
            else if (Radio1.Checked && (eventos.SelectedIndex > 0))
            {
                int a = 0;
                string tex = "";
                if (eventos.SelectedIndex > 0)
                {
                    tex = eventos.SelectedItem.Text;
                    dtuser = u.consultareventopornombre(tex);
                    if (dtuser.Rows.Count > 0)
                    {
                        druser = dtuser.Rows[0];
                        a = Convert.ToInt32(druser["idevento"]);
                    }
                    data = u.asistenciaevento(a);
                    asistente.SetDataSource(data);
                    asistente.SetParameterValue("Mi parámetro", tex);
                    CrystalReportViewer1.ReportSource = asistente;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Seleccione un Evento');", true);
                }
            }
            else if (Radio5.Checked && (eventos.SelectedIndex > 0))
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
            else
            if (Radio2.Checked)
            {
                data = u.ConsultarEventos();
                reporte.SetDataSource(data);
                CrystalReportViewer1.ReportSource = reporte;
            }
            CrystalReportViewer1.Height = 200;
            CrystalReportViewer1.Width = 400;

        }
    }
}