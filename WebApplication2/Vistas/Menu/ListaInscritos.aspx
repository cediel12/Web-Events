<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="ListaInscritos.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.ListaInscritos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel='stylesheet' href="../../Estilos/Otro/css/compiled.min268f.css?ver=4.5.0" />
    <link rel='stylesheet' id='compiled.css-css' href='../../wp-content/themes/mdbootstrap4/css/compiled.min268f.css?ver=4.5.0' type='text/css' media='all' />
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <!--Top Table UI-->
    <!--Top Table UI-->

    <div class="card card-cascade narrower">

        <!--Card image-->
        <div class="view gradient-card-header blue-gradient narrower py-2 mx-4 mb-3 d-flex justify-content-between align-items-center">

            <div>
                <a href="ListaEventos.aspx" class="white-text mx-3">Volver</a>
                <button style="background-color:transparent" type="button" id="Button2" class="btn btn-danger btn-lg btn-responsive" data-toggle="modal" data-target="#miventana" >Mensaje</button>
                <div class="modal fade" id="miventana" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h4 class="modal-title" style="color:black">Mensaje Masivo</h4>
                                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                            </div>
                            <div class="modal-body">
                                <div class="embed-responsive embed-responsive-16by9">
                                    <iframe class="embed-responsive-item" src="Mensaje.aspx"></iframe>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-primary" data-dismiss="modal">Cerrar</button>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

            <a class="white-text mx-3">Inscritos</a>
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
