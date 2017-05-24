using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Animalitos.Paginas
{
    public partial class Startop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuario"] = "";
            Session["nivel"] = "0";
            Session["value"] = "0";
            Response.RedirectPermanent("Inicio.aspx");
        }
    }
}