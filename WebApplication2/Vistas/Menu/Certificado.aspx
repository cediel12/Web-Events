<%@ Page Title="" Language="C#" enableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="Certificado.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.Certificado" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        
        <div class="form-group">
            <asp:DropDownList ID="eventos" class="form-control" AppendDataBoundItems="true" DataTextField="media_name" DataValueField="media_id" runat="server" Width="700px">
                <asp:ListItem>Seleccione Un Evento</asp:ListItem>
            </asp:DropDownList>

        </div>
        <div class="clearfix">
        </div>
        <asp:Button ID="Button2" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Reporte" OnClick="Reporte" />
    </div>
    <div class="form-group">
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
    </div>
</asp:Content>
