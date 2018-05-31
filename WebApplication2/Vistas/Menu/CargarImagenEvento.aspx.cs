using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebProgramacion.Models;

namespace PaginaWeb.Vistas.Menu
{
    public partial class CargarImagenEvento : System.Web.UI.Page
    {
        Usuario u = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Estado"].ToString() != "OK")
            {
                Response.Redirect("../Inicio/Login.aspx");
            }
            else
            {
                Page.Form.Enctype = "multipart/form-data";
            }
        }

        protected void Cargararchivo(object sender, EventArgs e)
        {
            if (Request.Files.Count > 0)
            {
                int vLenght = 0;
                int vnumeroarchivos = 0;
                string rutalocal = Server.MapPath("/");
                foreach (string item in Request.Files)
                {
                    HttpPostedFile file = Request.Files[item];
                    if (file.ContentLength > 0)
                    {
                        rutalocal = System.IO.Path.Combine(rutalocal, "src");
                        if (!System.IO.Directory.Exists(rutalocal))
                        {
                            Console.Write("mimamemememiememe");
                            System.IO.Directory.CreateDirectory(rutalocal);
                        };
                        string nombre = DateTime.Now.ToString();
                        rutalocal = System.IO.Path.Combine(rutalocal, nombre + System.IO.Path.GetExtension(file.FileName));
                        vnumeroarchivos++;
                        Console.Write("agrego archivos");
                        vLenght += file.ContentLength;
                    }

                }

            }
        }

        protected void subirarchivo(object sender, EventArgs e)
        {
            string filepth = "~/src/" + fileupload1.FileName;
            if (fileupload1.HasFile)
            {
                fileupload1.SaveAs(MapPath(filepth));
                label1.Text = "archivo subido con exito";
                if (u.actualizarimagen("imagen de" + Session["Nombre"].ToString(), fileupload1.FileName, "2018-05-24", 1, Int32.Parse(Session["IDUSER"].ToString())))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('La imagen se cambio con exito');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('ha fallado la insercion en la base de datos');", true);
                }

            }
            else
            {
                label1.Text = "error en la carga de archivo";
            }

        }
    }
}