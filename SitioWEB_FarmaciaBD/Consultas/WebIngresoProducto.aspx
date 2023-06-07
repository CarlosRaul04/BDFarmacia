<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebIngresoProducto.aspx.cs" Inherits="SitioWEB_FarmaciaBD.WebConsultaProducto" %>
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
            width: 144px;
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
        .auto-style11 {
            height: 24px;
            width: 135px;
        }
        .auto-style12 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 27px;
            width: 135px;
        }
        .auto-style14 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 27px;
            width: 144px;
        }
        .auto-style16 {
            height: 25px;
        }
        .auto-style17 {
            font-family: Verdana;
            font-size: 10pt;
            color: #993366;
            height: 25px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <p class="tituloForm">
        <br />
        CONSULTA DE INGRESO DE PRODUCTO POR USUARIO ENTRE FECHAS</p>
    <table width="1000px">
        <tr>
            <td class="auto-style9" >Ingrese Usuario:</td>
            <td class="auto-style1" colspan="2">
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="TextBoxDerecha" MaxLength="20" Width="186px"></asp:TextBox>
            &nbsp;
                <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/Images/Buscar.png" OnClick="btnBuscar_Click" CausesValidation="False" Width="16px"  />
            </td>
            <td class="auto-style4">
                </td>
        </tr>
        <tr>
            <td class="auto-style8">Fecha de Ingreso:</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtFecReg" runat="server" CssClass="TextBoxDerecha" Width="214px" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style5">Nivel de Usuario:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtNivel" runat="server" CssClass="TextBoxDerecha" Width="146px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Estado:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtEstado" runat="server" CssClass="TextBoxDerecha" Width="146px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style12">
                </td>
            <td class="auto-style14"></td>
            <td class="auto-style1">
                </td>
        </tr>
            <td colspan="3">
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
                <br />
                <br />
<tr>
            <td class="auto-style3" colspan="4">INGRESE FECHAS DE CONSULTA ( * Obligatorios):</td>
        </tr>
        <tr>
            <td class="auto-style17">Fecha inicio (*):</td>
            <td class="auto-style16">
                <asp:TextBox ID="txtFecIni" runat="server" CssClass="TextBoxDerecha" Width="100px"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="txtFecIni_CalendarExtender" runat="server" BehaviorID="txtFecIni_CalendarExtender" TargetControlID="txtFecIni" />
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFecIni" CssClass="labelErrores" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style17">Fecha fin (*):</td>
            <td class="auto-style16">
                <asp:TextBox ID="txtFecFin" runat="server" CssClass="TextBoxDerecha" Width="100px"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="txtFecFin_CalendarExtender" runat="server" BehaviorID="txtFecFin_CalendarExtender" TargetControlID="txtFecFin" />
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFecFin" CssClass="labelErrores" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style4">
                <asp:Button ID="btnConsultar" runat="server" CssClass="boton2" OnClick="btnConsultar_Click" Text="Consultar" />
            </td>
            <td class="auto-style2">
                </td>
            <td class="auto-style2">
                </td>
        </tr>
        <tr>
            <td colspan="3" class="auto-style1">
                <asp:Label ID="lblRegistros" runat="server" CssClass="labelErrores"></asp:Label>
            </td>
            <td class="auto-style1">
                </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
        
                <asp:GridView ID="grvRegistros" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="1155px" CssClass="auto-style7" ShowHeaderWhenEmpty="True">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="cod_pro" HeaderText="Cod Producto" />
                        <asp:BoundField DataField="fec_reg" DataFormatString="{0:d}" HeaderText="Fec. Registro" />
                        <asp:BoundField DataField="des_pro" HeaderText="Descripcion" />
                        <asp:BoundField DataField="Usu_Registro" HeaderText="Usuario" />
                        <asp:BoundField DataField="est_pro" HeaderText="Estado" />
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

