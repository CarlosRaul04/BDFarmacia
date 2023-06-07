using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar...
using ProyWEBFarmacia_ADO;

namespace ProyWEBFarmacia_BL
{
    public class SalidaProductoBL
    {
        SalidaProductoADO objSalidaProductoADO = new SalidaProductoADO();

        public DataTable ListarSalidasEmpleadoFechas(string strcodigo, DateTime fecini, DateTime fecfin)
        {
            return objSalidaProductoADO.ListarSalidasEmpleadoFechas(strcodigo, fecini, fecfin);
        }
    }
}
