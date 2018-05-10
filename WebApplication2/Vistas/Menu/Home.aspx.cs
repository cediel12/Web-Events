using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaWeb.Vistas.Menu
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Estado"].ToString()!="OK")
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
        }
    }
}