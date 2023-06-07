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
namespace ProyFarmacia_GUI
{
    public partial class ProveedorMan01 : Form
    {
        ProveedorBL objProveedorBL = new ProveedorBL();
        DataView dtv;

        public ProveedorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {

            dtv = new DataView(objProveedorBL.ListarProveedor());
            dtv.RowFilter = "raz_soc_prv like '%" + strFiltro + "%'";
            dtgProveedor.DataSource = dtv;
            lblRegistros.Text = dtgProveedor.Rows.Count.ToString();
        }

        private void ProveedorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgProveedor.AutoGenerateColumns = false;
                CargarDatos(String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                ProveedorMan02 objMan02 = new ProveedorMan02();
                objMan02.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorMan03 prov03 = new ProveedorMan03();

                prov03.Codigo = dtgProveedor.CurrentRow.Cells[0].Value.ToString();
                prov03.ShowDialog();

                dtv = new DataView(objProveedorBL.ListarProveedor());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
