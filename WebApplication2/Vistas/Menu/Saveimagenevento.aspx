<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Saveimagenevento.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.Saveimagenevento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <div>
                   <asp:FileUpload ID="fileupload1" runat="server"/>
                </div>
                <div>
                    <asp:Button ID="button1" Text="cargar_archivo" runat="server" OnClick="subirarchivo" Width="127px" />
                </div>
                <div>
                    <asp:Label ID="label1" Text="" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
