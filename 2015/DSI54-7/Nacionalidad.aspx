<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nacionalidad.aspx.cs" Inherits="pWebDSI54.BaseDatos.Nacionalidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td class="text-center" colspan="2" style="font-size: xx-large">
                <strong>NACIONALIDAD</strong>
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Código:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Nombre:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Activo:</strong>
            </td>
            <td>
                <asp:CheckBox ID="chkActivo" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="INSERTAR" Font-Bold="true" />
            </td>
            <td>
                <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="ACTUALIZAR" Font-Bold="true" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="ELIMINAR" Font-Bold="true" />
            </td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="CONSULTAR" Font-Bold="true" />
            </td>
        </tr>
        <tr>
            <td class="text-right" colspan="2">
                <asp:Label ID="lblError" runat="server" ForeColor="Red" />
            </td>
        </tr>
    </table>
</asp:Content>
