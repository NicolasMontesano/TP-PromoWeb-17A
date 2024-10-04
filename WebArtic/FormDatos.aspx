<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FormDatos.aspx.cs" Inherits="WebArtic.FormDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <h1>Registro de Cliente</h1>
        
        <div class="mb-3">
            <label for="txtDNI" class="form-label">DNI</label>
            <asp:TextBox ID="txtDNI" CssClass="form-control" runat="server" placeholder="Ingrese su DNI"></asp:TextBox>
        </div>
        <asp:Button Text="Verificar DNI" CssClass="btn btn-secondary" ID="btnVerificarDNI" OnClick="btnVerificarDNI_Click" runat="server" />

        <div id="formularioDatos" runat="server" visible="false">
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtApellido" class="form-label">Apellido</label>
                <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtDireccion" class="form-label">Dirección</label>
                <asp:TextBox ID="txtDireccion" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtCiudad" class="form-label">Ciudad</label>
                <asp:TextBox ID="txtCiudad" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtCP" class="form-label">Código Postal</label>
                <asp:TextBox ID="txtCP" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <asp:Button Text="Participar!" CssClass="btn btn-primary" ID="btnParticipar" OnClick="btnParticipar_Click" runat="server" />
        </div>

        <asp:Label ID="lblError" runat="server" CssClass="text-danger" Visible="false"></asp:Label>
    </div>
</asp:Content>

