﻿using System;
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
            if (!IsPostBack)
            {

                var x = Session["nivel"];

                if (Session["nivel"].Equals(0))
                {
                    Response.Redirect("Inicio.aspx");
                }
                if (Session["nivel"].Equals(1))
                {
                    Response.Redirect("Carrito.aspx");
                }

            }
            llenardvAnimalitos();
            llenarDLLAnimalitos();
            llenardvUsuarios();
            llenarDLLUsuarios();
        }
        private void llenardvAnimalitos()
        {
            string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
            string query = "SELECT id_animalito, especie, raza, descripcion, precio FROM T_Animalitos";
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
                        ddlAnimalitos.DataTextField = "id_animalito";
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
            string query = "SELECT id_usuario, username, correo_usuario, nivel_usuario FROM T_Usuarios where id_usuario != @actual";
            using (SqlConnection con = new SqlConnection(cnnstring))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@actual", Session["id_usuario"]);
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            gvUsuarios.DataSource = ds.Tables[0];
                            gvUsuarios.DataBind();

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
                string query = "SELECT id_usuario, username FROM T_Usuarios where id_usuario != @actual";
                using (SqlConnection con = new SqlConnection(cnnstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@actual", Session["id_usuario"]);
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

        protected void btnBorrarU_Click(object sender, EventArgs e)
        {
            string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
            string query;
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = cnnstring;
            con.Open();
            cmd.Connection = con;
            query = "DELETE T_Usuarios where id_usuario = @usuario";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@usuario", ddlUsuarios.SelectedValue);

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Ajustes.aspx");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string cnnstring = ConfigurationManager.ConnectionStrings["AnimalitosWebConnectionString"].ConnectionString;
            string query;
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = cnnstring;
            con.Open();
            cmd.Connection = con;
            query = "DELETE T_Animalitos where id_animalito = @animalito";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@animalito", ddlAnimalitos.SelectedValue);

            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Ajustes.aspx");
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Session["value"] = ddlAnimalitos.SelectedValue;
            Response.Redirect("FormularioNewAnimalito.aspx");
        }

        protected void btnEditar_OnClick(object sender, EventArgs e)
        {
            Session["value"] = ddlAnimalitos.SelectedValue;
            Response.Redirect("FormularioModAnimalitos.aspx");
        }
    }
}