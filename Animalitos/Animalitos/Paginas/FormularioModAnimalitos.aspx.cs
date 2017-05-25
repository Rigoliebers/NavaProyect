using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Animalitos.Paginas
{
    public partial class FormularioModAnimalitos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenaEspacios();
        }

        protected void llenaEspacios()
        {
            string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
            SqlDataReader sqldr;
            string query = "SELECT descripcion, precio, url_imagen FROM T_Animalitos";
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = cnnstring;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            sqldr = cmd.ExecuteReader();

            if (sqldr.Read())
            {
                tbxDescripcion.Text = (string)sqldr["descripcion"];
                tbxPrecio.Text = sqldr["precio"].ToString();
                tbxImagen.Text = (string)sqldr["url_imagen"];
                con.Close();
            }
        }

        protected void btnAceptar_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btnAceptar_OnClick(object sender, ImageClickEventArgs e)
        {
            bool succ = false;

            try
            {
                float precio = Convert.ToInt64(tbxPrecio.Text);

                string cnnstring =
                    ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                string query =
                    "UPDATE T_Animalitos SET descripcion = @DESCRIPCION, precio = @PRECIO, url_imagen = @IMAGEN WHERE id_animalito = @ID";
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = cnnstring;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@DESCRIPCION", tbxDescripcion.Text);
                cmd.Parameters.AddWithValue("@PRECIO", precio);
                cmd.Parameters.AddWithValue("@IMAGEN", tbxImagen.Text);
                cmd.Parameters.AddWithValue("@ID", Session["value"]);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception h)
            {
                string pito = h.Message;
                Response.Write("<script>alert('No se pudo completar la operacion');</script>");
                succ = false;
            }
            finally
            {
                Response.Write("<script>alert('Registro completado con Exito');</script>");
                succ = true;
            }

            if (succ)
            {
                Response.Redirect("Ajustes.aspx");
            }

            
        }
    }
}