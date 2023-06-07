using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar...
using System.Data.SqlClient;
using System.Data;


namespace ProyWEBFarmacia_ADO
{
    public class SalidaProductoADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarSalidasEmpleadoFechas(string strcodigo, DateTime fecini, DateTime fecfin)
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarSalidasEmpleadoFechas";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codemp", strcodigo);
                cmd.Parameters.AddWithValue("@fecini", fecini);
                cmd.Parameters.AddWithValue("@fecfin", fecfin);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "SalidasEmpleado");

                return dts.Tables["SalidasEmpleado"];
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
