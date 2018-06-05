<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="CrearEvento.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.CrearEvento" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <script type="text/javascript">
        function Agregar() {
            var oContador = 1;
            var oElementos = document.getElementsByTagName("input");
            for (var i = 0; i < length; i++) {
                if (oElementos[i].type == "file") {
                    oContador++;
                }
            }
            var oTr = document.getElementById("trArchivos");
            var oBr = document.createElement("br");
            var oFU = document.createElement("input");
            oFU.type = "file";
            oFU.name = "Archivo" + oContador;
            oFU.id = "file" + oContador;
            oTr.appendChild(oBr);
            oTr.appendChild(oFU);

        }

    </script>
    <style type="text/css">
        #file1 {
            width: 390px;
        }
    </style>
    <div class="container" id="advanced-search-form">
        <h2>Crear Nuevo Evento</h2>
        <from id="form1" runat="server">
            <div class="form-group">
                <label for="first-name">Nombre</label>
                <asp:TextBox ID="nombre" class="form-control" autocomplete="off"  runat="server"  placeholder="Nombre Evento"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="number">Fecha Inicio</label>
                <asp:TextBox ID="fechainicio" class="form-control"  runat="server" Height="46" TextMode="Date" ></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="country">Fecha Fin</label>
                <asp:TextBox ID="fechafin" class="form-control"  runat="server" Height="46" TextMode="Date" ></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="number">Hora</label>
                <asp:TextBox ID="hora" class="form-control"  runat="server" Height="46"  TextMode="Time"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="age">Lugar</label>
                <asp:TextBox ID="lugar" class="form-control"  runat="server" placeholder="Lugar"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="age">Imagen</label>
                   <asp:FileUpload ID="fileupload1" runat="server"/>
                    <asp:Button ID="button2" Text="cargar_archivo" runat="server" OnClick="subirarchivo" Width="127px" />
                    <asp:Label ID="label1" Text="" runat="server" />
            </div>
            
            <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Registrar" OnClick="Registrar" />
                </from>
    </div>
</asp:Content>
