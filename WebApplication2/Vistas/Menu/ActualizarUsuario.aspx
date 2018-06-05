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
            <asp:Button ID="Button2" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Registrar" OnClick="Button2_Click" />
            <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Cargar Imagen"  OnClick="Button1_Click"/>
                </from>
    </div>
</asp:Content>
