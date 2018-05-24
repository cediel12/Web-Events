<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="ReporteEvent.aspx.cs" Inherits="PaginaWeb.Vistas.Reportes.ReporteEvent" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        <h2>Reportes</h2>
        <div class="form-group">
            <asp:RadioButton ID="Radio2" GroupName="Reportes" Text="Reportes de Eventos" runat="server" />
            <br />
            <asp:RadioButton ID="Radio3" GroupName="Reportes" Text="Reportes de Usuarios Registrados Por Evento" runat="server" />

            <br />
            <asp:RadioButton ID="Radio4" GroupName="Reportes" Text="Reporte de Tema de Evento" runat="server" />
            <br />
        </div>
        <div class="form-group">

            <asp:Panel ID="Panel1" runat="server" BorderColor="#990000" BorderStyle="Solid" Height="116px" ScrollBars="Both" Style="width: 400px">
                <asp:ListBox ID="ListBox1" Width="1000px" SelectionMode="Single" runat="server"></asp:ListBox>
            </asp:Panel>

        </div>
        <div class="clearfix">
        </div>
        <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Reporte" OnClick="Reporte" />
    </div>
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
</asp:Content>
