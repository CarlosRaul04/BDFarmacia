<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebConsultaProducto.aspx.cs" Inherits="SitioWEB_FarmaciaBD.WebConsultaProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 27px;
        }
        .auto-style4 {
            text-align: center;
            height: 27px;
        }
        .auto-style5 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 24px;
        }
        .auto-style6 {
            height: 24px;
        }
        .auto-style7 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            width: 175px;
        }
        .auto-style8 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 24px;
            width: 175px;
        }
        .auto-style9 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 27px;
            width: 175px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">
        <br />
        CONSULTA DE PRODUCTO</p>
    <table width="1000px">
        <tr>
            <td class="auto-style7" >Ingrese Producto:</td>
            <td width="150px" class="auto-style5">
                <asp:TextBox ID="txtCod" runat="server" CssClass="TextBoxDerecha" MaxLength="4" Width="70px"></asp:TextBox>
            &nbsp;
                <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/Images/Buscar.png" OnClick="btnBuscar_Click" CausesValidation="False" Width="16px"  />
            </td>
            <td class="auto-style4">
                </td>
            <td class="auto-style4">
                </td>
        </tr>
        <tr>
            <td class="auto-style8">Descripcion: </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="TextBoxDerecha" Width="300px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style5">Precio:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="TextBoxDerecha" Width="120px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">Tipo de Producto:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtTipoProducto" runat="server" CssClass="TextBoxDerecha" Width="300px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style5">Stock:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtStock" runat="server" CssClass="TextBoxDerecha" Width="300px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Unidad de Medida:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtUM" runat="server" CssClass="TextBoxDerecha" Width="120px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style1">Estado:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtEstado" runat="server" CssClass="TextBoxDerecha" Width="120px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Fecha de Registro:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtFechaRegistro" runat="server" CssClass="TextBoxDerecha" Width="218px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style1"></td>
            <td class="auto-style1"></td>
        </tr>
            <td colspan="3">
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
                <br />
                <br />
                <asp:Button ID="btnListar" runat="server" CssClass="boton2" OnClick="btnListar_Click" Text="Ver todos los productos" />
        
                <br />
        
                <asp:GridView ID="grvProductos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="1155px" CssClass="GriedView" ShowHeaderWhenEmpty="True" PageSize="15">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="cod_pro" HeaderText="Cod Producto" />
                        <asp:BoundField DataField="des_pro" DataFormatString="{0:d}" HeaderText="Descripción" />
                        <asp:BoundField DataField="TipoProducto" HeaderText="TipoProducto" />
                        <asp:BoundField DataField="pre_pro" HeaderText="Precio" />
                        <asp:BoundField DataField="stock" HeaderText="Stock" />
                        <asp:BoundField DataField="UnidadMedida" HeaderText="UnidadMedida" />
                        <asp:BoundField DataField="est_pro" HeaderText="Estado" SortExpression="Estado" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
    <br />
                <asp:Label ID="lblRegistros" runat="server" CssClass="labelErrores"></asp:Label>
            <br />
    <br />

        
           <%--Este es el modal popup  que contiene los mensajes --%>
                <%--1 Control target (cualquier control)--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
                 <%--2 el panel que se mostrara en el popup--%>
              <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"> 
                    <table border="0" width="500px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                        color: #FFFFFF;"> 
                        <tr> 
                            <td align="center"> 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                            </td> 
                            <td width="12%" class="center"> 
                                <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                    ImageAlign="Right" /> 
                            </td> 
                        </tr> 
                         
                    </table>
                  <div>
                      <br />
                  </div>
                    <div> 
                        <asp:Label ID="lblMensajePopup" runat="server" CssClass="labelTitulo"  /> 
                    </div> 
                  <div>
                       <br />
                  </div>
                    <div> 
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CausesValidation="False" CssClass="boton-new" /> 
                    </div> 
                   <div>
                       <br />
                  </div>
                </asp:Panel> 
         <%--3 el Modal popup que hace referencia al control target  (1) y al panel (2)--%>
                <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion"  OkControlID="btnAceptar" />

</asp:Content>

