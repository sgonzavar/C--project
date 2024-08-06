<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="pDesarrollo8_10.BaseDatos.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="4">ADMINISTRACIÓN
                <asp:Label ID="Label1" runat="server" Text="CLIENTES"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Id Cliente</td>
            <td colspan="2">
                <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Documento</td>
            <td colspan="2">
                <asp:TextBox ID="txtDocumento" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Nombre</td>
            <td colspan="2">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Apellidos</td>
            <td colspan="2">
                <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Dirección</td>
            <td colspan="2">
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Telefono</td>
            <td colspan="2">
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Email</td>
            <td colspan="2">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblRespuesta" runat="server"></asp:Label>
            </td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" Text="GRABAR" />
            </td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="CONSULTAR" />
            </td>
            <td>
                <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="ACTUALIZAR" />
            </td>
            <td>
                <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="BORRAR" />
            </td>
        </tr>
    </table>
</asp:Content>
