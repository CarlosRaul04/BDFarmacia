using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyFarmacia_BE;
using ProyFarmacia_BL;
using ProyVentas_BL;

namespace ProyFarmacia_GUI
{

    public partial class ProductoMan02 : Form
    {

        ProductoBE objProductoBE = new ProductoBE();
        ProductoBL objProductoBL = new ProductoBL();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        TipoProductoBL objTipoProductoBL = new TipoProductoBL();


        public ProductoMan02()
        {
            InitializeComponent();
        }



        private void ProductoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objUnidadMedidaBL.ListarUM();
                DataRow dr;
                dr = dt.NewRow();
                dr["id_UM"] = 0;
                dr["des_UM"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboUM.DataSource = dt;
                cboUM.DisplayMember = "Des_UM";
                cboUM.ValueMember = "Id_UM";

                dt = objTipoProductoBL.ListarTipoProducto();
                dr = dt.NewRow();
                dr["cod_tip"] = 0;
                dr["des_tip"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboTipo.DataSource = dt;
                cboTipo.DisplayMember = "des_tip";
                cboTipo.ValueMember = "cod_tip";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }

        private void txtStk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDescripcion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripción es obligatoria");
                }

                if(cboTipo.SelectedIndex == 0 || cboUM.SelectedIndex == 0)
                {
                    throw new Exception("La UM y Tipo son datos obligatorios");
                }

                if (pcbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto");
                }


                objProductoBE.Des_pro = txtDescripcion.Text.Trim();
                objProductoBE.cod_tip = cboTipo.SelectedValue.ToString();
                objProductoBE.pre_pro = Convert.ToSingle(txtPrecio.Text);
                objProductoBE.Stock = Convert.ToInt16(txtStk.Text);
                objProductoBE.Id_UM = Convert.ToInt16(cboUM.SelectedValue);
                objProductoBE.est_pro = Convert.ToInt16(chkActivo.Checked);
                objProductoBE.imageP = File.ReadAllBytes(openFileDialog1.FileName);
                objProductoBE.Usu_Registro = clsCredenciales.Usuario;

                if(objProductoBL.InsertarProducto(objProductoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizo el registro. Contacte con IT.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Error");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String .Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();
                pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                    
              

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
