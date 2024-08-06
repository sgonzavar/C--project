<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MantenimientoMotos.aspx.cs" Inherits="pWEBDesarrollo_6_8.ClasesBasicas.MantenimientoMotos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td colspan="2" style="font-size: xx-large; text-align: center"><strong>CÁLCULO DEL MANTENIMIENTO DE MOTOS</strong></td>
        </tr>
        <tr>
            <td style="font-size: x-large"><b>Mano de obra:</b></td>
            <td>
                <asp:TextBox ID="txtManoObra" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: x-large"><b>Repuestos:</b></td>
            <td>
                <asp:TextBox ID="txtRepuestos" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: x-large; height: 36px; text-align: center">
                <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="CALCULAR" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="font-size: x-large">
                <asp:Label ID="lblError" runat="server" style="font-size: x-large; font-style: italic; color: #FF3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-size: x-large"><b>Subtotal:</b></td>
            <td>
                <asp:Label ID="lblSubtotal" runat="server" style="font-size: x-large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-size: x-large"><b>IVA:</b></td>
            <td>
                <asp:Label ID="lblIVA" runat="server" style="font-size: x-large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-size: x-large"><b>Total:</b></td>
            <td>
                <asp:Label ID="lblTotal" runat="server" style="font-size: x-large"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
