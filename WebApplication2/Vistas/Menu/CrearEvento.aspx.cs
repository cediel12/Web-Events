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
        DataTable dt;
        DataRow dr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void CrearEvent(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El evento se creo correctamente');", true);

            //if (u.crearevento(nombre.Text,fechainicio.Text,hora.Text,lugar.Text,tipolugar.Text,digital.Text, duracion.Text,tipolugar.Text,fechafin.Text) == true)
            //{
            //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El evento se creo correctamente');", true);
            //}
            //else
            //{
            //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El evento no se creo correctamente');", true);
            //}
            //if (u.crearevento(nombre.ToString(), fecha.ToString(), hora.ToString()) == 1)
            //{
            //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('ElEl evento se creo correctamente');", true);
            //}
            //else
            //{
            //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El evento no se creo');", true);

            //}
        }
    }
}