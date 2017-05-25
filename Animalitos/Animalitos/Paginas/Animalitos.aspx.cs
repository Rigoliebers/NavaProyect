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
    public partial class Animalitos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarDLLFiltro();
            if(!IsPostBack)
            llenardv();
        }

        private void llenardv()
        {
            string cnnstring;
            string query;

            if (ddlFiltro.SelectedValue.Equals("0"))
            {
                cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                query = "SELECT id_animalito, especie, raza, descripcion, precio FROM T_Animalitos";
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
            else
            {
                cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                query = "SELECT id_animalito, especie, raza, descripcion, precio FROM T_Animalitos where especie like @especie";
                using (SqlConnection con = new SqlConnection(cnnstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter())
                        {
                            cmd.Parameters.AddWithValue("@especie", ddlFiltro.SelectedValue);
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
            llenarDLL();
        }

        private void llenarDLL()
        {
            string cnnstring;
            string query;

            if (ddlFiltro.SelectedValue.Equals("0"))
            {
                cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                query = "SELECT especie, id_animalito FROM T_Animalitos";
                using (SqlConnection con = new SqlConnection(cnnstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        ddlAnimalitos.DataSource = cmd.ExecuteReader();
                        ddlAnimalitos.DataTextField = "id_animalito";
                        ddlAnimalitos.DataValueField = "id_animalito";
                        ddlAnimalitos.DataBind();
                        con.Close();
                    }
                }
            }
            else
            {
                cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                query = "SELECT especie, id_animalito FROM T_Animalitos where especie like @especie";
                using (SqlConnection con = new SqlConnection(cnnstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@especie", ddlFiltro.SelectedValue);
                        cmd.Connection = con;
                        con.Open();
                        ddlAnimalitos.DataSource = cmd.ExecuteReader();
                        ddlAnimalitos.DataTextField = "id_animalito";
                        ddlAnimalitos.DataValueField = "id_animalito";
                        ddlAnimalitos.DataBind();
                        con.Close();
                    }
                }
            }
        }

        private void llenarDLLFiltro()
        {
            if (!this.IsPostBack)
            {
                string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
                string query = "SELECT distinct especie FROM T_Animalitos";
                using (SqlConnection con = new SqlConnection(cnnstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        ddlFiltro.DataSource = cmd.ExecuteReader();
                        ddlFiltro.DataTextField = "especie";
                        ddlFiltro.DataValueField = "especie";
                        ddlFiltro.DataBind();
                        con.Close();
                    }
                }
                ddlFiltro.Items.Insert(0, new ListItem("--Mostrar todo el catalogo--", "0"));
                llenarDLL();
            }
        }

        protected void ddlAnimalitos_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, ImageClickEventArgs e)
        {
            Session["value"] = ddlAnimalitos.SelectedValue;
            Response.Redirect("Apartar.aspx");
        }

        protected void ddlFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardv();
        }
    }
}