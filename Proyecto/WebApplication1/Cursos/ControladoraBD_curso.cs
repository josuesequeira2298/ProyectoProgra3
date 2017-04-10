using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Cursos
{
    public class ControladoraBD_curso
    {
        Adaptador adaptador = new Adaptador();

        internal DataTable buscarCurso(Entidad_Curso curso)
        {
            DataTable dt = new DataTable();
            string consulta = "";
            adaptador.consultar(consulta);
            return dt;
        }

       
    }

}
//