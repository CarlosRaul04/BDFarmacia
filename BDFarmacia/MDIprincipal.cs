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
    public partial class MDIprincipal : Form
    {
        public MDIprincipal()
        {
            InitializeComponent();
        }

        private void MDIprincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = clsCredenciales.Usuario;
            if (clsCredenciales.Nivel == 1)
            {
                mantenimientoToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
                listadosToolStripMenuItem.Visible = true;
            }
            else if (clsCredenciales.Nivel == 2)
            {
                mantenimientoToolStripMenuItem.Visible = true;
                consultasToolStripMenuItem.Visible = true;
                listadosToolStripMenuItem.Visible = false;
            }
        }

        private void MDIprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MDIprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formularioEmpleados
            EmpleadoMan01 objEmpMan01 = new EmpleadoMan01();
            objEmpMan01.MdiParent = this;
            objEmpMan01.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formularioProductos
            ProductoMan01 objProdMan01 = new ProductoMan01();
            objProdMan01.MdiParent = this;
            objProdMan01.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formularioProveedores
            ProveedorMan01 prov01 = new ProveedorMan01();
            prov01.MdiParent = this;
            prov01.Show();
        }
    }
}
