using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Estudiante
{
    public class ControladoraBD_estudiante
    {
        
        Adaptador adaptador = new Adaptador();
        internal void agregarEstudiante(Entidad_estudiante estudiante)
        {
            string consulta = "";
            SqlCommand comando = new SqlCommand(consulta);
            SqlParameter carnet = new SqlParameter("@carnet", System.Data.SqlDbType.Int);
            carnet.Value = estudiante.Carnet;
            SqlParameter cedula = new SqlParameter("@cedula", System.Data.SqlDbType.Int);
            cedula.Value = estudiante.Cedula;
            SqlParameter genero = new SqlParameter("@genero", System.Data.SqlDbType.Bit);
            genero.Value = estudiante.Genero;
            SqlParameter telefono = new SqlParameter("@telefono", System.Data.SqlDbType.Int);
            telefono.Value = estudiante.Telefono;
            SqlParameter email = new SqlParameter("@email", System.Data.SqlDbType.VarChar, 30);
            email.Value = estudiante.Email;
            SqlParameter iddireccion = new SqlParameter("@iddireccion",System.Data.SqlDbType.SmallInt);
            iddireccion.Value = estudiante.id_direc;
            SqlParameter activo = new SqlParameter("@activo",System.Data.SqlDbType.Bit);
            activo.Value = estudiante.Activo;
            SqlParameter nombre = new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20);
            nombre.Value = estudiante.Nombre;
            SqlParameter apellido = new SqlParameter("@apellido", System.Data.SqlDbType.VarChar, 15);
            apellido.Value = estudiante.Apellido;
            SqlParameter apellido2 = new SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 15);
            apellido2.Value = estudiante.Apellido2;

        }

        internal void buscarEstudiante(Entidad_estudiante estudiante)
        {
            string consulta = "";
            adaptador.consultar(consulta);
        }

    }
}
