<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Imprenta.aspx.cs" Inherits="pWebDSI54.ReglasNegocio.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td class="text-center" colspan="2" style="font-size: xx-large">
                <strong>IMPRENTA</strong>
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Cantidad de libros:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtCantidadLibros" runat="server" Text="0" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="CALCULAR" Font-Bold="True" />
            </td>
        </tr>
        <tr>
            <td class="text-right" colspan="2">
                <asp:Label ID="lblError" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Sutotal:</strong>
            </td>
            <td>
                <asp:Label ID="lblSubtotal" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Descuento:</strong>
            </td>
            <td>
                <asp:Label ID="lblDescuento" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Total:</strong>
            </td>
            <td>
                <asp:Label ID="lblTotal" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
