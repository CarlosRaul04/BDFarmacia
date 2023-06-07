<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="Transacciones.aspx.cs" Inherits="SitioWEB_FarmaciaBD.Transacciones.Transacciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 48px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <table >
        <p class="tituloForm">TRANSACCIONES DEL SISTEMA </p>
        <tr>
            <td width ="180px">
                <asp:Image ID="Image1" runat="server" Height="285px" 
                    ImageUrl="~/Images/Transacciones.jpg" Width="248px" />
            </td>
            <td class="auto-style1">
                
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="BulletedList" ShowExpandCollapse="False">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                    <Nodes>
                        <asp:TreeNode Text="Transacciones del sistema" Value="Transacciones del sistema">
                            <asp:TreeNode NavigateUrl="~/Transacciones/RegistrarSalida.aspx" Text="Registar Salida" Value="Registar Salida"></asp:TreeNode>
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
