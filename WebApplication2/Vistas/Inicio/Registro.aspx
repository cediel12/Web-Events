<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Inicio/Inicio.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="PaginaWeb.Vistas.Inicio.Registro" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="hero">
        <div class="hero-container">
            <h2>
                <from runat="server">
                    <label>Usuario *</label>
                     <asp:TextBox ID="usua" class="form-control" MaxLength="20" runat="server" Width="252px" placeholder="Usuario"></asp:TextBox>
                <label>Contraseña *</label>
                <asp:TextBox ID="contra" class="form-control" MaxLength="20" TextMode="Password" runat="server" Width="252px" placeholder="*******"></asp:TextBox>
                <label>Nombre *</label>
                <asp:TextBox ID="nombre" class="form-control" runat="server" MaxLength="20" Width="252px" placeholder="Nombre"></asp:TextBox>
                <label>Apellido *</label>
                <asp:TextBox ID="apellido" MaxLength="20" class="form-control" runat="server" Width="252px" placeholder="Apellido"></asp:TextBox>
                <label>Correo *</label>
                <asp:TextBox ID="correo" class="form-control" MaxLength="40" runat="server" Width="252px" placeholder="Correo"></asp:TextBox>
                <label>Cedula *</label>
                <asp:TextBox ID="cedula" class="form-control" MaxLength="40" runat="server" Width="252px" placeholder="Numero de Identificacion"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revEmailAddress" runat="server" SetFocusOnError="true"
                    Display="None" ControlToValidate="correo" resourceKey="revEmailAddress"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="register"></asp:RegularExpressionValidator>
                <br />
                <asp:Button ID="registrar" runat="server" EnableTheming="True" class="btn btn-primary btn-round btn-lg btn-block" Text="Registrar" OnClick="Registrar" />

                </from>

            </h2>
        </div>
    </section>
</asp:Content>
