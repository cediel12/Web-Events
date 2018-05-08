<%@ Page Title="" EnableEventvalidation="false" Language="C#" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.RegistrarUsuario" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        <h2>Registra Nuevo Usuario</h2>
        <from >
            <div class="form-group">
                <label for="first-name">Usuario</label>
                <asp:TextBox ID="usuario" class="form-control" runat="server" placeholder="Usuario"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="number">Contraseña</label>
                <asp:TextBox ID="contra" TextMode="Password" class="form-control" runat="server" placeholder="Contraseña"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="country">Nombre</label>
                <asp:TextBox ID="nombre" class="form-control" runat="server" placeholder="Nombre"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="number">Apellido</label>
                <asp:TextBox ID="apellido" class="form-control" runat="server" placeholder="Apellido"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="age">Correo</label>
                <asp:TextBox ID="correo" class="form-control" runat="server" placeholder="Correo"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Rol</label>
                <asp:TextBox ID="rol" class="form-control" runat="server" placeholder="Rol"></asp:TextBox>
            </div>
            <div class="clearfix"></div>
            <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Registrar" OnClick="Registrar" />
                </from>
    </div>
</asp:Content>
