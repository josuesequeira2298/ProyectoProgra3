using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Plan_estudio
{
    public class controladoraBD_plan
    {
        Adaptador adaptador = new Adaptador();
        internal DataTable Aprovados(string carrera,string user)
        {
            DataTable dt = new DataTable();
            string consulta = "select cu.id_curso as Curso, cu.nombre as Nombre, cu.creditos as Creditos, re.id_requisito as Requisito, ca.nombre as Carrera from curso cu full join carrera_por_curso cpc on cu.id_curso= cpc.id_curso full join expediente ex on ex.id_curso=cu.id_curso full join requisito re on re.id_curso = cu.id_curso full join carrera ca on ca.id_carrera=cpc.id_carrera where ex.Estado = 'Aprobado' and ex.carnet= "+user+" and ca.nombre='"+carrera+"'";
           dt= adaptador.consultar(consulta);
            return dt;
        }

        internal DataTable noAprovados(string carrera,string user)
        {
            DataTable dt = new DataTable();
            string consulta = "select cu.id_curso as Curso, cu.nombre as Nombre, cu.creditos as Creditos, re.id_requisito as Requisito, ca.nombre as Carrera from curso cu full join carrera_por_curso cpc on cu.id_curso= cpc.id_curso full join expediente ex on ex.id_curso=cu.id_curso full join requisito re on re.id_curso = cu.id_curso full join carrera ca on ca.id_carrera=cpc.id_carrera where ex.Estado <> 'Aprobado' and ex.carnet= " + user + " and ca.nombre='" + carrera + "'";
            dt = adaptador.consultar(consulta);
            return dt;
        }
    }
}