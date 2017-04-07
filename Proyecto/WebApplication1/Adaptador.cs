using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Adaptador
    {
        SqlConnection conn;
        // C#
        public void conectar()
        {
            String conexion = "Server=tcp:progra3.database.windows.net,1433;Initial Catalog=Progra3;Persist Security Info=False;User ID=progra3;Password=progra,3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

            conn = new SqlConnection(conexion);

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {

            }

        }

        public void desconectar()
        {
            conn.Close();
        }

        internal void insertar(String consulta)
        {
            conectar();
            SqlCommand comando = new SqlCommand(consulta, conn);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            desconectar();

        }

        internal void insertar(SqlCommand comando)
        {
            conectar();
            comando.Connection = conn;
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //Detecto el error y notifico al usuario.
            }
            desconectar();

        }

        public DataTable consultar(String consulta)
        {
            conectar();
            SqlCommand comando = new SqlCommand(consulta, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            desconectar();
            return dt;
        }
    }
}
//