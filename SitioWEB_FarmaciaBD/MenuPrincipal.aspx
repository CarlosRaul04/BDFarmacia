﻿<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="SitioVentasWEB_GUI.MenuPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 14px;
        }
        .auto-style3 {
            font-size: x-large;
            color: #FF5050;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" Runat="Server">
    <p class="auto-style3">
        <strong>MENU PRINCIPAL - GESTION DE ALMACEN</strong></p>
    <p>
        &nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" rowspan="3">
                <asp:Image ID="Image1" runat="server" Height="284px" ImageUrl="~/Images/almacen3.jpg" Width="311px" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Consultas</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Transacciones/Transacciones.aspx">Transacciones</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

