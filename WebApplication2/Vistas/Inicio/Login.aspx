<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Inicio/Inicio.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PaginaWeb.Vistas.Inicio.Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="hero">
        <div class="hero-container">
            <h2>
                <label>Usuario</label>
                <asp:TextBox ID="usua" class="form-control requered" autocomplete="off" runat="server" Width="252px" MaxLength="20"></asp:TextBox>

                <label>Contraseña</label>
                <asp:TextBox ID="contra" class="form-control requered" TextMode="Password" runat="server" MaxLength="20" Width="252px"></asp:TextBox>
                <%--<asp:RequiredFieldValidator runat="server" ID="rfv" ControlToValidate="contra">
                 Debe completar todos los campos
                </asp:RequiredFieldValidator>--%>
                <br />
                <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-primary btn-round btn-lg btn-block" OnClick="IniciarSesion" Text="Iniciar Sesion" />
                <asp:Button ID="olvidoclave" runat="server" EnableTheming="True" class="btn btn-link" Text="Olvido su contraseña?" OnClick="recordarclave" />

            </h2>
        </div>
    </section>
</asp:Content>
