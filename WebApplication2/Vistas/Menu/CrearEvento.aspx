<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="CrearEvento.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.CrearEvento" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        <h2>Crear Evento</h2>
        <form>
            <div class="form-group">
                <label for="first-name">Nombre</label>
                <asp:TextBox ID="nombre" class="form-control" runat="server"  placeholder="Nombre Evento"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="number">Fecha Inicio</label>
                <asp:TextBox ID="fechainicio" class="form-control"  runat="server"  placeholder="Fecha Inicio"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="country">Fecha Fin</label>
                <asp:TextBox ID="fechafin" class="form-control"  runat="server"  placeholder="Fecha Fin"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="number">Hora</label>
                <asp:TextBox ID="hora" class="form-control"  runat="server"  placeholder="Hora"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="age">Lugar</label>
                <asp:TextBox ID="lugar" class="form-control"  runat="server" placeholder="Lugar"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="email">Tpio Lugar</label>
                <asp:TextBox ID="tipolugar" class="form-control"  runat="server" placeholder="Tipo Lugar"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="category">Computadores</label>
                <asp:TextBox ID="digital" class="form-control" runat="server" placeholder="Computadores"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="education">Duracion</label>
                <asp:TextBox ID="duracion" class="form-control" runat="server"  placeholder="Duracion"></asp:TextBox>
            </div>
            <div class="clearfix"></div>
            <asp:Button ID="registrar" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Crear Evento" OnClick="CrearEvent" />
        </form>
    </div>
</asp:Content>
