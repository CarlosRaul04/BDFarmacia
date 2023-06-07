using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyWEBFarmacia_BE
{
    public class ProductoBE
    {
        public String Cod_pro { get; set; }
        public String Des_pro { get; set; }
        public String tipoProducto { get; set; }
        public String cod_tip { get; set; }
        public Single pre_pro { get; set; }
        public Int16 Stock { get; set; }
        public Int16 Id_UM { get; set; }
        public String UnidadMedida { get; set; }
        public DateTime fec_reg { get; set; }
        public Int16 est_pro { get; set; }
        public Byte[] imageP { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Usu_Ult_Mod { get; set; }
    }
}
