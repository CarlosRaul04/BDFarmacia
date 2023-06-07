using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar
using ProyWEBFarmacia_ADO;
using ProyWEBFarmacia_BE;

namespace ProyWEBFarmacia_BL
{
    public class ProductoBL
    {

        ProductoADO objProductoADO = new ProductoADO();

        public ProductoBE ConsultarProductoWEB(String strCodigo)
        {
            return objProductoADO.ConsultarProductoWEB(strCodigo);
        }
        
        public DataTable ListarPagoPotencial()
        {
            return objProductoADO.ListarPagoPotencial();
        }

        public DataTable ListarProducto()
        {
            return objProductoADO.ListarProducto();
        }

        public DataTable ListarProductosActivos()
        {
            return objProductoADO.ListarProductosActivos();
        }

        public DataTable ListarIngresoProductoFechas(string strcodigo, DateTime fecini, DateTime fecfin)
        {
            return objProductoADO.ListarIngresoProductoFechas(strcodigo, fecini, fecfin);
        }

    }
}
