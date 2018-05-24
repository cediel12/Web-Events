<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="ListaEventos.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.ListaEventos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel='stylesheet' id='compiled.css-css' href="../../Estilos/Otro/css/compiled.min268f.css?ver=4.5.0" <link rel='stylesheet' id='compiled.css-css'  href='../../wp-content/themes/mdbootstrap4/css/compiled.min268f.css?ver=4.5.0' type='text/css' media='all' />

   

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
                            <th class="th-lg"><a>ID</a></th>
                            <th class="th-lg"><a>Nombre</a></th>
                            <th class="th-lg"><a>Fecha Inicio</a></th>
                            <th class="th-lg"><a>Fecha Fin</a></th>
                            <th class="th-lg"><a>Hora</a></th>
                            <th class="th-lg"><a>Lugar</a></th>
                            <th class="th-lg"><a>Usuario</a></th>
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
                                    <td><%=crece++ %></td>
                                    <td><%#Eval("nombre_e") %></td>
                                    <td><%#Eval("fechainicio") %></td>
                                    <td><%#Eval("fechafin") %></td>
                                    <td><%#Eval("horaevento") %></td>
                                    <td><%#Eval("tipo") %></td>
                                    <td><%#Eval("nombre") %></td>

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
            <!--Bottom Table UI-->

        </div>
    </div>
</asp:Content>
