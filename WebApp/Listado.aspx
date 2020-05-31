<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="WebApp.Listado" %>

<asp:Content runat="server" ID="Listado" ContentPlaceHolderID="ContentPlaceHolder1">

    <h1 style="margin-left: 50px; margin-top: 20px;">Lista Articulos</h1>

    <div class="row" style="margin-top: 10px;justify-content: center">
            <div class="btn-group dropright">
                <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    Filtrar por Categoria
                </button>
                <div class="dropdown-menu">
                    <% foreach (var cat in categorias) { %>
                    <a href="Listado.aspx?idcat=<% = cat.Id.ToString() %>" class="dropdown-item"><% = cat.Descripcion %></a>
                     <% } %>
                    <div class="dropdown-divider"></div>
                    <a href="Listado.aspx" class="dropdown-item">Quitar Filtro</a>
                </div>
            </div>
        </div>

    <div class="row" style="margin: 50px; justify-content: center">
        <div class="card-group" style="margin-left: 10px; margin-right: 10px;">

            <% foreach (var item in listaArticulos)
                { %>
            <div class="card">
                <div class="row" style="margin: 10px; height: 200px;">
                    <img src="<% = item.Imagen %>" class="card-img-top" alt="..." style="height: 200px;width:200px;">
                </div>
                <div class="card-body">
                    <div class="row" style="margin: 10px; height: 50px;">
                        <h5 class="card-title"><% = item.Nombre %></h5>
                    </div>
                    <div class="row" style="margin: 10px; height: 25px;">
                        <p class="card-text">$ <% = decimal.Round(item.Precio, 2, MidpointRounding.AwayFromZero) %></p>
                    </div>
                    <div class="row" style="margin: 10px; height: 38px;">
                        <a href="Detalle.aspx?idart=<% = item.Id.ToString() %>" class="btn btn-primary">Detalle</a>
                    </div>
                    <div class="row" style="margin: 10px; height: 38px;">
                        <a href="Listado.aspx?idart=<% = item.Id.ToString() %>" class="btn btn-success">Agregar al Carrito</a>
                    </div>

                </div>
            </div>
            <% } %>
        </div>
    </div>

</asp:Content>
