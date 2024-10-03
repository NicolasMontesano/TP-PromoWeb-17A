<%@ Page Title="Error" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="WebArtic.ErrorPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-12 text-center">
                <h1 class="display-4 text-danger">Algo salió mal!</h1>
                <p class="lead">Parece que hubo un problema mientras procesábamos tu solicitud.</p>
                <p>Por favor, vuelve a intentarlo más tarde.</p>
                <p class="lead">Detalles del error:</p>
                <asp:Literal ID="litErrorMessage" runat="server" Visible="false" />
                <hr />
                <a href="Default.aspx" class="btn btn-primary">Volver a la página principal</a>
            </div>
        </div>
    </div>
</asp:Content>

