<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="Ajustes.aspx.cs" Inherits="Animalitos.Paginas.Ajustes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div>
        <br />
        <asp:GridView ID="gvAnimalitos" runat="server"></asp:GridView>
        <br />
        <asp:DropDownList ID="ddlAnimalitos" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEditar" runat="server" Text="Editar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBorrar" runat="server" Text="Borrar" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
    </div>
    <div>
        <br />
        <asp:GridView ID="gvUsuarios" runat="server"></asp:GridView>
        <br />
        <asp:DropDownList ID="ddlUsuarios" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBorrarU" runat="server" Text="Borrar" OnClick="btnBorrarU_Click" />
    </div>
</asp:Content>
