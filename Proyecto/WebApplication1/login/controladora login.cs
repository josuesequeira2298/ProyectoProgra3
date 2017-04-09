using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.login
{
    public class controladora_login
    {
        ControladoraBD_login login = new ControladoraBD_login();

        internal void buscarlogin(string user,string pass)
        {
            login.buscarusuario(user, pass);
        }
    }
}