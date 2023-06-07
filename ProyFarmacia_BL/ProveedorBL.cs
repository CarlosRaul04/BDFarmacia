using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Agregamos los using...
using System.Data;
using ProyFarmacia_ADO;
using ProyFarmacia_BE;

namespace ProyFarmacia_BL
{
    public class ProveedorBL
    {
        ProveedorADO objProveedorADO = new ProveedorADO();

        public Boolean InsertarProveedor(ProveedorBE objProveedorBE)
        {
            return objProveedorADO.InsertarProveedor(objProveedorBE);
        }
        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            return objProveedorADO.ActualizarProveedor(objProveedorBE);
        }
        public Boolean EliminarProveedor(String strcod)
        {
            return objProveedorADO.EliminarProveedor(strcod);
        }

        public ProveedorBE ConsultarProveedor(String strcod)
        {
            return objProveedorADO.ConsultarProveedor(strcod);
        }

        public DataTable ListarProveedor()
        {
            return objProveedorADO.ListarProveedor();
        }

    }
}
