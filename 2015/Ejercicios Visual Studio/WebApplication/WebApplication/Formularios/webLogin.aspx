<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="webLogin.aspx.cs" Inherits="WebApplication.Formularios.webLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table cellspacing="1" style="width: 80%; border: 2px solid #FFFFFF; background-color: #FFFFFF">
        <tr>
            <td style="width: 500px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="font-size: large; font-family: Calibri; width: 500px"><strong>Usuario :</strong></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="height: 23px; font-size: large; font-family: calibri; width: 500px"><strong>Clave :</strong></td>
            <td style="height: 23px">
                <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-size: large; font-family: calibri; height: 12px; width: 500px">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
            </td>
            <td style="height: 12px">
                <asp:Button ID="btnCancelar" runat="server" style="font-family: calibri; font-size: 14pt" Text="Cancelar" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-size: large; font-family: calibri; height: 12px; width: 500px">
                <asp:Label ID="lblError" runat="server" BackColor="White" BorderColor="Red" ForeColor="Red"></asp:Label>
            </td>
            <td style="height: 12px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
