using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyFarmacia_BE;
using ProyFarmacia_BL;
using ProyVentas_BL;

namespace ProyFarmacia_GUI
{
    public partial class ProductoMan03 : Form
    {

        ProductoBE objProductoBE = new ProductoBE();
        ProductoBL objProductoBL = new ProductoBL();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        TipoProductoBL objTipoProductoBL = new TipoProductoBL();

        Boolean blnCambio;
        Byte[] fotoOriginal;

        public ProductoMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void ProductoMan03_Load(object sender, EventArgs e)
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

                objProductoBE = objProductoBL.ConsultarProducto(this.Codigo);

               
                lblCodigo.Text = objProductoBE.Cod_pro;
                txtDescripcion.Text = objProductoBE.Des_pro;
                txtPrecio.Text = objProductoBE.pre_pro.ToString();
                txtStock.Text = objProductoBE.Stock.ToString();
                cboTipo.SelectedValue = objProductoBE.cod_tip.ToString();
                cboUM.SelectedValue = objProductoBE.Id_UM.ToString();
                chkActivo.Checked = Convert.ToBoolean(objProductoBE.est_pro);

                if(objProductoBE.imageP.Length == 0)
                {
                    pcbFoto.Image = null;
                }
                else
                {
                    MemoryStream fotoStream = new MemoryStream(objProductoBE.imageP);
                    pcbFoto.Image = Image.FromStream(fotoStream);
                    //Guardamos la foto original, por si no se hace cambios
                    fotoOriginal = objProductoBE.imageP;
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box y la variable blnCambio se pone en true
                // Esta variable permitira saber si se cambio la foto en la categoria.
                if (openFileDialog1.FileName != String.Empty)
                {
                    pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                    blnCambio = true;
                }
                else // de lo contrario la variable blnCambio se mantiene en falso
                {
                    blnCambio = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Trim() == String.Empty)
            {
                throw new Exception("La descripción es obligatoria");
            }

            if (cboTipo.SelectedIndex == 0 || cboUM.SelectedIndex == 0)
            {
                throw new Exception("La UM y Tipo son datos obligatorios");
            }

            if (pcbFoto.Image == null)
            {
                throw new Exception("Debe registrar la foto");
            }

            objProductoBE.Cod_pro = lblCodigo.Text;
            objProductoBE.Des_pro = txtDescripcion.Text;
            objProductoBE.pre_pro = Convert.ToSingle(txtPrecio.Text);
            objProductoBE.Stock = Convert.ToInt16(txtStock.Text);
            objProductoBE.cod_tip = cboTipo.SelectedValue.ToString();
            objProductoBE.Id_UM = Convert.ToInt16(cboUM.SelectedValue);
            objProductoBE.est_pro = Convert.ToInt16(chkActivo.Checked);

            if(blnCambio == true)
            {
                objProductoBE.imageP = File.ReadAllBytes(openFileDialog1.FileName);
            }
            else
            {
                objProductoBE.imageP = fotoOriginal;
            }
            
            objProductoBE.Usu_Ult_Mod = clsCredenciales.Usuario;

            if (objProductoBL.ActualizarProducto(objProductoBE) == true)
            {
                this.Close();
            }
            else
            {
                throw new Exception("No se actualizo el registro. Contacte con TI");
            }


        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }
    }
}
