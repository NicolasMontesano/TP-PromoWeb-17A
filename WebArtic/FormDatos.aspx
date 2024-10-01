<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FormDatos.aspx.cs" Inherits="WebArtic.FormDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Ingresá tus datos</h1>
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtDNI" class="form-label">DNI</label>
                <asp:TextBox ID="txtDNI" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
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
                <div class="input-group">
                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="email"></asp:TextBox>
                    <span class="input-group-text">@</span>
                    <asp:TextBox ID="txtEmailDomain" CssClass="form-control" runat="server" placeholder="email.com"></asp:TextBox>
                </div>
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
            <div class="mb-3 form-check">
                <asp:CheckBox ID="chkAceptar" CssClass="form-check-input" runat="server" />
                <label class="form-check-label" for="chkAceptar">Acepto los términos y condiciones</label>
            </div>
            <asp:Button Text="Participar!" CssClass="btn btn-primary" ID="btnParticipar" OnClick="btnParticipar_Click" runat="server" />
        </div>
    </div>
</asp:Content>
