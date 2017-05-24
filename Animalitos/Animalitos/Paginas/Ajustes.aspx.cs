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
    public partial class Ajustes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nivel"] == "0")
            {
                Response.Redirect("Inicio.aspx");
            }
            if(Session["nivel"] == "1")
            {
                Response.Redirect("Carrito.aspx");
            }
            llenardvAnimalitos();
            llenarDLLAnimalitos();
        }
        private void llenardvAnimalitos()
        {
            string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
            string query = "SELECT especie, raza, descripcion, precio FROM T_Animalitos";
            using (SqlConnection con = new SqlConnection(cnnstring))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            gvAnimalitos.DataSource = ds.Tables[0];
                            gvAnimalitos.DataBind();

                        }
                    }
                }
            }
        }

        private void llenarDLLAnimalitos()
        {
            if (!this.IsPostBack)
            {
                string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                string query = "SELECT especie, id_animalito FROM T_Animalitos";
                using (SqlConnection con = new SqlConnection(cnnstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        ddlAnimalitos.DataSource = cmd.ExecuteReader();
                        ddlAnimalitos.DataTextField = "especie";
                        ddlAnimalitos.DataValueField = "id_animalito";
                        ddlAnimalitos.DataBind();
                        con.Close();
                    }
                }
            }
        }

        private void llenardvUsuarios()
        {
            string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
            string query = "SELECT id_usuario, username, correo_usuario, nivel_usuario FROM T_Usuarios";
            using (SqlConnection con = new SqlConnection(cnnstring))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            gvAnimalitos.DataSource = ds.Tables[0];
                            gvAnimalitos.DataBind();

                        }
                    }
                }
            }
        }

        private void llenarDLLUsuarios()
        {
            if (!this.IsPostBack)
            {
                string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                string query = "SELECT id_usuario, username FROM T_Usuarios";
                using (SqlConnection con = new SqlConnection(cnnstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        ddlUsuarios.DataSource = cmd.ExecuteReader();
                        ddlUsuarios.DataTextField = "username";
                        ddlUsuarios.DataValueField = "id_usuario";
                        ddlUsuarios.DataBind();
                        con.Close();
                    }
                }
            }
        }
    }
}