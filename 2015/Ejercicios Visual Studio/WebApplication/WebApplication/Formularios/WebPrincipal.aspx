<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebPrincipal.aspx.cs" Inherits="WebApplication.Formularios.WebPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TreeView ID="TreeView1" runat="server" ImageSet="Simple">
        <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
        <Nodes>
            <asp:TreeNode Checked="True" Text="Archivo" Value="Archivo">
                <asp:TreeNode NavigateUrl="~/Formularios/WebCliente.aspx" Text="Cliente" Value="Cliente"></asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/Formularios/WebAlmacen.aspx" Text="Producto" Value="Producto"></asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/Formularios/WebUsuario.aspx" Text="Usuario" Value="Usuario"></asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/Formularios/WebProveedor.aspx" Text="Proveedor" Value="Proveedor"></asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="Movimiento" Value="Movimiento">
                <asp:TreeNode NavigateUrl="~/Formularios/WebFactura.aspx" Text="Factura" Value="Factura"></asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/Formularios/WebInformeFactura.aspx" Text="Informe" Value="Informe"></asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="Ayuda" Value="Ayuda">
                <asp:TreeNode NavigateUrl="~/Formularios/WebAyuda.aspx" Text="Ayuda" Value="Ayuda"></asp:TreeNode>
                <asp:TreeNode Text="Razon de Ser" Value="Razon de Ser"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
        <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="0px" NodeSpacing="0px" VerticalPadding="0px" />
        <ParentNodeStyle Font-Bold="False" />
        <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
    </asp:TreeView>
</asp:Content>
