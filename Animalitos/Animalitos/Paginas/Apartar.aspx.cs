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
    public partial class Venta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nivel"].Equals("0"))
            {
                Response.Write("<script>alert('Por favor ingrese o registrese para poder ver el catalogo');</script>");
                Response.Redirect("Login.aspx");
            }
            else
            {
                llenardatos();
            }


            
        }

        protected void btnAceptar_OnClick(object sender, ImageClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void llenardatos()
        {

                string x = (string)Session["value"];

                string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                SqlDataReader sqldr;
                string query = "SELECT id_animalito, descripcion, precio, url_imagen FROM T_Animalitos WHERE id_animalito = @ID";
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = cnnstring;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@ID", x);
                sqldr = cmd.ExecuteReader();

                if (sqldr.Read())
                {
                    lblDescripcion.Text = (string)sqldr["descripcion"];
                    lblPrecio.Text = sqldr["precio"].ToString();
                    imgAnimalito.ImageUrl = (string)sqldr["url_imagen"];
                    con.Close();
                }
            



        }
    }
}