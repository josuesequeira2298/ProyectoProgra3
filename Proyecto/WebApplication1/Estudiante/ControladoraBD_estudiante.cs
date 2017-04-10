using System;
using System.Collections.Generic;
using System.Data;
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
            string consulta = "INSERT INTO [dbo].[Estudiante] ([cedula],[genero],[telefono],[email],[Activo],[Nombre],[Apellido1],[Apellido2])VALUES(@cedula, @genero, @telefono, @email, @activo, @nombre, @apellido1, @apellido2)";
            SqlCommand comando = new SqlCommand(consulta);
            SqlParameter cedula = new SqlParameter("@cedula", System.Data.SqlDbType.Int);
            cedula.Value = estudiante.Cedula;
            SqlParameter genero = new SqlParameter("@genero", System.Data.SqlDbType.Bit);
            genero.Value = estudiante.Genero;
            SqlParameter telefono = new SqlParameter("@telefono", System.Data.SqlDbType.Int);
            telefono.Value = estudiante.Telefono;
            SqlParameter email = new SqlParameter("@email", System.Data.SqlDbType.VarChar, 30);
            email.Value = estudiante.Email;
            SqlParameter activo = new SqlParameter("@activo", System.Data.SqlDbType.Bit);
            activo.Value = estudiante.Activo;
            SqlParameter nombre = new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 20);
            nombre.Value = estudiante.Nombre;
            SqlParameter apellido = new SqlParameter("@apellido", System.Data.SqlDbType.VarChar, 15);
            apellido.Value = estudiante.Apellido1;
            SqlParameter apellido2 = new SqlParameter("@apellido2", System.Data.SqlDbType.VarChar, 15);
            apellido2.Value = estudiante.Apellido2;


            comando.Parameters.Add(cedula);
            comando.Parameters.Add(genero);
            comando.Parameters.Add(telefono);
            comando.Parameters.Add(email);
            comando.Parameters.Add(activo);
            comando.Parameters.Add(nombre);
            comando.Parameters.Add(apellido);
            comando.Parameters.Add(apellido2);
            adaptador.insertar(comando);

        }

        internal DataTable buscarEstudiante(string carnet)
        {
            DataTable dt = new DataTable();
            string consulta = "select * from estudiante where carnet = " + carnet;

            dt = adaptador.consultar(consulta);
            return dt;
        }
        internal DataTable buscarDir(string carnet)
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Direccion where Carnet =  " + carnet;

            dt = adaptador.consultar(consulta);
            return dt;
        }
    }

}

