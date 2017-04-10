using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }
        controladora_login log = new controladora_login();


        public void log_in()
        {

        }

        public void iniciar_Click(object sender, EventArgs e)
       {
            DataTable dt = new DataTable();
            string user;
            string pass;
            user = carnet.Text;
            pass = contraseña.Text;
            dt = log.buscarlogin(user, pass);
            
           
            if (dt == null)
            {
                alerta.Text = "error de conexion";
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    alerta.Text = "bienvenido";
                    Response.Redirect("~/Default.aspx");
                   Session["user"] = user;
                }
                else
                {
                    alerta.Text = "Carnet o contraseña invalida";
                }
            }
            
        }
       
    }

}







