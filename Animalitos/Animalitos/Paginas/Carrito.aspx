<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Animalitos.Paginas.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div align="center">
        <asp:label runat="server" text="Estos son los articulos que TÚ haz apartado"></asp:label>
    </div> 
    <div align="center">
        <asp:gridview runat="server" ID="gvCarrito"></asp:gridview>    
    </div>
    
</asp:Content>
