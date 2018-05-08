using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace PaginaWeb.Vistas.Menu
{
    public partial class RegistrarUsuario : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Registrar(object sender, EventArgs e)
        {
            if (u.registrarusuarioadmin(usuario.Text,contra.Text, nombre.Text, apellido.Text, correo.Text, Int32.Parse(rol.Text)) == true)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El usuario "+ nombre.Text +" se creo correctamente');", true);
            }
            else
            {

            }
        }
    }
}