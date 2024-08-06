<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmLiga.aspx.cs" Inherits="WebParcial.FrmLiga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" style="width: 80%; border-color: #000000; background-color: #CCFFCC">
        <tr>
            <td colspan="2" style="font-size: xx-large; text-align: center; font-weight: 700; font-family: Tahoma">Liga Natacion</td>
        </tr>
        <tr>
            <td style="text-align: right; width: 348px">Juez 1:</td>
            <td>
                <asp:TextBox ID="txtj1" runat="server" CssClass="col-md-offset-0"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 348px">Juez 2:</td>
            <td>
                <asp:TextBox ID="txtj2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 348px">Juez 3:</td>
            <td>
                <asp:TextBox ID="txtj3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 348px">Grado Dificultad :</td>
            <td>
                <asp:TextBox ID="txtGradoDificultad" runat="server"></asp:TextBox>
                <asp:CheckBox ID="chkEventoOlimpico" runat="server" Text="Evento Olimpico" />
            </td>
        </tr>
        <tr>
            <td style="width: 348px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 348px">
                <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
            </td>
            <td class="text-left">
                <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" />
            </td>
        </tr>
        <tr>
            <td style="width: 348px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 348px">Resultado :</td>
            <td class="text-left">
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 348px">
                <asp:Label ID="lblError" runat="server" BackColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 348px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
