<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Impuestos.aspx.cs" Inherits="pDesarrollo_6_8.ClasesBasicas.Impuestos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 85%">
        <tr>
            <td colspan="2" style="text-align: center; font-weight: 700">CÁLCULO DE PAGO DE IMPUESTOS</td>
        </tr>
        <tr>
            <td><b>INGRESOS ANUALES:</b></td>
            <td>
                <asp:TextBox ID="txtIngresosAnuales" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><b>RETENCIÓN EN LA FUENTE:</b></td>
            <td>
                <asp:TextBox ID="txtRetencion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Button ID="btnCalcularImpuestos" runat="server" Height="29px" Text="CALCULAR IMPUESTOS" Width="169px" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" style="font-style: italic; color: #FF3300"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><b>VALOR IMPUESTO:</b></td>
            <td>
                <asp:Label ID="lblValorImpuesto" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td><b>
                <asp:Label ID="lblTituloPagar" runat="server" Text="VALOR A PAGAR:"></asp:Label>
                </b></td>
            <td>
                <asp:Label ID="lblValorPagar" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
