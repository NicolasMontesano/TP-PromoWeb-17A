<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListaArticulos.aspx.cs" Inherits="WebArtic.ListaArticulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- <style>
        .img-container {
            max-width: 300px; /* Ancho máximo del contenedor */
            max-height: 200px; /* Alto máximo del contenedor */
            overflow: hidden; /* Oculta cualquier contenido que exceda el tamaño del contenedor */
        }

        .img-container img {
            width: 100%; /* Ajusta el ancho de la imagen al 100% del contenedor */
            height: 100%; /* Mantiene la proporción de la imagen */
            object-fit:  scale-down; /* Ajusta la imagen para que se mantenga dentro del contenedor sin recortarse */
        }
    </style>--%>
   <%-- <style>
        .img-container {
            max-width: 300px; /* Ancho máximo del contenedor */
            max-height: 200px; /* Alto máximo del contenedor */
            background-size: contain; /* Ajusta la imagen para que toda sea visible dentro del contenedor */
            background-repeat: no-repeat; /* Evita que la imagen se repita */
            background-position: center; /* Centra la imagen en el contenedor */
    </style>
    }--%>

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
                    <img  src="<%:urlImg%>" class="card-img-top"  alt="...">

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
