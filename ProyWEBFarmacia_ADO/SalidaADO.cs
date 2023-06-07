using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyWEBFarmacia_BE;
using System.Data;
using System.Data.SqlClient;


namespace ProyWEBFarmacia_ADO
{ 
    public class SalidaADO
    {
        ConexionADO Miconexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public string RegistrarSalidaProducto(SalidaBE objSalidaBE)
        {
            try
            {
                cnx.ConnectionString = Miconexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_RegistrarSalidaProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vfecsal", objSalidaBE.fec_Sal);
                cmd.Parameters.AddWithValue("@vcodemp", objSalidaBE.cod_emp);
                cmd.Parameters.AddWithValue("@vestoco", objSalidaBE.est_sal);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objSalidaBE.Usu_Registro);
                //Paramtero de salida...
                cmd.Parameters.Add(new SqlParameter("@vnumsal", SqlDbType.Char, 6));
                cmd.Parameters["@vnumsal"].Direction = ParameterDirection.Output;

                //Parametro del tipo de tabla
                cmd.Parameters.Add(new SqlParameter("@detalles", SqlDbType.Structured));
                cmd.Parameters["@detalles"].Value = objSalidaBE.DetallesSal;

                //Ejecutamos...
                cnx.Open();
                cmd.ExecuteNonQuery();
                //Retornamos el nuevo numero de OC
                return cmd.Parameters["@vnumsal"].Value.ToString();
            }
            catch (Exception ex)
            {
                return String.Empty;
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
