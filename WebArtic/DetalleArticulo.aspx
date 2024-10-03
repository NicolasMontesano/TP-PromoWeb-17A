<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="WebArtic.DetalleArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .carousel-inner img {
            width: 300px; /* Ancho fijo */
            height: 300px; /* Alto fijo */
            object-fit: contain; /* Ajustar la imagen sin distorsión */
        }

        #carouselExampleFade {
            width: 300px; /* Ancho del carrusel */
            height: 300px; /* Alto del carrusel */
            overflow: hidden; /* Ocultar parte que sobresalga */
        }

        .carousel-control-prev-icon,
        .carousel-control-next-icon {
            background-color: rgba(0, 0, 0, 0.5); /* Fondo semitransparente */
            border-radius: 50%; /* Hacer que el fondo sea redondo */
        }

            .carousel-control-prev-icon::after,
            .carousel-control-next-icon::after {
                color: white; /* Color de las flechas */
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <%--formulario--%>
        <div class="col-md-6">
            <%--nombre--%>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <%--categoria--%>
            <div class="mb-3">
                <label for="txtCategoria" class="form-label">Categoria</label>
                <asp:TextBox ID="txtCategoria" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <%--marca--%>
            <div class="mb-3">
                <label for="txtMarca" class="form-label">Marca</label>
                <asp:TextBox ID="txtMarca" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <%--Descripcion--%>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripción</label>
                <asp:TextBox ID="txtDescripcion" TextMode="MultiLine" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <%--Codigo--%>
            <div class="mb-3">
                <label for="txtCodigo" class="form-label">Código</label>
                <asp:TextBox ID="txtCodigo" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <%--Precio--%>
            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox ID="txtPrecio" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>

        <%--carrusel--%>
        <div class="col-md-6">
            <div id="carouselExampleFade" class="carousel slide carousel-fade">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="https://http2.mlstatic.com/D_NQ_NP_703368-MLU76300898146_052024-O.webp" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="https://http2.mlstatic.com/D_NQ_NP_701613-MLA45464844877_042021-O.webp" class="d-block w-100" alt="...">
                    </div>
                    <div class="carousel-item">
                        <img src="https://http2.mlstatic.com/D_NQ_NP_767460-MLA74282172500_022024-O.webp" class="d-block w-100" alt="...">
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
        </div>
    </div>

</asp:Content>
