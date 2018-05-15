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
    public partial class CrearTema : System.Web.UI.Page
    {
        public DataTable dtconsulta = new DataTable();
        public DataTable dtuser = new DataTable();
        public DataRow drconsulta, druser;
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            dtconsulta = u.consultarponentes();
            if (dtconsulta.Rows.Count > 0)
            {
                drconsulta = dtconsulta.Rows[0];
                for (int i = 0; i < dtconsulta.Rows.Count; i++)
                {
                    drconsulta = dtconsulta.Rows[i];
                    ListBox1.Items.Add(drconsulta["usuario"].ToString() + " " + drconsulta["nombre"].ToString().ToUpper() + " " + drconsulta["apellido"].ToString().ToUpper());
                }
            }
        }
        protected void Registrar(object sender, EventArgs e)
        {
            Char delimiter = ' ';
            int a=0;
            if (ListBox1.SelectedIndex > -1)
            {
                string tex = ListBox1.SelectedItem.Text;
                string[] te = tex.Split(delimiter);
                string substring = te[0];
                dtuser = u.Consultaruser(substring);
                if (dtuser.Rows.Count > 0)
                {
                    druser = dtuser.Rows[0];
                    a = Convert.ToInt32(druser["idusuario"]);
                }
            }
            if (u.creartema(nombre.Text, fechainicio.Text, hora.Text, Convert.ToInt32(Session["creartema"].ToString()), a) == true)
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