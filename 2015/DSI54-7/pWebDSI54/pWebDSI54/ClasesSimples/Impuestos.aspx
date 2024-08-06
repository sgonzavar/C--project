<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Impuestos.aspx.cs" Inherits="pWebDSI54.ClasesSimples.Impuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td class="text-center" colspan="2" style="font-size: xx-large">
                <strong>CÁLCULO DE PAGO DE IMPUESTOS</strong>
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Ingresos anuales:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtIngresosAnuales" runat="server" Text="0" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Retención fuente:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtRetencionFuente" runat="server" Text="-1" />
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
                <strong>Valor impuesto:</strong>
            </td>
            <td>
                <asp:Label ID="lblValorImpuesto" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTituloPagar" runat="server" Font-Bold="True" Font-Size="Large" />
            </td>
            <td>
                <asp:Label ID="lblValorPagar" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
