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

        private string username = "Anonimo";
        private string nivel = "0";

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuario"] = username;
            Session["nivel"] = nivel;
            tbxAbajodelBaner.Text = "¡Bienvenido " + Session["usuario"] + "! Estamos actualizados a dia: " + DateTime.Today.ToShortDateString();
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            //username = "ninguno";
            //if (Menu1.SelectedItem = )
            //{
            //    username = "Ninguno";
            //}
        }
    }
}