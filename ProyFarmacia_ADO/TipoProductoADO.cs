using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyFarmacia_ADO
{
    public class TipoProductoADO
    {

        ConexionADO miconexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarTipoProducto()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = miconexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarTipoProducto";
            try
            {

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Tipos");
                return dts.Tables["Tipos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
