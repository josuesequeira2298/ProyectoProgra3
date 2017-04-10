using System;
using System.Collections.Generic;
using System.Data;
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
        internal DataTable buscarEstudiante(string carnet)
        {
            DataTable dt = new DataTable();
            

            dt=controladoraBD.buscarEstudiante(carnet);
            return dt;
        }

        internal DataTable buscarDir(string carnet)
        {
            DataTable dt = new DataTable();


            dt = controladoraBD.buscarDir(carnet);
            return dt;
        }

    }
}
