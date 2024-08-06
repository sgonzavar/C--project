<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Imprenta.aspx.cs" Inherits="pWebDesarrollo_6_8.Reglas_Negocio.Imprenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td class="text-center" colspan="2" style="font-size: x-large"><strong>IMPRENTA</strong></td>
        </tr>
        <tr>
            <td style="font-size: large"><strong>Número de libros:</strong></td>
            <td><strong>
                <asp:TextBox ID="txtNumeroLibros" runat="server" style="font-size: large"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td class="text-center" colspan="2"><strong>
                <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" style="font-size: x-large" Text="CALCULAR" />
                </strong></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" style="font-size: large"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="font-size: large"><strong>Subtotal:</strong></td>
            <td>
                <asp:Label ID="lblSubtotal" runat="server" style="font-size: large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-size: large"><strong>Descuento:</strong></td>
            <td>
                <asp:Label ID="lblDescuento" runat="server" style="font-size: large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-size: large"><strong>Total a pagar:</strong></td>
            <td>
                <asp:Label ID="lblTotalPagar" runat="server" style="font-size: large"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
