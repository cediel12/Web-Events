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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Registrar(object sender, EventArgs e)
        {

            if (u.crearevento(nombre.Text, fechainicio.Text, fechafin.Text, hora.Text, lugar.Text, tipolugar.Text, digital.Text, duracion.Text) == true)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El evento se creo correctamente');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El evento no se creo correctamente');", true);
            }
            
        }
    }
}