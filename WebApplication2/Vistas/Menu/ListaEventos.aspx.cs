﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace PaginaWeb.Vistas.Menu
{
    public partial class ListaEventos : System.Web.UI.Page
    {
        public DataTable dtconsulta = new DataTable();
        public DataRow drconsulta;
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            dtconsulta = u.ConsultarEventos();
            if (dtconsulta.Rows.Count > 0)
            {
                drconsulta = dtconsulta.Rows[0];
            }
        }
    }
}