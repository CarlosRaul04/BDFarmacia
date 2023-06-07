using ProyWEBFarmacia_BE;
using ProyWEBFarmacia_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioVentasWEB_GUI
{
    public partial class WebLogin : System.Web.UI.Page
    {
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                // Usuario y password obligatorios
                if (txtUsuario.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el usuario.");
                }

                if (txtPass.Text.Trim() == String.Empty)
                {
                    throw new Exception("Debe ingresar el password.");
                }


                // Validamos el usuario y contraseña

                if (txtUsuario.Text.Trim() != "" & txtPass.Text.Trim() != "")
                {
                    objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtUsuario.Text.Trim());
                    if (objUsuarioBE.Login_Usuario == null)
                    {
                        throw new Exception("Este Usuario no existe");
                    }
                    else if (txtUsuario.Text.Trim() == objUsuarioBE.Login_Usuario && txtPass.Text.Trim() == objUsuarioBE.Pass_Usuario)
                    {
                        Response.Redirect("MenuPrincipal.aspx");
                    }
                    else
                    {
                        throw new Exception("Usuario o password errados.");
                    }

                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}