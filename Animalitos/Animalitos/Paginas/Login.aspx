<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Animalitos.Paginas.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="cphLogin" ContentPlaceHolderID="cphPrincipal" runat="server">
    
    
    
        <div>
        <table width="100%">
            <tr>
                <td align="center">
                    <table>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" Text="Usuario:    " ID="lblUsuario"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbxUsername" Text="" Width="160px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" Text="Contraseña:" ID="lblContraseña"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbxContraseña" Text="" Width="160px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    
    <div align="center">
        <asp:Label runat="server" ID="lblStatus" Text="Everything OK"></asp:Label>
    </div>

    <div>
        <tr>
            <td align="center">
                <asp:ImageButton runat="server" ImageUrl="../Imagenes/Botones/ingresarbutton.png" ImageAlign="Middle" ID="btnAceptar" OnClick="CreateUser_OnContinueButtonClick"/>
            </td>
        </tr>
    </div>
    
    

</asp:Content>
