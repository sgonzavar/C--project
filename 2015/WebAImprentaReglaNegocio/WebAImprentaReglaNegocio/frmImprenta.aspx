<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmImprenta.aspx.cs" Inherits="WebAImprentaReglaNegocio.frmImprenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
            border: 1px solid #000066;
            background-color: #3366FF;
        }
        .auto-style2 {
            width: 540px;
            text-align: right;
        }
        .auto-style3 {
            height: 13px;
            text-align: left;
        }
        .auto-style5 {
            height: 13px;
            width: 540px;
            text-align: right;
        }
        .auto-style6 {
            text-align: right;
        }
        .auto-style7 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" cellpadding="2" cellspacing="1" class="auto-style1">
            <tr>
                <td colspan="2" style="text-align: center; font-size: xx-large">SERVICIO DE IMPRENTA</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Cantidad Hojas :</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtCantidadH" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Tipo Hojas :</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="cmbHojas" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="1000">Lujo</asp:ListItem>
                        <asp:ListItem Value="350">Normal</asp:ListItem>
                        <asp:ListItem Value="50">Reciclado</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Tipo Pasta :</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="cmbPasta" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="10000">Lujo</asp:ListItem>
                        <asp:ListItem Value="5000">Normal</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Tipo Impresion :</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="cmbImpresion" runat="server" AutoPostBack="True">
                        <asp:ListItem Value="500">Color</asp:ListItem>
                        <asp:ListItem Value="150">Blanco y Negro</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" style="text-align: center" Text="Calcular" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="Borrar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Subtotal : </td>
                <td class="auto-style7">
                    <asp:Label ID="lblSubtotal" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Descuento :</td>
                <td class="auto-style7">
                    <asp:Label ID="lblDescuento" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    Total :</td>
                <td class="auto-style7">
                    <asp:Label ID="lblTotal" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
