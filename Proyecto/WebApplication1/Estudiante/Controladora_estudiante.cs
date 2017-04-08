using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Estudiante

{
    public class Controladora_estudiante
    {
        ControladoraBD_estudiante controladoraBD = new ControladoraBD_estudiante();
        

        internal void insertarDatos(object[] atri)
        {
            Entidad_estudiante estudiante = new Entidad_estudiante(atri);

            controladoraBD.agregarEstudiante(estudiante);
            
        }
        internal void buscarEstudiante(object[] atri)
        {
            Entidad_estudiante estudiante = new Entidad_estudiante(atri);

            controladoraBD.buscarEstudiante(estudiante);
        }
    }
}
