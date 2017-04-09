using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.login
{
    public class ControladoraBD_login
    {
        Adaptador adaptador = new Adaptador();


        internal void buscarusuario(string user, string pass)
        {
            string consulta = "Select * from Estudiante where carnet=" + user + "and password=" + pass;
            adaptador.consultar(consulta);
        }
    }
}