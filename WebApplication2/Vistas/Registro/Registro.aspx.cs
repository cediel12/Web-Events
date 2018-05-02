using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace WebApplication2
{
    public partial class Registro : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Registrar(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(contra.Text) && !string.IsNullOrWhiteSpace(usua.Text) && !string.IsNullOrWhiteSpace(nombre.Text))
            {
                if (u.registrar(usua.Text, contra.Text, nombre.Text, apellido.Text, correo.Text) == 1)
                {
                    //Response.Redirect("vista.aspx");
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El registro fue completo');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Error en el servidor');", true);
                }


            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Datos no validos');", true);
            }
        }
    }
}