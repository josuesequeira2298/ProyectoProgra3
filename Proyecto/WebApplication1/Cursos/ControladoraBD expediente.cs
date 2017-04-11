using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Cursos
{
    public class ControladoraBD_expediente
    {
        Adaptador adaptador = new Adaptador();
        DataTable dt = new DataTable();
        internal DataTable cargarExp(string user)
        {
            string consulta = "select  Estado, Nota,Cuatrimestre_matri as Cuatrimestre, id_curso as Curso from expediente where carnet = " + user;
            dt=adaptador.consultar(consulta);
            return dt;
            
        }

    }
}