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


        internal DataTable buscarMatricula( string user)
        {
            DataTable dt = new DataTable();
            string consulta = "select distinct a.id_curso as Codigo, cu.nombre as Curso, gr.turno as Turno, gr.descrip as Grupo " +
"from" +
    "(select cpc.id_curso " +

        "from carrera_por_curso cpc " +

       " join carrera ca " +

        "on ca.id_carrera = cpc.ID_carrera " +

        "where id_curso not in " +

            "(select id_curso " +

               "from expediente ex " +

                "where carnet = "+ user  +

                " and ex.estado IN('Aprobado', 'Matriculado')))a " +
      "inner join requisito r " +
   " on   r.id_curso = a.id_curso " +
      " join curso cu on "+
       " cu.id_curso = a.id_curso "+
       "join  grupo gr "+
        "on gr.id_curso = a.id_curso "+
"where(r.id_requisito = 'N/A' " +
"or r.id_requisito in " +

        "(select id_curso " +

          "from expediente " +

           " where carnet = "+ user +" and estado = 'Aprobado'))";
            dt =adaptador.consultar(consulta);
            return dt;
        }

        internal void insertarmatricula(string curso,string user,string date)
        {
            string consulta = "INSERT INTO [dbo].[Expediente] ([Estado],[Cuatrimestre_matri],[id_curso],[Carnet]) VALUES ('Matriculado' ,'"+date+"','"+curso+"',"+user+")";
            adaptador.insertar(consulta);
        }
       
    }
}