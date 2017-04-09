using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.login
{
    public class ControladoraBD_login
    {
        Adaptador adaptador = new Adaptador();


        internal DataTable buscarusuario(string user, string pass)
        {
            DataTable dt = new DataTable();
            string consulta = "Select * from Estudiante where carnet =" +user+ "and contraseña =" +pass;
           dt= adaptador.consultar(consulta);
            return dt;
        }
    }
}