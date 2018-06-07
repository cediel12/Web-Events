<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Vistas/Menu/Administrador.Master" AutoEventWireup="true" CodeBehind="CrearEvento.aspx.cs" Inherits="PaginaWeb.Vistas.Menu.CrearEvento" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <link href="../../Estilos/styles.css" rel="stylesheet" />
    <div class="container" id="advanced-search-form">
        <h2>Crear Nuevo Evento</h2>
        <from>
          
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
                <label for="age">Director</label>
                <asp:DropDownList ID="director" class="form-control" AppendDataBoundItems="true" DataTextField="media_name" DataValueField="media_id" runat="server" >
                    <asp:ListItem>Seleccione Un Director</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="age">Lugar</label>
                <asp:TextBox ID="lugar" class="form-control"  runat="server" placeholder="Lugar"></asp:TextBox>
            </div>
              <div class="form-group">
                <label for="number">Nombre</label>
                <asp:TextBox ID="nombre" class="form-control" runat="server"  placeholder="Nombre Evento"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="Button1" runat="server" EnableTheming="True" class="btn btn-info btn-lg btn-responsive" Text="Registrar" OnClick="Registrar" />
        <button type="button" id="Button2" class="btn btn-danger btn-lg btn-responsive" data-toggle="modal" data-target="#miventana">Agregar Imagen</button>
        <div class="modal fade" id="miventana" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h4 class="modal-title">Cargar imagen</h4>
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                    </div>
                    <div class="modal-body">
                        <div class="embed-responsive embed-responsive-16by9">
                            <iframe class="embed-responsive-item" src="cargaarchivos.aspx"></iframe>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-primary" data-dismiss="modal">Cerrar</button>
                    </div>
                </div>
            </div>
        </div>
            </div>
            
        </from>
    </div>
</asp:Content>
