<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="Animalitos.Paginas.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    
    
    <div align="center">
        <asp:Image runat="server" ImageUrl="../Imagenes/bye.png"  />
    </div>
    <div align="center">
        <asp:Label runat="server" Text="¡Hasta luego!" Font-Size="24"  />
    </div>

</asp:Content>
