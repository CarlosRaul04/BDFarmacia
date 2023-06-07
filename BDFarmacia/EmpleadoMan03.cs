using ProyFarmacia_BE;
using ProyFarmacia_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyFarmacia_GUI
{

    public partial class EmpleadoMan03 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();



        public EmpleadoMan03()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

            UbigeoBL objUbigeoBL = new UbigeoBL();
            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.SelectedValue = IdDist;

        }


        private void EmpleadoMan03_Load(object sender, EventArgs e)
        {
            try
            {

                objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(this.Codigo);

                lblCod.Text = objEmpleadoBE.Cod_emp;
                txtNom.Text = objEmpleadoBE.Nom_emp;
                txtApe.Text = objEmpleadoBE.ape_emp;
                mskcel.Text = objEmpleadoBE.celular;
                txtdni.Text = objEmpleadoBE.dni_emp;
                txtDir.Text = objEmpleadoBE.direccion;
                chkEstado.Checked = Convert.ToBoolean(objEmpleadoBE.Est_emp);

                String Id_Ubigeo = objEmpleadoBE.id_ubigeo;

                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));
                
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNom.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es obligatorio");
                }

                if (txtApe.Text.Trim() == String.Empty)
                {
                    throw new Exception("El Apellido es obligatorio");
                }

                if (txtdni.Text.Trim() == String.Empty)
                {
                    throw new Exception("El DNI es obligatorio");
                }

        

                objEmpleadoBE.Cod_emp = lblCod.Text;
                objEmpleadoBE.Nom_emp = txtNom.Text;
                objEmpleadoBE.ape_emp = txtApe.Text;
                objEmpleadoBE.celular = mskcel.Text;
                objEmpleadoBE.dni_emp = txtdni.Text;
                objEmpleadoBE.direccion = txtDir.Text;

                objEmpleadoBE.id_ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString(); 

                objEmpleadoBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                if(objEmpleadoBL.ActualizarEmpleado(objEmpleadoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó el registro, contacte con TI");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(),cboProvincia.SelectedValue.ToString(), "01");
        }

        private void mskcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
