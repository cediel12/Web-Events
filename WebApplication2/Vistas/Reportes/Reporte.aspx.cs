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
    public partial class ReportEvents : System.Web.UI.Page
    {
        DataTable data;
        EventoReporte reporte;
        Usuario u;
        Conexion co;
        public ReportEvents()
        {
            data = new DataTable();
            reporte = new EventoReporte();
            u = new Usuario();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            data = u.ConsultarEventos();
            reporte.SetDataSource(data);
            CrystalReportViewer1.ReportSource = reporte;
            CrystalReportViewer1.Height = 200;
            CrystalReportViewer1.Width = 400;
        }
        protected void Buscar(object sender, EventArgs e)
        {

        }
    }
}