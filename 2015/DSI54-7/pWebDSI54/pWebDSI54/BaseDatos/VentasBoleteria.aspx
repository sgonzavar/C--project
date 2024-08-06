<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VentasBoleteria.aspx.cs" Inherits="pWebDSI54.BaseDatos.VentasBoleteria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="margin: auto">
        <tr>
            <td class="text-center" colspan="4" style="font-size: xx-large">
                <strong>VENTAS BOLETERIA</strong>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Codigo venta</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtCodigoVenta" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Cedula</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtCedula" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Nombre</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtNombre" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Fecha evento</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtFecha" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Lugar evento</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtLugar" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Cantidad de boletas</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtCantidad" runat="server" TextMode="Number" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Valor boleta</strong>
            </td>
            <td colspan="2">
                <asp:TextBox ID="txtValorBoleta" runat="server" TextMode="Number" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: large">
                <strong>Valor total</strong>
            </td>
            <td colspan="2">
                <asp:Label ID="lblValorTotal" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="4" class="text-right">
                <asp:Label ID="lblError" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="CONSULTAR" Font-Bold="true" Width="150" />
            </td>
            <td>
                <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="INSERTAR" Font-Bold="true" Width="150" />
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
