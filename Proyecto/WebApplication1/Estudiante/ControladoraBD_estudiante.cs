using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Estudiante
{
    public class ControladoraBD_estudiante
    {
        
        Adaptador adaptador = new Adaptador();
        internal void agregarEstudiante(Entidad_estudiante estudiante)
        {
            string consulta = "";
            adaptador.insertar(consulta);
        }

        internal void buscarEstudiante(Entidad_estudiante estudiante)
        {
            string consulta = "";
            adaptador.consultar(consulta);
        }

    }
}
