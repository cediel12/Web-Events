<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="ListaInscritos.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.ListaInscritos" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <link rel='stylesheet' id='compiled.css-css' href="../../Estilos/Otro/css/compiled.min268f.css?ver=4.5.0" <link rel='stylesheet' id='compiled.css-css'  href='../../wp-content/themes/mdbootstrap4/css/compiled.min268f.css?ver=4.5.0' type='text/css' media='all' />

    <!--Top Table UI-->
    <!--Top Table UI-->

    <div class="card card-cascade narrower">

        <!--Card image-->
        <div class="view gradient-card-header blue-gradient narrower py-2 mx-4 mb-3 d-flex justify-content-between align-items-center">

            <div>
                <a href="ListaEventos.aspx" class="white-text mx-3">Volver</a>
            </div>

            <a class="white-text mx-3">Temas</a>
            <div>
                
            </div>

        </div>
        <!--/Card image-->

        <div class="px-4">

            <div class="table-wrapper">
                <!--Table-->
                <table class="table table-hover mb-0">

                    <!--Table head-->
                    <thead>
                        <tr>
                            <th class="th-lg"><a>Nombre </a></th>
                            <th class="th-lg"><a>Identificacion </a></th>
                            <th class="th-lg"><a>Usuario  </a></th>


                        </tr>
                    </thead>
                    <!--Table head-->

                    <!--Table body-->
                    <tbody>
                        <% 
                            for (int i = 0; i < dtconsulta.Rows.Count; i++)
                            {
                                drconsulta = dtconsulta.Rows[i];
                        %>
                        <tr>

                            <td><%=drconsulta["nombrecompeto"].ToString().ToUpper() %> </td>
                            <td><%=drconsulta["cedula"].ToString().ToUpper() %></td>
                            <td><%=drconsulta["usuario"].ToString() %></td>

                        </tr>
                        <%} %>
                    </tbody>
                    <!--Table body-->
                </table>
                <!--Table-->
            </div>

            <hr class="my-0">

            <!--Bottom Table UI-->
            

        </div>
    </div>
</asp:Content>
