using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Matricula
{
    public class Controladora_matricula
    {
        controladoraBD_matricula controladora = new controladoraBD_matricula();

        internal DataTable buscarMatricula(string carrera,string user)
        {
            DataTable dt = new DataTable();

            dt=controladora.buscarMatricula(carrera,user);
            return dt;
        }

        
    }
}
