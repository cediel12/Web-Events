using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace PaginaWeb.Vistas.Inicio
{
    public partial class Home : System.Web.UI.Page
    {
        public DataTable dtconsulta = new DataTable(), ima, evecal;
        public DataRow drconsulta, rima;
        public Usuario u = new Usuario();
        public string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        public string[] dias = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
        public string encabezado;
        public int iz, der;
        public DateTime hoy = DateTime.Now;
        public string anterior, actual, siguiente1, siguiente2;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Estado"] = "";
            Session["rol"] = "";
            dtconsulta = u.ConsultarEventos();
            if (dtconsulta.Rows.Count > 0)
            {
                drconsulta = dtconsulta.Rows[0];
            }
            hoy = hoy.AddMonths(-1);
            anterior = generar_calendario(hoy.Month);
            hoy = hoy.AddMonths(1);
            actual = generar_calendario(hoy.Month);
            hoy = hoy.AddMonths(1);
            siguiente1 = generar_calendario(hoy.Month);
            hoy = hoy.AddMonths(1);
            siguiente2 = generar_calendario(hoy.Month);
        }
        public string generar_calendario(int m)
        {
            string texto_calendar = "";
            string mes = meses[m - 1];
            encabezado = "Junio " + hoy.Year;
            int daymon = DateTime.DaysInMonth(hoy.Year, m), dimes = DateTime.DaysInMonth(hoy.Year, m - 1);
            for (int i = 0; i < daymon; i++)
            {
                int valor = obtner_diainicial(i + 1, m, hoy.Year);
                string dia = dias[valor];
                if (i == 0)
                {
                    iz = valor;
                    for (int j = 0; j < iz; j++)
                    {
                        texto_calendar += "<div class=\"day col-sm p-2 border border-left-0 border-top-0 text-truncate d-none d-sm-inline-block bg-light text-muted\">"
                                           + "<h5 class=\"row align-items-center\">"
                                           + "<span class=\"date col-1\">" + (dimes - (iz - j - 1)) + "</span>"
                                           + "<small class=\"col d-sm-none text-center text-muted\">" + dias[obtner_diainicial((dimes - (iz - j - 1)), m - 1, hoy.Year)] + "</small>"
                                           + "<span class=\"col-1\"></span>"
                                           + "</h5>"
                                           + "<p class=\"d-sm-none\">No events</p>"
                                           + "</div>";
                    }
                }
                texto_calendar += "<div class=\"day col-sm p-2 border border-left-0 border-top-0 text-truncate\">"
                        + "<h5 class=\"row align-items-center\">"
                        + "<span class=\"date col-1\">" + (i + 1) + "</span>"
                        + "<small class=\"col d-sm-none text-center text-muted\">" + dia + "</small>"
                        + "<span class=\"col-1\"></span>"
                        + "</h5>";
                evecal = u.Consultarevento((i + 1), m, hoy.Year);
                if (evecal.Rows.Count > 0)
                {
                    for (int j = 0; j < evecal.Rows.Count; j++)
                    {
                        rima = evecal.Rows[j];
                        texto_calendar += "<a class=\"event d-block p-1 pl-2 pr-2 mb-1 rounded text-truncate small bg-info text-white\" title=\"" + rima["nombre_e"] + "\">" + rima["nombre_e"] + "</a>";
                    }
                }
                texto_calendar += "</div>";
                if (i + 1 == daymon)
                {
                    der = 6 - valor;
                    for (int j = 0; j < der; j++)
                    {
                        texto_calendar += "<div class=\"day col-sm p-2 border border-left-0 border-top-0 text-truncate d-none d-sm-inline-block bg-light text-muted\">"
                                           + "<h5 class=\"row align-items-center\">"
                                           + "<span class=\"date col-1\">" + (j + 1) + "</span>"
                                           + "<small class=\"col d-sm-none text-center text-muted\">" + dias[obtner_diainicial(j + 1, m + 1, hoy.Year)] + "</small>"
                                           + "<span class=\"col-1\"></span>"
                                           + "</h5>"
                                           + "<p class=\"d-sm-none\">No events</p>"
                                           + "</div>";
                    }
                }
                if ((valor + 1) % 7 == 0)
                {
                    texto_calendar += "<div class=\"w-100\"></div>";
                }
            }
            return texto_calendar;
        }
        public int obtner_diainicial(int dia, int mes, int año)
        {
            int[] regular = { 0, 3, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };
            int[] bisiesto = { 0, 3, 4, 0, 2, 5, 0, 3, 6, 1, 4, 6 };
            int d = dia;
            int result1, result2, result3, result4, result5;
            if ((año % 4 == 0) && !(año % 100 == 0))
            {
                mes = bisiesto[mes - 1];
            }
            else if (año % 400 == 0)
            {
                mes = bisiesto[mes - 1];
            }
            else
            {
                mes = regular[mes - 1];
            }
            result1 = (año - 1) % 7;
            result2 = (año - 1) / 4;
            result3 = (3 * (((año - 1) / 100) + 1)) / 4;
            result4 = (result2 - result3) % 7;
            result5 = d % 7;
            d = (result1 + result4 + mes + result5) % 7;
            return d;
        }
    }
}