<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebCliente.aspx.cs" Inherits="WebApplication.Formularios.WebCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table cellspacing="1" style="width: 80%; border: 2px solid #ffffff; background-color: #ffffff">
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px"><strong>Cedula :</strong></td>
        <td>
            <asp:TextBox ID="txtCedula" runat="server" TextMode="Number"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px"><strong>Nombre : </strong></td>
        <td>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px"><strong>Apellidos :</strong></td>
        <td>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px"><strong>Telefono :</strong></td>
        <td>
            <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px"><strong>Direccion :</strong></td>
        <td>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px"><strong>Correo :</strong></td>
        <td>
            <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px"><strong>Tipo Id :</strong></td>
        <td>
            <asp:DropDownList ID="cmbTipoId" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px; height: 18px;"><strong>Cuidad :</strong></td>
        <td style="height: 18px">
            <asp:DropDownList ID="cmbCuidad" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px">
            <asp:Label ID="lblSql" runat="server" ForeColor="#0099FF"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px">
            <strong>
            <asp:Button ID="btnAgregar" runat="server" Text="AGREGAR" style="font-family: Calibri; font-size: medium; font-weight: bold" OnClick="btnAgregar_Click" />
            </strong>
        </td>
        <td>
            <strong>
            <asp:Button ID="btneliminar" runat="server" Text="ELIMINAR" style="font-family: CALIbri; font-size: medium; font-weight: bold" OnClick="btneliminar_Click" />
            </strong>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; width: 501px">
            <strong>
            <asp:Button ID="btnActualizar" runat="server" Text="ACTUALIZAR" style="font-size: medium; font-weight: bold" OnClick="btnActualizar_Click" />
            </strong>
        </td>
        <td>
            <strong>
            <asp:Button ID="btnConsultar" runat="server" Text="CONSULTAR" style="font-family: Calibri; font-size: medium; font-weight: bold" OnClick="btnConsultar_Click" />
            </strong>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="font-family: Calibri; font-size: medium; " colspan="2"><strong></strong>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-left: 0px">
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
        <td class="text-right" style="width: 501px">
            <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
        </td>
        <td></td>
    </tr>
</table>
</asp:Content>
