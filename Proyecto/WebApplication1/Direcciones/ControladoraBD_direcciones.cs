using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Direcciones
{
    public class ControladoraBD_direcciones
    {
        Adaptador adaptador = new Adaptador();

        internal void agregarDireccion(Entidad persona)
        {
            string consulta = "select ";
        }

        internal void buscarDireccion()
        {
            string consulta = "";
            adaptador.consultar(consulta);
        }

    }
}