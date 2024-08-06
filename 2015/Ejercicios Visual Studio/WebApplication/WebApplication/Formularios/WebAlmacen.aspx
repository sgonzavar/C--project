<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebAlmacen.aspx.cs" Inherits="WebApplication.Formularios.WebAlmacen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table cellspacing="1" style="width: 80%; border: 2px solid #ffffff; background-color: #ffffff">
        <tr>
            <td class="text-right" style="font-family: Calibri; width: 500px;">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; width: 500px;"><strong>ID Producto :</strong></td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; width: 500px;"><strong>Nombre Producto :</strong></td>
            <td>
                <asp:TextBox ID="txtNombreP" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; width: 500px;"><strong>Tipo :</strong></td>
            <td>
                <asp:DropDownList ID="cmbTipo" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; width: 500px;"><strong>Precio :</strong></td>
            <td>
                <asp:TextBox ID="txtPrecio" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; width: 500px;"><strong>Nota :</strong></td>
            <td>
                <asp:TextBox ID="txtNota" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; width: 500px;">&nbsp;</td>
            <td>
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; width: 500px;">
                <asp:Button ID="btnAgregar" runat="server" Font-Bold="True" style="font-size: medium" Text="AGREGAR" />
            </td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" Font-Bold="True" style="font-family: Calibri; font-size: medium" Text="ELIMINAR" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; width: 500px;">
                <asp:Button ID="Button3" runat="server" Font-Bold="True" style="font-size: medium" Text="ACTUALIZAR" />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" Font-Bold="True" style="font-size: medium; font-family: Calibri" Text="CONSULTAR" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; width: 500px;">
                <asp:Label ID="lblSQL" runat="server" ForeColor="#3399FF"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; height: 23px; " colspan="2">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; height: 23px; ">&nbsp;</td>
            <td class="text-left" style="font-family: Calibri; height: 23px; ">
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
            </td>
        </tr>
    </table>
</asp:Content>
