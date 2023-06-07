<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="SitioWEB_FarmaciaBD.Consultas.Consultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 49px;
        }
        .auto-style3 {
            width: 179px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" Runat="Server">
    <table >
           <p class="tituloForm">CONSULTAS DE TABLAS MAESTRAS </p> 
        <tr>
            <td class="auto-style3">
                <asp:Image ID="Image1" runat="server" Height="285px" 
                    ImageUrl="~/Images/Consultas.jpg" Width="248px" />
            </td>
            <td class="auto-style1">
                 
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList" ShowExpandCollapse="False">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                    <Nodes>
                        <asp:TreeNode Text="Consulta de Tablas" Value="Consulta de Tablas">
                            <asp:TreeNode NavigateUrl="~/Consultas/WebSalidasEmpleado.aspx" Text="Empleados" Value="Empleados"></asp:TreeNode>
                            <asp:TreeNode NavigateUrl="~/Consultas/WebIngresoProducto.aspx" Text="Productos" Value="Productos"></asp:TreeNode>
                            <asp:TreeNode NavigateUrl="~/Consultas/WebGraficos.aspx" Text="PagoPotencial" Value="PagoPotencial"></asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
                </asp:TreeView>
                 
            </td>
        </tr>
    </table>


</asp:Content>
