using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyWEBFarmacia_BE
{
    public class EmpleadoBE
    {
        public String Cod_emp { get; set; }
        public String Nom_emp { get; set; }
        public String ape_emp { get; set; }
        public String celular { get; set; }
        public String dni_emp { get; set; }
        public String direccion { get; set; }
        public String id_ubigeo { get; set; }
        public String Departamento { get; set; }
        public String Provincia { get; set; }
        public String Distrito { get; set; }
        public DateTime Fec_ing { get; set; }
        public Int16 Est_emp { get; set; }
        public String Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public String Usu_Ult_Mod { get; set; }
    }
}
