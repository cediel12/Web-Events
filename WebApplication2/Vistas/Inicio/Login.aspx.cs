using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace PaginaWeb.Vistas.Inicio
{
    public partial class Login : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        DataTable dt, rol;
        DataRow dr, ro;

        protected void Page_Load(object sender, EventArgs e)
        {
            usua.Attributes.Add("autocomplete", "off");
            contra.Attributes.Add("autocomplete", "off");
            try
            {

                if (Session["Estado"].ToString().Equals("OK"))
                {
                    Response.Redirect("../Menu/Home.aspx");
                }
            }
            catch (Exception)
            {
            }
        }

        protected void IniciarSesion(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usua.Text) && !string.IsNullOrWhiteSpace(contra.Text))
            {
                dt = u.ValidarPersona(usua.Text, contra.Text);
                if (dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                    Session["Nombre"] = dr["nombre"].ToString() + " " + dr["apellido"].ToString();
                    Session["Estado"] = "OK";
                    Session["IDUSER"] = dr["idusuario"].ToString();
                    String id= dr["idusuario"].ToString();
                    Session["correo"] = dr["correo"].ToString();
                    rol = u.ConsultarRol(Session["IDUSER"].ToString());
                    if (rol.Rows.Count > 0)
                    {
                        ro = rol.Rows[0];
                        if (ro["rol_idrol"].ToString() == "1")
                        {
                            Session["rol"] = "Administrador";
                        }
                        else if (ro["rol_idrol"].ToString() == "2")
                        {
                            Session["rol"] = "Usuario";
                        }
                        else if ((ro["rol_idrol"].ToString() == "4"))
                        {
                            Session["rol"] = "Director Evento";
                        }
                        else
                        {
                            Session["rol"] = "Ponente";
                        }
                    }
                    Response.Redirect("../Menu/Home.aspx");
                }
                else if (u.ValidarPersona(usua.Text, contra.Text).Rows.Count == 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Usuario Invalido');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Error Al Conectar al Servidor');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Datos ingresados no validos');", true);
            }
        }

        protected void recordarclave(object sender, EventArgs e)
        {
            Response.Redirect("OlvidoClave.aspx");
        }
    }
}