using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Cursos
{
    public class Controladora_cursos
    {
        ControladoraBD_curso controladora = new ControladoraBD_curso();
        internal void agregarCurso(object[] atri)
        {
            Entidad_Curso curso = new Entidad_Curso(atri);
        }
    }
}