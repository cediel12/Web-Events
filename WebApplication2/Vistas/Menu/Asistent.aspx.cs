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
    public partial class Asistent : System.Web.UI.Page
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
            if (e.CommandName.Equals("asistencia"))
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
                        if (Convert.ToInt32(Session["jornada"].ToString()) == 1)
                        {
                            drr = dtr.Rows[0];
                            if (Convert.ToInt32(drr["asistenciamañana"].ToString()) == 0)
                            {
                                if (u.actualizarinscripcionmañana(Convert.ToInt32(Session["idregistro"].ToString())))
                                {
                                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Asistencia Confirmada');", true);

                                }
                            }
                            else if (Convert.ToInt32(drr["asistenciamañana"].ToString()) == 1)
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Ya se registro su asistencua');", true);

                            }
                        }
                        else if (Convert.ToInt32(Session["jornada"].ToString()) == 2)
                        {
                            drr = dtr.Rows[0];
                            if (Convert.ToInt32(drr["asistenciatarde"].ToString()) == 0)
                            {
                                if (u.actualizarinscripciontarde(Convert.ToInt32(Session["idregistro"].ToString())))
                                {
                                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Asistencia Confirmada');", true);

                                }
                            }
                            else if (Convert.ToInt32(drr["asistenciatarde"].ToString()) == 1)
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Ya se registro su asistencua');", true);

                            }
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(Session["jornada"].ToString()) == 1)
                        {
                            if (u.registrarmañana(Convert.ToInt32(Session["idregistro"].ToString())))
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Asistencia Confirmada');", true);
                            }
                        }
                        else if (Convert.ToInt32(Session["jornada"].ToString()) == 2)
                        {
                            if (u.registrartarde(Convert.ToInt32(Session["idregistro"].ToString())))
                            {
                                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Asistencia Confirmada');", true);
                            }
                        }
                    }
                }
            }

        }
    }
}