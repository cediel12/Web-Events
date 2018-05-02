<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="PaginaWeb.Menu" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Eventium</title>
    <meta name="description" content="A tutorial on how to recreate the effect of YouTube's little left side menu. The idea is to slide a little menu icon to the right side while revealing some menu item list beneath. " />
    <meta name="keywords" content="Add keywords" />
    <meta name="author" content="_yourName_ for Codrops" />
    <link rel="shortcut icon" href="Estilos/Otro/img/logopagina.ico">
    <link rel="stylesheet" type="text/css" href="css/Menu/default.css" />
    <link rel="stylesheet" type="text/css" href="css/Menu/component.css" />
    <script src="js/modernizr.custom.js"></script>
</head> 
<body>
    <div class="container">
        <div class="main">
            <p>This menu is inspired by the left side menu found on YouTube. When clicking on the menu label and icon, the main menu appears beneath and the menu icon slides to the right side while the label slides up. To close the menu, the menu icon needs to be clicked again.</p>
            <div class="side">
                <nav class="dr-menu">
                    <div class="dr-trigger">
                        <span class="dr-icon dr-icon-menu"></span><a class="dr-label"><%= Session["Nombre"].ToString() %></>
                        </a>
                    </div>
                    <ul>
                        <li><a class="dr-icon dr-icon-user">
                            <%= Session["Nombre"].ToString() %></>
                        </a></li>
                        <li><a class="dr-icon dr-icon-camera" href="#">Eventos</a></li>
                        <li><a class="dr-icon dr-icon-heart" href="#">Cronograma</a></li>
                        <li><a class="dr-icon dr-icon-bullhorn" href="#">Eventos Inscritos</a></li>
                        <li><a class="dr-icon dr-icon-download" href="#">Pagos</a></li>
                        <li><a class="dr-icon dr-icon-settings" href="#">Configuracion</a></li>
                        <li><a class="dr-icon dr-icon-switch" href="#">Cerrar Sesion</a></li>
                    </ul>
                </nav>
            </div>

        </div>
    </div>
    <!-- /container -->
    <script src="js/Menu.js"></script>
</body>
</html>
