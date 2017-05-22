using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Animalitos
{
    public partial class MasterOfPages : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var username = (String)Session["usuario"];
            tbxAbajodelBaner.Text = "¡Bienvenido " + username + "! Estamos actualizados a dia: " + DateTime.Today.ToShortDateString();
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}