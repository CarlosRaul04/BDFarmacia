using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using ProyFarmacia_ADO;
using ProyFarmacia_BE;

namespace ProyFarmacia_BL
{
    public  class ProductoBL
    {
        ProductoADO objProductoADO = new ProductoADO();

        public DataTable ListarProducto()
        { 
           return objProductoADO .ListarProducto ();
        }
        public ProductoBE ConsultarProducto(String strCodigo)
        {
            return objProductoADO.ConsultarProducto (strCodigo );
        }

        public Boolean InsertarProducto(ProductoBE objProductoBE)
        {
            return objProductoADO.InsertarProducto(objProductoBE);
        }
        public Boolean ActualizarProducto(ProductoBE objProductoBE)
        {
            return objProductoADO.ActualizarProducto(objProductoBE);
        }
        public Boolean EliminarProducto(String strCodigo, String strUsuario)
        {
            return objProductoADO.EliminarProducto(strCodigo, strUsuario);
        }
    }
}
