<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="ListaEventos.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.ListaEventos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Estilos/Tabla/css/lib/datatable/dataTables.bootstrap.min.css" rel="stylesheet" />

    <div class="content mt-3">
        <div class="animated fadeIn">
            <div class="row">

                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Eventos</strong>
                        </div>
                        <div class="card-body">
                            <table id="bootstrap-data-table" class="table table-striped table-bordered">
                                <thead>
                                    <tr>
                                        <th class="th-lg"><a>Nombre</a></th>
                                        <th class="th-lg"><a>Fecha Inicio</a></th>
                                        <th class="th-lg"><a>Fecha Fin</a></th>
                                        <th class="th-lg"><a>Hora</a></th>
                                        <th class="th-lg"><a>Lugar</a></th>
                                        <th class="th-lg"><a>Registrar</a></th>
                                        <th class="th-lg"><a>Temas</a></th>


                                        <%
                                            if (Session["rol"].ToString() == "Administrador")
                                            {%>
                                        <th class="th-lg"><a>Crear Tema </a></th>
                                        <th class="th-lg"><a>Lista de Inscritos </a></th>
                                        <% }
                                        %>
                                    </tr>
                                </thead>
                                <!--Table head-->

                                <!--Table body-->
                                <tbody>
                                    <asp:ListView runat="server" ID="lista">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%#Eval("nombre_e") %></td>
                                                <td><%#Eval("fechainicio") %></td>
                                                <td><%#Eval("fechafin") %></td>
                                                <td><%#Eval("horaevento") %></td>
                                                <td><%#Eval("tipo") %></td>

                                                <td>
                                                    <asp:LinkButton runat="server" OnCommand="Unnamed_Command" CssClass="" CommandArgument='<%#Eval("idevento") %>' CommandName="registrar">
                                            Registrar
                                                    </asp:LinkButton>
                                                </td>
                                                <td>
                                                    <asp:LinkButton runat="server" OnCommand="vertemas" CssClass="" CommandArgument='<%#Eval("idevento") %>' CommandName="ver">
                                            Ver
                                                    </asp:LinkButton>
                                                </td>
                                                <%
                                                    if (Session["rol"].ToString() == "Administrador")
                                                    {%>
                                                <td>
                                                    <asp:LinkButton runat="server" OnCommand="creartema" CssClass="" CommandArgument='<%#Eval("idevento") %>' CommandName="creartema">
                                            Crear
                                                    </asp:LinkButton>
                                                </td>
                                                <td>
                                                    <asp:LinkButton runat="server" OnCommand="veruser" CssClass="" CommandArgument='<%#Eval("idevento") %>' CommandName="listausereventos">
                                            Ver
                                                    </asp:LinkButton>
                                                </td>
                                                <% }
                                                %>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:ListView>


                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>


            </div>
        </div>
        <!-- .animated -->
    </div>
    <!-- .content -->
    <script src="../../Estilos/Tabla/js/lib/data-table/datatables.min.js"></script>
    <script src="../../Estilos/Tabla/js/lib/data-table/dataTables.bootstrap.min.js"></script>
    <script src="../../Estilos/Tabla/js/lib/data-table/dataTables.buttons.min.js"></script>
    <script src="../../Estilos/Tabla/js/lib/data-table/buttons.bootstrap.min.js"></script>
    <script src="../../Estilos/Tabla/js/lib/data-table/jszip.min.js"></script>
    <script src="../../Estilos/Tabla/js/lib/data-table/pdfmake.min.js"></script>
    <script src="../../Estilos/Tabla/js/lib/data-table/vfs_fonts.js"></script>
    <script src="../../Estilos/Tabla/js/lib/data-table/buttons.html5.min.js"></script>
    <script src="../../Estilos/Tabla/js/lib/data-table/buttons.print.min.js"></script>
    <script src="../../Estilos/Tabla/js/lib/data-table/buttons.colVis.min.js"></script>
    <script src="../../Estilos/Tabla/js/lib/data-table/datatables-init.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#bootstrap-data-table-export').DataTable();
        });
    </script>

</asp:Content>
