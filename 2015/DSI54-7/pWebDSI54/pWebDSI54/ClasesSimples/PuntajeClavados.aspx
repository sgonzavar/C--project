<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PuntajeClavados.aspx.cs" Inherits="pWebDSI54.ClasesSimples.PuntajeClavados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td class="text-center" colspan="2" style="font-size: xx-large">
                <strong>CÁLCULO DE PUNTAJE DE CLAVADOS</strong>
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Puntaje Juez 1:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtPuntajeJuez1" runat="server" Text="0.0" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Puntaje Juez 2:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtPuntajeJuez2" runat="server" Text="0.0" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Puntaje Juez 3:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtPuntajeJuez3" runat="server" Text="0.0" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Grado dificultad:</strong>
            </td>
            <td>
                <asp:TextBox ID="txtGradoDificultad" runat="server" Text="1.0" />
            </td>
        </tr>
        <tr>
            <td style="font-size: large">
                <strong>Ciclo olímpico:</strong>
            </td>
            <td>
                <asp:CheckBox ID="chkCicloOlimpico" runat="server" />
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
                <strong>Puntaje Total:</strong>
            </td>
            <td>
                <asp:Label ID="lblPuntajeTotal" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
