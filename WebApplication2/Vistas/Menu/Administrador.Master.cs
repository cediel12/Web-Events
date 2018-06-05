using PaginaWeb.Models;
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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["Estado"].ToString() == "OK")
                {
                    MenuControlador me = new MenuControlador();
                    Usuario u = new Usuario();
                    me.CargarMenu(Session["IDUSER"].ToString(), menudinamico);
                    
                }

            }
            catch
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
        }
        public void salir(object sender, EventArgs e)
        {
            Session["Nombre"] = "1";
            Session["Estado"] = "1";
            Session["IDUSER"] = "1";
            Session["rol"] = "1";
            Response.Redirect("../Inicio/Login.aspx");
        }
    }
}