<%@ Page Title="" EnableEventValidation="false"  Language="C#" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="Asistencia.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.Asistencia" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        <div class="form-group">
            <asp:DropDownList ID="eventos" class="form-control" AppendDataBoundItems="true" DataTextField="media_name" DataValueField="media_id" runat="server">
                <asp:ListItem>Seleccione Un Evento</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clearfix">
        </div>
        <asp:Button ID="Button2" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Reporte" OnClick="Button2_Click" />
    </div>
</asp:Content>
