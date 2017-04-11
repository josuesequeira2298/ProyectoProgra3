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

        internal DataTable buscarCarreras(string carnet)
        {
            DataTable dt = new DataTable();


            dt = controladoraBD.buscarCarreras(carnet);
            return dt;
        }

        internal DataTable buscarProvincia()
        {
            DataTable dt = new DataTable();
            
            dt = controladoraBD.buscarProvincia();
            return dt;
        }

        internal DataTable buscarCanton(String Provincia )
        {
            DataTable dt = new DataTable();

            dt = controladoraBD.buscarCanton(Provincia);
            return dt;
        }

        internal DataTable buscarDistrito(String canton)
        {
            DataTable dt = new DataTable();

            dt = controladoraBD.buscarDistrito(canton);
            return dt;
        }
    }
}
