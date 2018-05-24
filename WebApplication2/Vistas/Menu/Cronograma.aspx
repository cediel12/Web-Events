<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="Cronograma.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.Cronograma" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel='stylesheet' id='compiled.css-css' href="../../Estilos/Otro/css/compiled.min268f.css?ver=4.5.0"
    <<link rel='stylesheet' id='compiled.css-css'  href='../../wp-content/themes/mdbootstrap4/css/compiled.min268f.css?ver=4.5.0' type='text/css' media='all' />
        <% for (int i = 0; i < dtconsulta.Rows.Count; i++)
            {
                drconsulta = dtconsulta.Rows[i];
                Session["eventoid"] = drconsulta["idevento"].ToString().ToUpper();
        %>
    <div class="card card-cascade narrower">
        <%--</div>--%>
        <div class="view gradient-card-header blue-gradient narrower py-2 mx-4 mb-3 d-flex justify-content-between align-items-center">
            <div>
            </div>
            <a class="white-text mx-3"><%=drconsulta["nombre_e"].ToString().ToUpper() %></a>

            <div>
            </div>
        </div>
        <div class="px-4">
            <div class="table-wrapper">
                <table class="table table-hover mb-0">
                    <thead>
                        <tr>
                            <th class="th-lg"><a>ID</a></th>
                            <th class="th-lg"><a>Tema </a></th>
                            <th class="th-lg"><a>Fecha </a></th>
                            <th class="th-lg"><a>Hora  </a></th>
                            <th class="th-lg"><a>Ponente  </a></th>
                        </tr>
                    </thead>
                    <tbody>

                        <% dtemas = vertemas();
                            for (int j = 0; j < dtemas.Rows.Count; j++)
                            {
                                drtemas = dtemas.Rows[j];
                                %>
                        <tr>
                            <td><%=(i+1) %></td>
                            <td><%=drtemas["tema"].ToString().ToUpper() %></td>
                            <td><%=drtemas["fechatema"].ToString().ToUpper() %></td>
                            <td><%=drtemas["horatema"].ToString().ToUpper() %></td>
                            <td><%= drtemas["nombre"].ToString().ToUpper() + " "+ drtemas["apellido"].ToString().ToUpper()  %></td>
                        </tr>
                            <%} %>
                        <tr>
                        </tr>

                    </tbody>
                </table>
            </div>
            <hr class="my-0">
        </div>
        <%--</div>--%>
    </div>
        <%} %>
    <%--</div>--%>
</asp:Content>
