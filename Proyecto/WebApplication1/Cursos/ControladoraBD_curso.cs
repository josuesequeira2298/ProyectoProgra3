using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Cursos
{
    public class ControladoraBD_curso
    {
        Adaptador adaptador = new Adaptador();

        internal void buscarCurso(Entidad_Curso curso)
        {
            string consulta = "";
            adaptador.consultar(consulta);
        }

        internal void agregarCurso(Entidad_Curso curso)
        {
            string consulta = "";

            SqlCommand comando = new SqlCommand(consulta);

            SqlParameter idcurso = new SqlParameter("@idcurso", System.Data.SqlDbType.VarChar, 6);
            idcurso.Value = curso.Curso;
            SqlParameter nombre = new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20);
            nombre.Value = curso.Nombre;
            SqlParameter descripcion = new SqlParameter("@descrip", System.Data.SqlDbType.VarChar, 100);
            descripcion.Value = curso.descrip;
            SqlParameter creditos = new SqlParameter("@creditos", System.Data.SqlDbType.TinyInt);
            creditos.Value = curso.Creditos;
            SqlParameter grupo = new SqlParameter("@grupo", System.Data.SqlDbType.TinyInt);
            grupo.Value = curso.Grupo;
            SqlParameter activo = new SqlParameter("@activo", System.Data.SqlDbType.Bit);

            comando.Parameters.Add(idcurso);
            comando.Parameters.Add(nombre);
            comando.Parameters.Add(descripcion);
            comando.Parameters.Add(creditos);
            comando.Parameters.Add(grupo);
            comando.Parameters.Add(activo);
            adaptador.insertar(comando);

        }
    }

}
//