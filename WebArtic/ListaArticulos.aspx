<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListaArticulos.aspx.cs" Inherits="WebArtic.ListaArticulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .card-img-top {
            width: 200px; /* Ancho fijo */
            height: 200px; /* Alto fijo */
            object-fit: contain; /* Ajustar la imagen sin distorsión */
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% 
            foreach (dominio.Articulo art in ListArt)
            {
                string urlImg = "";
                if (ListImg.Find(x => x.IdArticulo == art.Id) != null)
                    urlImg = ListImg.Find(x => x.IdArticulo == art.Id).ImagenUrl;
        %>
        <div class="col">
            <div class="card">
                <img src="<%:urlImg%>" class="card-img-top" alt="...">

                <div class="card-body">
                    <h5 class="card-title"><%: art.Nombre %></h5>
                    <p class="card-text"><%: art.Categoria.Descripcion %></p>
                    <p class="card-text"><%: art.Marca.Descripcion %></p>
                    <a class="btn btn-primary" href="DetalleArticulo.aspx?id=<%: art.Id %>">Ver Detalle</a>
                    <a class="btn btn-success" href="FormDatos.aspx?id=<%: art.Id %>">Seleccionar</a>
                </div>
            </div>
        </div>
        <%  } %>
    </div>
</asp:Content>