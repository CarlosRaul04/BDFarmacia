using ProyWEBFarmacia_BE;
using ProyWEBFarmacia_BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWEB_FarmaciaBD.Transacciones
{
    public partial class RegistrarSalida : System.Web.UI.Page
    {
        DataTable mitb;
        DataColumn Ccodigo;
        DataColumn Cdescripcion;
        DataColumn Ccantidad;
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        ProductoBL objProductoBL = new ProductoBL();

        private void CrearTabla()
        {
            mitb = new DataTable("TBCompras");
            //Creando las columnas para la tabla temporal de  detalle de compra
            //Columna Codigo
            Ccodigo = new DataColumn("cod_pro");
            Ccodigo.DataType = Type.GetType("System.String");
            mitb.Columns.Add(Ccodigo);
            //Columna Descripcion
            Cdescripcion = new DataColumn("des_pro");
            Cdescripcion.DataType = Type.GetType("System.String");
            mitb.Columns.Add(Cdescripcion);
            //Columna Cantidad
            Ccantidad = new DataColumn("cantidad");
            Ccantidad.DataType = Type.GetType("System.Int16");
            mitb.Columns.Add(Ccantidad);
            //definimos la PK
            mitb.PrimaryKey = new DataColumn[] { mitb.Columns["cod_pro"] };
            grDetalles.DataSource = mitb;
            grDetalles.DataBind();
            Session["Detalles"] = mitb;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    // Para el manejo de la fecha con formato dd-MM-yyyy
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-PE");
                    //Mostramos la fecha por defecto
                    txtFecSal.Text = DateTime.Now.Date.ToShortDateString();

                    //Enlazamos el combo de proveedores...
                    DataTable dt = objEmpleadoBL.ListarEmpleadosActivos();
                    DataRow dr;
                    dr = dt.NewRow();
                    dr["cod_emp"] = "X";
                    dr["NombreCompleto"] = "-Seleccione-";
                    dt.Rows.InsertAt(dr, 0);
                    cboEmpleado.DataSource = dt;
                    cboEmpleado.DataValueField = "cod_emp";
                    cboEmpleado.DataTextField = "NombreCompleto";
                    cboEmpleado.DataBind();
                    cboEmpleado.SelectedIndex = 0;

                    //Creamos la tabla memoria
                    CrearTabla();
                }
            }
            catch(Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboEmpleado.SelectedValue.ToString() == "X")
                {
                    throw new Exception("Debes seleccionar un Empleado");
                }

                cboProducto.SelectedIndex = 0;
                txtCanSal.Text = String.Empty;
                lblMensajeDetalle.Text = String.Empty;
                PopDetalle.Show();


               

            }
            catch (Exception ex)
            {

                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void btnGrabarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboProducto.SelectedValue == "X")
                {
                    throw new Exception("Debe seleccionar un producto");
                }
                if (txtCanSal.Text == "")
                {
                    throw new Exception("Debe ingresar una cantidad");
                }

                mitb = (DataTable)Session["Detalles"];

                DataRow dr;
                dr = mitb.NewRow();
                dr["cod_pro"] = cboProducto.SelectedValue.ToString();
                dr["des_pro"] = cboProducto.SelectedItem.ToString();
                dr["cantidad"] = Convert.ToInt16(txtCanSal.Text);

                mitb.Rows.Add(dr);

                grDetalles.DataSource = mitb;
                grDetalles.DataBind();

            }
            catch (Exception ex)
            {

                lblMensajeDetalle.Text = "Error: " + ex.Message;
                PopDetalle.Show();
            }
        }

        protected void btnVerGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                mitb = (DataTable)Session["Detalles"];

                if (txtFecSal.Text == "")
                {
                    throw new Exception("Debe Ingresar Fecha de Salida de Producto");
                }
                
                if (cboEmpleado.SelectedItem.ToString() == "-Seleccione-")
                {
                    throw new Exception("Debe Seleccionar Empleado");
                }
                
                if (mitb.Rows.Count == 0)
                {
                    throw new Exception("No puede registrar una orden sin detalles.");
                }

                lblGrabarOC.Text = "";
                PopOCompra.Show();


            }
            catch (Exception ex)
            {

                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
            }
        }

        protected void btnCancelarDetalle_Click(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        protected void btnGrabarOC_Click(object sender, EventArgs e)
        {
            try
            {

                mitb = (DataTable)Session["Detalles"];

                if (fulOC.HasFile == false)
                {
                    throw new Exception("Debe adjuntar proforma");
                }
                //si adjunto la proforma se valida que sea PDF y de 4mg
                String strNombreArchivo = fulOC.FileName;
                String strExtension = Path.GetExtension(strNombreArchivo).ToLower();

                if (strExtension !=".pdf" && fulOC.PostedFile.ContentLength !=4200000)
                {
                    throw new Exception("El archivo no es PDF o excede los 4MB");
                }

                SalidaBE objSalidaBE = new SalidaBE();
                SalidaBL objsalidaBL = new SalidaBL();

                objSalidaBE.fec_Sal = Convert.ToDateTime(txtFecSal.Text);
                objSalidaBE.est_sal = "1";
                objSalidaBE.cod_emp = cboEmpleado.SelectedValue;
                objSalidaBE.Usu_Registro = "CarlosRC";

                objSalidaBE.DetallesSal = mitb;

                String strNumSal = objsalidaBL.RegistrarSalidaProducto(objSalidaBE);
                if (strNumSal == String.Empty)
                {
                    throw new Exception("Error, no se registró la orden. Revise");
                }
                else
                {
                    String strRuta = Server.MapPath("/") + @"Proformas\";
                    strRuta += strNumSal + ".pdf";

                    fulOC.SaveAs(strRuta);

                    txtFecSal.Text = DateTime.Now.ToShortDateString();
                    cboEmpleado.SelectedIndex = 0;
                    CrearTabla();

                    lblMensajePopup.Text = "Se registró la orden Nro:" + strNumSal + " exitosamente";
                    PopMensaje.Show();
                }

            }
            catch (Exception ex)
            {

                lblGrabarOC.Text = ex.Message;
                PopOCompra.Show();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void grDetalles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grDetalles_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int indicefila = Convert.ToInt16(e.CommandArgument);

                if (e.CommandName == "Eliminar")
                {
                    mitb = (DataTable)Session["Detalles"];
                    mitb.Rows.RemoveAt(indicefila);
                    grDetalles.DataSource = mitb;
                    grDetalles.DataBind();
                    Session["Detalles"] = mitb;
                }
            }
            catch (Exception ex)
            {
                lblMensajePopup.Text = ex.Message;
                PopMensaje.Show();
                
            }
        }

        protected void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grDetalles.Rows.Count > 0)
            {
                throw new Exception("Ya seleccionó detalles, no puede cambiar de empleado");
            }

            DataTable dt = objProductoBL.ListarProductosActivos();
            DataRow dr;
            dr = dt.NewRow();
            dr["cod_pro"] = "X";
            dr["des_pro"] = "-Selecccione-";

            dt.Rows.InsertAt(dr, 0);
            cboProducto.DataSource = dt;
            cboProducto.DataValueField = "cod_pro";
            cboProducto.DataTextField = "des_pro";
            cboProducto.DataBind();
            cboProducto.SelectedIndex = 0;
        }
    }
}