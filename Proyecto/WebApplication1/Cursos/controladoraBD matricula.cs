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
        internal DataTable buscarcurso(string curso)
        {
            DataTable dt = new DataTable();
            string consulta = "select cu.Nombre, cu.id_curso from carrera_por_curso cpc join Curso cu on cu.id_curso = cpc.id_curso where cpc.id_Carrera= "+curso;
            adaptador.consultar(consulta);
            return dt;
        }

        internal DataTable buscarcarrera()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Carrera";
            adaptador.consultar(consulta);
            return dt;
        }

        internal DataTable buscargrupo(string curso)
        {
            DataTable dt = new DataTable();
            string consulta = "select grupo from Grupo where id_curso = '"+curso+"'";
            adaptador.consultar(consulta);
            return dt;
        }
    }
}