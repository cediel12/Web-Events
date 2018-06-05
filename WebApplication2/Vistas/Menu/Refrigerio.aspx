<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="Refrigerio.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.Refrigerio" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        <h2>Refrigerio</h2>
        <div class="form-group">
            <asp:DropDownList ID="eventos" class="form-control" AppendDataBoundItems="true" DataTextField="media_name" DataValueField="media_id" runat="server">
                <asp:ListItem>Seleccione Un Evento</asp:ListItem>
            </asp:DropDownList>
        </div>
         <div class="form-group">
            <asp:DropDownList ID="jornada" class="form-control" AppendDataBoundItems="true" DataTextField="media_name" DataValueField="media_id" runat="server">
                <asp:ListItem>Seleccione Una Jornada</asp:ListItem>
                <asp:ListItem>Mañana</asp:ListItem>
                <asp:ListItem>Tarde</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clearfix">
        </div>
        <asp:Button ID="Button2" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Refrigerio" OnClick="Button2_Click" />
    </div>
</asp:Content>
