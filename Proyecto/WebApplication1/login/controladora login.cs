using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.login
{
    public class controladora_login
    {
        ControladoraBD_login login = new ControladoraBD_login();

        internal  DataTable buscarlogin(string user,string pass)
        {
            DataTable dt = new DataTable();
            dt = login.buscarusuario(user, pass);
            return dt;
        }
    }
}
