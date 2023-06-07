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
    public partial class ProductoMan01 : Form
    {
        ProductoBL objProductoBL = new ProductoBL();
        DataView dtv;
        public ProductoMan01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
            try
            {

                dtgDatos.AutoGenerateColumns = false;
                // Invocamos al metodo para cargar los datos              
                CargarDatos("");
            }
            catch (Exception ex)
            {

            }
        }
            private void CargarDatos(String strFiltro)
        {

           

            dtv = new DataView(objProductoBL.ListarProducto());
            dtv.RowFilter = "des_pro like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                ProductoMan02 objMan02 = new ProductoMan02();
                objMan02.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
            
                ProductoMan03 objMan03 = new ProductoMan03();
                objMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objMan03.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }


        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

