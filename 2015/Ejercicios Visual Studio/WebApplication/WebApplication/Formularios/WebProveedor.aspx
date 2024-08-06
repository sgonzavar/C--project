<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebProveedor.aspx.cs" Inherits="WebApplication.Formularios.WebProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table cellspacing="1" style="width: 80%; border: 2px solid #ffffff; background-color: #ffffff">
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; width: 500px"><strong></strong></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; width: 500px"><strong>Cedula :</strong></td>
            <td>
                <asp:TextBox ID="txtCedula" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; width: 500px"><strong>Nombre :</strong></td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; width: 500px"><strong>Apellido :</strong></td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; width: 500px"><strong>Telefono :</strong></td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; width: 500px"><strong>Correo : </strong></td>
            <td>
                <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; width: 500px">&nbsp;</td>
            <td>
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; width: 500px"><strong>
                <asp:Button ID="btnAgregar" runat="server" Font-Bold="True" Text="AGREGAR" />
                </strong></td>
            <td style="font-family: Calibri; font-size: medium">
                <asp:Button ID="btnEliminar" runat="server" Font-Bold="True" Text="ELIMINAR" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; width: 500px">
                <asp:Button ID="btnActualizar" runat="server" Font-Bold="True" Text="ACTUALIZAR" />
            </td>
            <td style="font-family: Calibri; font-size: medium">
                <asp:Button ID="btnConsultar" runat="server" Font-Bold="True" Text="CONSULTAR" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; width: 500px"><strong></strong>
                <asp:Label ID="lblSQl" runat="server" ForeColor="#0099FF"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: Calibri; font-size: medium; " colspan="2">
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
            <td class="text-right" style="font-family: Calibri; font-size: medium; ">&nbsp;</td>
            <td class="text-left" style="font-family: Calibri; font-size: medium; ">
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
            </td>
        </tr>
    </table>
</asp:Content>
