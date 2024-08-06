<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmImprenta.aspx.cs" Inherits="WebImprentaRN.frmImprenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 80%;
            border: 2px solid #0099ff;
            background-color: #0099FF;
        }
        .auto-style3 {
            font-size: xx-large;
            text-align: center;
        }
        .auto-style4 {
            text-align: right;
            width: 449px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <table cellspacing="1" class="auto-style2">
        <tr>
            <td class="auto-style3" colspan="2">IMPRENTA</td>
        </tr>
        <tr>
            <td class="auto-style4">Cantidad Hojas :</td>
            <td>
                <asp:TextBox ID="txtCantidad" runat="server" Width="179px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Tipo De Pasta :</td>
            <td>
                <asp:DropDownList ID="cmbPasta" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="0">Seleccione Valor.</asp:ListItem>
                    <asp:ListItem Value="10000">Lujo</asp:ListItem>
                    <asp:ListItem Value="5000">Normal</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Tipo De Papel:</td>
            <td>
                <asp:DropDownList ID="cmbPapel" runat="server" AutoPostBack="True">
                    <asp:ListItem>Seleccione Valor.</asp:ListItem>
                    <asp:ListItem Value="1000">Lujo</asp:ListItem>
                    <asp:ListItem Value="350">Normal</asp:ListItem>
                    <asp:ListItem Value="50">Reciclado</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Tipo De Imprecion:</td>
            <td>
                <asp:DropDownList ID="cmbImpresion" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="0">Seleccione Valor.</asp:ListItem>
                    <asp:ListItem Value="500">Color</asp:ListItem>
                    <asp:ListItem Value="150">Blanco y Negro</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" Width="76px" />
            </td>
            <td>
                <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Subtotal :</td>
            <td>
                <asp:Label ID="lblSubtotal" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Descuento :</td>
            <td>
                <asp:Label ID="lblDescuento" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Total :</td>
            <td>
                <asp:Label ID="lblTotal" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
