<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHerencia.aspx.cs" Inherits="WebPractica3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Practica # 3- Herencia Y Polimorfismo </title>
    <style type="text/css">
        .auto-style3 {
            width: 80%;
            border: 4px solid #000000;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            text-align: center;
            font-size: xx-large;
            color: #FF3300;
        }
        .auto-style6 {
            width: 80%;
        }
        .auto-style7 {
            width: 245px;
            text-align: right;
        }
        .auto-style8 {
            width: 80%;
        }
        .auto-style12 {
            text-align: center;
            height: 22px;
        }
        .auto-style15 {
        }
        .auto-style17 {
            width: 243px;
        }
        .auto-style18 {
            width: 243px;
            text-align: right;
        }
        .auto-style19 {
            width: 246px;
        }
        .auto-style21 {
            width: 247px;
            text-align: right;
        }
        .auto-style22 {
            width: 247px;
        }
        .auto-style23 {
            text-align: center;
            height: 130px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="auto-style3">
            <tr>
                <td class="auto-style5"><strong>Cálculos Figura Geométrica.</strong></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:RadioButtonList ID="rblFiguras" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rblFiguras_SelectedIndexChanged" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True" Value="opcCirc">Circulo</asp:ListItem>
                        <asp:ListItem Value="opcTriag">Triángulo</asp:ListItem>
                        <asp:ListItem Value="opcCuad">Cuadrado</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Panel ID="pnlCirculo" runat="server" BackColor="#99FF99" BorderColor="#3366FF">
                        <table align="center" class="auto-style6">
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style7">Radio:</td>
                                <td>
                                    <asp:TextBox ID="txtRadio" runat="server" style="text-align: center" Width="192px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">
                    <asp:Panel ID="pnlTriangulo" runat="server" BackColor="#FFFF66" BorderColor="Red" Visible="False">
                        <table align="center" class="auto-style8">
                            <tr>
                                <td class="auto-style17">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style18">Lado A:</td>
                                <td>
                                    <asp:TextBox ID="txtLadoA" runat="server" style="text-align: center" Width="189px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style18">Lado B:</td>
                                <td>
                                    <asp:TextBox ID="txtLadoB" runat="server" style="text-align: center" Width="188px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style18">Lado C:</td>
                                <td>
                                    <asp:TextBox ID="txtLadoC" runat="server" style="text-align: center" Width="189px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Panel ID="pnlCuadrado" runat="server" BackColor="#00FF99" BorderColor="#33CC33" Visible="False">
                        <table align="center" class="auto-style6">
                            <tr>
                                <td class="auto-style19">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style19" style="text-align: right">Lado:</td>
                                <td>
                                    <asp:TextBox ID="txtLado" runat="server" style="text-align: center" Width="190px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style19">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnCalcular" runat="server" BorderStyle="Outset" Font-Names="Comic Sans MS" Font-Size="Small" Text="Cálcular" Width="197px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Panel ID="pnlRpta" runat="server" BackColor="#3399FF" BorderColor="#993333" Visible="False">
                        <table align="center" class="auto-style6">
                            <tr>
                                <td class="auto-style22" style="text-align: right">Área:</td>
                                <td>
                                    <asp:Label ID="lblArea" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style21">Perímetro:</td>
                                <td>
                                    <asp:Label ID="lblPerim" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style15" colspan="2">
                                    <asp:Button ID="btnLimpiar" runat="server" BorderStyle="Groove" Font-Names="Comic Sans MS" OnClick="btnLimpiar_Click" Text="Limpiar" Width="205px" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblMsj" runat="server" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnTerminar" runat="server" BorderStyle="Dotted" OnClick="btnTerminar_Click" Text="Terminar" Width="199px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
