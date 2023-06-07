using ProyWEBFarmacia_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar...
using ProyWEBFarmacia_ADO;
using System.Data;


namespace ProyWEBFarmacia_BL
{
    public class SalidaBL
    {

        SalidaADO objSalidaADO = new SalidaADO();

        public string RegistrarSalidaProducto(SalidaBE objSalidaBE)
        {
            return objSalidaADO.RegistrarSalidaProducto(objSalidaBE);
        }
    }
}
