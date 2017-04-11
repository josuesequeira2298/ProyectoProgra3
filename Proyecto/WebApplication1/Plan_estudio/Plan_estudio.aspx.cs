using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Plan_estudio
{
    public partial class Plan_estudio : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        Controladora_Plan controladora = new Controladora_Plan();
        Estudiante.ControladoraBD_estudiante contro = new Estudiante.ControladoraBD_estudiante();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }


            string user =Session["user"].ToString();


            cboCarrera.DataSource = (contro.buscarCarreras("43519"));
            cboCarrera.DataValueField = "Carreras";
            cboCarrera.DataTextField = "Carreras";
            cboCarrera.DataBind();
            if (IsPostBack)
            {
 dt = controladora.Aprovados(cboCarrera.SelectedItem.Text, user);
            dt2 = controladora.noAprovados(cboCarrera.SelectedItem.Text, user);
            }
        }




        protected void btnCargar_Click(object sender, EventArgs e)
        {
            string user = Session["user"].ToString();
           

            dgvplan.DataSource = dt;
            dgvplan.DataBind();

            dgvplan2.DataSource = dt2;
            dgvplan2.DataBind();
        }

        protected void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}