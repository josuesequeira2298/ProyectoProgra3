using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Plan_estudio
{
    public class Controladora_Plan
    {
 controladoraBD_plan controladora = new controladoraBD_plan();

        internal DataTable Aprovados(string carrera, string user)
        {           
            DataTable dt = new DataTable();

            dt=controladora.Aprovados(carrera,user);
            return dt;
        }

        internal DataTable noAprovados(string carrera, string user)
        {
            DataTable dt = new DataTable();

           dt= controladora.noAprovados(carrera,user);
            return dt;
        }

        
    }
}