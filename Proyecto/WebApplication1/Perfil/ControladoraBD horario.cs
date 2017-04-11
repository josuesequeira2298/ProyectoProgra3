using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Perfil
{
    public class ControladoraBD_horario
    {
        Adaptador adaptador = new Adaptador();
        DataTable dt = new DataTable();

        internal DataTable cargatHorario(string user)
        {
            string consulta = "SELECT ex.[id_curso] as Codigo,cu.nombre as Curso, gr.grupo as Grupo, gr.turno as Turno FROM [dbo].[Expediente] ex join grupo gr on gr.id_curso= ex.Id_curso join curso cu on cu.id_curso= ex.id_curso  where estado='Matriculado' and carnet= " + user;
           dt= adaptador.consultar(consulta);
            return dt;
        }
    }
}