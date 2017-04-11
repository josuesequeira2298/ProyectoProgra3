using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Estudiante
{
    public partial class Estudiante : System.Web.UI.Page
    {
        Controladora_estudiante controladora = new Controladora_estudiante();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Index.aspx");
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
    }
}