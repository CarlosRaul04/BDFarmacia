<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebGraficos.aspx.cs" Inherits="SitioWEB_FarmaciaBD.Consultas.WebGraficos" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 99%;
        }
        .auto-style2 {
            height: 304px;
            width: 1241px;
        }
        .auto-style3 {
            width: 1241px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm"> Graficos de facturacion Anual</p>
    <table class="auto-style1">
        <tr>
            <td align="center" class="auto-style3">
                &nbsp;</td>
        </tr>
        <tr>
             <td class="auto-style2" align="center">
                <asp:Chart ID="grafTotales" runat="server" Width="1525px" OnLoad="grafTotales_Load">
                    <series>
                        <asp:Series Name="Series1" ChartArea="ChartArea1">
                        </asp:Series>
                    </series>
                    <chartareas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </chartareas>
                    <Titles>
                        <asp:Title BackColor="224, 224, 224" Font="Microsoft Sans Serif, 8pt, style=Bold" Name="Title1" Text="Ganancia Potencial">
                        </asp:Title>
                    </Titles>
                </asp:Chart>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
            </td>
        </tr>
    </table>
    <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
    <br />

</asp:Content>
