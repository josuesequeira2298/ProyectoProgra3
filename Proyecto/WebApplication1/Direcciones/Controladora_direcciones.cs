using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Direcciones
{
    public class Controladora_direcciones
    {
        ControladoraBD_direcciones controladora = new ControladoraBD_direcciones();

        internal void agregarDireccion(object[] atri)
        {
            Entidad_provincia direccion = new Entidad_provincia(atri);
            controladora.agregarDireccion(direccion);
        }
    }
}