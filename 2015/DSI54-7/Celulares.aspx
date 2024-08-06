<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Celulares.aspx.cs" Inherits="pDesarrollo_6_8.ReglasNegocio.Celulares" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td class="text-center" colspan="2" style="font-size: xx-large"><strong>VENTA DE PLANES CORPORATIVOS</strong></td>
        </tr>
        <tr>
            <td style="font-size: x-large"><strong>TIPO DE EMPRESA:</strong></td>
            <td>
                <asp:DropDownList ID="cboTipoEmpresa" runat="server" style="font-size: x-large">
                    <asp:ListItem>GOLD</asp:ListItem>
                    <asp:ListItem>PLATA</asp:ListItem>
                    <asp:ListItem>BRONCE</asp:ListItem>
                    <asp:ListItem Value="NO_ESPECIAL">NINGUNO</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="font-size: x-large"><strong>PLAN:</strong></td>
            <td>
                <asp:DropDownList ID="cboPlan" runat="server" style="font-size: x-large">
                    <asp:ListItem Value="50000">$ 50.000</asp:ListItem>
                    <asp:ListItem Value="75000">$ 75.000</asp:ListItem>
                    <asp:ListItem Value="100000">$ 100.000</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="2" style="height: 40px">
                <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" style="font-size: xx-large" Text="CALCULAR" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" style="font-size: x-large"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="font-size: x-large"><strong>Minutos del plan:</strong></td>
            <td>
                <asp:Label ID="lblMinutosPlan" runat="server" style="font-size: x-large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-size: x-large"><strong>Porcentaje incremento:</strong></td>
            <td>
                <asp:Label ID="lblPorcentajeIncremento" runat="server" style="font-size: x-large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-size: x-large"><strong>Minutos adicionales:</strong></td>
            <td>
                <asp:Label ID="lblMinutosAdicionales" runat="server" style="font-size: x-large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-size: x-large"><strong>Total Minutos:</strong></td>
            <td>
                <asp:Label ID="lblTotalMinutos" runat="server" style="font-size: x-large"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
