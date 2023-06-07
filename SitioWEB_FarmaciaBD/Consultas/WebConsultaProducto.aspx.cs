using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyWEBFarmacia_BL;
using ProyWEBFarmacia_BE;
using System.Drawing;
using System.Data;

namespace SitioWEB_FarmaciaBD
{
    public partial class WebConsultaProducto : System.Web.UI.Page
    {
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        DataView dtv;

        protected void Page_Load(object sender, EventArgs e)
        {

          
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {

            try
            {
                objProductoBE = objProductoBL.ConsultarProductoWEB(txtCod.Text);

                if (objProductoBE.Des_pro == null)
                {
                    txtDescripcion.Text = String.Empty;
                    txtEstado.Text = String.Empty;
                    txtFechaRegistro.Text = String.Empty;
                    txtPrecio.Text = String.Empty;
                    txtStock.Text = String.Empty;
                    txtTipoProducto.Text = String.Empty;
                    txtUM.Text = String.Empty;

                    throw new Exception("Codigo de producto no existe");
                }
                else
                {
                    txtDescripcion.Text = objProductoBE.Des_pro;
                    txtFechaRegistro.Text = objProductoBE.fec_reg.ToString();
                    txtTipoProducto.Text = objProductoBE.tipoProducto;
                    txtUM.Text= objProductoBE.UnidadMedida;
                    if (objProductoBE.est_pro == 1)
                    {
                        txtEstado.Text = "Activo";
                    }
                    else if (objProductoBE.est_pro == 0)
                    {
                        txtEstado.Text = "Inactivo";
                        txtEstado.ForeColor = Color.Red;
                    }
                    float sngPrecio = objProductoBE.pre_pro;
                    txtPrecio.Text = sngPrecio.ToString("#,###,##0.00");
                    int sngStock = objProductoBE.Stock;
                    txtStock.Text = sngStock.ToString();

                }
            }
            catch (Exception ex)
            {

                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();

            }
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                
                    dtv = new DataView(objProductoBL.ListarProducto());
                    grvProductos.DataSource = dtv;
                    grvProductos.DataBind();
                    lblRegistros.Text = "Cantidad de Productos: " + grvProductos.Rows.Count.ToString();
             
            }
            catch(Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }
    }
}