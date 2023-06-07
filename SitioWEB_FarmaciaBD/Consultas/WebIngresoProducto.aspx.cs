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
        UsuarioBL objUsuarioBL = new UsuarioBL();
        UsuarioBE objUsuarioBE = new UsuarioBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                btnConsultar.Enabled = false;
            }
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {

            try
            {
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtUsuario.Text);


                if (objUsuarioBE.Pass_Usuario == null)
                {
                    txtEstado.Text = String.Empty;
                    txtFecReg.Text = String.Empty;
                    txtNivel.Text = String.Empty;
                    txtUsuario.Text = String.Empty;

                    lblRegistros.Text = String.Empty;
                    btnConsultar.Enabled = false;

                    throw new Exception("Nombre de Usuario no existe");
                }
                else
                {           
                    txtFecReg.Text = Convert.ToDateTime(objUsuarioBE.Fec_Registro).ToString();
                    txtNivel.Text = Convert.ToInt16(objUsuarioBE.Niv_Usuario).ToString();
                    
                    if (objUsuarioBE.Niv_Usuario == 1)
                    {
                        txtNivel.Text = "Administrador";
                    }
                    else if (objUsuarioBE.Niv_Usuario == 2)
                    {
                        txtNivel.Text = "Supervisor";
                    }
                    else if (objUsuarioBE.Niv_Usuario == 3)
                    {
                        txtNivel.Text = "General";
                    }


                    txtEstado.Text = Convert.ToInt16(objUsuarioBE.Est_Usuario).ToString();
                    
                    if (objUsuarioBE.Est_Usuario == 1)
                    {
                        txtEstado.Text = "Activo";
                    }
                    else if (objUsuarioBE.Est_Usuario == 0)
                    {
                        txtEstado.Text = "Inactivo";
                        txtEstado.ForeColor = Color.Red;
                    }

                    btnConsultar.Enabled = true;
                    lblRegistros.Text = String.Empty;


                }
            }
            catch (Exception ex)
            {

                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();

            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grvRegistros.DataSource = objProductoBL.ListarIngresoProductoFechas(txtUsuario.Text, Convert.ToDateTime(txtFecIni.Text), Convert.ToDateTime(txtFecFin.Text));
                grvRegistros.DataBind();
                lblRegistros.Text = "Cantidad de registros: " + grvRegistros.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }
    }
}