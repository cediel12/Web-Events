<%@ Page Title="" Language="C#" enableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="ActualizarUsuario.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.ActualizarUsuario" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        <h2>Actualizar Usuario</h2>
        <from >
            <div class="form-group">
                <label for="country">Nombre</label>
                <asp:TextBox ID="nombre" class="form-control" autocomplete="off"  runat="server" placeholder="Nombre"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="country">Apellido</label>
                <asp:TextBox ID="apellido" class="form-control" autocomplete="off"  runat="server" placeholder="Apellido"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Correo</label>
                <asp:TextBox ID="correo" class="form-control" autocomplete="off"  runat="server" placeholder="Correo"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="country">Cedula</label>
                <asp:TextBox ID="cedula" class="form-control" runat="server" placeholder="Identificacion"></asp:TextBox>
            </div>
            <div class="clearfix"></div>
            <asp:Button ID="actualizar" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Actualizar" OnClick="Button2_Click" />
            <Button type="button" ID="Button2" class="btn btn-info btn-lg btn-responsive" data-toggle="modal" data-target="#miventana">Cargar Imagen</button>
            <div class="modal fade" id="miventana" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Cargar imagen</h4>
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        </div>
                    <div class="modal-body">
                        <div class="embed-responsive embed-responsive-16by9">
                            <iframe class="embed-responsive-item" src="cargaarchivos.aspx"></iframe>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" data-dismiss="modal">Cerrar</button>
                    </div>
                  </div>
                </div>
            </div>

                </from>
    </div>
</asp:Content>
