
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar...
using ProyWEBFarmacia_ADO;
using ProyWEBFarmacia_BE;

namespace ProyWEBFarmacia_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();

        public EmpleadoBE ConsultarEmpleadoWEB(String strCodigo)
        {
            return objEmpleadoADO.ConsultarEmpleadoWEB(strCodigo);
        }

        public DataTable ListarEmpleadosActivos()
        {
            return objEmpleadoADO.ListarEmpleadosActivos();
        }

    }
}
