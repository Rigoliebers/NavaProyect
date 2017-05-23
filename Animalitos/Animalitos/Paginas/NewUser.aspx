<%@ Page Title="Nuevo Usuario" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="Animalitos.Paginas.NewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="cphNewUser" ContentPlaceHolderID="cphPrincipal" runat="server">


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
                                <asp:TextBox runat="server" ID="tbxContraseña" Text="" Width="160px" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" Text="Confirmar Contraseña:" ID="lblConfirmarContraseña"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbxConfirmarContraseña" Text="" Width="160px" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" Text="Correo:" ID="lblCorreo"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbxCorreo" Text="" Width="160px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" Text="Nivel:" ID="lblNivel"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbxNivel" Text="1" Width="160px"></asp:TextBox>
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
                <asp:ImageButton runat="server" ImageUrl="../Imagenes/Botones/Aceptarbutton.png" ImageAlign="Middle" ID="btnAceptar" OnClick="CreateUser_OnContinueButtonClick"/>
            </td>
        </tr>
    </div>




</asp:Content>
