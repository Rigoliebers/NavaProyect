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
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, ImageClickEventArgs e)
        {
            string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
            SqlDataReader sqldr;
            string query = "SELECT username, password, nivel_usuario FROM T_USUARIOS WHERE username = @USUARIO AND password = @PASSWORD";
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = cnnstring;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@USUARIO", tbxUsername.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", tbxContraseña.Text);
            sqldr = cmd.ExecuteReader();

            if (sqldr.Read())
            {
                var user = sqldr["username"];
                Session["usuario"] = sqldr["username"];
                Session["nivel"] = sqldr["nivel_usuario"];
                con.Close();
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "El usuario o la contraseña no son validos";
            }
        }

        protected void Button1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("NewUser.aspx");
        }
    }
}