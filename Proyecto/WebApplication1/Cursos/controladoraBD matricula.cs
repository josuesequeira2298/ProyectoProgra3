using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApplication1.Matricula
{
    public class controladoraBD_matricula
    {
        Adaptador adaptador = new Adaptador();
        internal DataTable buscarcurso()
        {
            DataTable dt = new DataTable();
            string consulta = "select Nombre from Curso";
            dt=adaptador.consultar(consulta);
            return dt;
        }

        internal DataTable buscarcarrera()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Carrera";
           dt= adaptador.consultar(consulta);
            return dt;
        }

        internal DataTable buscargrupo(string curso)
        {
            
            DataTable dt = new DataTable();
            string consulta = "select grupo from Grupo where id_curso = '"+curso+"'";
           dt= adaptador.consultar(consulta);
            return dt;
        }
    }
}