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
        protected void log_in()
        {
            DataTable dt = new DataTable();
            string user;
            string pass;
            user = carnet.Text;
            pass = contraseña.Text;
           dt= log.buscarlogin(user,pass);
        
            if (dt.Rows.Count>1)
            {
                alerta.Text = "bienvenido";
            }
            else
            {
                alerta.Text = "error";
            }
        }
    }

}