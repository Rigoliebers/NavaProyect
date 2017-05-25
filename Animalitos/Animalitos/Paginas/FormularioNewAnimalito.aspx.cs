using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Animalitos.Paginas
{
    public partial class FormularioNewAnimalito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                SqlDataReader sqldr;
                string query = "INSERT INTO T_Animalitos VALUES (@ESPECIE, @RAZA, @DESCRIPCION, @PRECIO, @IMAGEN)";
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = cnnstring;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@ESPECIE", tbxEspecie.Text);
                cmd.Parameters.AddWithValue("@RAZA", tbxRaza.Text);
                cmd.Parameters.AddWithValue("@DESCRIPCION", tbxDescripcion.Text);
                cmd.Parameters.AddWithValue("@PRECIO", tbxPrecio.Text);
                cmd.Parameters.AddWithValue("@IMAGEN", tbxImagen.Text);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Registro creado con exito');</script>");
                Response.RedirectPermanent("Ajustes.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Hubo un error, intentelo de nuevo');</script>");
            }
        }
    }
}