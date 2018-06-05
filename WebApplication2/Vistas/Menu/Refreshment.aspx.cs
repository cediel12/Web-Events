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
    public partial class Refreshment : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        DataTable dt, dtr;
        DataRow dr, drr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Estado"].ToString() != "OK")
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
            if (!IsPostBack)
            {
                lista.DataSource = u.consutaruserevento(Convert.ToInt32(Session["ideventoseccionado"].ToString()));
                lista.DataBind();
            }
        }
        public void Unnamed_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName.Equals("refrigerio"))
            {
                int idusuario = Convert.ToInt32(e.CommandArgument.ToString());
                dt = u.inscribirevento(idusuario, Convert.ToInt32(Session["ideventoseccionado"].ToString()));
                if (dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                    Session["idregistro"] = Convert.ToInt32(dr["idevento_usuario"].ToString());
                    dtr = u.consultarasistencia(Convert.ToInt32(Session["idregistro"].ToString()));
                    if (dtr.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(Session["jornadarefrigerio"].ToString()) == 1)
                        {
                            drr = dtr.Rows[0];
                            if (Convert.ToInt32(drr["asistenciamañana"].ToString()) == 1)
                            {
                                if (Convert.ToInt32(drr["meriendamañana"].ToString()) == 0)
                                {
                                    if (u.actualizarrefrigeriomañana(Convert.ToInt32(Session["idregistro"].ToString())))
                                    {
                                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El usuario reclama refrigerio');", true);
                                    }
                                }
                                else
                                {
                                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El usuario ya reclamo refrigerio');", true);
                                }
                            }
                            else if (Convert.ToInt32(drr["asistenciamañana"].ToString()) == 0)
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El usuario no valodo la entrada al evento');", true);
                            }
                        }
                        else if (Convert.ToInt32(Session["jornadarefrigerio"].ToString()) == 2)
                        {
                            drr = dtr.Rows[0];
                            if (Convert.ToInt32(drr["asistenciatarde"].ToString()) == 1)
                            {
                                if (Convert.ToInt32(drr["meriandatarde"].ToString()) == 0)
                                {
                                    if (u.actualizarrefrigeriotarde(Convert.ToInt32(Session["idregistro"].ToString())))
                                    {
                                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El usuario reclama refrigerio');", true);
                                    }
                                }
                                else
                                {
                                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El usuario ya reclamo refrigerio');", true);
                                }
                            }
                            else if (Convert.ToInt32(drr["meriandatarde"].ToString()) == 0)
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('El usuario no valodo la entrada al evento');", true);
                            }
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('No se a registrado ninguna entrada el dia de hoy');", true);
                    }
                }
            }
        }
    }
}