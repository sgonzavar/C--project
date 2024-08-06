<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlanesCorporativos.aspx.cs" Inherits="pWebDSI54.ReglasNegocio.PlanesCorporativs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td class="text-center" colspan="2" style="font-size: xx-large">
                <strong>VENTA DE PLANES CORPORATIVOS</strong>
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Tipo de empresa:</strong>
            </td>
            <td>
                <asp:RadioButtonList ID="optTipoCliente" runat="server">
                    <asp:ListItem>GOLD</asp:ListItem>
                    <asp:ListItem>SILVER</asp:ListItem>
                    <asp:ListItem>BRONZE</asp:ListItem>
                    <asp:ListItem Selected="True">REGULAR</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Plan:</strong>
            </td>
            <td>
                <asp:DropDownList ID="cboPlan" runat="server">
                    <asp:ListItem Value="50000">$ 50.000</asp:ListItem>
                    <asp:ListItem Value="75000">$ 75.000</asp:ListItem>
                    <asp:ListItem Value="100000">$ 100.000</asp:ListItem>
                </asp:DropDownList>
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
            <td>
                Minutos del plan
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                Minutos adicionales
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Minutos totales</td>
            <td></td>
        </tr>
    </table>
</asp:Content>
