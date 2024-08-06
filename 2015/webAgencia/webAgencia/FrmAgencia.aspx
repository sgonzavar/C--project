<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmAgencia.aspx.cs" Inherits="webAgencia.FrmAgencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 80%">
        <tr>
            <td class="text-center" colspan="2">AGENCIA DE MODELAJE</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right">Valor de Servicio:</td>
            <td>
                <asp:TextBox ID="txtServicio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right">Cantidad Años:</td>
            <td>
                <asp:TextBox ID="txtCantidadA" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right">
                <asp:Button ID="btnCal" runat="server" OnClick="btnCal_Click" Text="Calcular" />
            </td>
            <td>
                <asp:Button ID="btnLim" runat="server" OnClick="btnLim_Click" Text="Limpiar" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right">Valor Antes Descuento:</td>
            <td>
                <asp:Label ID="lblVAntesDescuento" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right">Valor Descuento:</td>
            <td>
                <asp:Label ID="lblDescuento" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right">Valor Iva:</td>
            <td>
                <asp:Label ID="lblIva" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right">Valor Pagar:</td>
            <td>
                <asp:Label ID="lblPagar" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
