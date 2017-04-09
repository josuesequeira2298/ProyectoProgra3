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
        int activo;
        String nombre;
        String apellido1;
        String apellido2;
        string password;
        public Entidad_estudiante(object[] atri)
        {
            this.carnet = int.Parse(atri[0].ToString());
            this.cedula = int.Parse(atri[1].ToString());
            this.genero = int.Parse(atri[2].ToString());
            this.telefono = int.Parse(atri[3].ToString());
            this.email = atri[4].ToString();    
            this.activo = int.Parse(atri[5].ToString());
            this.nombre = atri[6].ToString();
            this.apellido1 = atri[7].ToString();
            this.apellido2 = atri[8].ToString();
            this.password= atri[9].ToString();

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
            get { return genero; }

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
        public string Pass
        {
            get { return password; }

            set { password = value; }
        }
        public int Activo
        {
            get { return activo; }

            set { activo = value; }
        }

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }

        }

        public string Apellido1
        {
            get { return apellido1; }

            set { apellido1 = value; }

        }

        public string Apellido2
        {
            get { return apellido2; }

            set { apellido2 = value; }
        }
    }
}
