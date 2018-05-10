﻿<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="CrearTema.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.CrearTema" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        <a href="ListaEventos.aspx" class="white-text mx-3">Volver</a>
        <h2>Crear Tema</h2>
        <from>
            <div class="form-group">
                <label for="first-name">Nombre</label>
                <asp:TextBox ID="nombre" class="form-control" runat="server"  placeholder="Nombre Evento"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="number">Fecha</label>
                <asp:TextBox ID="fechainicio" class="form-control"  runat="server" Height="46" TextMode="Date" ></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="number">Hora</label>
                <asp:TextBox ID="hora" class="form-control"  runat="server" Height="46"  TextMode="Time"></asp:TextBox>
            </div>
            
            <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Registrar" OnClick="Registrar" />
                </from>
    </div>
</asp:Content>
