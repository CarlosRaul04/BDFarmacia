using ProyFarmacia_ADO;
using ProyFarmacia_BE;
using ProyFarmacia_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyFarmacia_GUI
{
    public partial class frmLogin : Form
    {
        int intentos = 0;
        int tiempo = 30;

        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text.Trim());
                if (objUsuarioBE.Login_Usuario == null)
                {
                    MessageBox.Show("Usuario no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                }
                else if (txtLogin.Text.Trim() == objUsuarioBE.Login_Usuario && txtPassword.Text.Trim() == objUsuarioBE.Pass_Usuario)
                {
                    this.Hide();
                    timer1.Enabled = false;
                    clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
                    clsCredenciales.Password = objUsuarioBE.Pass_Usuario;
                    clsCredenciales.Nivel = objUsuarioBE.Niv_Usuario;
                    MDIprincipal objMDI = new MDIprincipal();
                    objMDI.Show();
                }
                else
                {
                    MessageBox.Show("Password incorrecto",
                       "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                }

            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
            }
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }
    }
}
