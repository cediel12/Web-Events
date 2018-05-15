<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="CrearEvento.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.CrearEvento" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        <h2>Crear Nuevo Evento</h2>
        <from>
            <div class="form-group">
                <label for="first-name">Nombre</label>
                <asp:TextBox ID="nombre" class="form-control" runat="server"  placeholder="Nombre Evento"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="number">Fecha Inicio</label>
                <asp:TextBox ID="fechainicio" class="form-control"  runat="server" Height="46" TextMode="Date" ></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="country">Fecha Fin</label>
                <asp:TextBox ID="fechafin" class="form-control"  runat="server" Height="46" TextMode="Date" ></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="number">Hora</label>
                <asp:TextBox ID="hora" class="form-control"  runat="server" Height="46"  TextMode="Time"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="age">Lugar</label>
                <asp:TextBox ID="lugar" class="form-control"  runat="server" placeholder="Lugar"></asp:TextBox>
            </div>
            
            <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Registrar" OnClick="Registrar" />
                </from>
    </div>
</asp:Content>
