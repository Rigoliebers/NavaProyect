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
    }
}