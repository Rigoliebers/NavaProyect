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
        string especie, raza;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nivel"].Equals(0))
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
            string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
            string query;
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = cnnstring;
            con.Open();
            cmd.Connection = con;
            query = "INSERT INTO T_Apartados VALUES(@id_cliente,@nombre_cliente,@id_animalito,@especie,@raza,@precio)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@id_cliente", Session["id_usuario"]);
            cmd.Parameters.AddWithValue("@nombre_cliente", Session["usuario"]);
            cmd.Parameters.AddWithValue("@id_animalito", Session["value"]);
            cmd.Parameters.AddWithValue("@especie", especie);
            cmd.Parameters.AddWithValue("@raza", raza);
            cmd.Parameters.AddWithValue("@precio", lblPrecio.Text);

        cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Carrito.aspx");
        }

        private void llenardatos()
        {

                string x = (string)Session["value"];

                string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                SqlDataReader sqldr;
                string query = "SELECT id_animalito, descripcion, precio, url_imagen, raza, especie FROM T_Animalitos WHERE id_animalito = @ID";
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
                    raza = (string)sqldr["raza"];
                    especie = (string) sqldr["especie"];
                    con.Close();
                }
            



        }
    }
}