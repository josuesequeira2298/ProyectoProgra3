using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Perfil
{
    public partial class Perfil : System.Web.UI.Page 
    {
Estudiante.Controladora_estudiante controladora = new Estudiante.Controladora_estudiante();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"]!=null) {
                string user = Session["user"].ToString();
                dt = controladora.buscarEstudiante(user);
                lbcarnet.Text = dt.Rows[0][1].ToString();
                lbcedula.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                lbcarnet.Text = "sesion null";
            }
        }
  
    }
}