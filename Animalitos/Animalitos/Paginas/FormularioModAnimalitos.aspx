﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="FormularioModAnimalitos.aspx.cs" Inherits="Animalitos.Paginas.FormularioModAnimalitos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    
    
    
            <div>
        <table width="100%">
            <tr>
                <td align="center">
                    <table>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" Text="Descripcion:" ID="lblDescripcion"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbxDescripcion" Text="" Width="180px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label runat="server" Text="Precio:" ID="lblPrecio"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbxPrecio" Text="" Width="180px"></asp:TextBox>
                            </td>
                        </tr>
                                                <tr>
                            <td align="right">
                                <asp:Label runat="server" Text="Imagen Url:" ID="lblImagen"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="tbxImagen" Text="" Width="180px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    
    <div align="center">
        <br/>
        <asp:ImageButton runat="server" ID="btnAceptar" ImageUrl="../Imagenes/Botones/Aceptarbutton.png" OnClick="btnAceptar_OnClick"/>
    </div>
    
    

</asp:Content>
