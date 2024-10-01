<%@ Page Title="Error" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="WebArtic.ErrorPage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-12 text-center">
                <h1 class="display-4">¡Error inesperado!</h1>
                <p class="lead">Parece que ha ocurrido un error inesperado.</p>
                <p>Por favor, intente volver a la página anterior o póngase en contacto con el administrador si el problema persiste.</p>
                <hr />
                <a href="/" class="btn btn-primary">Volver a la página principal</a>
            </div>
        </div>
    </div>
</asp:Content>
