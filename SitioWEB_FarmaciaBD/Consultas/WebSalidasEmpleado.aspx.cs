using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyWEBFarmacia_BE;
using ProyWEBFarmacia_BL;

namespace SitioWEB_FarmaciaBD
{
    public partial class WebSalidasEmpleado : System.Web.UI.Page
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        SalidaProductoBL objSalidaProducto = new SalidaProductoBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack==false)
            {
                btnConsultar.Enabled = false;
            }
        }

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                objEmpleadoBE = objEmpleadoBL.ConsultarEmpleadoWEB(txtCod.Text);


                if (objEmpleadoBE.Nom_emp == null)
                {
                    txtNombre.Text = String.Empty;
                    txtApellido.Text = String.Empty;
                    txtDireccion.Text = String.Empty;
                    txtCelular.Text = String.Empty;
                    txtDNI.Text = String.Empty;
                    txtEstado.Text = String.Empty;
                    txtUbicacion.Text = String.Empty;
                    
                    lblRegistros.Text = String.Empty;
                    btnConsultar.Enabled = false;

                    throw new Exception("Codigo de empleado no existe");
                }
                else
                {
                    txtNombre.Text = objEmpleadoBE.Nom_emp;
                    txtApellido.Text = objEmpleadoBE.ape_emp;
                    txtDireccion.Text = objEmpleadoBE.direccion;
                    txtCelular.Text = objEmpleadoBE.celular;
                    txtDNI.Text = objEmpleadoBE.dni_emp;
                    txtUbicacion.Text = objEmpleadoBE.Departamento + " - " + objEmpleadoBE.Provincia + " - " + objEmpleadoBE.Distrito;
                    if (objEmpleadoBE.Est_emp == 1)
                    {
                        txtEstado.Text = "Activo";
                    }
                    else if (objEmpleadoBE.Est_emp == 0)
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
                grvSalidas.DataSource = objSalidaProducto.ListarSalidasEmpleadoFechas(txtCod.Text, Convert.ToDateTime(txtFecIni.Text), Convert.ToDateTime(txtFecFin.Text));
                grvSalidas.DataBind();
                lblRegistros.Text = "Cantidad de salidas: " + grvSalidas.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                lblMensajePopup.Text = "Error: " + ex.Message;
                PopMensaje.Show();
            }
        }
    }
}