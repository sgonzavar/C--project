<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="pWebDSI54.BaseDatos.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="margin: auto">
        <tr>
            <td class="text-center" colspan="4" style="font-size: xx-large">
                <strong>CLIENTES</strong>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Código:</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtCodigo" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Documento:</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtDocumento" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Nombre:</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtNombre" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Apellidos:</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtApellidos" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Dirección:</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtDireccion" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Telefono:</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtTelefono" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Email:</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtEmail" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="4" class="text-right">
                <asp:Label ID="lblError" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="INSERTAR" Font-Bold="true" Width="150" />
            </td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="CONSULTAR" Font-Bold="true" Width="150" />
            </td>
            <td>
                <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="ACTUALIZAR" Font-Bold="true" Width="150" />
            </td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="ELIMINAR" Font-Bold="true" Width="150" />
            </td>
        </tr>
    </table>
</asp:Content>
