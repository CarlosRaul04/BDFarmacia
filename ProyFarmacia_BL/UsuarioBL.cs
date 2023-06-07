using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyFarmacia_ADO;
using ProyFarmacia_BE;

namespace ProyFarmacia_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new ProyFarmacia_ADO.UsuarioADO();
        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            return objUsuarioADO.ConsultarUsuario(strLogin);
        }
    }
}
