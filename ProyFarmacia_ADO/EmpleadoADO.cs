using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyFarmacia_BE;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;

namespace ProyFarmacia_ADO
{
    public class EmpleadoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEmpleado()
        {

            try
            {

                // Codifique
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleado";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Empleados");
                return dts.Tables["Empleados"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
        public EmpleadoBE ConsultarEmpleado(String strCodigo)
        {

            try
            {
                //Codifique
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
                    objEmpleadoBE.Cod_emp = dtr["cod_emp"].ToString();
                    objEmpleadoBE.Nom_emp = dtr["nom_emp"].ToString();
                    objEmpleadoBE.ape_emp = dtr["ape_emp"].ToString();
                    objEmpleadoBE.celular = dtr["celular"].ToString();
                    objEmpleadoBE.dni_emp = dtr["dni_emp"].ToString();
                    objEmpleadoBE.direccion =dtr["direccion"].ToString();
                    objEmpleadoBE.id_ubigeo = dtr["id_ubigeo"].ToString();
                    objEmpleadoBE.Fec_ing = Convert.ToDateTime(dtr["fec_ing"]);
                    objEmpleadoBE.Est_emp = Convert.ToInt16(dtr["est_emp"]);
                    objEmpleadoBE.Usu_Registro = dtr["Usu_Registro"].ToString();
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

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vnombre", objEmpleadoBE.Nom_emp);
                cmd.Parameters.AddWithValue("@vapellido", objEmpleadoBE.ape_emp);
                cmd.Parameters.AddWithValue("@vcelular", objEmpleadoBE.celular);
                cmd.Parameters.AddWithValue("@vdni", objEmpleadoBE.dni_emp);
                cmd.Parameters.AddWithValue("@vdireccion", objEmpleadoBE.direccion);
                cmd.Parameters.AddWithValue("@vid_Ubigeo", objEmpleadoBE.id_ubigeo);
                cmd.Parameters.AddWithValue("@vest_emp", objEmpleadoBE.Est_emp);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objEmpleadoBE.Usu_Registro);
            

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
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEmpleado";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vcod", objEmpleadoBE.Cod_emp);
                cmd.Parameters.AddWithValue("@vnombre", objEmpleadoBE.Nom_emp);
                cmd.Parameters.AddWithValue("@vapellido", objEmpleadoBE.ape_emp);
                cmd.Parameters.AddWithValue("@vcelular", objEmpleadoBE.celular);
                cmd.Parameters.AddWithValue("@vdni", objEmpleadoBE.dni_emp);
                cmd.Parameters.AddWithValue("@vdireccion", objEmpleadoBE.direccion);
                cmd.Parameters.AddWithValue("@vid_ubigeo", objEmpleadoBE.id_ubigeo);
                cmd.Parameters.AddWithValue("@vest_emp", objEmpleadoBE.Est_emp);
                cmd.Parameters.AddWithValue("@vUsu_ult_Mod", objEmpleadoBE.Usu_Ult_Mod);
             

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

        public Boolean EliminarEmpleado(String strCodigo, String strUsuario)
        {


            try
            {
                //Codifique
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarEmpleado";
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

