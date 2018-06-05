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
    public partial class ActualizarUsuario : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        public DataTable dtconsulta = new DataTable();
        public DataRow drconsulta, druser;
        public DataTable dtuser = new DataTable();

        protected void Button2_Click(object sender, EventArgs e)
        {
            string nomb = nombre.Text;
            string apell = apellido.Text;
            string corre = correo.Text;
            int cedul = Convert.ToInt32(cedula.Text);

            int id = Convert.ToInt32(Session["IDUSER"].ToString());
            if (u.actualizarusuario(nombre.Text, apellido.Text, correo.Text, Convert.ToInt32(cedula.Text), id))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Datos Actualizado');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Error al actualizar');", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["Estado"].ToString() != "OK")
                {
                    Response.Redirect("../Inicio/Login.aspx");
                }
                dtconsulta = u.buscaruserid(Convert.ToInt32(Session["IDUSER"].ToString()));
                if (dtconsulta.Rows.Count > 0)
                {
                    drconsulta = dtconsulta.Rows[0];
                    nombre.Text = drconsulta["nombre"].ToString();
                    apellido.Text = drconsulta["apellido"].ToString();
                    correo.Text = drconsulta["correo"].ToString();
                    cedula.Text = drconsulta["cedula"].ToString();

                }
            }
        }
    }
}