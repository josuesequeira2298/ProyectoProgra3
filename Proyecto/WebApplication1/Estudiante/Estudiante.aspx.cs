using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Estudiante
{
    public partial class Estudiante : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        Controladora_estudiante controladora = new Controladora_estudiante();
        protected void Page_Load(object sender, EventArgs e)
        {
          /*  if (Session["user"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }
*/
            string user = "43519"; // Session["user"].ToString();

            if (!IsPostBack)
            {
                dt = controladora.buscarEstudiante(user);

                lbcarnet.Text = dt.Rows[0][0].ToString();
                lbnombre.Text = dt.Rows[0][6].ToString() + " " + dt.Rows[0][7].ToString() + " " + dt.Rows[0][8].ToString();
                dt1 = controladora.buscarProvincia();
                cboProvincia.DataSource= dt1;
                cboProvincia.DataValueField = "Provincia";
                cboProvincia.DataTextField= "Provincia";
                cboProvincia.DataBind();
            }



        }
        

        
       

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
          
            Response.Redirect("~/Index.aspx");

        }

        protected void datosEstudiante(object sender, EventArgs e)
        {
            string user = Session["user"].ToString();
             
            
        }

        protected void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt2 = controladora.buscarCanton(cboProvincia.SelectedItem.Text);
            cboCanton.DataSource = dt2;
            cboCanton.DataValueField = "Canton";
            cboCanton.DataTextField = "Canton";
        }
        
    }
}