<%@ Page Title="" Language="C#" enableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="ConsultarUsuario.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.ConsultarUsuario" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <link rel='stylesheet' id='compiled.css-css' href="../../Estilos/Otro/css/compiled.min268f.css?ver=4.5.0" 
    <link rel='stylesheet' id='compiled.css-css'  href='../../wp-content/themes/mdbootstrap4/css/compiled.min268f.css?ver=4.5.0' type='text/css' media='all' />
    <div class="card card-cascade narrower">
        <div class="view gradient-card-header blue-gradient narrower py-2 mx-4 mb-3 d-flex justify-content-between align-items-center">
            <div>
            </div>
            <a class="white-text mx-3">Lista de Usuarios</a>
            <div>
            </div>
        </div>
        <div class="px-4">
            <div class="table-wrapper">
                <table class="table table-hover mb-0">
                    <thead>
                        <tr>
                            <th class="th-lg"><a>ID </a></th>
                            <th class="th-lg"><a>Nombre </a></th>
                            <th class="th-lg"><a>Identificación </a></th>
                            <th class="th-lg"><a>Correo  </a></th>
                            <th class="th-lg"><a>Usuario </a></th>
                        </tr>
                    </thead>
                    <tbody>                        
                        <% for (int i = 0; i < dtconsulta.Rows.Count; i++)
                            {
                                drconsulta = dtconsulta.Rows[i];
                                %>
                        <tr>
                            <td><%=(i+1) %></td>
                            <td><%=drconsulta["nombrecompeto"].ToString().ToUpper() %></td>
                            <td><%=drconsulta["cedula"].ToString().ToUpper() %></td>
                            <td><%=drconsulta["correo"].ToString() %></td>
                            <td><%=drconsulta["usuario"].ToString() %></td>
                        </tr>
                            <%} %>
                    </tbody>
                </table>
            </div>
            <hr class="my-0">
        </div>
    </div>
</asp:Content>
