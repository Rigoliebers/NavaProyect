<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="Animalitos.aspx.cs" Inherits="Animalitos.Paginas.Animalitos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">

    <div>
        <table width="100%">
            <tr>
                <td align="center">
                    <table>
                        <tr>
                            <td>
                                <asp:GridView runat="server" ID="gvAnimalitos"></asp:GridView>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    
    <div align="center">
        <asp:Label runat="server" ID="lblApartar" Text="¡Aparta ahora!" Font-Size="24"></asp:Label>
    </div>
    <div align="center">
        <asp:DropDownList runat="server" ID="ddlAnimalitos"/>
    </div>

</asp:Content>
