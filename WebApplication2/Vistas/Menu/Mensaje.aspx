<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mensaje.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.Mensaje" %>

<!DOCTYPE html>

<head runat="server">
    <title>Agregar Imagen Usuario</title>
    <!-- Bootstrap CSS-->
    <link href="../../Estilos/Men/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome CSS-->
    <link href="../../Estilos/Men/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
    <!-- Fontastic Custom icon font-->
    <link href="../../Estilos/Men/css/fontastic.css" rel="stylesheet" />
    <!-- Google fonts - Poppins -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Poppins:300,400,700">
    <!-- theme stylesheet-->
    <link href="../../Estilos/Men/css/style.default.css" rel="stylesheet" />
    <!-- Custom stylesheet - for your changes-->
    <link href="../../Estilos/Men/css/custom.css" rel="stylesheet" />
    <!-- Favicon-->
    <link href="../../Estilos/Otro/img/logopagina.png" rel="icon">

    <style type="text/css">
        #file1 {
            width: 390px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="panel-heading">
                <asp:Label ID="label1" Text="" runat="server" />
            </div>
            <div>
                <div class="form-group">
                    <asp:TextBox id="mensaje" TextMode="multiline" placeholder="Mensaje" Columns="50" Rows="5" runat="server" />
                    <div class="validation"></div>
                </div>
                <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Enviar" OnClick="Button1_Click" />

            </div>
        </div>
    </form>
</body>
</html>
