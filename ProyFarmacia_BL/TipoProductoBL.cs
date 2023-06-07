using ProyFarmacia_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyFarmacia_BL
{
    public class TipoProductoBL
    {
        TipoProductoADO objTipoProductoADO = new TipoProductoADO();

        public DataTable ListarTipoProducto()
        {
            return objTipoProductoADO.ListarTipoProducto();
        }

    }
}
