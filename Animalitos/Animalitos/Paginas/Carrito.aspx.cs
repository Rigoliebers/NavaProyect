using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Animalitos.Paginas
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenardv();
        }

        private void llenardv()
        {
            string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
            string query = "SELECT * FROM T_Apartados where id_cliente = @usuario";
            using (SqlConnection con = new SqlConnection(cnnstring))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@usuario", Session["id_usuario"]);
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            gvCarrito.DataSource = ds.Tables[0];
                            gvCarrito.DataBind();

                        }
                    }
                }
            }
        }
    }
}