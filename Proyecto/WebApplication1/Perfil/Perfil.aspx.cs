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
        DataTable dt1 = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"]!=null) {
                string user = Session["user"].ToString();
                dt = controladora.buscarEstudiante(user);
                dt1 = controladora.buscarDir(user);
                lbcarnet.Text = dt.Rows[0][0].ToString();
                lbcedula.Text = dt.Rows[0][1].ToString();
                if (dt.Rows[0][2].ToString() == "True")
                {
                    lbgenero.Text = "Masculino";
                }
                else
                {
                    lbgenero.Text = "Femenino";
                }

                lbtelefono.Text = dt.Rows[0][3].ToString();
                lbcorreo.Text = dt.Rows[0][4].ToString();
                lbnombre.Text = dt.Rows[0][6].ToString();
                lbapellido1.Text = dt.Rows[0][7].ToString();
                lbapellido2.Text = dt.Rows[0][8].ToString();
                
                lbdireccion.Text = dt1.Rows[0][4].ToString()+", "+ dt1.Rows[0][3].ToString() + ", " + dt1.Rows[0][2].ToString() + ", " + dt1.Rows[0][1].ToString() ;
            }
            else
            {
               
                lbcarnet.Text = "sesion es null";
            }
        }
  
    }
}