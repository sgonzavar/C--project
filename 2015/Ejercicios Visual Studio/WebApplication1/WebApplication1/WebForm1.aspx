<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento">
                    <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento">
                    <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento">
                        <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento">
                            <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento"></asp:MenuItem>
                        </asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento"></asp:MenuItem>
                <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento"></asp:MenuItem>
                <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento">
                    <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento"></asp:MenuItem>
                <asp:MenuItem Text="Nuevo elemento" Value="Nuevo elemento"></asp:MenuItem>
            </Items>
        </asp:Menu>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Panel ID="Panel1" runat="server">
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
