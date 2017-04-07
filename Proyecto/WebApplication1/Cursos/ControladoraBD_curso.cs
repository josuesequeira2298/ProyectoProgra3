using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Cursos
{
    public class ControladoraBD_curso
    {
        Adaptador adaptador = new Adaptador();

     internal void agregarCurso (Entidad_Curso curso)
        {
            string consulta = "";
            adaptador.insertar(consulta);
        }

        internal void buscarCurso(Entidad_Curso curso)
        {
            string consulta = "";
            adaptador.consultar(consulta);
        }
    }
}