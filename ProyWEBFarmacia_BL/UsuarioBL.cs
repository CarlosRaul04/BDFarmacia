using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar...
using ProyWEBFarmacia_ADO;
using ProyWEBFarmacia_BE;

namespace ProyWEBFarmacia_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new ProyWEBFarmacia_ADO.UsuarioADO();
        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            return objUsuarioADO.ConsultarUsuario(strLogin);
        }
    }
}
