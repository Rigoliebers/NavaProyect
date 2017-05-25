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
    public partial class NewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNivel.Visible = false;
            ddlNivel.Visible = false;

            if (Session["nivel"].Equals(69))
            {
                lblNivel.Visible = true;
                ddlNivel.Visible = true;
            }
        }
        protected void CreateUser_OnContinueButtonClick(object sender, ImageClickEventArgs e)
        {
            if (tbxContraseña.Text.Equals(tbxConfirmarContraseña.Text)) //Y otras validaciones
            {
                string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                SqlDataReader sqldr;
                string query = "SELECT username FROM T_USUARIOS WHERE username = @USUARIO";
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = cnnstring;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@USUARIO", tbxUsername.Text);
                sqldr = cmd.ExecuteReader();

                if (sqldr.Read())
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "El usuario ya existe";
                }
                else
                {
                    int nivel = Convert.ToInt16(ddlNivel.SelectedValue);
                    con.Close();
                    query = "INSERT INTO T_Usuarios VALUES (@USUARIO,@PASSWORD,@CORREO,@NIVEL)";
                    cmd.Parameters.AddWithValue("@PASSWORD", tbxContraseña.Text);
                    cmd.Parameters.AddWithValue("@CORREO", tbxCorreo.Text);
                    cmd.Parameters.AddWithValue("@NIVEL", nivel);
                    con.Open();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Redirect("Redirect.aspx");
                }

            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Las contraseñas no coinciden";
            }
        }
    }



}