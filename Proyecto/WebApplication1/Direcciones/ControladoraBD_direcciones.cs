using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Direcciones
{
    public class Direcciones
    {
        Adaptador adaptador = new Adaptador();

        internal void buscarDireccion()
        {
            string consulta = "";
            adaptador.consultar(consulta);
        }

    }
}