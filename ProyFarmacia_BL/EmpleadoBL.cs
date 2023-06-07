using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyFarmacia_BE;
using ProyFarmacia_ADO;
namespace ProyFarmacia_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();

        public DataTable ListarEmpleado()
        {
            return objEmpleadoADO.ListarEmpleado();
        }

        public EmpleadoBE ConsultarEmpleado(String strcod)
        {
            return objEmpleadoADO.ConsultarEmpleado(strcod);
        }

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.InsertarEmpleado(objEmpleadoBE);
        }
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.ActualizarEmpleado(objEmpleadoBE);
        }
        public Boolean EliminarProveedor(String strcod, String Usuario)
        {
            return objEmpleadoADO.EliminarEmpleado(strcod, Usuario);
        }

    }
}
