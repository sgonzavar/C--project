<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webAgencia._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified">
        <tr>
            <td class="text-center" colspan="2" style="font-size: x-large; height: 36px"><strong>AGENCIA DE MODELAJE</strong></td>
        </tr>
        <tr>
            <td style="width: 605px; height: 22px"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td class="text-right" style="width: 605px"><strong>Valor del Servicio:</strong></td>
            <td>
                <asp:TextBox ID="txtValorServicio" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 605px"><strong>Cantidad de Años de la Empresa:</strong></td>
            <td>
                <asp:TextBox ID="txtCantidadAnios" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 605px; height: 22px"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td class="text-right" style="width: 605px; height: 28px">
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" />
            </td>
            <td style="height: 28px">
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" />
            </td>
        </tr>
        <tr>
            <td style="width: 605px">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 605px; height: 22px"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td class="text-right" style="width: 605px; height: 22px"><strong>Valor Antes de Descuento:</strong></td>
            <td style="height: 22px">
                <asp:Label ID="lblValorAntesDescuento" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 605px; height: 22px"><strong>Valor del Descuento:</strong></td>
            <td style="height: 22px">
                <asp:Label ID="lblValorDescuento" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 605px"><strong>Valor a Pagar:</strong></td>
            <td>
                <asp:Label ID="lblValorPagar" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 605px"><strong>Valor del Iva:</strong></td>
            <td>
                <asp:Label ID="lblValorIva" runat="server"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
