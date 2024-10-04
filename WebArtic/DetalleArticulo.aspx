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
            <%--Id--%>
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox ID="txtId" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <%--nombre--%>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" ReadOnly="true" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <%--categoria--%>
            <div class="mb-3">
                <label for="ddlCategoria" class="form-label">Categoria</label>
                <asp:DropDownList ID="ddlCategoria" Enabled="false" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <%--marca--%>
            <div class="mb-3">
                <label for="ddlMarca" class="form-label">Marca</label>
                <asp:DropDownList ID="ddlMarca" Enabled="false" CssClass="form-select" runat="server"></asp:DropDownList>
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

                    <% 
                        int contador = 0; // Para ver si es el primer elemento
                        foreach (dominio.Imagen img in ListaImg)
                        {
            %>
                    <div class="carousel-item <%: contador == 0 ? "active" : "" %>">
                        <img src="<%: img.ImagenUrl %>" class="d-block w-100" alt="...">
                    </div>
                    <% 
                            contador++;
                        }
            %>
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
     <div class="row">
     <div class="col-6">
         <div class="mb-3">
             <asp:Button Text="Seleccionar" ID="btnSeleccionar" OnClick="btnSeleccionar_Click" CssClass="btn btn-success" runat="server" />
             <asp:Button Text="Atras" ID="btnAtras" OnClick="btnAtras_Click" CssClass="btn btn-light" runat="server" />

         </div>
     </div>
 </div>


</asp:Content>
