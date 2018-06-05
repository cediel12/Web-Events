<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="Refreshment.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.Refreshment" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Estilos/Tabla/css/lib/datatable/dataTables.bootstrap.min.css" rel="stylesheet" />

    <div class="content mt-3">
        <div class="animated fadeIn">
            <div class="row">

                <div class="col-md-12">
                    <div class="card">
                        <div class="card-header">
                            <a href="Refrigerio.aspx" class="white-text mx-3">Volver</a>
                            <strong class="card-title">Asistencia - <%= Session["nombreevento"].ToString() %></strong>
                        </div>
                        <div class="card-body">
                            <table id="bootstrap-data-table" class="table table-striped table-bordered">
                                <thead>
                                    <tr>
                                        <th>Nombre</th>
                                        <th>Identificación</th>
                                        <th>Inscribir</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:ListView runat="server" ID="lista">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%#Eval("nombrecompeto") %></td>
                                                <td><%#Eval("cedula") %></td>
                                                <td>
                                                    <asp:LinkButton runat="server" OnCommand="Unnamed_Command" CssClass="" CommandArgument='<%#Eval("idusuario") %>' CommandName="refrigerio">
                                            Asistencia
                                                    </asp:LinkButton>
                                                </td>
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
