using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.Perfil
{
    public class Controladora_Horario
    {
        DataTable dt = new DataTable();
        ControladoraBD_horario controladora = new ControladoraBD_horario();
        internal DataTable buscarHorario(string user)
        {
            dt= controladora.cargatHorario(user);
            return dt;
        }
    }
}