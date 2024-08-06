<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mantenimiento.aspx.cs" Inherits="pWebDSI54.ClasesSimples.Mantenimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td class="text-center" colspan="2" style="font-size: xx-large">
                <strong>CÁLCULO DEL MANTENIMIENTO</strong>
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Mano de obra:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtManoObra" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Repuestos:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtRepuestos" runat="server" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="CALCULAR" Font-Bold="true" />
            </td>
        </tr>
        <tr>
            <td class="text-right" colspan="2">
                <asp:Label ID="lblError" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Subtotal:</strong>
            </td>
            <td>
                <asp:Label ID="lblSubtotal" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>IVA:</strong>
            </td>
            <td>
                <asp:Label ID="lblIVA" runat="server" />
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
