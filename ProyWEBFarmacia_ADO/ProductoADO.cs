using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyWEBFarmacia_BE;

namespace ProyWEBFarmacia_ADO
{
    public class ProductoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public ProductoBE ConsultarProductoWEB(String strCodigo)
        {
            try
            {
                ProductoBE objProductoBE = new ProductoBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objProductoBE.Des_pro = dtr["des_pro"].ToString();
                    objProductoBE.tipoProducto = dtr["TipoProducto"].ToString();
                    objProductoBE.pre_pro = Convert.ToSingle(dtr["pre_pro"]);
                    objProductoBE.Stock = Convert.ToInt16(dtr["stock"]);
                    objProductoBE.UnidadMedida = dtr["UnidadMedida"].ToString();
                    objProductoBE.fec_reg = Convert.ToDateTime(dtr["fec_reg"]);
                    objProductoBE.est_pro = Convert.ToInt16(dtr["est_pro"]);

                }
                dtr.Close();

                return objProductoBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }
        public DataTable ListarPagoPotencial()
        {

            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_PagoPotencialProducto";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "PagoPotencialProducto");
                return dts.Tables["PagoPotencialProducto"];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarProducto()
        {

            try
            {

                // Codifique
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProducto";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Producto");
                return dts.Tables["Producto"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarProductosActivos()
        {

            try
            {

                // Codifique
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProductosActivos";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "ProductoActivos");
                return dts.Tables["ProductoActivos"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarIngresoProductoFechas(string strcodigo, DateTime fecini, DateTime fecfin)
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarIngresoProductoFechas";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", strcodigo);
                cmd.Parameters.AddWithValue("@fecini", fecini);
                cmd.Parameters.AddWithValue("@fecfin", fecfin);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "IngresoProducto");

                return dts.Tables["IngresoProducto"];
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
