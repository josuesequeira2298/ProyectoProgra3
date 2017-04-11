using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Cursos
{
    public partial class Expediente : System.Web.UI.Page
    {
        Controladora_expediente controladora = new Controladora_expediente();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }

            string user = Session["user"].ToString();
            dt = controladora.cargarExp(user);

            dgvExp.DataSource = dt;
            dgvExp.DataBind();
        }
    }
}