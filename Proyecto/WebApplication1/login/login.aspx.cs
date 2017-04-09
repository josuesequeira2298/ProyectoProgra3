using System;
using System.Collections.Generic;
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
            string user;
            string pass;
            user = carnet.Text;
            pass = contraseña.Text;
            log.buscarlogin(user,pass);
        }
    }

}