<%@ Page Title="" Language="C#" MasterPageFile="~/MasterOfPages.Master" AutoEventWireup="true" CodeBehind="Ajustes.aspx.cs" Inherits="Animalitos.Paginas.Ajustes" %>
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
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_OnClick" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
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
