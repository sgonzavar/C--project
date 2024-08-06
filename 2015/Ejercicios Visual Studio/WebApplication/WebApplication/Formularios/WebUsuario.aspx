<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebUsuario.aspx.cs" Inherits="WebApplication.Formularios.WebUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table cellspacing="1" style="width: 80%; border: 2px solid #FFFFFF; background-color: #FFFFFF">
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;">&nbsp;</td>
            <td class="text-left">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;"><strong>ID Usuario :</strong></td>
            <td class="text-left">
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;"><strong>Nombre :</strong></td>
            <td class="text-left">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;"><strong>Telefono :</strong></td>
            <td class="text-left">
                <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;"><strong>Cargo :</strong></td>
            <td class="text-left">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Administrador</asp:ListItem>
                    <asp:ListItem>Operario</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;"><strong>Correo :</strong></td>
            <td class="text-left">
                <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;"><strong>Clave :</strong></td>
            <td class="text-left">
                <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;"><strong>Confirmar Clave :</strong></td>
            <td class="text-left">
                <asp:TextBox ID="txtConfirmacion" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;">
                <asp:Label ID="lblCabeza" runat="server" ForeColor="#0099FF"></asp:Label>
            </td>
            <td class="text-left">
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;"><strong>
                <asp:Button ID="btnAgregar" runat="server" style="font-size: 14pt" Text="AGREGAR" />
                </strong></td>
            <td class="text-left"><strong>
                <asp:Button ID="btnEliminar" runat="server" style="font-family: CALIbri; font-size: 14pt" Text="ELIMINAR" />
                </strong></td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;">
                <asp:Button ID="btnActualizar" runat="server" style="font-size: 14pt" Text="ACTUALIZAR" />
            </td>
            <td class="text-left">
                <asp:Button ID="btnConsulta" runat="server" style="font-size: 14pt; font-family: CALIbri" Text="CONSULTAR" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: calibri; width: 500px;">
                <asp:Label ID="lblSql" runat="server" ForeColor="#0099FF"></asp:Label>
            </td>
            <td class="text-left">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-center" style="font-family: calibri; height: 23px; " colspan="2">
                <asp:GridView ID="grvUsuario" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <td class="text-center" style="font-family: calibri; height: 23px">&nbsp;</td>
            <td class="text-left" style="font-family: calibri; height: 23px">
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
            </td>
        </tr>
    </table>
</asp:Content>
