using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Matricula
{
    public partial class matricula : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        controladoraBD_matricula controladora = new controladoraBD_matricula();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"]==null)
            {
                Response.Redirect("~/Index.aspx");
            }
            string user = Session["user"].ToString();
            dt=controladora.buscarMatricula( user);


            dgvMatri.DataSource = dt;
            dgvMatri.DataBind();

            cbocurso.DataSource = dt;
            cbocurso.DataValueField = "Codigo";
            cbocurso.DataTextField = "Codigo";
            cbocurso.DataBind();

        }


        protected void btnmatricular_Click(object sender, EventArgs e)
        {
            string date = System.DateTime.Now.ToString("yyyy.MM.dd");
            string user = Session["user"].ToString();
            string curso = cbocurso.SelectedItem.Text;
            controladora.insertarmatricula(curso,user,date);
        }
    }
}

