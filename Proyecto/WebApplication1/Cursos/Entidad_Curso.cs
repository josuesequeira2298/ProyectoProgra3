using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Cursos
{
    public class Entidad_Curso
    {
        string idcurso;
        string nombre;
        string descripcion;
        int creditos;
        int grupo;
        string profesor;
        int activo;
        public Entidad_Curso(object[] atri)
        {
            this.idcurso = atri[0].ToString();
            this.nombre = atri[1].ToString();
            this.descripcion = atri[2].ToString();
            this.creditos = int.Parse(atri[3].ToString());
            this.grupo = int.Parse(atri[4].ToString());
            this.profesor = atri[5].ToString();
            this.activo = int.Parse(atri[6].ToString());
        }
        public string Curso
        {
            get { return idcurso; }

            set { idcurso = value; }
        }

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public string descrip
        {
            get { return descripcion; }

            set { descripcion = value; }
        }

        public int Creditos
        {
            get { return creditos; }

            set { creditos = value; }
        }

        public int Grupo
        {
            get { return grupo; }

            set { grupo = value; }
        }

        public string profe
        {
            get { return profesor; }

            set { profesor = value; }
        }

        public int Activo
        {
            get { return activo; }

            set { activo = value; }
        }
    }
}