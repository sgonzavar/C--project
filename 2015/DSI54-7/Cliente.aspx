<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="pWebDSI54.BaseDatos.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="4">ADMINISTRACIÓN
                <asp:Label ID="Label1" runat="server" Text="CLIENTES"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2"><b>Id Cliente</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><b>Documento</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtDocumento" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><b>Nombre</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><b>Apellidos</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><b>Dirección</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><b>Telefono</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2"><b>Email</b></td>
            <td colspan="2">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblRespuesta" runat="server"></asp:Label>
            </td>
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
