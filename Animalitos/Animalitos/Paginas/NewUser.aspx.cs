using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Animalitos.Paginas
{
    public partial class NewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreateUser_OnContinueButtonClick(object sender, ImageClickEventArgs e)
        {
            if (tbxContraseña.Text.Equals(tbxConfirmarContraseña.Text)) //Y otras validaciones
            {
                Usuario user = new Usuario();
                user.Nombre = tbxUsername.Text;
                user.Password = tbxContraseña.Text;
                user.Correo = tbxCorreo.Text;
                user.Nivel = "0";
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Las contraseñas no coinciden";
            }
        }
    }



}