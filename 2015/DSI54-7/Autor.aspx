<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Autor.aspx.cs" Inherits="pWEBDesarrollo6_8.BaseDatos.Autor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified">
        <tr>
            <td colspan="2" style="text-align: center; font-size: x-large; font-weight: 700">ADMINISTRACIÓN DE AUTORES</td>
        </tr>
        <tr>
            <td style="font-size: large"><b>Código:</b></td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server" style="font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 22px; font-size: large"><b>Nombre:</b></td>
            <td style="height: 22px">
                <asp:TextBox ID="txtNombre" runat="server" style="font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: large"><b>Apellidos:</b></td>
            <td>
                <asp:TextBox ID="txtApellidos" runat="server" style="font-size: large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: large"><b>Fecha de nacimiento:</b></td>
            <td>
                <asp:TextBox ID="txtFechaNacimiento" runat="server" style="font-size: large" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-size: large"><b>Nacionalidad:</b></td>
            <td>
                <asp:DropDownList ID="cboNacionalidad" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" style="font-size: large; font-style: italic; color: #FF6600"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" style="font-size: x-large" Text="INGRESAR" Width="300px" />
            </td>
            <td class="text-center">
                <asp:Button ID="btnActualizar" runat="server" style="font-size: x-large" Text="ACTUALIZAR" Width="300px" />
            </td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Button ID="btnEliminar" runat="server" style="font-size: x-large" Text="ELIMINAR" Width="300px" />
            </td>
            <td class="text-center">
                <asp:Button ID="btnConsultar" runat="server" style="font-size: x-large" Text="CONSULTAR" Width="300px" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
