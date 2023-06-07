using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyFarmacia_ADO;
using ProyFarmacia_BL;
using ProyFarmacia_BE;
namespace ProyFarmacia_GUI
{
    public partial class ProveedorMan03 : Form
    {   
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();
        public ProveedorMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

            UbigeoBL objUbigeoBL = new UbigeoBL();
            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.DisplayMember = "Departamento";          
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;

        }
        private void ProveedorMan03_Load(object sender, EventArgs e)
        {
            try
            {
                


                objProveedorBE = objProveedorBL.ConsultarProveedor(this.Codigo);

                lblCod.Text = objProveedorBE.Cod_prv;
                txtRS.Text = objProveedorBE.Raz_soc_prv;
                txtDir.Text = objProveedorBE.Dir_prv;
                txtTel.Text = objProveedorBE.Tel_prv;
                mskRuc.Text = objProveedorBE.Ruc_prv;
                txtRepVen.Text = objProveedorBE.Rep_ven;
                chkEstado.Checked = Convert.ToBoolean(objProveedorBE.Est_prv);

                String Id_Ubigeo = objProveedorBE.Id_Ubigeo;

                CargarUbigeo(Id_Ubigeo.Substring(0,2),Id_Ubigeo.Substring(2,2),Id_Ubigeo.Substring(4,2));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtRS.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripción es obligatoria");
                }
       
                objProveedorBE.Cod_prv = lblCod.Text;
                objProveedorBE.Raz_soc_prv = txtRS.Text.Trim();
                objProveedorBE.Dir_prv = txtDir.Text.Trim();
                objProveedorBE.Tel_prv = txtTel.Text.Trim();
                objProveedorBE.Ruc_prv = mskRuc.Text.Trim();
                objProveedorBE.Rep_ven = txtRepVen.Text.Trim();
                objProveedorBE.Est_prv = Convert.ToInt16(chkEstado.Checked);
                objProveedorBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString() ;

                objProveedorBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                if (objProveedorBL.ActualizarProveedor(objProveedorBE) == true)
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void mskRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
