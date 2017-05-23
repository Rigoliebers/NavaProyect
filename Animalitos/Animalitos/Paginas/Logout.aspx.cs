using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Animalitos.Paginas
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].Equals(""))
            {
                Response.Redirect(Request.UrlReferrer.ToString());
            }
            else
            {

                Session["usuario"] = "";
                Session["nivel"] = 0;
                Response.Redirect("Inicio.aspx");
            }
        }
    }
}