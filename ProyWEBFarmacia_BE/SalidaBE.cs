using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyWEBFarmacia_BE
{
    public class SalidaBE
    {
        public String cod_sal
        {
            get;set;
        }
        public System.DateTime fec_Sal
        {
            get;set;
        }
        public String est_sal
        {
            get;set;
        }
        public String cod_emp
        {
            get;set;
        }

        private DataTable Detalles;
        public DataTable DetallesSal
        {
            get { return Detalles; }
            set { Detalles = value; }

        }

        public String Usu_Registro
        {
            get;
            set;
        }


        public DateTime Fec_Ult_Mod
        {
            get;
            set;
        }


        public String Usu_Ult_Mod
        {
            get;
            set;
        }

    }
}
