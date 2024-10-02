<%@ Page Title="Registro Exitoso" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Exito.aspx.cs" Inherits="WebArtic.Exito" %>

<asp:Content ID="Content5" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-12 text-center">
                <h1 class="display-4"><asp:Literal ID="litMensajeExito" runat="server" /></h1>
                <p class="lead">Gracias por participar. Tu registro ha sido completado.</p>
                <p>Estas participando por el premio! Te deseamos mucha suerte.</p>
                <hr />
                <a href="Default.aspx" class="btn btn-primary">Volver a la página principal</a>
            </div>
        </div>
    </div>
</asp:Content>

