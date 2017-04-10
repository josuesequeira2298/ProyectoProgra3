using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Cursos
{
    public class Controladora_cursos
    {
        ControladoraBD_curso controladora = new ControladoraBD_curso();

       
        internal DataTable buscarcurso(object[] atri)
        {
            DataTable dt = new DataTable();
            Entidad_Curso curso = new Entidad_Curso(atri);
           dt= controladora.buscarCurso(curso);
            return dt;

        }
    }
}
