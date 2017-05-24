<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="Apartar.aspx.cs" Inherits="Animalitos.Paginas.Venta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPrincipal" runat="server">


    <div align="center">
        <asp:Image runat="server" ID="imgAnimalito" BorderColor="Black" BorderWidth="3" ImageAlign="Middle" Width="500" />
    </div>
    <div align="center">
        <asp:Label runat="server" ID="lblDescripcion"></asp:Label>
    </div>
    <div align="center">
        <asp:Label runat="server" ID="lblPrecio" Font-Italic="True" Font-Size="18"></asp:Label>
    </div>
    <div align="center">
        <asp:ImageButton runat="server" ID="btnAceptar" OnClick="btnAceptar_OnClick" ImageUrl="../Imagenes/Botones/apartarbutton.png" />
    </div>
    
    

</asp:Content>