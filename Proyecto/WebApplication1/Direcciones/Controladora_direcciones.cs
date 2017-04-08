using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Direcciones
{
    public class Controladora_direcciones
    {
        ControladoraBD_direcciones controladora = new ControladoraBD_direcciones();

        internal void cargarProvincia(object[] atri)
        {
            Entidad_provincia provincia = new Entidad_provincia(atri);
            controladora.buscarProvincia(provincia);
        }

        internal void cargarCanton(object[] atri,string prov)
        {
            Entidad_canton canton = new Entidad_canton(atri);
            controladora.buscarCanton(canton,prov);
        }

        internal void cargarDisttrito(object[] atri,string cant)
        {
            Entidad_distrito distrito = new Entidad_distrito(atri);
            controladora.buscarDistrito(distrito,cant);
        }
    }
}