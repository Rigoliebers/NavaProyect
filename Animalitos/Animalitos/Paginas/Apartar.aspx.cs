using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Animalitos.Paginas
{
    public partial class Venta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nivel"].Equals("0"))
            {
                Response.Write("<script>alert('Por favor ingrese o registrese para poder ver el catalogo');</script>");
                Response.Redirect("Login.aspx");
            }
        }
    }
}