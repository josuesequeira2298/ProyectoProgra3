using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Matricula
{
    
    public class Controladora_matricula
    {
        ControladoraBD_matricula controladoraBD = new ControladoraBD_matricula();
        internal void insertarDatos(object[] atri)
        {
            Entidad_matricula matricula = new Entidad_matricula(atri);

            controladoraBD.agregarmatricula(matricula);
        }
    }

}