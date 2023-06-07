using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyWEBFarmacia_BL;
namespace SitioWEB_FarmaciaBD.Consultas
{
    public partial class WebGraficos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    ProductoBL objProductolBL = new ProductoBL();

                    

                    DataTableReader dtReaderTotales = objProductolBL.ListarPagoPotencial().CreateDataReader();

                    grafTotales.Series.Add("Totales");
                    grafTotales.Series["Totales"].Points.DataBindXY(dtReaderTotales, "TipoProducto", dtReaderTotales, "PagoPotencialCategoria");
                    grafTotales.Series["Totales"].IsValueShownAsLabel = true;
                    grafTotales.Series["Totales"].LabelFormat = "c";
                    
               

                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void grafTotales_Load(object sender, EventArgs e)
        {

        }
    }
}