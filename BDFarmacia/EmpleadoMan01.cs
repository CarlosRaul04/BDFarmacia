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
    public partial class EmpleadoMan01 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        DataView dtv;

        public EmpleadoMan01()
        {
            InitializeComponent();
        }
        public void CargarDatos(String strFiltro)
        {

            dtv = new DataView(objEmpleadoBL.ListarEmpleado());
            dtv.RowFilter = " ape_emp like '%" + strFiltro + "%'";
            dtgEmpleados.DataSource = dtv;
            lblRegistros.Text = dtgEmpleados.Rows.Count.ToString();
        }
        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                dtgEmpleados.AutoGenerateColumns = false;
                CargarDatos(String.Empty);
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

                EmpleadoMan02 objMan02 = new EmpleadoMan02();
                objMan02.ShowDialog();

                //Refrescar el grid
                CargarDatos(txtFiltro.Text.Trim());

            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                EmpleadoMan03 objMan03 = new EmpleadoMan03();
                objMan03.Codigo = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();
                objMan03.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
