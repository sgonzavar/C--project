<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nacionalidad.aspx.cs" Inherits="pWebDesarrollo_6_8.BaseDatos.Nacionalidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td colspan="2" style="text-align: center; font-size: xx-large; font-weight: 1000">NACIONALIDAD</td>
        </tr>
        <tr>
            <td style="font-size: large"><b>Código:</b></td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server" style="font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: large"><b>Nombre:</b></td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" style="font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: large"><b>Activo:</b></td>
            <td>
                <asp:CheckBox ID="chkActivo" runat="server" style="font-size: large" />
            </td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Button ID="btnGrabar" runat="server" OnClick="btnGrabar_Click" style="font-size: xx-large" Text="GRABAR" />
            </td>
            <td class="text-center">
                <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" style="font-size: xx-large" Text="ACTUALIZAR" />
            </td>
        </tr>
        <tr>
            <td class="text-center" dir="ltr">
                <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" style="font-size: xx-large" Text="BORRAR" />
            </td>
            <td class="text-center">
                <asp:Button ID="btnConsultar" runat="server" style="font-size: xx-large" Text="CONSULTAR" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" style="font-style: italic; color: #FF3300"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        </table>
</asp:Content>
