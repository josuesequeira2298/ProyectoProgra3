using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Direcciones
{
    public class ControladoraBD_direcciones
    {
        Adaptador adaptador = new Adaptador();

        

        internal void buscarProvincia(Entidad_provincia provincia)
        {
            string consulta = "";
            adaptador.consultar(consulta);
        }

        internal void buscarCanton(Entidad_canton canton,string provincia)
        {
            
            string consulta = ""+ provincia ;
            adaptador.consultar(consulta);
        }
        internal void buscarDistrito(Entidad_distrito distrito, string canton)
        {
            string consulta = ""+canton;
            adaptador.consultar(consulta);
        }
    }
}