<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="Redirect.aspx.cs" Inherits="Animalitos.Paginas.Redirect" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">

    <div align="center">
        <asp:Image runat="server" ID="imgCongrats" ImageUrl="../Imagenes/Botones/Nerfthis.jpg" />
    </div>
    <div align="center">
        <asp:Label runat="server" Text="¡Registro completado con exito!" Font-Size="24" Font-Bold="True"></asp:Label>
    </div>
    <div align="center">
        <asp:Label runat="server" Text="Redireccionando..." Font-Size="20"></asp:Label>
    </div>
    <meta http-equiv="refresh" content="3;url=../Paginas/Login.aspx" />

</asp:Content>
