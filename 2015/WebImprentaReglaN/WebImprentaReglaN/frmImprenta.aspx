<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmImprenta.aspx.cs" Inherits="WebImprentaReglaN.frmImprenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 80%; border: 1px solid #428BCA">
        <tr>
            <td colspan="2" style="text-align: center; font-family: 'Comic Sans MS'; font-size: xx-large; font-weight: 700; height: 47px">IMPRENTA</td>
        </tr>
        <tr>
            <td style="text-align: right; font-family: 'Comic Sans MS'; width: 487px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; font-family: 'Comic Sans MS'; width: 487px">Cantidad Hojas :</td>
            <td>
                <asp:TextBox ID="txtCatidad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-family: 'Comic Sans MS'; width: 487px">Tipo De Pasta :&nbsp; </td>
            <td>
                <asp:DropDownList ID="cmbPasta" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="0">Seleccione Valor</asp:ListItem>
                    <asp:ListItem Value="10000">Lujo</asp:ListItem>
                    <asp:ListItem Value="5000">Normal</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-family: 'Comic Sans MS'; width: 487px">Tipo De Papel :</td>
            <td>
                <asp:DropDownList ID="cmbPapel" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="0">Seleccione Valor</asp:ListItem>
                    <asp:ListItem Value="1000">Lujo</asp:ListItem>
                    <asp:ListItem Value="350">Normal</asp:ListItem>
                    <asp:ListItem Value="50">Reciclado</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-family: 'Comic Sans MS'; width: 487px">Tipo De Impresion :</td>
            <td>
                <asp:DropDownList ID="cmbImpresion" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="0">Seleccione Valor</asp:ListItem>
                    <asp:ListItem Value="500">Color</asp:ListItem>
                    <asp:ListItem Value="150">Blanco y Negro</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align: right; font-family: 'Comic Sans MS'; width: 487px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: right; height: 22px; width: 487px">
                <asp:Button ID="btnEjecutar" runat="server" OnClick="btnEjecutar_Click" Text="Ejecutar" />
            </td>
            <td class="text-left" style="height: 22px">
                <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" />
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 487px">
                <asp:Label ID="lblError" runat="server" BackColor="Red" style="text-align: right"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 487px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: 'Comic Sans MS'; width: 487px">Total Bruto :</td>
            <td>
                <asp:Label ID="lblTotalBruto" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="font-family: 'Comic Sans MS'; width: 487px">Total Neto : </td>
            <td>
                <asp:Label ID="lblTotalNeto" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 487px; font-family: 'Comic Sans MS'">Total Descuento :</td>
            <td>
                <asp:Label ID="lblDescuento" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
