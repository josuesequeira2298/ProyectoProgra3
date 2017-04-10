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

        internal DataTable buscarcurso(string carrera)
        {
            DataTable dt = new DataTable();

            controladora.buscarcurso(carrera);
            return dt;
        }

        internal DataTable buscarcarrera()
        {
            DataTable dt = new DataTable();
            controladora.buscarcarrera();
            return dt;
        }

        internal DataTable buscargrupo(string curso)
        {
            DataTable dt = new DataTable();
            controladora.buscargrupo(curso);
            
            return dt;
        }
    }
}
