using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar...
using System.Data.SqlClient;
using System.Data;
using ProyWEBFarmacia_BE;

namespace ProyWEBFarmacia_ADO
{
    public class EmpleadoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public EmpleadoBE ConsultarEmpleadoWEB(String strCodigo)
        {
            try
            {
                EmpleadoBE objEmpleadoBE = new EmpleadoBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod_emp", strCodigo);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEmpleadoBE.Nom_emp = dtr["nom_emp"].ToString();
                    objEmpleadoBE.ape_emp = dtr["ape_emp"].ToString();
                    objEmpleadoBE.celular = dtr["celular"].ToString();
                    objEmpleadoBE.dni_emp = dtr["dni_emp"].ToString();
                    objEmpleadoBE.direccion = dtr["direccion"].ToString();
                    objEmpleadoBE.Departamento = dtr["Departamento"].ToString();
                    objEmpleadoBE.Provincia = dtr["Provincia"].ToString();
                    objEmpleadoBE.Distrito = dtr["Distrito"].ToString();
                    objEmpleadoBE.Est_emp = Convert.ToInt16(dtr["est_emp"]);
                }
                dtr.Close();
                return objEmpleadoBE;
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

        public DataTable ListarEmpleadosActivos()
        {

            try
            {

                // Codifique
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleadosActivos";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "EmpleadosActivos");
                return dts.Tables["EmpleadosActivos"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
