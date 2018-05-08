<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Inicio/Inicio.Master" AutoEventWireup="true" CodeBehind="OlvidoClave.aspx.cs" Inherits="PaginaWeb.Vistas.Inicio.OlvidoClave" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="hero">
        <div class="hero-container">
            <h2>
                <from runat="server">
                    <label>Ingrese su nombre de usuario</label>
                     <asp:TextBox ID="usua" class="form-control" MaxLength="20" runat="server" Width="252px" placeholder="Usuario"></asp:TextBox>
                    <br />
                    <asp:Button ID="recuperarclave" runat="server" EnableTheming="True" class="btn btn-primary btn-round btn-lg btn-block" Text="Restablecer Contraseña" OnClick="RestaurarClave" />
                    <asp:Button ID="olvidoclave" runat="server" EnableTheming="True" class="btn btn-link" Text="Iniciar Sesion" OnClick="recordarclave" />


                </from>

            </h2>
        </div>
    </section>
</asp:Content>
