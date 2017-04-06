using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Estudiante
{
    public class Entidad_estudiante
    {

        int carnet;
        int cedula;
        int genero;
        int telefono;
        String email;
        int id_direccion;
        int activo;
        String Nombre;
        String Apellido;
        String Apellido2;
        public Entidad_estudiante(object[] atri)
        {
            this.carnet = int.Parse(atri[0].ToString());
            this.cedula = int.Parse(atri[1].ToString());
            this.genero = int.Parse(atri[2].ToString());
            this.telefono = int.Parse(atri[3].ToString());
            this.email = atri[4].ToString();
            this.id_direccion = int.Parse(atri[5].ToString());
            this.activo = int.Parse(atri[6].ToString());
            this.Nombre = atri[7].ToString();
            this.Apellido = atri[8].ToString();
            this.Apellido2 = atri[9].ToString();


        }
        public int Carnet
        {
            get { return carnet; }

            set { carnet = value; }
        }

        public int Cedula
        {
            get { return cedula; }

            set { cedula = value; }
        }

        public int Genero
        {
            get { return Genero; }

            set { genero = value; }
        }

        public int Telefono
        {
            get { return telefono; }

            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }

            set { email = value; }
        }
    }
}