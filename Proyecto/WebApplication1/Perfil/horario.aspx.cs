using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Perfil
{
    public partial class horario : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        Controladora_Horario controladora = new Controladora_Horario();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                Response.Redirect("~/Index.aspx");
            }
            string user = Session["user"].ToString();
            dt = controladora.buscarHorario(user);
            dgvhorario.DataSource = dt;
            DataBind();
        }

    }
}