<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="ListaEventos.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.ListaEventos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .table-wrapper {
            display: block;
            max-height: 300px;
            overflow-y: auto;
            -ms-overflow-style: -ms-autohiding-scrollbar;
        }
    </style>
    <!--Top Table UI-->
    <!--Top Table UI-->

    <div class="card card-cascade narrower">

        <!--Card image-->
        <div class="view gradient-card-header blue-gradient narrower py-2 mx-4 mb-3 d-flex justify-content-between align-items-center">
            <div>
            </div>

            <a class="white-text mx-3">Eventos</a>
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
                            <th class="th-lg"><a>ID<i class="fa fa-sort ml-1"></i></a></th>
                            <th class="th-lg"><a>Nombre<i class="fa fa-sort ml-1"></i></a></th>
                            <th class="th-lg"><a>Fecha Inicio <i class="fa fa-sort ml-1"></i></a></th>
                            <th class="th-lg"><a>Fecha Fin <i class="fa fa-sort ml-1"></i></a></th>
                            <th class="th-lg"><a>Hora <i class="fa fa-sort ml-1"></i></a></th>
                            <th class="th-lg"><a>Lugar<i class="fa fa-sort ml-1"></i></a></th>
                            <th class="th-lg"><a>Registrar<i class="fa fa-sort ml-1"></i></a></th>
                            <th class="th-lg"><a>Temas<i class="fa fa-sort ml-1"></i></a></th>

                            <%
                                if (Session["rol"].ToString() == "Administrador")
                                {%>
                            <th class="th-lg"><a>Crear Tema<i class="fa fa-sort ml-1"></i></a></th>
                            <th class="th-lg"><a>Lista de Inscritos<i class="fa fa-sort ml-1"></i></a></th>
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

                                    <td><%=crece++ %></td>
                                    <td><%#Eval("nombre") %></td>
                                    <td><%#Eval("fechainicio") %></td>
                                    <td><%#Eval("fechafin") %></td>
                                    <td><%#Eval("hora") %></td>
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

                        <%--<% 
                            for (int i = 0; i < dtconsulta.Rows.Count; i++)
                            {
                                drconsulta = dtconsulta.Rows[i];
                                idpe = drconsulta["idevento"].ToString().ToUpper();
                        %>
                        <tr>

                            <td><%=(i+1) %></td>
                            <td><%=drconsulta["nombre"].ToString().ToUpper() %></td>
                            <td><%=drconsulta["fechainicio"].ToString().ToUpper() %></td>
                            <td><%=drconsulta["fechafin"].ToString().ToUpper() %></td>
                            <td><%=drconsulta["hora"].ToString().ToUpper() %></td>
                            <td><%=drconsulta["lugar"].ToString().ToUpper() %></td>
                            <td><%=drconsulta["tipo"].ToString().ToUpper() %></td>
                            <td><%=drconsulta["digital"].ToString().ToUpper() %></td>
                            <td><%=drconsulta["duracion"].ToString().ToUpper() %></td>
                            <%--<td>
                                <asp:Button ID="button" runat="server" EnableTheming="True" class="btn btn-link" Text="Registrar"  />
                            </td>--%
                            <td>
                                <button runat="server" onserverclick="inscribir" id='' class="btn btn-link">Inscrbir</button></td>
                            <td>
                                <asp:Button ID="button1" runat="server" EnableTheming="True" class="btn btn-link" Text="Ver" />
                            </td>

                        </tr>
                        <%} %>--%>
                    </tbody>
                    <!--Table body-->
                </table>
                <!--Table-->
            </div>

            <hr class="my-0">

            <!--Bottom Table UI-->
            <div class="d-flex justify-content-between">

                <!--Name-->
                <select class="mdb-select colorful-select dropdown-primary mt-2 hidden-md-down">
                    <option value="" disabled>Rows number</option>
                    <option value="1" selected>10 rows</option>
                    <option value="2">25 rows</option>
                    <option value="3">50 rows</option>
                    <option value="4">100 rows</option>
                </select>

                <!--Pagination -->
                <nav class="my-4">
                    <ul class="pagination pagination-circle pg-blue mb-0">

                        <!--First-->
                        <li class="page-item disabled"><a class="page-link">First</a></li>

                        <!--Arrow left-->
                        <li class="page-item disabled">
                            <a class="page-link" aria-label="Previous">
                                <span aria-hidden="true">&laquo;</span>
                                <span class="sr-only">Previous</span>
                            </a>
                        </li>

                        <!--Numbers-->
                        <li class="page-item active"><a class="page-link">1</a></li>
                        <li class="page-item"><a class="page-link">2</a></li>
                        <li class="page-item"><a class="page-link">3</a></li>
                        <li class="page-item"><a class="page-link">4</a></li>
                        <li class="page-item"><a class="page-link">5</a></li>

                        <!--Arrow right-->
                        <li class="page-item">
                            <a class="page-link" aria-label="Next">
                                <span aria-hidden="true">&raquo;</span>
                                <span class="sr-only">Next</span>
                            </a>
                        </li>

                        <!--First-->
                        <li class="page-item"><a class="page-link">Last</a></li>

                    </ul>
                </nav>
                <!--/Pagination -->

            </div>
            <!--Bottom Table UI-->

        </div>
    </div>
</asp:Content>
