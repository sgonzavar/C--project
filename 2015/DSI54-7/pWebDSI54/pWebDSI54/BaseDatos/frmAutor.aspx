<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAutor.aspx.cs" Inherits="pWebDSI54.BaseDatos.frmAutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" style="width: 80%">
        <tr>
            <td class="text-center" colspan="2" style="font-size: xx-large"><strong>ADMINISTRACION DE AUTORES</strong></td>
        </tr>
        <tr>
            <td class="text-right">CODIGO :</td>
            <td class="text-left">
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right">NOMBRE :</td>
            <td class="text-left">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right">APELLIDO :</td>
            <td class="text-left">
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right">FECHA NACIMIENTO :</td>
            <td class="text-left">
                <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right">NACIONALIDAD :</td>
            <td class="text-left">
                <asp:DropDownList ID="cmbNacionalidad" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="text-center">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </td>
            <td class="text-center">
                <asp:Label ID="lblCorrecto" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right">&nbsp;</td>
            <td class="text-left">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right">
                <asp:Button ID="btnActualizar" runat="server" Text="ACTUALIZA" OnClick="btnActualizar_Click1" />
            </td>
            <td class="text-left">
                <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="INGRESAR" />
            </td>
        </tr>
        <tr>
            <td class="text-right">
                <asp:Button ID="btnEliminar" runat="server" Text="ELIMINAR" OnClick="btnEliminar_Click1" />
            </td>
            <td class="text-left">
                <asp:Button ID="btnConsultar" runat="server" Text="CONSULTAR" OnClick="btnConsultar_Click" />
            </td>
        </tr>
        <tr>
            <td class="text-right">&nbsp;</td>
            <td class="text-left">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" colspan="2">
                <asp:GridView ID="grvAutor" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
