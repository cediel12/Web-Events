<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PaginaWeb.Vistas.Login.Login" %>

<!DOCTYPE html>

<head>
    <meta charset="utf-8">
    <title>Registro</title>
    <meta content="width=device-width, initial-scale=1.0" name="viewport">
    <meta content="" name="keywords">
    <meta content="" name="description">
<link href="img/logopagina.png" rel="icon">
    <link href="img/apple-touch-icon.png" rel="apple-touch-icon">
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,700,700i|Poppins:300,400,500,700" rel="stylesheet">
    <link href="../../Estilos/Men/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Estilos/Men/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <link href="../../Estilos/Men/vendor/animate/animate.css" rel="stylesheet" />
    <link rel="shortcut icon" href="Estilos/Otro/img/logopagina.ico">
    <link href="../../Estilos/Otro/css/style.css" rel="stylesheet" />
</head>

<body>

    <!--==========================
  Header
  ============================-->
    <header id="header">
        <div class="container">

            <div id="logo" class="pull-left">
                <a href="#hero">
                    <img src="img/logo1.png" alt="" title="" /></a>
            </div>

            <nav id="nav-menu-container">
                <ul class="nav-menu">
                    <li class="menu-active"><a href="../Inicio/Index.aspx">Inicio</a></li>
                    <li><a href="Registro.aspx">Registrar</a></li>
                    <li><a href="../Inicio/Index.aspx#team">Desarrolladores</a></li>
                    <li><a href="../Inicio/Index.aspx#contact">Contacto</a></li>
                </ul>
            </nav>
        </div>
    </header>

    <!--==========================
      Centro de opciones
    ============================-->
    <section id="hero">
        <form id="form1" runat="server">
            <div class="hero-container">
                <h2>
                    <label>Usuario</label>
                    <asp:TextBox ID="usua" class="form-control" runat="server" Width="252px"></asp:TextBox>
                    <label>Contraseña</label>
                    <asp:TextBox ID="contra" class="form-control" TextMode="Password" runat="server" Width="252px"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-primary btn-round btn-lg btn-block" OnClick="IniciarSesion" Text="Iniciar Sesion" />
                </h2>
            </div>
        </form>
    </section>
    <!--==========================
      Parte de abajo
    ============================-->
    <footer id="footer">
        <div class="footer-top">
            <div class="container">
            </div>
        </div>

        <div class="container">
            <div class="copyright">
                &copy; Copyright <strong>Eventium</strong>. All Rights Reserved
            </div>
            <div class="credits">
            </div>
        </div>
    </footer>
    <!-- #footer -->

    <a href="#" class="back-to-top"><i class="fa fa-chevron-up"></i></a>

    <!-- JavaScript Libraries -->
    <script src="../../Estilos/Men/vendor/jquery/jquery.min.js"></script>
    <script src="../../Estilos/Men/vendor/jquery/jquery-migrate.min.js"></script>
    <script src="../../Estilos/Men/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="../../Estilos/Men/vendor/easing/easing.min.js"></script>
    <script src="../../Estilos/Men/vendor/wow/wow.min.js"></script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD8HeI8o-c1NppZA-92oYlXakhDPYR7XMY"></script>

    <script src="../../Estilos/Men/vendor/waypoints/waypoints.min.js"></script>
    <script src="../../Estilos/Men/vendor/counterup/counterup.min.js"></script>
    <script src="../../Estilos/Men/vendor/superfish/hoverIntent.js"></script>
    <script src="../../Estilos/Men/vendor/superfish/superfish.min.js"></script>
    <script src="../../contactform/contactform.js"></script>
    <script src="../../Estilos/Otro/js/main.js"></script>
</body>
