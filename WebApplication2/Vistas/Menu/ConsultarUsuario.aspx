<%@ Page Title="" Language="C#" enableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="ConsultarUsuario.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.ConsultarUsuario" %>
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
                            <table id="bootstrap-data-table" class="table table-striped table-bordered">                   <thead>
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
