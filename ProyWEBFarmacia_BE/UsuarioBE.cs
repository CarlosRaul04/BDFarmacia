﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyWEBFarmacia_BE
{
     public class UsuarioBE
    {
        public String Login_Usuario { get; set; }
        public String Pass_Usuario { get; set; }
        public Int16 Niv_Usuario { get; set; }
        public Int16 Est_Usuario { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_registro { get; set; }
    }
}
