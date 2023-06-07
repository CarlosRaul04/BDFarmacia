using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyFarmacia_BL;
using ProyFarmacia_BE;

namespace ProyFarmacia_GUI
{
    public partial class EmpleadoMan02 : Form
    {
        //Instancias..
        EmpleadoBL ObjEmpleadoBL = new EmpleadoBL();
        EmpleadoBE ObjEmpleadoBE = new EmpleadoBE();

        public EmpleadoMan02()
        {
            InitializeComponent();
        }

        private void EmpleadoMan02_Load(object sender, EventArgs e)
        {
            try
            {

                CargarUbigeo("14","01","01");

            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void CargarUbigeo(string IdDepa, string IdProv, string IdDist)
        {
            UbigeoBL ObjUbigeoBL = new UbigeoBL();
            cboDepartamento.DataSource = ObjUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = ObjUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = ObjUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.ValueMember = "idDist";
            cboDistrito.SelectedValue = IdDist;
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Refrescamos
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(),cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNom.Text.Trim() == String.Empty)
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

                ObjEmpleadoBE.Nom_emp = txtNom.Text.Trim();
                ObjEmpleadoBE.ape_emp = txtApe.Text.Trim();
                ObjEmpleadoBE.celular = mskcel.Text.Trim();
                ObjEmpleadoBE.dni_emp = txtdni.Text.Trim();
                ObjEmpleadoBE.direccion = txtDir.Text.Trim();

                ObjEmpleadoBE.id_ubigeo = cboDepartamento.SelectedValue.ToString() + 
                                          cboProvincia.SelectedValue.ToString() +
                                          cboDistrito.SelectedValue.ToString();

                ObjEmpleadoBE.Est_emp = Convert.ToInt16(chkEstado.Checked);
                ObjEmpleadoBE.Usu_Registro = clsCredenciales.Usuario;
                
                //Invocamos al metodo insertar
                if(ObjEmpleadoBL.InsertarEmpleado(ObjEmpleadoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se insertó el registro, contacte con el TI");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
