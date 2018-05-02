using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaWeb
{
    public partial class Menu : System.Web.UI.Page
    {
        public string nombreyapellido;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string nomb()
        {
            nombreyapellido = (string)(Session["Nombre"]);
            return nombreyapellido;
        }
    }
}