using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Cursos
{
    public class Controladora_expediente
    {
        ControladoraBD_expediente controladora = new ControladoraBD_expediente();

        internal DataTable cargarExp(string user)
        {
            DataTable dt = new DataTable();
            dt=controladora.cargarExp(user);
            return dt;
        }
    }
}