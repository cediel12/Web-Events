﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace PaginaWeb.Vistas.Inicio
{
    public partial class Registro : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Registrar(object sender, EventArgs e)
        {
            if (u.registrar(usua.Text,contra.Text,nombre.Text,apellido.Text,correo.Text)==true)
            {
                Response.Redirect("../Inicio/Login.aspx");
            }else
            {

            }
        }
    }
}