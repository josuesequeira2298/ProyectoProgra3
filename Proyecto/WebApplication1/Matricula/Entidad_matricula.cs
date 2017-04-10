using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Matricula
{
    public class Entidad_matricula
    {
        string carrera;
        string curso;
        int grupo;

        public Entidad_matricula(object[] atri)
        {
            this.carrera = atri[0].ToString();
            this.curso = atri[1].ToString();
            this.grupo = int.Parse(atri[2].ToString());
        }
        public string Carrera
        {
            get { return carrera; }

            set { carrera = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public int Grupo
        {
            get { return grupo;}
            set { grupo = value; }
        }
    }
}