﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="Ajustes.aspx.cs" Inherits="Animalitos.Paginas.Ajustes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphPrincipal" runat="server">
    <div>

        <div>
            <table width="100%">
                <tr>
                    <td align="center">
                        <table>
                            <tr>
                                <td>
                                            <asp:GridView ID="gvAnimalitos" runat="server"></asp:GridView>
                                </td>
                                <td>
                                            <asp:GridView ID="gvUsuarios" runat="server"></asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        
        

        
        

        <div align="left">
            
        </div>
        <br />

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

        <br />
        <asp:DropDownList ID="ddlUsuarios" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBorrarU" runat="server" Text="Borrar" />
    </div>
</asp:Content>
