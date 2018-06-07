<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="ReporteEvent.aspx.cs" Inherits="PaginaWeb.Vistas.Reportes.ReporteEvent" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        <h2>Reportes</h2>
        <div class="form-group">
            <asp:RadioButton ID="Radio2" GroupName="Reportes" Text="Reportes de Eventos" runat="server" OnSelectedIndexChanged="Index_Changed2" />
            <br />
            <asp:RadioButton ID="Radio4" GroupName="Reportes" Text="Reporte de Tema de Evento" runat="server" OnSelectedIndexChanged="Index_Changed" />
            <br />
            <%if (Session["rol"].ToString()=="Administrador" || Session["rol"].ToString()=="Director Evento" ) { %>
            <asp:RadioButton ID="Radio3" GroupName="Reportes" Text="Reportes de Usuarios Registrados Por Evento" runat="server" OnSelectedIndexChanged="Index_Changed" />
            <br />
            <asp:RadioButton ID="Radio1" GroupName="Reportes" Text="Participantes Certificados" runat="server" OnSelectedIndexChanged="Index_Changed" />
            <%} %>
            <br />
            
        </div>
        <div class="form-group">
            <asp:DropDownList ID="eventos" class="form-control" AppendDataBoundItems="true" DataTextField="media_name" DataValueField="media_id" runat="server" Visible="false">
                <asp:ListItem>Seleccione Un Evento</asp:ListItem>
            </asp:DropDownList>

        </div>
        <div class="clearfix">
        </div>
        <asp:Button ID="Button2" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Reporte" OnClick="Reporte" />
        <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Visualizar" OnClick="ver" />
    </div>
    <div class="form-group">
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
    </div>

</asp:Content>
