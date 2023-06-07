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
    public partial class ProveedorMan02 : Form
    {
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();
        public ProveedorMan02()
        {
            InitializeComponent();
        }
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
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtRS.Text.Trim() == String.Empty)
                {
                    throw new Exception("La razon social es obligatoria");
                }

                if (mskRuc.MaskFull == false)
                {
                    throw new Exception("El RUC debe tener 11 caracteres");
                }

                objProveedorBE.Raz_soc_prv = txtRS.Text.Trim();
                objProveedorBE.Dir_prv = txtDir.Text.Trim();
                objProveedorBE.Tel_prv = txtTel.Text.Trim();
                objProveedorBE.Rep_ven = txtRepVen.Text.Trim();
                objProveedorBE.Ruc_prv = mskRuc.Text.Trim();

                objProveedorBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                                        cboProvincia.SelectedValue.ToString() +
                                        cboDistrito.SelectedValue.ToString();
                objProveedorBE.Usu_Registro = clsCredenciales.Usuario;
                objProveedorBE.Est_prv = Convert.ToInt16(chkEstado.Checked);

                if (objProveedorBL.InsertarProveedor(objProveedorBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("NO se insertó el registro, contacte con TI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }


        }

        private void ProveedorMan02_Load(object sender, EventArgs e)
        {
            try
            {

                CargarUbigeo("14", "01", "01");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

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

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
