using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using ProyFarmacia_BE;
using System.Runtime.Remoting;

namespace ProyFarmacia_ADO
{
    public  class ProductoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;



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
        public ProductoBE ConsultarProducto (String strCodigo)
        {
            
            try
            {
                //Codifique
                ProductoBE objProductoBE = new ProductoBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if(dtr.HasRows == true)
                {
                    dtr.Read();
                    objProductoBE.Cod_pro = dtr["cod_pro"].ToString();
                    objProductoBE.Des_pro = dtr["des_pro"].ToString();
                    objProductoBE.cod_tip = dtr["cod_tip"].ToString();
                    objProductoBE.pre_pro = Convert.ToSingle(dtr["pre_pro"]);
                    objProductoBE.Stock = Convert.ToInt16(dtr["Stock"]);
                    objProductoBE.Id_UM = Convert.ToInt16(dtr["Id_UM"]);
                    objProductoBE.est_pro = Convert.ToInt16(dtr["est_pro"]);
                    objProductoBE.imageP = (Byte[])(dtr["fotoP"]);

                   
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

        public Boolean InsertarProducto(ProductoBE objProductoBE)
        {
          
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vdes",objProductoBE.Des_pro);
                cmd.Parameters.AddWithValue("@vtip",objProductoBE.cod_tip);
                cmd.Parameters.AddWithValue("@vpre",objProductoBE.pre_pro);
                cmd.Parameters.AddWithValue("@vstk",objProductoBE.Stock);
                cmd.Parameters.AddWithValue("@vId_UM",objProductoBE.Id_UM);
                cmd.Parameters.AddWithValue("@vEst_pro",objProductoBE.est_pro);
                cmd.Parameters.AddWithValue("@vImage",objProductoBE.imageP);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objProductoBE.Usu_Registro);
                

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
        public Boolean ActualizarProducto(ProductoBE objProductoBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarProducto";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vcod", objProductoBE.Cod_pro);
                cmd.Parameters.AddWithValue("@vdes", objProductoBE.Des_pro);
                cmd.Parameters.AddWithValue("@vcod_tip", objProductoBE.cod_tip);
                cmd.Parameters.AddWithValue("@vpre_pro", objProductoBE.pre_pro);
                cmd.Parameters.AddWithValue("@vstock", objProductoBE.Stock);
                cmd.Parameters.AddWithValue("@vId_UM", objProductoBE.Id_UM);
                cmd.Parameters.AddWithValue("@vest_pro", objProductoBE.est_pro);
                cmd.Parameters.AddWithValue("@vimage", objProductoBE.imageP);
                cmd.Parameters.AddWithValue("@vUsu_ult_Mod", objProductoBE.Usu_Ult_Mod);


                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }

        public Boolean EliminarProducto(String strCodigo, String strUsuario)
        {
           

            try
            {
                //Codifique
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);
                cmd.Parameters.AddWithValue("@Usuario", strUsuario);

                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }

    }
}
