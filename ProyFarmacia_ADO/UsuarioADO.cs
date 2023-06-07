using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyFarmacia_BE;

namespace ProyFarmacia_ADO
{
    public class UsuarioADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            try
            {
                //Codifique
                UsuarioBE objUsuarioBE = new UsuarioBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Login_Usuario", strLogin);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuarioBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objUsuarioBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                    objUsuarioBE.Niv_Usuario = Convert.ToInt16(dtr["Niv_Usuario"]);
                    objUsuarioBE.Est_Usuario = Convert.ToInt16(dtr["Est_Usuario"]);
                    objUsuarioBE.Usu_registro =dtr["Usu_registro"].ToString();
                    objUsuarioBE.Fec_Registro = Convert.ToDateTime(dtr["Fec_registro"]);

                    dtr.Close();
                }
                return objUsuarioBE;
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
    }
}
